namespace DKVN
{
    partial class FormConfirmVision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmVision));
            this.btnNG = new System.Windows.Forms.Button();
            this.lbAlarmMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNG
            // 
            this.btnNG.BackColor = System.Drawing.Color.Red;
            this.btnNG.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNG.ForeColor = System.Drawing.Color.White;
            this.btnNG.Location = new System.Drawing.Point(260, 106);
            this.btnNG.Name = "btnNG";
            this.btnNG.Size = new System.Drawing.Size(123, 53);
            this.btnNG.TabIndex = 10;
            this.btnNG.Text = "Cancel";
            this.btnNG.UseVisualStyleBackColor = false;
            this.btnNG.Click += new System.EventHandler(this.btnNG_Click);
            // 
            // lbAlarmMessage
            // 
            this.lbAlarmMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlarmMessage.BackColor = System.Drawing.Color.IndianRed;
            this.lbAlarmMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarmMessage.ForeColor = System.Drawing.Color.Black;
            this.lbAlarmMessage.Location = new System.Drawing.Point(127, 5);
            this.lbAlarmMessage.Name = "lbAlarmMessage";
            this.lbAlarmMessage.Size = new System.Drawing.Size(256, 98);
            this.lbAlarmMessage.TabIndex = 9;
            this.lbAlarmMessage.Text = "Vision detection Warning. Please confirm the results below.";
            this.lbAlarmMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(125, 106);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 53);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Confirm";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormConfirmVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 168);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNG);
            this.Controls.Add(this.lbAlarmMessage);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConfirmVision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormConfirmVision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfirmVision_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNG;
        private System.Windows.Forms.Label lbAlarmMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}