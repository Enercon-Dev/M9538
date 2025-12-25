using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace M9538
{
    class SlaveRawI2c : M9526.I_I2C
    {
        public System.Threading.AutoResetEvent RecievedI2C;
        public Data.Message RecievedMsg = null;
        uint LastStatus = 0;
        System.Threading.SynchronizationContext SC;
        public delegate void PrintFunc(object str);
        public PrintFunc PrintToBox;
        private PDU m_activePDU;

        public SlaveRawI2c(PDU activePDU)
        {
            RecievedI2C = new System.Threading.AutoResetEvent(false);
            SC = System.Threading.SynchronizationContext.Current;
            m_activePDU = activePDU;
        }


        public bool I2C_Write(uint sadd, uint memadd, uint memlen, byte[] data)
        {
            //SC.Send(status => PrintToBox(Data),null);
            LastStatus = 0xFF;
            data = BitConverter.GetBytes((UInt32)memadd).Take((int)memlen).Concat(data).ToArray();
            RecievedI2C.Reset();
            byte wrLen = (byte)data.Count();
            Data.Set_Debug msg = new Set_Debug();
            msg.set_I2C_Write((byte)sadd, data);
            msg.Send(m_activePDU);
            if (!RecievedI2C.WaitOne(1000)) return false;
            LastStatus = new Data.Set_Debug(RecievedMsg).I2cResult;
            if (LastStatus != 0) return false;
            return true;
        }

        public bool I2C_Transfer(uint sadd, byte[] WrData, byte[] RdData)
        {
            LastStatus = 0xFF;
            RecievedI2C.Reset();
            Data.Set_Debug msg = new Set_Debug();
            msg.set_I2C_Transfer((byte)sadd, WrData, (byte)RdData.Count());
            msg.Send(m_activePDU);
            if (!RecievedI2C.WaitOne(1000)) return false;
            LastStatus = new Data.Set_Debug(RecievedMsg).I2cResult;
            if (LastStatus != 0) return false;
            new Data.Set_Debug(RecievedMsg).RecvdData.CopyTo(RdData, 0);
            return true;
        }

        public uint I2C_GetStatus()
        {
            return LastStatus;
        }
    }
}
