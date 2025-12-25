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
using Data;
using static Data.Message;

namespace M9538
{
    public partial class SlaveUpdate : Form
    {
        private SlaveRawI2c CBRawI2C;
        AutoResetEvent m_recieved_flag;
        Data.Message Recieved_Message = null;
        System.Threading.Thread m_thd = null;
        System.Threading.SynchronizationContext SC;
        List<ProgressBar> pbList;
        List<CheckBox> cbList;
        PDU m_activePDU;
        

        public SlaveUpdate(PDU activePDU)
        {
            InitializeComponent();
            m_activePDU = activePDU;
            CBRawI2C = new SlaveRawI2c(activePDU);
            CBRawI2C.PrintToBox = PrintToLb;
            m_recieved_flag = new AutoResetEvent(false);
            pbList = new List<ProgressBar>(16)
            {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4,
                progressBar5,
                progressBar6,
                progressBar7,
                progressBar8,
                progressBar9,
                progressBar10,
                progressBar11,
                progressBar12,
                progressBar13,
                progressBar14,
                progressBar15,
                progressBar16

            };
            cbList = new List<CheckBox>(16)
            {
                checkBox1,
                checkBox2,
                checkBox3,
                checkBox4,
                checkBox5,
                checkBox6,
                checkBox7,
                checkBox8,
                checkBox9,
                checkBox10,
                checkBox11,
                checkBox12,
                checkBox13,
                checkBox14,
                checkBox15,
                checkBox16

            };
            foreach (CheckBox cb in cbList)
            {
                cb.Text = "Output " + cbList.IndexOf(cb).ToString();
                cb.Checked = true;
            }
        }
        
        private void PrintToLb(object str)
        {
            if (str.GetType().IsArray)
                lbCalib.Items.Add(string.Join("-", Array.ConvertAll((byte [])str, x => x.ToString("X2"))));
            else
                lbCalib.Items.Add(str.ToString());
        }

        byte activeChannel;
        private void btnCal_Click(object sender, EventArgs e)
        {
            SC = System.Threading.SynchronizationContext.Current;
            pbList.ForEach(x => x.Value = 0);
            timer1.Start();
            m_thd = new Thread(StartUpdate);
            m_thd.Start();


            /*
            Data.Calibrate msg = new Calibrate();
            msg.Channel = (int)nudChannel.Value;
            if (rbCurrent.Checked)
                msg.Calibration = Calibrate.CalibrationType.CURRENT;
            else
                msg.Calibration = Calibrate.CalibrationType.VOLTAGE;
            double val;
            double.TryParse(tbValue.Text, out val);
            msg.Value = val;
            msg.Send();
            */
        }

        M9526.Programmer prg = null;

        private void StartUpdate()
        {
            foreach (CheckBox cb in cbList)
            {
                if (!cb.Checked) continue;
                activeChannel = (byte)cbList.IndexOf(cb);
                prg = new M9526.Programmer(CBRawI2C);
                byte m_slave_add = (byte)(activeChannel > 7 ? activeChannel : activeChannel + 0x70);
                Data.Set_Debug msg = new Set_Debug();
                msg.Module_On(activeChannel, P_Enable.Enable);
                SC.Send(status => msg.Send(m_activePDU), null);
                if (!m_recieved_flag.WaitOne(1000))
                    SC.Send(status => PrintToLb("time out turning on module"), null);
                Thread.Sleep(1000);
                byte[] Data_wr = new byte[1] { 0xDD };
                CBRawI2C.I2C_Write(m_slave_add, 0x70, 1, Data_wr);
                Thread.Sleep(1000);
                Data_wr[0] = 0x7A;
                CBRawI2C.I2C_Write(m_slave_add, 0x70, 1, Data_wr);
                Thread.Sleep(10000);
                msg.Module_On(activeChannel, P_Enable.Disable);
                SC.Send(status => msg.Send(m_activePDU), null);
                if (!m_recieved_flag.WaitOne(1000))
                    SC.Send(status => PrintToLb("time out turning off module"), null);
                Thread.Sleep(1000);
                msg.Module_On(activeChannel, P_Enable.Enable);
                SC.Send(status => msg.Send(m_activePDU), null);
                if (!m_recieved_flag.WaitOne(1000))
                    SC.Send(status => PrintToLb("time out turning on module"), null);
                Thread.Sleep(100);
                bool res = prg.Program(0x012B2043, new StreamReader(tbFileName.Text));
                if (!res)
                {
                    SC.Send(status => pbList[(int)activeChannel].Value = 0, null);
                    SC.Send(status => pbList[(int)activeChannel].BackColor = Color.Red, null);
                }
                msg.Module_On(activeChannel, P_Enable.Disable);
                SC.Send(status => msg.Send(m_activePDU), null);
                if (!m_recieved_flag.WaitOne(1000))
                    SC.Send(status => PrintToLb("time out turning off module"), null);
                SC.Send(status => PrintToLb("Finished Ch number " + activeChannel.ToString()), null);
                Thread.Sleep(100);
                SC.Send(status=> pbList[(int)activeChannel].Value = (int)prg.ProgramState,null);
            }
            

        }


        private void SlaveCalibration_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m_thd == null)
                return;
            m_thd.Abort();
            if (!m_thd.IsAlive)
                m_thd = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = openFileDialog2.ShowDialog();
            if (rs != DialogResult.OK)
                return;
            tbFileName.Text = openFileDialog2.FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prg == null) return;
            pbList[(int)activeChannel].Value = (int)prg.ProgramState;
        }
    }
}
