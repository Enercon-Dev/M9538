using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9526
{
    interface I_I2C
    {
        bool I2C_Write(uint sadd, uint memadd, uint memlen, byte[] Data);
        bool I2C_Transfer(uint sadd, byte[] WrData, byte[] RdData);
        UInt32 I2C_GetStatus();

    }

    class Programmer : IDisposable
    {
        I_I2C m_com;
        public float ProgramState { get; set; }
        public Programmer(I_I2C com)
        {
            m_com = com;
            ProgramState = 0;
        }
        public bool Program(UInt32 DevID, StreamReader jed_file, byte[] UFM = null)
        {
            try
            {
                WaitBusy();
                if (!CheckDeviceID(DevID))
                    return false;
                I2C_Write(0xC6, new byte[2] { 0x08, 0 }); //enter enable configuration interface (offline mode)
                //I2C_Write(0x74, new byte[2] { 0x08, 0 }); //enter enable configuration interface (transparent mode)
                WaitBusy();
                I2C_Write(0x0E, new byte[3] { 0x0E, 0, 0 }); //Erase
                //I2C_Write(0x0E, new byte[3] { 0x0C, 0, 0 }); //Erase  (transparent mode)
                WaitBusy();
                ProgramState = 5;
                if (IsFail())
                {
                    Exit();
                    return false;
                }
                I2C_Write(0x46, new byte[3] { 0, 0, 0 }); // Reset Configuration Address
                WaitBusy();
                int page_num = 0;
                string line;
                do
                {
                    line = jed_file.ReadLine();
                } while (!line.StartsWith("L"));
                ProgramState += 1;
                float progStep = (128F / jed_file.BaseStream.Length)*37;
                line = jed_file.ReadLine();
                while (!line.Contains("*"))
                {
                    byte[] bytes = new byte[16];
                    for (int i = 0; i < 16; ++i)
                    {
                        bytes[i] = Convert.ToByte(line.Substring(8 * i, 8), 2);
                    }
                    I2C_Write(0x70, new byte[] { 0, 0, 1 }, bytes);
                    WaitBusy();
                    if (IsFail())
                        throw new Exception("AAAA");
                    page_num++;
                    ProgramState += progStep;
                    line = jed_file.ReadLine();
                }
                
                //Write UFM
                I2C_Write(0x47, new byte[3] { 0, 0, 0 }); // Reset UFM Address
                do
                {
                    line = jed_file.ReadLine();
                } while (!line.StartsWith("L"));
                line = jed_file.ReadLine();
                int ufm_page_num = 0;
                if (UFM == null)
                    UFM = new byte[16];
                string res = UFM.Aggregate("", (cum, x) => cum + Convert.ToString((short)x, 2).PadLeft(9, '0'));
                res = res.PadRight(8 - (res.Length % 8), '0');
                while (!line.Contains("*"))
                {
                    byte[] bytes = new byte[16];
                    
                   
                    for (int i = 0; i < 16; ++i)
                    {
                        if (ufm_page_num > 0 && res.Length > 7 )
                        {
                            bytes[i] = Convert.ToByte(res.Substring(0, 8), 2);
                            res = res.Remove(0,8);
                        }
                        else
                            bytes[i] = Convert.ToByte(line.Substring(8 * i, 8), 2);
                    }
                    I2C_Write(0x70, new byte[] { 0, 0, 1 }, bytes);
                    WaitBusy();
                    ufm_page_num++;
                    ProgramState += progStep;
                    line = jed_file.ReadLine();
                }
                
                //Verify Configuration
                I2C_Write(0x46, new byte[3] { 0, 0, 0 }); // Reset Configuration Address
                WaitBusy();
                jed_file.DiscardBufferedData();
                jed_file.BaseStream.Position = 0;
                do
                {
                    line = jed_file.ReadLine();
                } while (!line.StartsWith("L"));
                line = jed_file.ReadLine();
                while (!line.Contains("*"))
                {
                    byte[] bytes = new byte[16];
                    byte[] data = new byte[16];
                    for (int i = 0; i < 16; ++i)
                    {
                        bytes[i] = Convert.ToByte(line.Substring(8 * i, 8), 2);
                    }
                    I2C_Read(0x73, new byte[3] { 0, 0, 1 }, data);
                    WaitBusy();
                    if (!data.SequenceEqual(bytes))
                    {
                        throw new Exception("Verify Configuration Fail");
                    }
                    ProgramState += progStep;
                    line = jed_file.ReadLine();
                }

                //Verify UFM
                res = UFM.Aggregate("", (cum, x) => cum + Convert.ToString((short)x, 2).PadLeft(9, '0'));
                res = res.PadRight(8 - (res.Length % 8), '0');
                ufm_page_num = 0;
                I2C_Write(0x47, new byte[3] { 0, 0, 0 }); // Reset UFM Address
                do
                {
                    line = jed_file.ReadLine();
                } while (!line.StartsWith("L"));
                line = jed_file.ReadLine();
                while (!line.Contains("*"))
                {
                    byte[] bytes = new byte[16];
                    byte[] data = new byte[16];
                    for (int i = 0; i < 16; ++i)
                    {
                        if (ufm_page_num > 0 && res.Length > 7)
                        {
                            bytes[i] = Convert.ToByte(res.Substring(0, 8), 2);
                            res = res.Remove(0, 8);
                        }
                        else
                            bytes[i] = Convert.ToByte(line.Substring(8 * i, 8), 2);
                    }
                    I2C_Read(0x73, new byte[3] { 0, 0, 1 }, data);
                    WaitBusy();
                    if (!data.SequenceEqual(bytes))
                    {
                        throw new Exception("Verify UFM Fail");
                    }
                    ufm_page_num++;
                    ProgramState += progStep;
                    line = jed_file.ReadLine();
                }

                

                //Program DONE
                I2C_Write(0x5E, new byte[3] { 0, 0, 0 });
                WaitBusy();
                {
                    byte[] data = new byte[4];
                    I2C_Read(0x3C, new byte[3] { 0, 0, 0 }, data);
                    if ((data[2] & 0x01) == 0)
                        throw new Exception("DONE bit not set");
                }


                //Write FR
                do
                {
                    line = jed_file.ReadLine();
                } while (!line.StartsWith("E"));
                {
                    line = new string(line.Substring(1).ToCharArray().Reverse().ToArray());
                    byte[] bytes = new byte[8];
                    for (int i = 0; i < 8; ++i)
                    {
                        bytes[i] = Convert.ToByte(line.Substring(8 * i, 8), 2);
                    }
                    bytes[2] = 0x10;
                    I2C_Write(0xE4, new byte[] { 0, 0, 0 }, bytes);
                    WaitBusy();
                    byte[] data = new byte[8];
                    I2C_Read(0xE7, new byte[] { 0, 0, 0 }, data);
                    if (!data.SequenceEqual(bytes))
                    {
                        throw new Exception("Verify UFM Fail");
                    }


                }
                ProgramState = 90;
                //Write FEABITS
                line = jed_file.ReadLine();
                {
                    line = new string(line.ToCharArray().Reverse().Skip(1).ToArray());
                    byte[] bytes = new byte[2];
                    for (int i = 0; i < 2; ++i)
                    {
                        bytes[i] = Convert.ToByte(line.Substring(8 * i, 8), 2);
                    }
                    I2C_Write(0xF8, new byte[] { 0, 0, 0 }, bytes);
                    
                }
                ProgramState = 100;
                return true;

            }
            catch (Exception e)
            {
                try
                {
                    CleanUp();
                }
                catch
                {

                }
                return false;
            }

        }

        public void ReadFEABITs()
        {
            I2C_Write(0xC6, new byte[2] { 0x08, 0 }); //enter enable configuration interface (offline mode)
            WaitBusy();
            byte[] temp = new byte[8];
            byte[] FEABITs = new byte[2];
            I2C_Read(0xE7, new byte[3] { 0, 0, 0 }, temp);
            I2C_Read(0xFB, new byte[3] { 0, 0, 0 }, FEABITs);
            Exit();
        }

        void Exit()
        {
            I2C_Write(0x26, new byte[2] { 0, 0 });
            I2C_Write(0xFF, new byte[3] { 0xFF, 0xFF, 0xFF });
        }
        void WaitBusy()
        {
            //System.Threading.Thread.Sleep(1);
            byte[] Wr = new byte[1];
            uint tries = 0;
            do
            {
                try
                {
                    I2C_Read(0xF0, new byte[3] { 0, 0, 0 }, Wr);
                }
                catch(Exception e)
                {
                    tries++;
                    if (tries == 20)
                        throw e;
                    Wr[0] = 0x80;
                }
                
            } while ((Wr[0] & 0x80) != 0);
        }
        bool IsFail()
        {
            byte[] Wr = new byte[4];
            I2C_Read(0x3C, new byte[3] { 0, 0, 0 }, Wr);
            return (Wr[2] & 0x20) == 0x20;
        }
        void CleanUp()
        {
            I2C_Write(0x0E, new byte[3] { 0x0E, 0, 0 });
            WaitBusy();
            I2C_Write(0x79, new byte[2] { 0, 0 });
        }

        public bool CheckDeviceID( UInt32 ExpectedID)
        {
            byte[] ID = new byte[4];
            I2C_Read(0xE0, new byte[3] { 0, 0, 0 }, ID);
            return ExpectedID == (BitConverter.ToUInt32(ID.Reverse().ToArray(), 0) & 0xFFFF7FFF);
        }

        /*     ReadDeviceID
         *     Returns the ID of the Device. optional outputs:
         *     
         *     Device Name                 HE/ZE Devices   HC Devices
         *     MachXO2-256                 0x01 2B 00 43   0x01 2B 80 43
         *     MachXO2-640                 0x01 2B 10 43   0x01 2B 90 43
         *     MachXO2-1200/MachXO2-640U   0x01 2B 20 43   0x01 2B A0 43
         *     MachXO2-2000/MachXO2-1200U  0x01 2B 30 43   0x01 2B B0 43
         *     MachXO2-4000/MachXO2-2000U  0x01 2B 40 43   0x01 2B C0 43
         *     MachXO2-7000                0x01 2B 50 43   0x01 2B D0 43
       */
        public UInt32 ReadDeviceID()
        {
            byte[] ID = new byte[4];
            I2C_Read(0xE0, new byte[3] { 0, 0, 0 }, ID);
            return BitConverter.ToUInt32(ID.Reverse().ToArray(), 0);
        }

        void I2C_Write(byte CMD, byte[] OP, byte[] WData = null)
        {
            if (OP.Length != 3 && OP.Length != 2)
                throw new Exception("Length Not 3 for CMD "+ CMD.ToString() + " Write operation");
            byte[] Wr = new byte[1] { CMD };
            Wr = Wr.Concat(OP).ToArray();
            if (WData != null)
                Wr = Wr.Concat(WData).ToArray();
            if(!m_com.I2C_Write(0x40, 0, 0, Wr))
                throw new Exception("I2C Error 0x" + m_com.I2C_GetStatus().ToString("X") + " for CMD 0x" + CMD.ToString("X") + " Write operation");
        }
        void I2C_Read(byte CMD, byte[] OP, byte[] RData)
        {
            if (OP.Length != 3 && OP.Length != 2)
                throw new Exception("Length Not 3 for CMD " + CMD.ToString() + " Read operation");
            byte[] Wr = new byte[1] { CMD};
            Wr = Wr.Concat(OP).ToArray();
            if (!m_com.I2C_Transfer(0x40, Wr, RData))
                throw new Exception("I2C Error 0x"+ m_com.I2C_GetStatus().ToString("X") + " for CMD 0x" + CMD.ToString("X") + " Read operation");
        }

        public void Dispose()
        {
            m_com=null;
        }
    }
}
