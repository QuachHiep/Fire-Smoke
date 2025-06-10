namespace DKVN
{
    partial class FormStartupLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartupLoading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lbProgramName = new System.Windows.Forms.Label();
            this.lbReleasedDate = new System.Windows.Forms.Label();
            this.lbProgramVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContainer.BackgroundImage")));
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Controls.Add(this.lbProgramName);
            this.panelContainer.Controls.Add(this.lbReleasedDate);
            this.panelContainer.Controls.Add(this.lbProgramVersion);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.pictureBox2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(574, 362);
            this.panelContainer.TabIndex = 4;
            // 
            // lbProgramName
            // 
            this.lbProgramName.BackColor = System.Drawing.Color.Transparent;
            this.lbProgramName.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramName.ForeColor = System.Drawing.Color.Blue;
            this.lbProgramName.Location = new System.Drawing.Point(3, 104);
            this.lbProgramName.Name = "lbProgramName";
            this.lbProgramName.Size = new System.Drawing.Size(302, 129);
            this.lbProgramName.TabIndex = 11;
            this.lbProgramName.Text = "PROGRAM NAME";
            this.lbProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReleasedDate
            // 
            this.lbReleasedDate.BackColor = System.Drawing.Color.Transparent;
            this.lbReleasedDate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReleasedDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbReleasedDate.Location = new System.Drawing.Point(-3, 339);
            this.lbReleasedDate.Name = "lbReleasedDate";
            this.lbReleasedDate.Size = new System.Drawing.Size(198, 22);
            this.lbReleasedDate.TabIndex = 13;
            this.lbReleasedDate.Text = "Released Date";
            this.lbReleasedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProgramVersion
            // 
            this.lbProgramVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbProgramVersion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramVersion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbProgramVersion.Location = new System.Drawing.Point(-2, 308);
            this.lbProgramVersion.Name = "lbProgramVersion";
            this.lbProgramVersion.Size = new System.Drawing.Size(198, 31);
            this.lbProgramVersion.TabIndex = 12;
            this.lbProgramVersion.Text = "VER 1.0.0";
            this.lbProgramVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "VISION CAMERA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(196, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FormStartupLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 362);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStartupLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStartupLoading";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lbProgramName;
        private System.Windows.Forms.Label lbReleasedDate;
        private System.Windows.Forms.Label lbProgramVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}