namespace OmroLink
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpPlcComm = new GroupBox();
            plcBtnDisconnect = new Button();
            plcBtnConnect = new Button();
            txtPort = new TextBox();
            label5 = new Label();
            txtIP = new TextBox();
            label4 = new Label();
            label3 = new Label();
            protocolList = new ComboBox();
            label2 = new Label();
            plcList = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rdoTCP = new RadioButton();
            rdoUDP = new RadioButton();
            groupBox3 = new GroupBox();
            rdoASCII = new RadioButton();
            rdoBIN = new RadioButton();
            grpStatus = new GroupBox();
            plcStatus = new Label();
            grpRead = new GroupBox();
            btnStopRead = new Button();
            btnReadPulse = new Button();
            btnRead = new Button();
            label8 = new Label();
            txtSizeRead = new TextBox();
            label6 = new Label();
            txtReadDeviceAddress = new TextBox();
            grpWrite = new GroupBox();
            txtDataToWrite = new TextBox();
            label10 = new Label();
            txtWriteDeviceAddress = new TextBox();
            label9 = new Label();
            btnStartWrite = new Button();
            txtSizeWrite = new TextBox();
            label7 = new Label();
            grpReadRslt = new GroupBox();
            txtReadResult = new TextBox();
            grpPlcComm.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            grpStatus.SuspendLayout();
            grpRead.SuspendLayout();
            grpWrite.SuspendLayout();
            grpReadRslt.SuspendLayout();
            SuspendLayout();
            // 
            // grpPlcComm
            // 
            grpPlcComm.Controls.Add(plcBtnDisconnect);
            grpPlcComm.Controls.Add(plcBtnConnect);
            grpPlcComm.Controls.Add(txtPort);
            grpPlcComm.Controls.Add(label5);
            grpPlcComm.Controls.Add(txtIP);
            grpPlcComm.Controls.Add(label4);
            grpPlcComm.Controls.Add(label3);
            grpPlcComm.Controls.Add(protocolList);
            grpPlcComm.Controls.Add(label2);
            grpPlcComm.Controls.Add(plcList);
            grpPlcComm.Controls.Add(label1);
            grpPlcComm.Controls.Add(groupBox2);
            grpPlcComm.Controls.Add(groupBox3);
            grpPlcComm.Location = new Point(6, 6);
            grpPlcComm.Margin = new Padding(2, 1, 2, 1);
            grpPlcComm.Name = "grpPlcComm";
            grpPlcComm.Padding = new Padding(2, 1, 2, 1);
            grpPlcComm.Size = new Size(260, 249);
            grpPlcComm.TabIndex = 0;
            grpPlcComm.TabStop = false;
            grpPlcComm.Text = "PLC Connection Setup";
            // 
            // plcBtnDisconnect
            // 
            plcBtnDisconnect.Enabled = false;
            plcBtnDisconnect.Location = new Point(148, 201);
            plcBtnDisconnect.Margin = new Padding(2, 1, 2, 1);
            plcBtnDisconnect.Name = "plcBtnDisconnect";
            plcBtnDisconnect.Size = new Size(81, 22);
            plcBtnDisconnect.TabIndex = 13;
            plcBtnDisconnect.Text = "Disconnect";
            plcBtnDisconnect.UseVisualStyleBackColor = true;
            plcBtnDisconnect.Click += plcBtnDisconnect_Click;
            // 
            // plcBtnConnect
            // 
            plcBtnConnect.Location = new Point(31, 201);
            plcBtnConnect.Margin = new Padding(2, 1, 2, 1);
            plcBtnConnect.Name = "plcBtnConnect";
            plcBtnConnect.Size = new Size(81, 22);
            plcBtnConnect.TabIndex = 12;
            plcBtnConnect.Text = "Connect";
            plcBtnConnect.UseVisualStyleBackColor = true;
            plcBtnConnect.Click += PlcBtnConnect_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(92, 159);
            txtPort.Margin = new Padding(2, 1, 2, 1);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(56, 23);
            txtPort.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 161);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 10;
            label5.Text = "Port";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(93, 131);
            txtIP.Margin = new Padding(2, 1, 2, 1);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(110, 23);
            txtIP.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 132);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "IP Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Data Type";
            // 
            // protocolList
            // 
            protocolList.DropDownStyle = ComboBoxStyle.DropDownList;
            protocolList.FormattingEnabled = true;
            protocolList.Items.AddRange(new object[] { "MC Protocol", "Fins Protocol" });
            protocolList.Location = new Point(93, 59);
            protocolList.Margin = new Padding(2, 1, 2, 1);
            protocolList.Name = "protocolList";
            protocolList.Size = new Size(132, 23);
            protocolList.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Protocol";
            // 
            // plcList
            // 
            plcList.DropDownStyle = ComboBoxStyle.DropDownList;
            plcList.FormattingEnabled = true;
            plcList.Items.AddRange(new object[] { "MITSUBISHI", "OMRON", "KEYENCE" });
            plcList.Location = new Point(93, 32);
            plcList.Margin = new Padding(2, 1, 2, 1);
            plcList.Name = "plcList";
            plcList.Size = new Size(132, 23);
            plcList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "PLC Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoTCP);
            groupBox2.Controls.Add(rdoUDP);
            groupBox2.Location = new Point(93, 73);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(130, 30);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // rdoTCP
            // 
            rdoTCP.AutoSize = true;
            rdoTCP.Location = new Point(4, 10);
            rdoTCP.Margin = new Padding(2, 1, 2, 1);
            rdoTCP.Name = "rdoTCP";
            rdoTCP.Size = new Size(46, 19);
            rdoTCP.TabIndex = 0;
            rdoTCP.TabStop = true;
            rdoTCP.Text = "TCP";
            rdoTCP.UseVisualStyleBackColor = true;
            // 
            // rdoUDP
            // 
            rdoUDP.AutoSize = true;
            rdoUDP.Location = new Point(54, 9);
            rdoUDP.Margin = new Padding(2, 1, 2, 1);
            rdoUDP.Name = "rdoUDP";
            rdoUDP.Size = new Size(48, 19);
            rdoUDP.TabIndex = 1;
            rdoUDP.TabStop = true;
            rdoUDP.Text = "UDP";
            rdoUDP.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdoASCII);
            groupBox3.Controls.Add(rdoBIN);
            groupBox3.Location = new Point(93, 97);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(130, 30);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // rdoASCII
            // 
            rdoASCII.AutoSize = true;
            rdoASCII.Location = new Point(53, 11);
            rdoASCII.Margin = new Padding(2, 1, 2, 1);
            rdoASCII.Name = "rdoASCII";
            rdoASCII.Size = new Size(53, 19);
            rdoASCII.TabIndex = 7;
            rdoASCII.TabStop = true;
            rdoASCII.Text = "ASCII";
            rdoASCII.UseVisualStyleBackColor = true;
            // 
            // rdoBIN
            // 
            rdoBIN.AutoSize = true;
            rdoBIN.Location = new Point(3, 11);
            rdoBIN.Margin = new Padding(2, 1, 2, 1);
            rdoBIN.Name = "rdoBIN";
            rdoBIN.Size = new Size(44, 19);
            rdoBIN.TabIndex = 6;
            rdoBIN.TabStop = true;
            rdoBIN.Text = "BIN";
            rdoBIN.UseVisualStyleBackColor = true;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(plcStatus);
            grpStatus.Location = new Point(541, 6);
            grpStatus.Margin = new Padding(2, 1, 2, 1);
            grpStatus.Name = "grpStatus";
            grpStatus.Padding = new Padding(2, 1, 2, 1);
            grpStatus.Size = new Size(156, 66);
            grpStatus.TabIndex = 1;
            grpStatus.TabStop = false;
            grpStatus.Text = "Communication Status";
            // 
            // plcStatus
            // 
            plcStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plcStatus.BackColor = SystemColors.AppWorkspace;
            plcStatus.Font = new Font("Segoe UI", 9F);
            plcStatus.ForeColor = SystemColors.ActiveCaptionText;
            plcStatus.Location = new Point(40, 25);
            plcStatus.Margin = new Padding(2, 0, 2, 0);
            plcStatus.MaximumSize = new Size(80, 24);
            plcStatus.MinimumSize = new Size(80, 24);
            plcStatus.Name = "plcStatus";
            plcStatus.Padding = new Padding(0, 0, 0, 1);
            plcStatus.Size = new Size(80, 24);
            plcStatus.TabIndex = 3;
            plcStatus.Text = "Setup";
            plcStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpRead
            // 
            grpRead.Controls.Add(btnStopRead);
            grpRead.Controls.Add(btnReadPulse);
            grpRead.Controls.Add(btnRead);
            grpRead.Controls.Add(label8);
            grpRead.Controls.Add(txtSizeRead);
            grpRead.Controls.Add(label6);
            grpRead.Controls.Add(txtReadDeviceAddress);
            grpRead.Location = new Point(272, 6);
            grpRead.Margin = new Padding(2, 1, 2, 1);
            grpRead.Name = "grpRead";
            grpRead.Padding = new Padding(2, 1, 2, 1);
            grpRead.Size = new Size(260, 120);
            grpRead.TabIndex = 14;
            grpRead.TabStop = false;
            grpRead.Text = "Read";
            grpRead.Enabled = false;
            // 
            // btnStopRead
            // 
            btnStopRead.Location = new Point(175, 87);
            btnStopRead.Margin = new Padding(2, 1, 2, 1);
            btnStopRead.Name = "btnStopRead";
            btnStopRead.Size = new Size(57, 22);
            btnStopRead.TabIndex = 20;
            btnStopRead.Text = "Stop";
            btnStopRead.UseVisualStyleBackColor = true;
            btnStopRead.Click += btnStopRead_Click;
            // 
            // btnReadPulse
            // 
            btnReadPulse.Location = new Point(95, 87);
            btnReadPulse.Margin = new Padding(2, 1, 2, 1);
            btnReadPulse.Name = "btnReadPulse";
            btnReadPulse.Size = new Size(67, 22);
            btnReadPulse.TabIndex = 19;
            btnReadPulse.Text = "Read(1s)";
            btnReadPulse.UseVisualStyleBackColor = true;
            btnReadPulse.Click += btnReadPulse_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(25, 87);
            btnRead.Margin = new Padding(2, 1, 2, 1);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(57, 22);
            btnRead.TabIndex = 16;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 53);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 17;
            label8.Text = "Size";
            // 
            // txtSizeRead
            // 
            txtSizeRead.Location = new Point(62, 48);
            txtSizeRead.Margin = new Padding(2, 1, 2, 1);
            txtSizeRead.Name = "txtSizeRead";
            txtSizeRead.Size = new Size(40, 23);
            txtSizeRead.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 16;
            label6.Text = "Address";
            // 
            // txtReadDeviceAddress
            // 
            txtReadDeviceAddress.Location = new Point(62, 18);
            txtReadDeviceAddress.Margin = new Padding(2, 1, 2, 1);
            txtReadDeviceAddress.Name = "txtReadDeviceAddress";
            txtReadDeviceAddress.Size = new Size(110, 23);
            txtReadDeviceAddress.TabIndex = 16;
            // 
            // grpWrite
            // 
            grpWrite.Controls.Add(txtDataToWrite);
            grpWrite.Controls.Add(label10);
            grpWrite.Controls.Add(txtWriteDeviceAddress);
            grpWrite.Controls.Add(label9);
            grpWrite.Controls.Add(btnStartWrite);
            grpWrite.Controls.Add(txtSizeWrite);
            grpWrite.Controls.Add(label7);
            grpWrite.Location = new Point(272, 132);
            grpWrite.Margin = new Padding(2, 1, 2, 1);
            grpWrite.Name = "grpWrite";
            grpWrite.Padding = new Padding(2, 1, 2, 1);
            grpWrite.Size = new Size(260, 123);
            grpWrite.TabIndex = 15;
            grpWrite.TabStop = false;
            grpWrite.Text = "Write";
            grpWrite.Enabled = false;
            // 
            // txtDataToWrite
            // 
            txtDataToWrite.Location = new Point(62, 79);
            txtDataToWrite.Margin = new Padding(2, 1, 2, 1);
            txtDataToWrite.Name = "txtDataToWrite";
            txtDataToWrite.Size = new Size(62, 23);
            txtDataToWrite.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 84);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 26;
            label10.Text = "Data";
            // 
            // txtWriteDeviceAddress
            // 
            txtWriteDeviceAddress.Location = new Point(62, 18);
            txtWriteDeviceAddress.Margin = new Padding(2, 1, 2, 1);
            txtWriteDeviceAddress.Name = "txtWriteDeviceAddress";
            txtWriteDeviceAddress.Size = new Size(110, 23);
            txtWriteDeviceAddress.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 23);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 22;
            label9.Text = "Address";
            // 
            // btnStartWrite
            // 
            btnStartWrite.Location = new Point(188, 89);
            btnStartWrite.Margin = new Padding(2, 1, 2, 1);
            btnStartWrite.Name = "btnStartWrite";
            btnStartWrite.Size = new Size(57, 22);
            btnStartWrite.TabIndex = 21;
            btnStartWrite.Text = "Write";
            btnStartWrite.UseVisualStyleBackColor = true;
            btnStartWrite.Click += btnStartWrite_Click;
            // 
            // txtSizeWrite
            // 
            txtSizeWrite.Location = new Point(62, 48);
            txtSizeWrite.Margin = new Padding(2, 1, 2, 1);
            txtSizeWrite.Name = "txtSizeWrite";
            txtSizeWrite.Size = new Size(40, 23);
            txtSizeWrite.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 53);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 24;
            label7.Text = "Size";
            // 
            // grpReadRslt
            // 
            grpReadRslt.Controls.Add(txtReadResult);
            grpReadRslt.Location = new Point(541, 79);
            grpReadRslt.Margin = new Padding(2, 1, 2, 1);
            grpReadRslt.Name = "grpReadRslt";
            grpReadRslt.Padding = new Padding(2, 1, 2, 1);
            grpReadRslt.Size = new Size(295, 176);
            grpReadRslt.TabIndex = 16;
            grpReadRslt.TabStop = false;
            grpReadRslt.Text = "Read Address Result";
            grpReadRslt.Enabled = false;
            // 
            // txtReadResult
            // 
            txtReadResult.Location = new Point(7, 20);
            txtReadResult.Margin = new Padding(2, 1, 2, 1);
            txtReadResult.Multiline = true;
            txtReadResult.Name = "txtReadResult";
            txtReadResult.Size = new Size(281, 147);
            txtReadResult.TabIndex = 19;
            txtReadResult.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 266);
            Controls.Add(grpReadRslt);
            Controls.Add(grpWrite);
            Controls.Add(grpRead);
            Controls.Add(grpStatus);
            Controls.Add(grpPlcComm);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "OmroLink";
            grpPlcComm.ResumeLayout(false);
            grpPlcComm.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpRead.ResumeLayout(false);
            grpRead.PerformLayout();
            grpWrite.ResumeLayout(false);
            grpWrite.PerformLayout();
            grpReadRslt.ResumeLayout(false);
            grpReadRslt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPlcComm;
        private ComboBox plcList;
        private Label label1;
        private ComboBox protocolList;
        private Label label2;
        private RadioButton rdoUDP;
        private RadioButton rdoTCP;
        private RadioButton rdoASCII;
        private RadioButton rdoBIN;
        private Label label3;
        private TextBox txtIP;
        private Label label4;
        private TextBox txtPort;
        private Label label5;
        private Button plcBtnDisconnect;
        private Button plcBtnConnect;
        private GroupBox grpStatus;
        private Label plcStatus;
        private GroupBox grpRead;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox txtReadDeviceAddress;
        private GroupBox grpWrite;
        private Label label8;
        private TextBox txtSizeRead;
        private Button btnRead;
        private GroupBox grpReadRslt;
        private TextBox txtReadResult;
        private Button btnStopRead;
        private Button btnReadPulse;
        private TextBox txtDataToWrite;
        private Label label10;
        private TextBox txtWriteDeviceAddress;
        private Label label9;
        private Button btnStartWrite;
        private TextBox txtSizeWrite;
        private Label label7;
    }
}
