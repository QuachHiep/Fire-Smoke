namespace DemoFire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLoginIcon = new System.Windows.Forms.Button();
            this.lbTitleHeader = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLog = new System.Windows.Forms.Panel();
            this.dgviewLog = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnMainUI = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbReleasedDate = new System.Windows.Forms.Label();
            this.lbProgramVersion = new System.Windows.Forms.Label();
            this.lbProgramName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewLog)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(175)))), ((int)(((byte)(215)))));
            this.panelHeader.Controls.Add(this.btnLoginIcon);
            this.panelHeader.Controls.Add(this.lbTitleHeader);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnMaximum);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1300, 28);
            this.panelHeader.TabIndex = 14;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // btnLoginIcon
            // 
            this.btnLoginIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginIcon.BackgroundImage")));
            this.btnLoginIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoginIcon.FlatAppearance.BorderSize = 0;
            this.btnLoginIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginIcon.ForeColor = System.Drawing.Color.White;
            this.btnLoginIcon.Location = new System.Drawing.Point(1168, 1);
            this.btnLoginIcon.Name = "btnLoginIcon";
            this.btnLoginIcon.Size = new System.Drawing.Size(28, 33);
            this.btnLoginIcon.TabIndex = 13;
            this.btnLoginIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginIcon.UseVisualStyleBackColor = true;
            this.btnLoginIcon.Click += new System.EventHandler(this.btnLoginIcon_Click);
            // 
            // lbTitleHeader
            // 
            this.lbTitleHeader.AutoSize = true;
            this.lbTitleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbTitleHeader.Location = new System.Drawing.Point(3, 5);
            this.lbTitleHeader.Name = "lbTitleHeader";
            this.lbTitleHeader.Size = new System.Drawing.Size(39, 16);
            this.lbTitleHeader.TabIndex = 11;
            this.lbTitleHeader.Text = "Hello";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1212, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 22);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximum.BackgroundImage")));
            this.btnMaximum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximum.FlatAppearance.BorderSize = 0;
            this.btnMaximum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMaximum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMaximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximum.ForeColor = System.Drawing.Color.White;
            this.btnMaximum.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximum.Location = new System.Drawing.Point(1242, 3);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(24, 22);
            this.btnMaximum.TabIndex = 7;
            this.btnMaximum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(1272, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 22);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Controls.Add(this.panelTop);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 28);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1300, 648);
            this.panelContainer.TabIndex = 15;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(72)))));
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 90);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1300, 558);
            this.panelMain.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.17632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.82368F));
            this.tableLayoutPanel1.Controls.Add(this.panelLog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 558F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 558);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.dgviewLog);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(3, 3);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(243, 552);
            this.panelLog.TabIndex = 3;
            // 
            // dgviewLog
            // 
            this.dgviewLog.AllowUserToAddRows = false;
            this.dgviewLog.AllowUserToDeleteRows = false;
            this.dgviewLog.AllowUserToResizeRows = false;
            this.dgviewLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewLog.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewLog.Location = new System.Drawing.Point(0, 0);
            this.dgviewLog.Name = "dgviewLog";
            this.dgviewLog.RowHeadersVisible = false;
            this.dgviewLog.Size = new System.Drawing.Size(243, 552);
            this.dgviewLog.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(252, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 552);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 552F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1045, 552);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightCyan;
            this.panelTop.Controls.Add(this.panel3);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.panel5);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 90);
            this.panelTop.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitter2);
            this.panel3.Controls.Add(this.panelDateTime);
            this.panel3.Controls.Add(this.btnMainUI);
            this.panel3.Controls.Add(this.btnSetting);
            this.panel3.Controls.Add(this.btnLog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(590, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 90);
            this.panel3.TabIndex = 42;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(427, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1, 90);
            this.splitter2.TabIndex = 17;
            this.splitter2.TabStop = false;
            // 
            // panelDateTime
            // 
            this.panelDateTime.Controls.Add(this.splitter4);
            this.panelDateTime.Controls.Add(this.lbTime);
            this.panelDateTime.Controls.Add(this.lbDate);
            this.panelDateTime.Controls.Add(this.splitter1);
            this.panelDateTime.Location = new System.Drawing.Point(146, 0);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(169, 90);
            this.panelDateTime.TabIndex = 26;
            this.panelDateTime.Visible = false;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.SteelBlue;
            this.splitter4.Location = new System.Drawing.Point(0, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1, 90);
            this.splitter4.TabIndex = 18;
            this.splitter4.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTime.Location = new System.Drawing.Point(5, 44);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(161, 43);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDate.Location = new System.Drawing.Point(10, 4);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(152, 37);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "Date";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(168, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 90);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // btnMainUI
            // 
            this.btnMainUI.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMainUI.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMainUI.FlatAppearance.BorderSize = 0;
            this.btnMainUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainUI.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainUI.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMainUI.Image = ((System.Drawing.Image)(resources.GetObject("btnMainUI.Image")));
            this.btnMainUI.Location = new System.Drawing.Point(428, 0);
            this.btnMainUI.Name = "btnMainUI";
            this.btnMainUI.Size = new System.Drawing.Size(102, 90);
            this.btnMainUI.TabIndex = 2;
            this.btnMainUI.Text = "MONITOR";
            this.btnMainUI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainUI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMainUI.UseVisualStyleBackColor = false;
            this.btnMainUI.Click += new System.EventHandler(this.btnMainUI_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetting.Enabled = false;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(530, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(89, 90);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.Text = "SETTING";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLog.Enabled = false;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.Location = new System.Drawing.Point(619, 0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(91, 90);
            this.btnLog.TabIndex = 12;
            this.btnLog.Text = "LOG";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbReleasedDate);
            this.panel1.Controls.Add(this.lbProgramVersion);
            this.panel1.Controls.Add(this.lbProgramName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(128, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 90);
            this.panel1.TabIndex = 28;
            // 
            // lbReleasedDate
            // 
            this.lbReleasedDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReleasedDate.Location = new System.Drawing.Point(3, 41);
            this.lbReleasedDate.Name = "lbReleasedDate";
            this.lbReleasedDate.Size = new System.Drawing.Size(170, 16);
            this.lbReleasedDate.TabIndex = 2;
            this.lbReleasedDate.Text = "Released Date";
            // 
            // lbProgramVersion
            // 
            this.lbProgramVersion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramVersion.Location = new System.Drawing.Point(3, 63);
            this.lbProgramVersion.Name = "lbProgramVersion";
            this.lbProgramVersion.Size = new System.Drawing.Size(170, 16);
            this.lbProgramVersion.TabIndex = 1;
            this.lbProgramVersion.Text = "VER 1.0.0";
            // 
            // lbProgramName
            // 
            this.lbProgramName.AutoSize = true;
            this.lbProgramName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbProgramName.Location = new System.Drawing.Point(3, 4);
            this.lbProgramName.Name = "lbProgramName";
            this.lbProgramName.Size = new System.Drawing.Size(229, 31);
            this.lbProgramName.TabIndex = 0;
            this.lbProgramName.Text = "PROGRAM NAME";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBoxLogo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 90);
            this.panel5.TabIndex = 44;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::DemoFire.Properties.Resources.INFINIQ_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(128, 90);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 28;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 676);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewLog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelDateTime.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnLoginIcon;
        private System.Windows.Forms.Label lbTitleHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMainUI;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbReleasedDate;
        private System.Windows.Forms.Label lbProgramVersion;
        private System.Windows.Forms.Label lbProgramName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.DataGridView dgviewLog;
    }
}

