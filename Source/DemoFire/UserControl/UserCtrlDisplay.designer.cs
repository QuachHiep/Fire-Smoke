namespace DKVN
{
    partial class UserCtrlDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCtrlDisplay));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMainDisplay = new System.Windows.Forms.Panel();
            this.cogDisplay1 = new Cognex.VisionPro.Display.CogDisplay();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRTSP_Link = new System.Windows.Forms.TextBox();
            this.btnRTSP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUser_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUser_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIP_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIP_Cam = new System.Windows.Forms.TextBox();
            this.bntConnectCam = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.statusCAM = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLive2 = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnLive = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVideoPredict = new System.Windows.Forms.Button();
            this.lbNameControl = new System.Windows.Forms.Label();
            this.btnCameraLive = new System.Windows.Forms.Button();
            this.btnHideSetup = new System.Windows.Forms.Button();
            this.btnSpread = new System.Windows.Forms.Button();
            this.lbIndexControl = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMainDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBackground.Controls.Add(this.panelMain);
            this.panelBackground.Controls.Add(this.panelHeader);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(920, 637);
            this.panelBackground.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(0, 26);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(920, 611);
            this.panelMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelMainDisplay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 611);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelMainDisplay
            // 
            this.panelMainDisplay.Controls.Add(this.cogDisplay1);
            this.panelMainDisplay.Controls.Add(this.panelMenu);
            this.panelMainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelMainDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.panelMainDisplay.Name = "panelMainDisplay";
            this.panelMainDisplay.Size = new System.Drawing.Size(920, 611);
            this.panelMainDisplay.TabIndex = 0;
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cogDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay1.MouseWheelSensitivity = 1D;
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay1.OcxState")));
            this.cogDisplay1.Size = new System.Drawing.Size(682, 611);
            this.cogDisplay1.TabIndex = 9;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.tabControl1);
            this.panelMenu.Controls.Add(this.panelBottom);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(682, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 611);
            this.panelMenu.TabIndex = 7;
            this.panelMenu.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 579);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(230, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manual";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 550);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.txbRTSP_Link);
            this.groupBox7.Controls.Add(this.btnRTSP);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.txbUser_pass);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txbUser_name);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txbIP_Port);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txbIP_Cam);
            this.groupBox7.Controls.Add(this.bntConnectCam);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.statusCAM);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(224, 204);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "RTSP:";
            // 
            // txbRTSP_Link
            // 
            this.txbRTSP_Link.Location = new System.Drawing.Point(99, 57);
            this.txbRTSP_Link.Name = "txbRTSP_Link";
            this.txbRTSP_Link.Size = new System.Drawing.Size(119, 22);
            this.txbRTSP_Link.TabIndex = 39;
            this.txbRTSP_Link.Text = "rtsp://admin:infiniq@2025@10.29.98.61:554/cam/realmonitor?channel=1&subtype=0";
            // 
            // btnRTSP
            // 
            this.btnRTSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRTSP.FlatAppearance.BorderSize = 0;
            this.btnRTSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRTSP.Location = new System.Drawing.Point(66, 16);
            this.btnRTSP.Name = "btnRTSP";
            this.btnRTSP.Size = new System.Drawing.Size(73, 22);
            this.btnRTSP.TabIndex = 38;
            this.btnRTSP.Text = "RTSP";
            this.btnRTSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRTSP.UseVisualStyleBackColor = false;
            this.btnRTSP.Click += new System.EventHandler(this.btnRTSP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Password:";
            // 
            // txbUser_pass
            // 
            this.txbUser_pass.Location = new System.Drawing.Point(99, 172);
            this.txbUser_pass.Name = "txbUser_pass";
            this.txbUser_pass.Size = new System.Drawing.Size(119, 22);
            this.txbUser_pass.TabIndex = 36;
            this.txbUser_pass.Text = "infiniq@2025";
            this.txbUser_pass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "User name:";
            // 
            // txbUser_name
            // 
            this.txbUser_name.Location = new System.Drawing.Point(99, 144);
            this.txbUser_name.Name = "txbUser_name";
            this.txbUser_name.Size = new System.Drawing.Size(119, 22);
            this.txbUser_name.TabIndex = 34;
            this.txbUser_name.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Port:";
            // 
            // txbIP_Port
            // 
            this.txbIP_Port.Location = new System.Drawing.Point(99, 115);
            this.txbIP_Port.Name = "txbIP_Port";
            this.txbIP_Port.Size = new System.Drawing.Size(119, 22);
            this.txbIP_Port.TabIndex = 32;
            this.txbIP_Port.Text = "8000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "IP:";
            // 
            // txbIP_Cam
            // 
            this.txbIP_Cam.Location = new System.Drawing.Point(99, 86);
            this.txbIP_Cam.Name = "txbIP_Cam";
            this.txbIP_Cam.Size = new System.Drawing.Size(119, 22);
            this.txbIP_Cam.TabIndex = 30;
            this.txbIP_Cam.Text = "10.29.98.60";
            // 
            // bntConnectCam
            // 
            this.bntConnectCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntConnectCam.FlatAppearance.BorderSize = 0;
            this.bntConnectCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConnectCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConnectCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntConnectCam.Location = new System.Drawing.Point(145, 16);
            this.bntConnectCam.Name = "bntConnectCam";
            this.bntConnectCam.Size = new System.Drawing.Size(73, 22);
            this.bntConnectCam.TabIndex = 29;
            this.bntConnectCam.Text = "Connect";
            this.bntConnectCam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntConnectCam.UseVisualStyleBackColor = false;
            this.bntConnectCam.Click += new System.EventHandler(this.bntConnectCam_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 16);
            this.label23.TabIndex = 10;
            this.label23.Text = "CAM";
            this.label23.Visible = false;
            // 
            // statusCAM
            // 
            this.statusCAM.Appearance = System.Windows.Forms.Appearance.Button;
            this.statusCAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusCAM.Enabled = false;
            this.statusCAM.FlatAppearance.BorderSize = 0;
            this.statusCAM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.statusCAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusCAM.Location = new System.Drawing.Point(6, 22);
            this.statusCAM.Name = "statusCAM";
            this.statusCAM.Size = new System.Drawing.Size(14, 14);
            this.statusCAM.TabIndex = 0;
            this.statusCAM.UseVisualStyleBackColor = false;
            this.statusCAM.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLive2);
            this.panel2.Controls.Add(this.btnCapture);
            this.panel2.Controls.Add(this.btnRecord);
            this.panel2.Controls.Add(this.btnLive);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 334);
            this.panel2.TabIndex = 11;
            // 
            // btnLive2
            // 
            this.btnLive2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLive2.FlatAppearance.BorderSize = 0;
            this.btnLive2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLive2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLive2.Location = new System.Drawing.Point(6, 117);
            this.btnLive2.Name = "btnLive2";
            this.btnLive2.Size = new System.Drawing.Size(212, 32);
            this.btnLive2.TabIndex = 35;
            this.btnLive2.Text = "Live 2";
            this.btnLive2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLive2.UseVisualStyleBackColor = false;
            this.btnLive2.Click += new System.EventHandler(this.btnLive2_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCapture.FlatAppearance.BorderSize = 0;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Location = new System.Drawing.Point(6, 79);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(212, 32);
            this.btnCapture.TabIndex = 31;
            this.btnCapture.Text = "Cap";
            this.btnCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(6, 41);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(212, 32);
            this.btnRecord.TabIndex = 32;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnLive
            // 
            this.btnLive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLive.FlatAppearance.BorderSize = 0;
            this.btnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLive.Location = new System.Drawing.Point(6, 3);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(212, 32);
            this.btnLive.TabIndex = 30;
            this.btnLive.Text = "Live";
            this.btnLive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLive.UseVisualStyleBackColor = false;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 579);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(238, 32);
            this.panelBottom.TabIndex = 10;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Linen;
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.btnCameraLive);
            this.panelHeader.Controls.Add(this.btnHideSetup);
            this.panelHeader.Controls.Add(this.btnSpread);
            this.panelHeader.Controls.Add(this.lbIndexControl);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(920, 26);
            this.panelHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVideoPredict);
            this.panel1.Controls.Add(this.lbNameControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(36, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 26);
            this.panel1.TabIndex = 49;
            // 
            // btnVideoPredict
            // 
            this.btnVideoPredict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVideoPredict.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVideoPredict.FlatAppearance.BorderSize = 0;
            this.btnVideoPredict.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVideoPredict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnVideoPredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoPredict.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoPredict.ForeColor = System.Drawing.Color.White;
            this.btnVideoPredict.Image = ((System.Drawing.Image)(resources.GetObject("btnVideoPredict.Image")));
            this.btnVideoPredict.Location = new System.Drawing.Point(692, 0);
            this.btnVideoPredict.Name = "btnVideoPredict";
            this.btnVideoPredict.Size = new System.Drawing.Size(48, 26);
            this.btnVideoPredict.TabIndex = 49;
            this.btnVideoPredict.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideoPredict.UseVisualStyleBackColor = true;
            this.btnVideoPredict.Visible = false;
            this.btnVideoPredict.Click += new System.EventHandler(this.btnVideoPredict_Click);
            // 
            // lbNameControl
            // 
            this.lbNameControl.BackColor = System.Drawing.Color.Transparent;
            this.lbNameControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNameControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameControl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNameControl.Location = new System.Drawing.Point(0, 0);
            this.lbNameControl.Name = "lbNameControl";
            this.lbNameControl.Size = new System.Drawing.Size(740, 26);
            this.lbNameControl.TabIndex = 2;
            this.lbNameControl.Text = "                  Name";
            this.lbNameControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCameraLive
            // 
            this.btnCameraLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCameraLive.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCameraLive.FlatAppearance.BorderSize = 0;
            this.btnCameraLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCameraLive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCameraLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCameraLive.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameraLive.ForeColor = System.Drawing.Color.White;
            this.btnCameraLive.Image = ((System.Drawing.Image)(resources.GetObject("btnCameraLive.Image")));
            this.btnCameraLive.Location = new System.Drawing.Point(776, 0);
            this.btnCameraLive.Name = "btnCameraLive";
            this.btnCameraLive.Size = new System.Drawing.Size(48, 26);
            this.btnCameraLive.TabIndex = 48;
            this.btnCameraLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCameraLive.UseVisualStyleBackColor = true;
            this.btnCameraLive.Click += new System.EventHandler(this.btnCameraLive_Click);
            // 
            // btnHideSetup
            // 
            this.btnHideSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHideSetup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHideSetup.FlatAppearance.BorderSize = 0;
            this.btnHideSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHideSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHideSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideSetup.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideSetup.ForeColor = System.Drawing.Color.White;
            this.btnHideSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnHideSetup.Image")));
            this.btnHideSetup.Location = new System.Drawing.Point(824, 0);
            this.btnHideSetup.Name = "btnHideSetup";
            this.btnHideSetup.Size = new System.Drawing.Size(48, 26);
            this.btnHideSetup.TabIndex = 47;
            this.btnHideSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHideSetup.UseVisualStyleBackColor = true;
            this.btnHideSetup.Visible = false;
            this.btnHideSetup.Click += new System.EventHandler(this.btnHideSetup_Click);
            // 
            // btnSpread
            // 
            this.btnSpread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpread.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpread.FlatAppearance.BorderSize = 0;
            this.btnSpread.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSpread.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSpread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpread.ForeColor = System.Drawing.Color.White;
            this.btnSpread.Image = global::DemoFire.Properties.Resources.expand2;
            this.btnSpread.Location = new System.Drawing.Point(872, 0);
            this.btnSpread.Name = "btnSpread";
            this.btnSpread.Size = new System.Drawing.Size(48, 26);
            this.btnSpread.TabIndex = 46;
            this.btnSpread.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpread.UseVisualStyleBackColor = true;
            this.btnSpread.Click += new System.EventHandler(this.btnSpread_Click);
            // 
            // lbIndexControl
            // 
            this.lbIndexControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbIndexControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndexControl.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbIndexControl.Location = new System.Drawing.Point(0, 0);
            this.lbIndexControl.Name = "lbIndexControl";
            this.lbIndexControl.Size = new System.Drawing.Size(36, 26);
            this.lbIndexControl.TabIndex = 0;
            this.lbIndexControl.Text = "[0]";
            this.lbIndexControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbIndexControl.Visible = false;
            // 
            // UserCtrlDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserCtrlDisplay";
            this.Size = new System.Drawing.Size(920, 637);
            this.Load += new System.EventHandler(this.UserCtrlDisplay_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelMainDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbIndexControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelMainDisplay;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSpread;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnHideSetup;
        private System.Windows.Forms.Button btnCameraLive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameControl;
        private System.Windows.Forms.Button btnLive;
        private Cognex.VisionPro.Display.CogDisplay cogDisplay1;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIP_Cam;
        private System.Windows.Forms.Button bntConnectCam;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox statusCAM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLive2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUser_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIP_Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUser_pass;
        private System.Windows.Forms.Button btnRTSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRTSP_Link;
        private System.Windows.Forms.Button btnVideoPredict;
    }
}
