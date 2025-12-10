using System.Collections.Generic;
using Tftp.Net;

namespace M9538
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpControl = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.led1 = new Data.Led(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblInVolt = new System.Windows.Forms.Label();
            this.lblInCurr = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sspc1 = new OUTPUT();
            this.output1 = new OUTPUT();
            this.output2 = new OUTPUT();
            this.output3 = new OUTPUT();
            this.output4 = new OUTPUT();
            this.output5 = new OUTPUT();
            this.output6 = new OUTPUT();
            this.output7 = new OUTPUT();
            this.group1 = new GROUP();
            this.group2 = new GROUP();
            this.group3 = new GROUP();
            this.group4 = new GROUP();
            this.group5 = new GROUP();
            this.group6 = new GROUP();
            this.group7 = new GROUP();
            this.group8 = new GROUP();
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLimits = new System.Windows.Forms.DataGridView();
            this.clUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOverload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCurrentLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTherm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clbOutputs = new System.Windows.Forms.CheckedListBox();
            this.btnGroupLimits = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btnSetGroup = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.tbGroupTherm = new System.Windows.Forms.TextBox();
            this.tbGroupSC = new System.Windows.Forms.TextBox();
            this.tbGroupOL = new System.Windows.Forms.TextBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.btnPor = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.tbPorDelay = new System.Windows.Forms.TextBox();
            this.tbPorChans = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btnDci = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.tbDciOper = new System.Windows.Forms.TextBox();
            this.tbDciDelay = new System.Windows.Forms.TextBox();
            this.tbDciChan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbConfigDynamic = new System.Windows.Forms.RadioButton();
            this.rbConfigStatic = new System.Windows.Forms.RadioButton();
            this.gbConfigStatic = new System.Windows.Forms.GroupBox();
            this.iacSelectedMac = new IPAddressControlLib.IPAddressControl();
            this.iacSelectedIp = new IPAddressControlLib.IPAddressControl();
            this.iacSelectedGw = new IPAddressControlLib.IPAddressControl();
            this.label43 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSetSN = new System.Windows.Forms.Button();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OutputsToProgram = new System.Windows.Forms.CheckedListBox();
            this.label46 = new System.Windows.Forms.Label();
            this.Btn_ChannelUpload = new System.Windows.Forms.Button();
            this.Browse_FpgaBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpDHCP = new System.Windows.Forms.TabPage();
            this.dgvDHCPLease = new System.Windows.Forms.DataGridView();
            this.dgv_clSesionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clMAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clLeaseExpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clAck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbDHCPTrace = new System.Windows.Forms.ListBox();
            this.dgPDUs = new System.Windows.Forms.DataGridView();
            this.cbActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.tsmiStart = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tmrFirmware = new System.Windows.Forms.Timer(this.components);
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tmrGetStatus = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tpConfig.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimits)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbConfigStatic.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tpDHCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDHCPLease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPDUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpControl);
            this.tabControl.Controls.Add(this.tpConfig);
            this.tabControl.Controls.Add(this.tpUpdate);
            this.tabControl.Controls.Add(this.tpDHCP);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(738, 457);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tpControl
            // 
            this.tpControl.Controls.Add(this.splitContainer1);
            this.tpControl.Location = new System.Drawing.Point(4, 22);
            this.tpControl.Name = "tpControl";
            this.tpControl.Padding = new System.Windows.Forms.Padding(3);
            this.tpControl.Size = new System.Drawing.Size(730, 431);
            this.tpControl.TabIndex = 2;
            this.tpControl.Text = "Status & Control";
            this.tpControl.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(724, 425);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.led1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label28, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblInVolt, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblInCurr, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblTemp, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(123, 425);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.Silver;
            this.led1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.led1.Location = new System.Drawing.Point(3, 3);
            this.led1.Margin = new System.Windows.Forms.Padding(3);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(25, 25);
            this.led1.TabIndex = 6;
            this.led1.Click += new System.EventHandler(this.led1_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 31);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.label27.Size = new System.Drawing.Size(70, 28);
            this.label27.TabIndex = 7;
            this.label27.Text = "Input Voltage";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 59);
            this.label28.Name = "label28";
            this.label28.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.label28.Size = new System.Drawing.Size(68, 28);
            this.label28.TabIndex = 7;
            this.label28.Text = "Input Current";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 87);
            this.label29.Name = "label29";
            this.label29.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.label29.Size = new System.Drawing.Size(67, 28);
            this.label29.TabIndex = 7;
            this.label29.Text = "Temperature";
            // 
            // lblInVolt
            // 
            this.lblInVolt.AutoSize = true;
            this.lblInVolt.Location = new System.Drawing.Point(79, 31);
            this.lblInVolt.Name = "lblInVolt";
            this.lblInVolt.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.lblInVolt.Size = new System.Drawing.Size(41, 28);
            this.lblInVolt.TabIndex = 7;
            this.lblInVolt.Text = "-00.0 V";
            // 
            // lblInCurr
            // 
            this.lblInCurr.AutoSize = true;
            this.lblInCurr.Location = new System.Drawing.Point(79, 59);
            this.lblInCurr.Name = "lblInCurr";
            this.lblInCurr.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.lblInCurr.Size = new System.Drawing.Size(37, 28);
            this.lblInCurr.TabIndex = 7;
            this.lblInCurr.Text = "-00.0 I";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(79, 87);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.lblTemp.Size = new System.Drawing.Size(33, 28);
            this.lblTemp.TabIndex = 7;
            this.lblTemp.Text = "25 °C";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.sspc1);
            this.flowLayoutPanel1.Controls.Add(this.output1);
            this.flowLayoutPanel1.Controls.Add(this.output2);
            this.flowLayoutPanel1.Controls.Add(this.output3);
            this.flowLayoutPanel1.Controls.Add(this.output4);
            this.flowLayoutPanel1.Controls.Add(this.output5);
            this.flowLayoutPanel1.Controls.Add(this.output6);
            this.flowLayoutPanel1.Controls.Add(this.output7);
            this.flowLayoutPanel1.Controls.Add(this.group1);
            this.flowLayoutPanel1.Controls.Add(this.group2);
            this.flowLayoutPanel1.Controls.Add(this.group3);
            this.flowLayoutPanel1.Controls.Add(this.group4);
            this.flowLayoutPanel1.Controls.Add(this.group5);
            this.flowLayoutPanel1.Controls.Add(this.group6);
            this.flowLayoutPanel1.Controls.Add(this.group7);
            this.flowLayoutPanel1.Controls.Add(this.group8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(597, 425);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // sspc1
            // 
            this.sspc1.Location = new System.Drawing.Point(4, 4);
            this.sspc1.Margin = new System.Windows.Forms.Padding(4);
            this.sspc1.Name = "sspc1";
            this.sspc1.OUT_ID = 1;
            this.sspc1.OutLabel = null;
            this.sspc1.Size = new System.Drawing.Size(150, 114);
            this.sspc1.TabIndex = 0;
            this.sspc1._SwitchClicked += new System.EventHandler(this.sspc1__SwitchClicked);
            this.sspc1._BattleClicked += new System.EventHandler(this.BattleClicked);
            this.sspc1._ResetTripsClicked += new System.EventHandler(this.sspc1__ResetTripsClicked);
            // 
            // output1
            // 
            this.output1.Location = new System.Drawing.Point(162, 4);
            this.output1.Margin = new System.Windows.Forms.Padding(4);
            this.output1.Name = "output1";
            this.output1.OUT_ID = 2;
            this.output1.OutLabel = null;
            this.output1.Size = new System.Drawing.Size(150, 114);
            this.output1.TabIndex = 0;
            this.output1._SwitchClicked += new System.EventHandler(this.sspc1__SwitchClicked);
            this.output1._BattleClicked += new System.EventHandler(this.BattleClicked);
            this.output1._ResetTripsClicked += new System.EventHandler(this.sspc1__ResetTripsClicked);
            // 
            // output2
            // 
            this.output2.Location = new System.Drawing.Point(320, 4);
            this.output2.Margin = new System.Windows.Forms.Padding(4);
            this.output2.Name = "output2";
            this.output2.OUT_ID = 3;
            this.output2.OutLabel = null;
            this.output2.Size = new System.Drawing.Size(150, 114);
            this.output2.TabIndex = 0;
            this.output2._SwitchClicked += new System.EventHandler(this.sspc1__SwitchClicked);
            this.output2._BattleClicked += new System.EventHandler(this.BattleClicked);
            this.output2._ResetTripsClicked += new System.EventHandler(this.sspc1__ResetTripsClicked);
            // 
            // output3
            // 
            this.output3.Location = new System.Drawing.Point(4, 126);
            this.output3.Margin = new System.Windows.Forms.Padding(4);
            this.output3.Name = "output3";
            this.output3.OUT_ID = 4;
            this.output3.OutLabel = null;
            this.output3.Size = new System.Drawing.Size(150, 114);
            this.output3.TabIndex = 0;
            this.output3._SwitchClicked += new System.EventHandler(this.sspc1__SwitchClicked);
            this.output3._BattleClicked += new System.EventHandler(this.BattleClicked);
            this.output3._ResetTripsClicked += new System.EventHandler(this.sspc1__ResetTripsClicked);
            // 
            // output4
            // 
            this.output4.Location = new System.Drawing.Point(162, 126);
            this.output4.Margin = new System.Windows.Forms.Padding(4);
            this.output4.Name = "output4";
            this.output4.OUT_ID = 5;
            this.output4.OutLabel = null;
            this.output4.Size = new System.Drawing.Size(150, 114);
            this.output4.TabIndex = 0;
            this.output4._SwitchClicked += new System.EventHandler(this.sspc1__SwitchClicked);
            this.output4._BattleClicked += new System.EventHandler(this.BattleClicked);
            this.output4._ResetTripsClicked += new System.EventHandler(this.sspc1__ResetTripsClicked);
            // 
            // output5
            // 
            this.output5.Location = new System.Drawing.Point(320, 126);
            this.output5.Margin = new System.Windows.Forms.Padding(4);
            this.output5.Name = "output5";
            this.output5.OUT_ID = 6;
            this.output5.OutLabel = null;
            this.output5.Size = new System.Drawing.Size(150, 114);
            this.output5.TabIndex = 0;
            this.output5._SwitchClicked += new System.EventHandler(this.sspc1__SwitchClicked);
            this.output5._BattleClicked += new System.EventHandler(this.BattleClicked);
            this.output5._ResetTripsClicked += new System.EventHandler(this.sspc1__ResetTripsClicked);
            // 
            // output6
            // 
            this.output6.Location = new System.Drawing.Point(4, 248);
            this.output6.Margin = new System.Windows.Forms.Padding(4);
            this.output6.Name = "output6";
            this.output6.OUT_ID = 7;
            this.output6.OutLabel = null;
            this.output6.Size = new System.Drawing.Size(150, 114);
            this.output6.TabIndex = 0;
            this.output6._SwitchClicked += new System.EventHandler(this.sspc1__SwitchClicked);
            this.output6._BattleClicked += new System.EventHandler(this.BattleClicked);
            this.output6._ResetTripsClicked += new System.EventHandler(this.sspc1__ResetTripsClicked);
            // 
            // output7
            // 
            this.output7.Location = new System.Drawing.Point(162, 248);
            this.output7.Margin = new System.Windows.Forms.Padding(4);
            this.output7.Name = "output7";
            this.output7.OUT_ID = 8;
            this.output7.OutLabel = null;
            this.output7.Size = new System.Drawing.Size(150, 114);
            this.output7.TabIndex = 0;
            this.output7._SwitchClicked += new System.EventHandler(this.sspc1__SwitchClicked);
            this.output7._BattleClicked += new System.EventHandler(this.BattleClicked);
            this.output7._ResetTripsClicked += new System.EventHandler(this.sspc1__ResetTripsClicked);
            // 
            // group1
            // 
            this.group1.GROUP_ID = 1;
            this.group1.Location = new System.Drawing.Point(320, 248);
            this.group1.Margin = new System.Windows.Forms.Padding(4);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(150, 233);
            this.group1.TabIndex = 1;
            this.group1._SwitchClicked += new System.EventHandler(this.group1__SwitchClicked);
            this.group1._BattleClicked += new System.EventHandler(this.group1__BattleClicked);
            this.group1._ResetTripsClicked += new System.EventHandler(this.group1__ResetTripsClicked);
            // 
            // group2
            // 
            this.group2.GROUP_ID = 2;
            this.group2.Location = new System.Drawing.Point(4, 489);
            this.group2.Margin = new System.Windows.Forms.Padding(4);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(150, 233);
            this.group2.TabIndex = 1;
            this.group2._SwitchClicked += new System.EventHandler(this.group1__SwitchClicked);
            // 
            // group3
            // 
            this.group3.GROUP_ID = 3;
            this.group3.Location = new System.Drawing.Point(162, 489);
            this.group3.Margin = new System.Windows.Forms.Padding(4);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(150, 233);
            this.group3.TabIndex = 1;
            this.group3._SwitchClicked += new System.EventHandler(this.group1__SwitchClicked);
            // 
            // group4
            // 
            this.group4.GROUP_ID = 4;
            this.group4.Location = new System.Drawing.Point(320, 489);
            this.group4.Margin = new System.Windows.Forms.Padding(4);
            this.group4.Name = "group4";
            this.group4.Size = new System.Drawing.Size(150, 233);
            this.group4.TabIndex = 1;
            this.group4._SwitchClicked += new System.EventHandler(this.group1__SwitchClicked);
            // 
            // group5
            // 
            this.group5.GROUP_ID = 5;
            this.group5.Location = new System.Drawing.Point(4, 730);
            this.group5.Margin = new System.Windows.Forms.Padding(4);
            this.group5.Name = "group5";
            this.group5.Size = new System.Drawing.Size(150, 233);
            this.group5.TabIndex = 1;
            this.group5._SwitchClicked += new System.EventHandler(this.group1__SwitchClicked);
            // 
            // group6
            // 
            this.group6.GROUP_ID = 6;
            this.group6.Location = new System.Drawing.Point(162, 730);
            this.group6.Margin = new System.Windows.Forms.Padding(4);
            this.group6.Name = "group6";
            this.group6.Size = new System.Drawing.Size(150, 233);
            this.group6.TabIndex = 2;
            this.group6._SwitchClicked += new System.EventHandler(this.group1__SwitchClicked);
            // 
            // group7
            // 
            this.group7.GROUP_ID = 7;
            this.group7.Location = new System.Drawing.Point(320, 730);
            this.group7.Margin = new System.Windows.Forms.Padding(4);
            this.group7.Name = "group7";
            this.group7.Size = new System.Drawing.Size(150, 233);
            this.group7.TabIndex = 3;
            this.group7._SwitchClicked += new System.EventHandler(this.group1__SwitchClicked);
            // 
            // group8
            // 
            this.group8.GROUP_ID = 8;
            this.group8.Location = new System.Drawing.Point(4, 971);
            this.group8.Margin = new System.Windows.Forms.Padding(4);
            this.group8.Name = "group8";
            this.group8.Size = new System.Drawing.Size(150, 233);
            this.group8.TabIndex = 4;
            this.group8._SwitchClicked += new System.EventHandler(this.group1__SwitchClicked);
            // 
            // tpConfig
            // 
            this.tpConfig.AutoScroll = true;
            this.tpConfig.Controls.Add(this.tableLayoutPanel1);
            this.tpConfig.Location = new System.Drawing.Point(4, 22);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfig.Size = new System.Drawing.Size(730, 431);
            this.tpConfig.TabIndex = 4;
            this.tpConfig.Text = "Configuration";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvLimits, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 425);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvLimits
            // 
            this.dgvLimits.AllowUserToAddRows = false;
            this.dgvLimits.AllowUserToDeleteRows = false;
            this.dgvLimits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLimits.ColumnHeadersHeight = 34;
            this.dgvLimits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUpdate,
            this.clChannel,
            this.clOverload,
            this.clCurrentLimit,
            this.clTherm});
            this.dgvLimits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLimits.Location = new System.Drawing.Point(3, 3);
            this.dgvLimits.Name = "dgvLimits";
            this.dgvLimits.RowHeadersWidth = 62;
            this.dgvLimits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLimits.ShowEditingIcon = false;
            this.dgvLimits.Size = new System.Drawing.Size(718, 275);
            this.dgvLimits.TabIndex = 0;
            this.dgvLimits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLimits_CellContentClick);
            this.dgvLimits.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLimits_CellEnter);
            // 
            // clUpdate
            // 
            this.clUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clUpdate.FillWeight = 30F;
            this.clUpdate.HeaderText = "Update";
            this.clUpdate.MinimumWidth = 8;
            this.clUpdate.Name = "clUpdate";
            this.clUpdate.Text = "↑";
            this.clUpdate.Width = 48;
            // 
            // clChannel
            // 
            this.clChannel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clChannel.DataPropertyName = "strChannel";
            this.clChannel.HeaderText = "Channel";
            this.clChannel.MinimumWidth = 8;
            this.clChannel.Name = "clChannel";
            this.clChannel.ReadOnly = true;
            this.clChannel.Width = 71;
            // 
            // clOverload
            // 
            this.clOverload.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clOverload.DataPropertyName = "strOverload";
            this.clOverload.HeaderText = "Overload Limit";
            this.clOverload.MinimumWidth = 8;
            this.clOverload.Name = "clOverload";
            this.clOverload.Width = 91;
            // 
            // clCurrentLimit
            // 
            this.clCurrentLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clCurrentLimit.DataPropertyName = "strCurrentLimit";
            this.clCurrentLimit.HeaderText = "Current Limit";
            this.clCurrentLimit.MinimumWidth = 8;
            this.clCurrentLimit.Name = "clCurrentLimit";
            this.clCurrentLimit.Width = 83;
            // 
            // clTherm
            // 
            this.clTherm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clTherm.DataPropertyName = "strThermal";
            this.clTherm.HeaderText = "Thermal Constant";
            this.clTherm.MinimumWidth = 8;
            this.clTherm.Name = "clTherm";
            this.clTherm.Width = 106;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.clbOutputs);
            this.groupBox6.Controls.Add(this.btnGroupLimits);
            this.groupBox6.Controls.Add(this.label41);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.btnSetGroup);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.tbGroupTherm);
            this.groupBox6.Controls.Add(this.tbGroupSC);
            this.groupBox6.Controls.Add(this.tbGroupOL);
            this.groupBox6.Controls.Add(this.cbGroup);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(718, 117);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Grouping";
            // 
            // clbOutputs
            // 
            this.clbOutputs.ColumnWidth = 70;
            this.clbOutputs.FormattingEnabled = true;
            this.clbOutputs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.clbOutputs.Location = new System.Drawing.Point(124, 30);
            this.clbOutputs.MultiColumn = true;
            this.clbOutputs.Name = "clbOutputs";
            this.clbOutputs.Size = new System.Drawing.Size(159, 49);
            this.clbOutputs.TabIndex = 2;
            // 
            // btnGroupLimits
            // 
            this.btnGroupLimits.Location = new System.Drawing.Point(640, 30);
            this.btnGroupLimits.Name = "btnGroupLimits";
            this.btnGroupLimits.Size = new System.Drawing.Size(75, 23);
            this.btnGroupLimits.TabIndex = 3;
            this.btnGroupLimits.Text = "Update";
            this.btnGroupLimits.UseVisualStyleBackColor = true;
            this.btnGroupLimits.Click += new System.EventHandler(this.btnGroupLimits_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(439, 81);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(45, 13);
            this.label41.TabIndex = 1;
            this.label41.Text = "Thermal";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(439, 55);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(32, 13);
            this.label40.TabIndex = 1;
            this.label40.Text = "Short";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(439, 26);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(50, 13);
            this.label39.TabIndex = 1;
            this.label39.Text = "Overload";
            // 
            // btnSetGroup
            // 
            this.btnSetGroup.Location = new System.Drawing.Point(321, 30);
            this.btnSetGroup.Name = "btnSetGroup";
            this.btnSetGroup.Size = new System.Drawing.Size(75, 23);
            this.btnSetGroup.TabIndex = 3;
            this.btnSetGroup.Text = "Update";
            this.btnSetGroup.UseVisualStyleBackColor = true;
            this.btnSetGroup.Click += new System.EventHandler(this.btnSetGroup_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(16, 14);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(36, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "Group";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(174, 14);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Outputs";
            // 
            // tbGroupTherm
            // 
            this.tbGroupTherm.Location = new System.Drawing.Point(544, 78);
            this.tbGroupTherm.Name = "tbGroupTherm";
            this.tbGroupTherm.Size = new System.Drawing.Size(75, 20);
            this.tbGroupTherm.TabIndex = 0;
            // 
            // tbGroupSC
            // 
            this.tbGroupSC.Location = new System.Drawing.Point(544, 52);
            this.tbGroupSC.Name = "tbGroupSC";
            this.tbGroupSC.Size = new System.Drawing.Size(75, 20);
            this.tbGroupSC.TabIndex = 0;
            // 
            // tbGroupOL
            // 
            this.tbGroupOL.Location = new System.Drawing.Point(544, 26);
            this.tbGroupOL.Name = "tbGroupOL";
            this.tbGroupOL.Size = new System.Drawing.Size(75, 20);
            this.tbGroupOL.TabIndex = 0;
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(9, 30);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(80, 21);
            this.cbGroup.TabIndex = 0;
            this.cbGroup.SelectedValueChanged += new System.EventHandler(this.cbGroup_SelectedValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.btnPor);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.tbPorDelay);
            this.groupBox5.Controls.Add(this.tbPorChans);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 407);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(718, 94);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "POR";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 55);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Delay Before Enable";
            // 
            // btnPor
            // 
            this.btnPor.Location = new System.Drawing.Point(377, 24);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(94, 23);
            this.btnPor.TabIndex = 1;
            this.btnPor.Text = "Update";
            this.btnPor.Click += new System.EventHandler(this.button3_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 29);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "Channels to Enable";
            // 
            // tbPorDelay
            // 
            this.tbPorDelay.Location = new System.Drawing.Point(112, 52);
            this.tbPorDelay.Name = "tbPorDelay";
            this.tbPorDelay.Size = new System.Drawing.Size(231, 20);
            this.tbPorDelay.TabIndex = 0;
            // 
            // tbPorChans
            // 
            this.tbPorChans.Location = new System.Drawing.Point(112, 26);
            this.tbPorChans.Name = "tbPorChans";
            this.tbPorChans.Size = new System.Drawing.Size(231, 20);
            this.tbPorChans.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.btnDci);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.tbDciOper);
            this.groupBox7.Controls.Add(this.tbDciDelay);
            this.groupBox7.Controls.Add(this.tbDciChan);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 507);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(718, 108);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DCI";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(7, 81);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 13);
            this.label38.TabIndex = 1;
            this.label38.Text = "Operation";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(7, 55);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "Delay";
            // 
            // btnDci
            // 
            this.btnDci.Location = new System.Drawing.Point(377, 52);
            this.btnDci.Name = "btnDci";
            this.btnDci.Size = new System.Drawing.Size(94, 23);
            this.btnDci.TabIndex = 1;
            this.btnDci.Text = "Update";
            this.btnDci.Click += new System.EventHandler(this.btnDci_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(7, 29);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(51, 13);
            this.label37.TabIndex = 1;
            this.label37.Text = "Channels";
            // 
            // tbDciOper
            // 
            this.tbDciOper.Location = new System.Drawing.Point(112, 78);
            this.tbDciOper.Name = "tbDciOper";
            this.tbDciOper.Size = new System.Drawing.Size(231, 20);
            this.tbDciOper.TabIndex = 0;
            // 
            // tbDciDelay
            // 
            this.tbDciDelay.Location = new System.Drawing.Point(112, 52);
            this.tbDciDelay.Name = "tbDciDelay";
            this.tbDciDelay.Size = new System.Drawing.Size(231, 20);
            this.tbDciDelay.TabIndex = 0;
            // 
            // tbDciChan
            // 
            this.tbDciChan.Location = new System.Drawing.Point(112, 26);
            this.tbDciChan.Name = "tbDciChan";
            this.tbDciChan.Size = new System.Drawing.Size(231, 20);
            this.tbDciChan.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 621);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(264, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 201);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rbConfigDynamic);
            this.groupBox2.Controls.Add(this.rbConfigStatic);
            this.groupBox2.Controls.Add(this.gbConfigStatic);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 201);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP Configuration";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rbConfigDynamic
            // 
            this.rbConfigDynamic.AutoSize = true;
            this.rbConfigDynamic.Location = new System.Drawing.Point(11, 19);
            this.rbConfigDynamic.Name = "rbConfigDynamic";
            this.rbConfigDynamic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbConfigDynamic.Size = new System.Drawing.Size(76, 17);
            this.rbConfigDynamic.TabIndex = 0;
            this.rbConfigDynamic.TabStop = true;
            this.rbConfigDynamic.Text = "Dynamic";
            this.rbConfigDynamic.UseVisualStyleBackColor = true;
            this.rbConfigDynamic.CheckedChanged += new System.EventHandler(this.rbConfigStatic_CheckedChanged);
            // 
            // rbConfigStatic
            // 
            this.rbConfigStatic.AutoSize = true;
            this.rbConfigStatic.Location = new System.Drawing.Point(11, 39);
            this.rbConfigStatic.Name = "rbConfigStatic";
            this.rbConfigStatic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbConfigStatic.Size = new System.Drawing.Size(62, 17);
            this.rbConfigStatic.TabIndex = 0;
            this.rbConfigStatic.TabStop = true;
            this.rbConfigStatic.Text = "Static";
            this.rbConfigStatic.UseVisualStyleBackColor = true;
            this.rbConfigStatic.CheckedChanged += new System.EventHandler(this.rbConfigStatic_CheckedChanged);
            this.rbConfigStatic.Click += new System.EventHandler(this.rbConfigStatic_Click);
            // 
            // gbConfigStatic
            // 
            this.gbConfigStatic.Controls.Add(this.iacSelectedMac);
            this.gbConfigStatic.Controls.Add(this.iacSelectedIp);
            this.gbConfigStatic.Controls.Add(this.iacSelectedGw);
            this.gbConfigStatic.Controls.Add(this.label43);
            this.gbConfigStatic.Controls.Add(this.label31);
            this.gbConfigStatic.Controls.Add(this.label30);
            this.gbConfigStatic.Enabled = false;
            this.gbConfigStatic.Location = new System.Drawing.Point(6, 42);
            this.gbConfigStatic.Name = "gbConfigStatic";
            this.gbConfigStatic.Size = new System.Drawing.Size(237, 124);
            this.gbConfigStatic.TabIndex = 0;
            this.gbConfigStatic.TabStop = false;
            this.gbConfigStatic.Text = "                      ";
            // 
            // iacSelectedMac
            // 
            this.iacSelectedMac.AllowInternalTab = true;
            this.iacSelectedMac.AutoHeight = true;
            this.iacSelectedMac.BackColor = System.Drawing.SystemColors.Window;
            this.iacSelectedMac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iacSelectedMac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iacSelectedMac.Location = new System.Drawing.Point(113, 62);
            this.iacSelectedMac.Margin = new System.Windows.Forms.Padding(4);
            this.iacSelectedMac.MinimumSize = new System.Drawing.Size(87, 20);
            this.iacSelectedMac.Name = "iacSelectedMac";
            this.iacSelectedMac.ReadOnly = false;
            this.iacSelectedMac.Size = new System.Drawing.Size(111, 20);
            this.iacSelectedMac.TabIndex = 1;
            this.iacSelectedMac.Text = "...";
            // 
            // iacSelectedIp
            // 
            this.iacSelectedIp.AllowInternalTab = true;
            this.iacSelectedIp.AutoHeight = true;
            this.iacSelectedIp.BackColor = System.Drawing.SystemColors.Window;
            this.iacSelectedIp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iacSelectedIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iacSelectedIp.Location = new System.Drawing.Point(113, 32);
            this.iacSelectedIp.Margin = new System.Windows.Forms.Padding(4);
            this.iacSelectedIp.MinimumSize = new System.Drawing.Size(87, 20);
            this.iacSelectedIp.Name = "iacSelectedIp";
            this.iacSelectedIp.ReadOnly = false;
            this.iacSelectedIp.Size = new System.Drawing.Size(111, 20);
            this.iacSelectedIp.TabIndex = 0;
            this.iacSelectedIp.Text = "...";
            this.iacSelectedIp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iacSelectedIp_KeyDown);
            // 
            // iacSelectedGw
            // 
            this.iacSelectedGw.AllowInternalTab = true;
            this.iacSelectedGw.AutoHeight = true;
            this.iacSelectedGw.BackColor = System.Drawing.SystemColors.Window;
            this.iacSelectedGw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iacSelectedGw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iacSelectedGw.Location = new System.Drawing.Point(113, 93);
            this.iacSelectedGw.Margin = new System.Windows.Forms.Padding(4);
            this.iacSelectedGw.MinimumSize = new System.Drawing.Size(87, 20);
            this.iacSelectedGw.Name = "iacSelectedGw";
            this.iacSelectedGw.ReadOnly = false;
            this.iacSelectedGw.Size = new System.Drawing.Size(111, 20);
            this.iacSelectedGw.TabIndex = 3;
            this.iacSelectedGw.Text = "...";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 96);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(89, 13);
            this.label43.TabIndex = 4;
            this.label43.Text = "Default Gateway:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 65);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(73, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Subnet Mask:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(9, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(61, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "IP Address:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 847);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(718, 856);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Erase";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(61, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Erase All Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tpUpdate
            // 
            this.tpUpdate.Controls.Add(this.splitContainer5);
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(730, 431);
            this.tpUpdate.TabIndex = 3;
            this.tpUpdate.Text = "Update";
            this.tpUpdate.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.textBox1);
            this.splitContainer5.Panel1.Controls.Add(this.label42);
            this.splitContainer5.Panel1.Controls.Add(this.btnReset);
            this.splitContainer5.Panel1.Controls.Add(this.btnSetSN);
            this.splitContainer5.Panel1.Controls.Add(this.tbSerial);
            this.splitContainer5.Panel1.Controls.Add(this.label25);
            this.splitContainer5.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer5.Panel1.Controls.Add(this.label15);
            this.splitContainer5.Panel1.Controls.Add(this.label1);
            this.splitContainer5.Panel1.Controls.Add(this.label14);
            this.splitContainer5.Panel1.Controls.Add(this.label3);
            this.splitContainer5.Panel1.Controls.Add(this.label12);
            this.splitContainer5.Panel1.Controls.Add(this.label11);
            this.splitContainer5.Panel1.Controls.Add(this.label4);
            this.splitContainer5.Panel1.Controls.Add(this.label13);
            this.splitContainer5.Panel1.Controls.Add(this.label2);
            this.splitContainer5.Panel1.Controls.Add(this.label16);
            this.splitContainer5.Panel1.Controls.Add(this.label84);
            this.splitContainer5.Panel1.Controls.Add(this.label83);
            this.splitContainer5.Panel1.Controls.Add(this.label82);
            this.splitContainer5.Panel1.Controls.Add(this.label80);
            this.splitContainer5.Panel1.Controls.Add(this.label79);
            this.splitContainer5.Panel1.Controls.Add(this.label8);
            this.splitContainer5.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.OutputsToProgram);
            this.splitContainer5.Panel2.Controls.Add(this.label46);
            this.splitContainer5.Panel2.Controls.Add(this.Btn_ChannelUpload);
            this.splitContainer5.Panel2.Controls.Add(this.Browse_FpgaBtn);
            this.splitContainer5.Panel2.Controls.Add(this.textBox3);
            this.splitContainer5.Panel2.Controls.Add(this.label45);
            this.splitContainer5.Panel2.Controls.Add(this.label44);
            this.splitContainer5.Panel2.Controls.Add(this.label26);
            this.splitContainer5.Panel2.Controls.Add(this.progressBar2);
            this.splitContainer5.Panel2.Controls.Add(this.label9);
            this.splitContainer5.Panel2.Controls.Add(this.label10);
            this.splitContainer5.Panel2.Controls.Add(this.label17);
            this.splitContainer5.Panel2.Controls.Add(this.label18);
            this.splitContainer5.Panel2.Controls.Add(this.label19);
            this.splitContainer5.Panel2.Controls.Add(this.label20);
            this.splitContainer5.Panel2.Controls.Add(this.label21);
            this.splitContainer5.Panel2.Controls.Add(this.label22);
            this.splitContainer5.Panel2.Controls.Add(this.label23);
            this.splitContainer5.Panel2.Controls.Add(this.label24);
            this.splitContainer5.Panel2.Controls.Add(this.label78);
            this.splitContainer5.Panel2.Controls.Add(this.label77);
            this.splitContainer5.Panel2.Controls.Add(this.label5);
            this.splitContainer5.Panel2.Controls.Add(this.label6);
            this.splitContainer5.Size = new System.Drawing.Size(724, 425);
            this.splitContainer5.SplitterDistance = 349;
            this.splitContainer5.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(39, 346);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(50, 13);
            this.label42.TabIndex = 10;
            this.label42.Text = "Log Path";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(69, 397);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 24);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSetSN
            // 
            this.btnSetSN.Location = new System.Drawing.Point(257, 273);
            this.btnSetSN.Name = "btnSetSN";
            this.btnSetSN.Size = new System.Drawing.Size(64, 38);
            this.btnSetSN.TabIndex = 8;
            this.btnSetSN.Text = "Set Serial Number";
            this.btnSetSN.UseVisualStyleBackColor = true;
            this.btnSetSN.Visible = false;
            this.btnSetSN.Click += new System.EventHandler(this.btnSetSN_Click);
            // 
            // tbSerial
            // 
            this.tbSerial.Location = new System.Drawing.Point(116, 273);
            this.tbSerial.MaxLength = 25;
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.ReadOnly = true;
            this.tbSerial.Size = new System.Drawing.Size(135, 20);
            this.tbSerial.TabIndex = 7;
            this.tbSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSerial_KeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(122, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 25);
            this.label25.TabIndex = 6;
            this.label25.Text = "Software";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 155);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(269, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Active File:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Server:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(206, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Size:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(41, 256);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(69, 13);
            this.label84.TabIndex = 4;
            this.label84.Text = "Part Number:";
            this.label84.Click += new System.EventHandler(this.label5_Click);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(118, 256);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(0, 13);
            this.label83.TabIndex = 4;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(41, 276);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(76, 13);
            this.label82.TabIndex = 4;
            this.label82.Text = "Serial Number:";
            this.label82.Click += new System.EventHandler(this.label5_Click);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(170, 74);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(33, 13);
            this.label80.TabIndex = 4;
            this.label80.Text = "Date:";
            this.label80.Click += new System.EventHandler(this.label5_Click);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(206, 74);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(0, 13);
            this.label79.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sofware Version:";
            // 
            // OutputsToProgram
            // 
            this.OutputsToProgram.ColumnWidth = 70;
            this.OutputsToProgram.FormattingEnabled = true;
            this.OutputsToProgram.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.OutputsToProgram.Location = new System.Drawing.Point(80, 321);
            this.OutputsToProgram.MultiColumn = true;
            this.OutputsToProgram.Name = "OutputsToProgram";
            this.OutputsToProgram.Size = new System.Drawing.Size(159, 49);
            this.OutputsToProgram.TabIndex = 23;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(153, 305);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(44, 13);
            this.label46.TabIndex = 22;
            this.label46.Text = "Outputs";
            // 
            // Btn_ChannelUpload
            // 
            this.Btn_ChannelUpload.Location = new System.Drawing.Point(155, 394);
            this.Btn_ChannelUpload.Name = "Btn_ChannelUpload";
            this.Btn_ChannelUpload.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChannelUpload.TabIndex = 21;
            this.Btn_ChannelUpload.Text = "Upload";
            this.Btn_ChannelUpload.UseVisualStyleBackColor = true;
            this.Btn_ChannelUpload.Click += new System.EventHandler(this.Btn_ChannelUpload_Click);
            // 
            // Browse_FpgaBtn
            // 
            this.Browse_FpgaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse_FpgaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_FpgaBtn.Location = new System.Drawing.Point(242, 373);
            this.Browse_FpgaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.Browse_FpgaBtn.Name = "Browse_FpgaBtn";
            this.Browse_FpgaBtn.Size = new System.Drawing.Size(27, 18);
            this.Browse_FpgaBtn.TabIndex = 20;
            this.Browse_FpgaBtn.Text = "---";
            this.Browse_FpgaBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Browse_FpgaBtn.UseVisualStyleBackColor = true;
            this.Browse_FpgaBtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 371);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(72, 264);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(214, 25);
            this.label45.TabIndex = 18;
            this.label45.Text = "Channels Firmware";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(9, 374);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 13);
            this.label44.TabIndex = 17;
            this.label44.Text = "Program File:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(120, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 25);
            this.label26.TabIndex = 6;
            this.label26.Text = "Firmware";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(33, 155);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(269, 24);
            this.progressBar2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Status:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(88, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Active File:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(74, 192);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 192);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Server:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(93, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 214);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "File Name:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(74, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 13);
            this.label23.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(232, 130);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "Size:";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(178, 74);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(33, 13);
            this.label78.TabIndex = 4;
            this.label78.Text = "Date:";
            this.label78.Click += new System.EventHandler(this.label5_Click);
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(214, 74);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(0, 13);
            this.label77.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Firmware Version:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 4;
            // 
            // tpDHCP
            // 
            this.tpDHCP.Controls.Add(this.dgvDHCPLease);
            this.tpDHCP.Controls.Add(this.lbDHCPTrace);
            this.tpDHCP.Location = new System.Drawing.Point(4, 22);
            this.tpDHCP.Name = "tpDHCP";
            this.tpDHCP.Padding = new System.Windows.Forms.Padding(3);
            this.tpDHCP.Size = new System.Drawing.Size(730, 431);
            this.tpDHCP.TabIndex = 1;
            this.tpDHCP.Text = "DHCP";
            this.tpDHCP.UseVisualStyleBackColor = true;
            // 
            // dgvDHCPLease
            // 
            this.dgvDHCPLease.AllowUserToAddRows = false;
            this.dgvDHCPLease.AllowUserToDeleteRows = false;
            this.dgvDHCPLease.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDHCPLease.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDHCPLease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDHCPLease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_clSesionID,
            this.dgv_clMAC,
            this.dgv_clIP,
            this.dgv_clLeaseExpr,
            this.dgv_clAck});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDHCPLease.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDHCPLease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDHCPLease.Location = new System.Drawing.Point(3, 59);
            this.dgvDHCPLease.Name = "dgvDHCPLease";
            this.dgvDHCPLease.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDHCPLease.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDHCPLease.RowHeadersWidth = 62;
            this.dgvDHCPLease.Size = new System.Drawing.Size(724, 369);
            this.dgvDHCPLease.TabIndex = 1;
            // 
            // dgv_clSesionID
            // 
            this.dgv_clSesionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_clSesionID.DataPropertyName = "SesionID";
            this.dgv_clSesionID.HeaderText = "Sesion ID";
            this.dgv_clSesionID.MinimumWidth = 8;
            this.dgv_clSesionID.Name = "dgv_clSesionID";
            this.dgv_clSesionID.ReadOnly = true;
            this.dgv_clSesionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_clMAC
            // 
            this.dgv_clMAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_clMAC.DataPropertyName = "MAC";
            this.dgv_clMAC.HeaderText = "MAC";
            this.dgv_clMAC.MinimumWidth = 8;
            this.dgv_clMAC.Name = "dgv_clMAC";
            this.dgv_clMAC.ReadOnly = true;
            this.dgv_clMAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_clIP
            // 
            this.dgv_clIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_clIP.DataPropertyName = "IP";
            this.dgv_clIP.HeaderText = "IP";
            this.dgv_clIP.MinimumWidth = 8;
            this.dgv_clIP.Name = "dgv_clIP";
            this.dgv_clIP.ReadOnly = true;
            this.dgv_clIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_clLeaseExpr
            // 
            this.dgv_clLeaseExpr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_clLeaseExpr.DataPropertyName = "Exp";
            this.dgv_clLeaseExpr.HeaderText = "Lease Experation";
            this.dgv_clLeaseExpr.MinimumWidth = 8;
            this.dgv_clLeaseExpr.Name = "dgv_clLeaseExpr";
            this.dgv_clLeaseExpr.ReadOnly = true;
            this.dgv_clLeaseExpr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_clAck
            // 
            this.dgv_clAck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgv_clAck.DataPropertyName = "ACK";
            this.dgv_clAck.FalseValue = "0";
            this.dgv_clAck.HeaderText = "ACK";
            this.dgv_clAck.IndeterminateValue = "2";
            this.dgv_clAck.MinimumWidth = 8;
            this.dgv_clAck.Name = "dgv_clAck";
            this.dgv_clAck.ReadOnly = true;
            this.dgv_clAck.TrueValue = "1";
            this.dgv_clAck.Width = 34;
            // 
            // lbDHCPTrace
            // 
            this.lbDHCPTrace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDHCPTrace.FormattingEnabled = true;
            this.lbDHCPTrace.Location = new System.Drawing.Point(3, 3);
            this.lbDHCPTrace.Name = "lbDHCPTrace";
            this.lbDHCPTrace.ScrollAlwaysVisible = true;
            this.lbDHCPTrace.Size = new System.Drawing.Size(724, 56);
            this.lbDHCPTrace.TabIndex = 0;
            // 
            // dgPDUs
            // 
            this.dgPDUs.AllowUserToAddRows = false;
            this.dgPDUs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPDUs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgPDUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPDUs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbActive,
            this.tbName,
            this.tbIP,
            this.Status});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPDUs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgPDUs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPDUs.Location = new System.Drawing.Point(0, 0);
            this.dgPDUs.MultiSelect = false;
            this.dgPDUs.Name = "dgPDUs";
            this.dgPDUs.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPDUs.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgPDUs.RowHeadersVisible = false;
            this.dgPDUs.RowHeadersWidth = 62;
            this.dgPDUs.Size = new System.Drawing.Size(173, 457);
            this.dgPDUs.TabIndex = 0;
            this.dgPDUs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cbActive
            // 
            this.cbActive.HeaderText = "Active";
            this.cbActive.MinimumWidth = 8;
            this.cbActive.Name = "cbActive";
            this.cbActive.ReadOnly = true;
            this.cbActive.Width = 40;
            // 
            // tbName
            // 
            this.tbName.HeaderText = "Name";
            this.tbName.MinimumWidth = 8;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Width = 150;
            // 
            // tbIP
            // 
            this.tbIP.HeaderText = "IP";
            this.tbIP.MinimumWidth = 8;
            this.tbIP.Name = "tbIP";
            this.tbIP.ReadOnly = true;
            this.tbIP.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "tbStatus";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem1});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem7});
            this.menuItem2.Text = "File";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem3});
            this.menuItem6.Text = "Software";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Prepare and Check Sofware File ";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Start Software Update";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem5});
            this.menuItem7.Text = "Firmware";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "Prepare and Check Firmware File ";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Start Firmware Update";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.tsmiStart});
            this.menuItem1.Text = "DHCP";
            // 
            // tsmiStart
            // 
            this.tsmiStart.Index = 0;
            this.tsmiStart.Text = "Start";
            this.tsmiStart.Click += new System.EventHandler(this.tsmiStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Binary file|*.bin";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Binary file|*.bin";
            // 
            // tmrFirmware
            // 
            this.tmrFirmware.Interval = 500;
            this.tmrFirmware.Tick += new System.EventHandler(this.tmrFirmware_Tick);
            // 
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 1000;
            this.Updater.Tick += new System.EventHandler(this.Updater_Tick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "JED File |*.jed";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "JED File |*.jed";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgPDUs);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl);
            this.splitContainer3.Size = new System.Drawing.Size(915, 457);
            this.splitContainer3.SplitterDistance = 173;
            this.splitContainer3.TabIndex = 2;
            // 
            // tmrGetStatus
            // 
            this.tmrGetStatus.Enabled = true;
            this.tmrGetStatus.Interval = 50;
            this.tmrGetStatus.Tick += new System.EventHandler(this.tmrGetStatus_Tick);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "JED File |*.jed";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(915, 457);
            this.Controls.Add(this.splitContainer3);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(683, 496);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tpConfig.ResumeLayout(false);
            this.tpConfig.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimits)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbConfigStatic.ResumeLayout(false);
            this.gbConfigStatic.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tpUpdate.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tpDHCP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDHCPLease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPDUs)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpDHCP;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem tsmiStart;
        private System.Windows.Forms.TabPage tpControl;
        private System.Windows.Forms.ListBox lbDHCPTrace;
        private System.Windows.Forms.DataGridView dgvDHCPLease;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clSesionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clMAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clLeaseExpr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_clAck;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer tmrFirmware;
        private System.Windows.Forms.Timer Updater;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button btnSetSN;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Data.Led led1;
        private System.Windows.Forms.DataGridView dgPDUs;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private OUTPUT sspc1;
        private OUTPUT output1;
        private OUTPUT output2;
        private OUTPUT output3;
        private OUTPUT output4;
        private OUTPUT output5;
        private OUTPUT output6;
        private OUTPUT output7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblInVolt;
        private System.Windows.Forms.Label lblInCurr;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Timer tmrGetStatus;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbConfigStatic;
        private System.Windows.Forms.RadioButton rbConfigDynamic;
        private System.Windows.Forms.RadioButton rbConfigStatic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private IPAddressControlLib.IPAddressControl iacSelectedMac;
        private IPAddressControlLib.IPAddressControl iacSelectedIp;
        private System.Windows.Forms.DataGridView dgvLimits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbPorDelay;
        private System.Windows.Forms.TextBox tbPorChans;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private GROUP group1;
        private GROUP group2;
        private GROUP group3;
        private GROUP group4;
        private GROUP group5;
        private GROUP group6;
        private GROUP group7;
        private GROUP group8;
        private System.Windows.Forms.Button btnSetGroup;
        private System.Windows.Forms.CheckedListBox clbOutputs;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridViewButtonColumn clUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOverload;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCurrentLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTherm;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnDci;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbDciDelay;
        private System.Windows.Forms.TextBox tbDciChan;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tbDciOper;
        private System.Windows.Forms.Button btnGroupLimits;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox tbGroupTherm;
        private System.Windows.Forms.TextBox tbGroupSC;
        private System.Windows.Forms.TextBox tbGroupOL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label42;
        private IPAddressControlLib.IPAddressControl iacSelectedGw;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button Browse_FpgaBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Btn_ChannelUpload;
        private System.Windows.Forms.CheckedListBox OutputsToProgram;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}

