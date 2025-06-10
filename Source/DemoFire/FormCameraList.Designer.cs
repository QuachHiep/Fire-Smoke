namespace DKVN
{
    partial class FormCameraList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCameraList));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbTitleHeader = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteCamera = new System.Windows.Forms.Button();
            this.btnAddCamera = new System.Windows.Forms.Button();
            this.txbType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbUserID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIPCamera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRtsp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCameraName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIDCamera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgviewCameraDetail = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCameraDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lbTitleHeader);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnMaximum);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1048, 28);
            this.panelHeader.TabIndex = 6;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // lbTitleHeader
            // 
            this.lbTitleHeader.AutoSize = true;
            this.lbTitleHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleHeader.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbTitleHeader.Location = new System.Drawing.Point(3, 6);
            this.lbTitleHeader.Name = "lbTitleHeader";
            this.lbTitleHeader.Size = new System.Drawing.Size(85, 17);
            this.lbTitleHeader.TabIndex = 12;
            this.lbTitleHeader.Text = "Camera List";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(961, 3);
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
            this.btnMaximum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximum.FlatAppearance.BorderSize = 0;
            this.btnMaximum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMaximum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMaximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximum.ForeColor = System.Drawing.Color.White;
            this.btnMaximum.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximum.Image")));
            this.btnMaximum.Location = new System.Drawing.Point(991, 3);
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
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1021, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 22);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 512);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 512);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1048, 512);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnDeleteCamera);
            this.panel4.Controls.Add(this.btnAddCamera);
            this.panel4.Controls.Add(this.txbType);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txbPassword);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txbUserID);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txbIPCamera);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txbRtsp);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txbCameraName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txbIDCamera);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 506);
            this.panel4.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 31);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteCamera
            // 
            this.btnDeleteCamera.Location = new System.Drawing.Point(0, 338);
            this.btnDeleteCamera.Name = "btnDeleteCamera";
            this.btnDeleteCamera.Size = new System.Drawing.Size(241, 31);
            this.btnDeleteCamera.TabIndex = 16;
            this.btnDeleteCamera.Text = "Delete";
            this.btnDeleteCamera.UseVisualStyleBackColor = true;
            this.btnDeleteCamera.Click += new System.EventHandler(this.btnDeleteCamera_Click);
            // 
            // btnAddCamera
            // 
            this.btnAddCamera.Location = new System.Drawing.Point(0, 301);
            this.btnAddCamera.Name = "btnAddCamera";
            this.btnAddCamera.Size = new System.Drawing.Size(241, 31);
            this.btnAddCamera.TabIndex = 15;
            this.btnAddCamera.Text = "Add New";
            this.btnAddCamera.UseVisualStyleBackColor = true;
            this.btnAddCamera.Click += new System.EventHandler(this.btnAddCamera_Click);
            // 
            // txbType
            // 
            this.txbType.Location = new System.Drawing.Point(87, 215);
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(151, 24);
            this.txbType.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Type:";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(87, 185);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(151, 24);
            this.txbPassword.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password:";
            // 
            // txbUserID
            // 
            this.txbUserID.Location = new System.Drawing.Point(87, 155);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.Size = new System.Drawing.Size(151, 24);
            this.txbUserID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "UserID:";
            // 
            // txbIPCamera
            // 
            this.txbIPCamera.Location = new System.Drawing.Point(87, 125);
            this.txbIPCamera.Name = "txbIPCamera";
            this.txbIPCamera.Size = new System.Drawing.Size(151, 24);
            this.txbIPCamera.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP Addr:";
            // 
            // txbRtsp
            // 
            this.txbRtsp.Enabled = false;
            this.txbRtsp.Location = new System.Drawing.Point(87, 95);
            this.txbRtsp.Name = "txbRtsp";
            this.txbRtsp.ReadOnly = true;
            this.txbRtsp.Size = new System.Drawing.Size(151, 24);
            this.txbRtsp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "RTSP URL:";
            // 
            // txbCameraName
            // 
            this.txbCameraName.Location = new System.Drawing.Point(87, 65);
            this.txbCameraName.Name = "txbCameraName";
            this.txbCameraName.Size = new System.Drawing.Size(151, 24);
            this.txbCameraName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // txbIDCamera
            // 
            this.txbIDCamera.Location = new System.Drawing.Point(87, 35);
            this.txbIDCamera.Name = "txbIDCamera";
            this.txbIDCamera.Size = new System.Drawing.Size(151, 24);
            this.txbIDCamera.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera Info";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgviewCameraDetail);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(253, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 506);
            this.panel5.TabIndex = 1;
            // 
            // dgviewCameraDetail
            // 
            this.dgviewCameraDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewCameraDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewCameraDetail.Location = new System.Drawing.Point(0, 0);
            this.dgviewCameraDetail.Name = "dgviewCameraDetail";
            this.dgviewCameraDetail.ReadOnly = true;
            this.dgviewCameraDetail.RowHeadersVisible = false;
            this.dgviewCameraDetail.Size = new System.Drawing.Size(792, 506);
            this.dgviewCameraDetail.TabIndex = 0;
            this.dgviewCameraDetail.SelectionChanged += new System.EventHandler(this.dgviewCameraDetail_SelectionChanged);
            // 
            // FormCameraList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCameraList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormConfirmVision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfirmVision_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCameraDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbTitleHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteCamera;
        private System.Windows.Forms.Button btnAddCamera;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbUserID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbIPCamera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRtsp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCameraName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIDCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgviewCameraDetail;
    }
}