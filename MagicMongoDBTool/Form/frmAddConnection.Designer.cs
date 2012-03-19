﻿using System.Windows.Forms;
namespace MagicMongoDBTool
{
    partial class frmAddConnection
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
            this.lblReplsetName = new System.Windows.Forms.Label();
            this.radRouteSrv = new System.Windows.Forms.RadioButton();
            this.radConfigSrv = new System.Windows.Forms.RadioButton();
            this.radDataSrv = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblConnectionName = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtReplSetName = new System.Windows.Forms.TextBox();
            this.lblDataBaseName = new System.Windows.Forms.Label();
            this.txtDataBaseName = new System.Windows.Forms.TextBox();
            this.lstServerce = new System.Windows.Forms.ListBox();
            this.lblReplsetList = new System.Windows.Forms.Label();
            this.grpReplset = new System.Windows.Forms.GroupBox();
            this.cmdInitReplset = new System.Windows.Forms.Button();
            this.grpServerRole = new System.Windows.Forms.GroupBox();
            this.radMaster = new System.Windows.Forms.RadioButton();
            this.radSlave = new System.Windows.Forms.RadioButton();
            this.radArbiters = new System.Windows.Forms.RadioButton();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.tabConnection = new System.Windows.Forms.TabControl();
            this.tabBasicInfo = new System.Windows.Forms.TabPage();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.lblAttentionPassword = new System.Windows.Forms.Label();
            this.chkSlaveOk = new System.Windows.Forms.CheckBox();
            this.numTimeOut = new System.Windows.Forms.NumericUpDown();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.chkSafeMode = new System.Windows.Forms.CheckBox();
            this.Replset = new System.Windows.Forms.TabPage();
            this.lblAttentionPriority = new System.Windows.Forms.Label();
            this.lblMainReplsetName = new System.Windows.Forms.Label();
            this.numPriority = new System.Windows.Forms.NumericUpDown();
            this.lblpriority = new System.Windows.Forms.Label();
            this.txtMainReplsetName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmdTest = new System.Windows.Forms.Button();
            this.grpReplset.SuspendLayout();
            this.grpServerRole.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tabBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOut)).BeginInit();
            this.Replset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReplsetName
            // 
            this.lblReplsetName.AutoSize = true;
            this.lblReplsetName.BackColor = System.Drawing.Color.Transparent;
            this.lblReplsetName.Location = new System.Drawing.Point(17, 33);
            this.lblReplsetName.Name = "lblReplsetName";
            this.lblReplsetName.Size = new System.Drawing.Size(83, 15);
            this.lblReplsetName.TabIndex = 0;
            this.lblReplsetName.Text = "ReplsetName";
            // 
            // radRouteSrv
            // 
            this.radRouteSrv.AutoSize = true;
            this.radRouteSrv.BackColor = System.Drawing.Color.Transparent;
            this.radRouteSrv.Location = new System.Drawing.Point(132, 61);
            this.radRouteSrv.Name = "radRouteSrv";
            this.radRouteSrv.Size = new System.Drawing.Size(96, 19);
            this.radRouteSrv.TabIndex = 2;
            this.radRouteSrv.Text = "Route Server";
            this.radRouteSrv.UseVisualStyleBackColor = false;
            // 
            // radConfigSrv
            // 
            this.radConfigSrv.AutoSize = true;
            this.radConfigSrv.BackColor = System.Drawing.Color.Transparent;
            this.radConfigSrv.Location = new System.Drawing.Point(23, 62);
            this.radConfigSrv.Name = "radConfigSrv";
            this.radConfigSrv.Size = new System.Drawing.Size(98, 19);
            this.radConfigSrv.TabIndex = 1;
            this.radConfigSrv.Text = "Config Server";
            this.radConfigSrv.UseVisualStyleBackColor = false;
            // 
            // radDataSrv
            // 
            this.radDataSrv.AutoSize = true;
            this.radDataSrv.BackColor = System.Drawing.Color.Transparent;
            this.radDataSrv.Checked = true;
            this.radDataSrv.Location = new System.Drawing.Point(23, 25);
            this.radDataSrv.Name = "radDataSrv";
            this.radDataSrv.Size = new System.Drawing.Size(104, 19);
            this.radDataSrv.TabIndex = 0;
            this.radDataSrv.TabStop = true;
            this.radDataSrv.Text = "Normal Server";
            this.radDataSrv.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Transparent;
            this.cmdCancel.Location = new System.Drawing.Point(481, 338);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(98, 31);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.Transparent;
            this.cmdAdd.Location = new System.Drawing.Point(184, 338);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(98, 31);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(244, 57);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(38, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 15);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "UserName";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.Location = new System.Drawing.Point(439, 31);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 15);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            // 
            // lblConnectionName
            // 
            this.lblConnectionName.AutoSize = true;
            this.lblConnectionName.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectionName.Location = new System.Drawing.Point(41, 32);
            this.lblConnectionName.Name = "lblConnectionName";
            this.lblConnectionName.Size = new System.Drawing.Size(69, 15);
            this.lblConnectionName.TabIndex = 0;
            this.lblConnectionName.Text = "Connection";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.BackColor = System.Drawing.Color.Transparent;
            this.lblHost.Location = new System.Drawing.Point(244, 27);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 15);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Host";
            // 
            // txtConnectionName
            // 
            this.txtConnectionName.Location = new System.Drawing.Point(118, 22);
            this.txtConnectionName.Name = "txtConnectionName";
            this.txtConnectionName.Size = new System.Drawing.Size(119, 21);
            this.txtConnectionName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(310, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(119, 21);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(119, 21);
            this.txtUsername.TabIndex = 7;
            // 
            // txtHost
            // 
            this.txtHost.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHost.Location = new System.Drawing.Point(311, 22);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(119, 21);
            this.txtHost.TabIndex = 3;
            // 
            // txtReplSetName
            // 
            this.txtReplSetName.Location = new System.Drawing.Point(135, 22);
            this.txtReplSetName.Name = "txtReplSetName";
            this.txtReplSetName.Size = new System.Drawing.Size(178, 21);
            this.txtReplSetName.TabIndex = 1;
            this.txtReplSetName.TextChanged += new System.EventHandler(this.txtReplSetName_TextChanged);
            // 
            // lblDataBaseName
            // 
            this.lblDataBaseName.AutoSize = true;
            this.lblDataBaseName.Location = new System.Drawing.Point(439, 60);
            this.lblDataBaseName.Name = "lblDataBaseName";
            this.lblDataBaseName.Size = new System.Drawing.Size(60, 15);
            this.lblDataBaseName.TabIndex = 10;
            this.lblDataBaseName.Text = "Database";
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.Location = new System.Drawing.Point(518, 50);
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.Size = new System.Drawing.Size(119, 21);
            this.txtDataBaseName.TabIndex = 11;
            // 
            // lstServerce
            // 
            this.lstServerce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstServerce.FormattingEnabled = true;
            this.lstServerce.ItemHeight = 16;
            this.lstServerce.Location = new System.Drawing.Point(136, 62);
            this.lstServerce.Name = "lstServerce";
            this.lstServerce.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstServerce.Size = new System.Drawing.Size(481, 84);
            this.lstServerce.TabIndex = 4;
            // 
            // lblReplsetList
            // 
            this.lblReplsetList.AutoSize = true;
            this.lblReplsetList.BackColor = System.Drawing.Color.Transparent;
            this.lblReplsetList.Location = new System.Drawing.Point(16, 65);
            this.lblReplsetList.Name = "lblReplsetList";
            this.lblReplsetList.Size = new System.Drawing.Size(64, 15);
            this.lblReplsetList.TabIndex = 3;
            this.lblReplsetList.Text = "Server List";
            // 
            // grpReplset
            // 
            this.grpReplset.BackColor = System.Drawing.Color.Transparent;
            this.grpReplset.Controls.Add(this.lstServerce);
            this.grpReplset.Controls.Add(this.cmdInitReplset);
            this.grpReplset.Controls.Add(this.txtReplSetName);
            this.grpReplset.Controls.Add(this.lblReplsetName);
            this.grpReplset.Controls.Add(this.lblReplsetList);
            this.grpReplset.Location = new System.Drawing.Point(20, 66);
            this.grpReplset.Name = "grpReplset";
            this.grpReplset.Size = new System.Drawing.Size(635, 186);
            this.grpReplset.TabIndex = 4;
            this.grpReplset.TabStop = false;
            this.grpReplset.Text = "Replset Config";
            // 
            // cmdInitReplset
            // 
            this.cmdInitReplset.BackColor = System.Drawing.Color.Transparent;
            this.cmdInitReplset.Location = new System.Drawing.Point(335, 16);
            this.cmdInitReplset.Name = "cmdInitReplset";
            this.cmdInitReplset.Size = new System.Drawing.Size(119, 32);
            this.cmdInitReplset.TabIndex = 2;
            this.cmdInitReplset.Text = "Init Replset";
            this.cmdInitReplset.UseVisualStyleBackColor = false;
            this.cmdInitReplset.Click += new System.EventHandler(this.cmdInitReplset_Click);
            // 
            // grpServerRole
            // 
            this.grpServerRole.BackColor = System.Drawing.Color.Transparent;
            this.grpServerRole.Controls.Add(this.radMaster);
            this.grpServerRole.Controls.Add(this.radSlave);
            this.grpServerRole.Controls.Add(this.radArbiters);
            this.grpServerRole.Controls.Add(this.radDataSrv);
            this.grpServerRole.Controls.Add(this.radConfigSrv);
            this.grpServerRole.Controls.Add(this.radRouteSrv);
            this.grpServerRole.Location = new System.Drawing.Point(27, 22);
            this.grpServerRole.Name = "grpServerRole";
            this.grpServerRole.Size = new System.Drawing.Size(636, 164);
            this.grpServerRole.TabIndex = 0;
            this.grpServerRole.TabStop = false;
            this.grpServerRole.Text = "Server Role";
            // 
            // radMaster
            // 
            this.radMaster.AutoSize = true;
            this.radMaster.Location = new System.Drawing.Point(23, 99);
            this.radMaster.Name = "radMaster";
            this.radMaster.Size = new System.Drawing.Size(63, 19);
            this.radMaster.TabIndex = 4;
            this.radMaster.TabStop = true;
            this.radMaster.Text = "Master";
            this.radMaster.UseVisualStyleBackColor = true;
            // 
            // radSlave
            // 
            this.radSlave.AutoSize = true;
            this.radSlave.Location = new System.Drawing.Point(132, 99);
            this.radSlave.Name = "radSlave";
            this.radSlave.Size = new System.Drawing.Size(55, 19);
            this.radSlave.TabIndex = 5;
            this.radSlave.TabStop = true;
            this.radSlave.Text = "Slave";
            this.radSlave.UseVisualStyleBackColor = true;
            // 
            // radArbiters
            // 
            this.radArbiters.AutoSize = true;
            this.radArbiters.Location = new System.Drawing.Point(243, 61);
            this.radArbiters.Name = "radArbiters";
            this.radArbiters.Size = new System.Drawing.Size(104, 19);
            this.radArbiters.TabIndex = 3;
            this.radArbiters.TabStop = true;
            this.radArbiters.Text = "Arbiters Server";
            this.radArbiters.UseVisualStyleBackColor = true;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(44, 144);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(600, 69);
            this.txtConnectionString.TabIndex = 17;
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(41, 126);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(172, 15);
            this.lblConnectionString.TabIndex = 16;
            this.lblConnectionString.Text = "Use ConnectionString Directly:";
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.tabBasicInfo);
            this.tabConnection.Controls.Add(this.Replset);
            this.tabConnection.Controls.Add(this.tabPage3);
            this.tabConnection.Location = new System.Drawing.Point(12, 8);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.SelectedIndex = 0;
            this.tabConnection.Size = new System.Drawing.Size(699, 324);
            this.tabConnection.TabIndex = 0;
            // 
            // tabBasicInfo
            // 
            this.tabBasicInfo.Controls.Add(this.numPort);
            this.tabBasicInfo.Controls.Add(this.lblAttentionPassword);
            this.tabBasicInfo.Controls.Add(this.chkSlaveOk);
            this.tabBasicInfo.Controls.Add(this.numTimeOut);
            this.tabBasicInfo.Controls.Add(this.lblTimeOut);
            this.tabBasicInfo.Controls.Add(this.chkSafeMode);
            this.tabBasicInfo.Controls.Add(this.lblConnectionString);
            this.tabBasicInfo.Controls.Add(this.txtConnectionString);
            this.tabBasicInfo.Controls.Add(this.lblConnectionName);
            this.tabBasicInfo.Controls.Add(this.lblPort);
            this.tabBasicInfo.Controls.Add(this.lblUsername);
            this.tabBasicInfo.Controls.Add(this.lblPassword);
            this.tabBasicInfo.Controls.Add(this.lblHost);
            this.tabBasicInfo.Controls.Add(this.txtConnectionName);
            this.tabBasicInfo.Controls.Add(this.txtPassword);
            this.tabBasicInfo.Controls.Add(this.txtUsername);
            this.tabBasicInfo.Controls.Add(this.txtHost);
            this.tabBasicInfo.Controls.Add(this.lblDataBaseName);
            this.tabBasicInfo.Controls.Add(this.txtDataBaseName);
            this.tabBasicInfo.Location = new System.Drawing.Point(4, 24);
            this.tabBasicInfo.Name = "tabBasicInfo";
            this.tabBasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicInfo.Size = new System.Drawing.Size(691, 296);
            this.tabBasicInfo.TabIndex = 0;
            this.tabBasicInfo.Text = "BasicInfo";
            this.tabBasicInfo.UseVisualStyleBackColor = true;
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(518, 21);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(118, 21);
            this.numPort.TabIndex = 5;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAttentionPassword
            // 
            this.lblAttentionPassword.AutoSize = true;
            this.lblAttentionPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttentionPassword.ForeColor = System.Drawing.Color.Red;
            this.lblAttentionPassword.Location = new System.Drawing.Point(41, 237);
            this.lblAttentionPassword.Name = "lblAttentionPassword";
            this.lblAttentionPassword.Size = new System.Drawing.Size(295, 13);
            this.lblAttentionPassword.TabIndex = 18;
            this.lblAttentionPassword.Text = "Password is saved in config file without Encryption";
            // 
            // chkSlaveOk
            // 
            this.chkSlaveOk.AutoSize = true;
            this.chkSlaveOk.BackColor = System.Drawing.Color.Transparent;
            this.chkSlaveOk.Location = new System.Drawing.Point(139, 92);
            this.chkSlaveOk.Name = "chkSlaveOk";
            this.chkSlaveOk.Size = new System.Drawing.Size(73, 19);
            this.chkSlaveOk.TabIndex = 13;
            this.chkSlaveOk.Text = "SlaveOK";
            this.chkSlaveOk.UseVisualStyleBackColor = false;
            // 
            // numTimeOut
            // 
            this.numTimeOut.Location = new System.Drawing.Point(379, 87);
            this.numTimeOut.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numTimeOut.Name = "numTimeOut";
            this.numTimeOut.Size = new System.Drawing.Size(120, 21);
            this.numTimeOut.TabIndex = 15;
            this.numTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTimeOut.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(244, 93);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(120, 15);
            this.lblTimeOut.TabIndex = 14;
            this.lblTimeOut.Text = "SocketTimeOut(Sec)";
            // 
            // chkSafeMode
            // 
            this.chkSafeMode.AutoSize = true;
            this.chkSafeMode.Location = new System.Drawing.Point(44, 92);
            this.chkSafeMode.Name = "chkSafeMode";
            this.chkSafeMode.Size = new System.Drawing.Size(83, 19);
            this.chkSafeMode.TabIndex = 12;
            this.chkSafeMode.Text = "SafeMode";
            this.chkSafeMode.UseVisualStyleBackColor = true;
            // 
            // Replset
            // 
            this.Replset.Controls.Add(this.lblAttentionPriority);
            this.Replset.Controls.Add(this.lblMainReplsetName);
            this.Replset.Controls.Add(this.numPriority);
            this.Replset.Controls.Add(this.lblpriority);
            this.Replset.Controls.Add(this.txtMainReplsetName);
            this.Replset.Controls.Add(this.grpReplset);
            this.Replset.Location = new System.Drawing.Point(4, 24);
            this.Replset.Name = "Replset";
            this.Replset.Padding = new System.Windows.Forms.Padding(3);
            this.Replset.Size = new System.Drawing.Size(691, 296);
            this.Replset.TabIndex = 1;
            this.Replset.Text = "Replset";
            this.Replset.UseVisualStyleBackColor = true;
            // 
            // lblAttentionPriority
            // 
            this.lblAttentionPriority.AutoSize = true;
            this.lblAttentionPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttentionPriority.ForeColor = System.Drawing.Color.Red;
            this.lblAttentionPriority.Location = new System.Drawing.Point(23, 261);
            this.lblAttentionPriority.Name = "lblAttentionPriority";
            this.lblAttentionPriority.Size = new System.Drawing.Size(303, 13);
            this.lblAttentionPriority.TabIndex = 5;
            this.lblAttentionPriority.Text = "If Priority is 0,then it can\'t be the ReplaceSet server";
            // 
            // lblMainReplsetName
            // 
            this.lblMainReplsetName.AutoSize = true;
            this.lblMainReplsetName.Location = new System.Drawing.Point(23, 36);
            this.lblMainReplsetName.Name = "lblMainReplsetName";
            this.lblMainReplsetName.Size = new System.Drawing.Size(83, 15);
            this.lblMainReplsetName.TabIndex = 0;
            this.lblMainReplsetName.Text = "ReplsetName";
            // 
            // numPriority
            // 
            this.numPriority.Location = new System.Drawing.Point(355, 31);
            this.numPriority.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(120, 21);
            this.numPriority.TabIndex = 3;
            this.numPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblpriority
            // 
            this.lblpriority.AutoSize = true;
            this.lblpriority.Location = new System.Drawing.Point(294, 36);
            this.lblpriority.Name = "lblpriority";
            this.lblpriority.Size = new System.Drawing.Size(43, 15);
            this.lblpriority.TabIndex = 2;
            this.lblpriority.Text = "priority";
            // 
            // txtMainReplsetName
            // 
            this.txtMainReplsetName.Location = new System.Drawing.Point(113, 32);
            this.txtMainReplsetName.Name = "txtMainReplsetName";
            this.txtMainReplsetName.Size = new System.Drawing.Size(149, 21);
            this.txtMainReplsetName.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpServerRole);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(691, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ServerRole";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(330, 338);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(98, 31);
            this.cmdTest.TabIndex = 3;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // frmAddConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 379);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.tabConnection);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Connection";
            this.grpReplset.ResumeLayout(false);
            this.grpReplset.PerformLayout();
            this.grpServerRole.ResumeLayout(false);
            this.grpServerRole.PerformLayout();
            this.tabConnection.ResumeLayout(false);
            this.tabBasicInfo.ResumeLayout(false);
            this.tabBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOut)).EndInit();
            this.Replset.ResumeLayout(false);
            this.Replset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Label lblReplsetName;
        private System.Windows.Forms.RadioButton radRouteSrv;
        private System.Windows.Forms.RadioButton radConfigSrv;
        private System.Windows.Forms.RadioButton radDataSrv;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblConnectionName;
        private System.Windows.Forms.Label lblHost;
        private TextBox txtConnectionName;
        private TextBox txtHost;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtReplSetName;
        private TextBox txtDataBaseName;
        private System.Windows.Forms.Label lblDataBaseName;
        private System.Windows.Forms.Label lblReplsetList;
        private System.Windows.Forms.ListBox lstServerce;
        private System.Windows.Forms.GroupBox grpServerRole;
        private System.Windows.Forms.GroupBox grpReplset;
        private System.Windows.Forms.RadioButton radArbiters;
        private System.Windows.Forms.Button cmdInitReplset;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TabControl tabConnection;
        private System.Windows.Forms.TabPage tabBasicInfo;
        private System.Windows.Forms.CheckBox chkSafeMode;
        private System.Windows.Forms.TabPage Replset;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numTimeOut;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.Label lblMainReplsetName;
        private System.Windows.Forms.NumericUpDown numPriority;
        private System.Windows.Forms.Label lblpriority;
        private TextBox txtMainReplsetName;
        private System.Windows.Forms.CheckBox chkSlaveOk;
        private System.Windows.Forms.RadioButton radMaster;
        private System.Windows.Forms.RadioButton radSlave;
        private Label lblAttentionPassword;
        private Label lblAttentionPriority;
        private NumericUpDown numPort;
        private Button cmdTest;
    }
}