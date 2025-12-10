using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Data;


namespace M9538
{

    public class Eth_Sub20 
    {
        byte m_slave_add;

        public bool I2C_Transfer(PDU activePDU,int SlaveAddress, Array WriteBuffer, Array ReadBuffer) // send set debug message
        {
            
            return true;
        }
        public  bool I2C_Write(PDU activePDU, byte SlaveAddress, byte MemoryAddress, byte MemoryAddressSize, byte[] Buffer)// send set debug message
        {
           
            Set_Debug msg = new Set_Debug();
            msg.Type = 2;
            msg.I2C_SlaveAddress = SlaveAddress;
            msg.I2C_MemoryAddress = MemoryAddress;
            msg.I2C_MemoryAddressSize = MemoryAddressSize;
            msg.I2C_Data = Buffer;
            msg.Send(activePDU);
            return true;

        }

        public  bool GPIO_Write(PDU activePDU,uint value, uint mask)// send set debug message
        {


            return true;
        }
        public  bool GPIO_Read(PDU activePDU,ref uint value)// send set debug message
        {

            return true;
        }

       public bool ProgramDevice( PDU activePDU, int index, string filepath) // code for ST set debug
        {
            // Tester.CB_PWR_OFF(com); GPIO on st side

            byte[] UFM = new byte[16];
            UFM[0] = 0x04;

            m_slave_add = (byte)(0x70 + index);

            // Tester.CB_PWR_ON(com, index);  GPIO on st side
            Thread.Sleep(100);
            // Programmer prg = new Programmer(com);
            StreamReader f = new StreamReader(filepath);
      
             byte[] Data_wr = new byte[1] { 0xDD };
             I2C_Write(activePDU, m_slave_add, 0x70, 1, Data_wr);
             Thread.Sleep(1000);
             Data_wr[0] = 0x7A;
             I2C_Write(activePDU, m_slave_add, 0x70, 1, Data_wr);
             Thread.Sleep(10000);
             //  Tester.CB_PWR_OFF(com);
             Thread.Sleep(1000);
             //  Tester.CB_PWR_ON(com, index);
             Thread.Sleep(100);
             //try
             //{
             //    if (!prg.CheckDeviceID(0x12B2043))
             //        return false;
             //}
             //catch
             //{
             //    return false;
             //}
            
            //bool res = prg.Program(0x012B2043, f, UFM); // TODO: figure out how to implement on ST side
                                                        //  Tester.CB_PWR_OFF(com);
            Thread.Sleep(100);
           // return res;
           return true ;
        }
    }


}

   
