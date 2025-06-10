namespace DKVN
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeftHide_LogIn = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.txbUserLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLogInUI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPasswordLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnIconUsername = new System.Windows.Forms.Button();
            this.btnIconPassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelLeftHide_LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.panelLeftHide_LogIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 246);
            this.panel1.TabIndex = 0;
            // 
            // panelLeftHide_LogIn
            // 
            this.panelLeftHide_LogIn.Controls.Add(this.btnClose);
            this.panelLeftHide_LogIn.Controls.Add(this.btnChangePW);
            this.panelLeftHide_LogIn.Controls.Add(this.txbUserLogin);
            this.panelLeftHide_LogIn.Controls.Add(this.btnLogInUI);
            this.panelLeftHide_LogIn.Controls.Add(this.label1);
            this.panelLeftHide_LogIn.Controls.Add(this.txbPasswordLogin);
            this.panelLeftHide_LogIn.Controls.Add(this.btnIconUsername);
            this.panelLeftHide_LogIn.Controls.Add(this.btnIconPassword);
            this.panelLeftHide_LogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftHide_LogIn.Location = new System.Drawing.Point(0, 0);
            this.panelLeftHide_LogIn.Name = "panelLeftHide_LogIn";
            this.panelLeftHide_LogIn.Size = new System.Drawing.Size(405, 246);
            this.panelLeftHide_LogIn.TabIndex = 15;
            this.panelLeftHide_LogIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.panelLeftHide_LogIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.panelLeftHide_LogIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Gold;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(375, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChangePW
            // 
            this.btnChangePW.FlatAppearance.BorderSize = 0;
            this.btnChangePW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnChangePW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnChangePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePW.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePW.ForeColor = System.Drawing.Color.Gold;
            this.btnChangePW.Location = new System.Drawing.Point(55, 188);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(135, 31);
            this.btnChangePW.TabIndex = 14;
            this.btnChangePW.Text = "Change PW";
            this.btnChangePW.UseVisualStyleBackColor = true;
            this.btnChangePW.Visible = false;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // txbUserLogin
            // 
            this.txbUserLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUserLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserLogin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbUserLogin.HintForeColor = System.Drawing.Color.DimGray;
            this.txbUserLogin.HintText = "User name";
            this.txbUserLogin.isPassword = false;
            this.txbUserLogin.LineFocusedColor = System.Drawing.Color.Gold;
            this.txbUserLogin.LineIdleColor = System.Drawing.Color.FloralWhite;
            this.txbUserLogin.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txbUserLogin.LineThickness = 4;
            this.txbUserLogin.Location = new System.Drawing.Point(55, 64);
            this.txbUserLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserLogin.Name = "txbUserLogin";
            this.txbUserLogin.Size = new System.Drawing.Size(322, 35);
            this.txbUserLogin.TabIndex = 10;
            this.txbUserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogInUI
            // 
            this.btnLogInUI.FlatAppearance.BorderSize = 0;
            this.btnLogInUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnLogInUI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLogInUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInUI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInUI.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogInUI.Location = new System.Drawing.Point(279, 188);
            this.btnLogInUI.Name = "btnLogInUI";
            this.btnLogInUI.Size = new System.Drawing.Size(98, 31);
            this.btnLogInUI.TabIndex = 13;
            this.btnLogInUI.Text = "Log In";
            this.btnLogInUI.UseVisualStyleBackColor = true;
            this.btnLogInUI.Click += new System.EventHandler(this.btnLogInUI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN";
            // 
            // txbPasswordLogin
            // 
            this.txbPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPasswordLogin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbPasswordLogin.HintForeColor = System.Drawing.Color.DimGray;
            this.txbPasswordLogin.HintText = "Password";
            this.txbPasswordLogin.isPassword = false;
            this.txbPasswordLogin.LineFocusedColor = System.Drawing.Color.Gold;
            this.txbPasswordLogin.LineIdleColor = System.Drawing.Color.FloralWhite;
            this.txbPasswordLogin.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txbPasswordLogin.LineThickness = 4;
            this.txbPasswordLogin.Location = new System.Drawing.Point(55, 124);
            this.txbPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txbPasswordLogin.Name = "txbPasswordLogin";
            this.txbPasswordLogin.Size = new System.Drawing.Size(322, 35);
            this.txbPasswordLogin.TabIndex = 12;
            this.txbPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPasswordLogin.OnValueChanged += new System.EventHandler(this.txbPasswordLogin_OnValueChanged);
            this.txbPasswordLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPasswordLogin_KeyDown);
            // 
            // btnIconUsername
            // 
            this.btnIconUsername.FlatAppearance.BorderSize = 0;
            this.btnIconUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnIconUsername.Image")));
            this.btnIconUsername.Location = new System.Drawing.Point(3, 68);
            this.btnIconUsername.Name = "btnIconUsername";
            this.btnIconUsername.Size = new System.Drawing.Size(43, 31);
            this.btnIconUsername.TabIndex = 9;
            this.btnIconUsername.UseVisualStyleBackColor = true;
            this.btnIconUsername.Click += new System.EventHandler(this.btnIconUsername_Click);
            // 
            // btnIconPassword
            // 
            this.btnIconPassword.FlatAppearance.BorderSize = 0;
            this.btnIconPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnIconPassword.Image")));
            this.btnIconPassword.Location = new System.Drawing.Point(3, 128);
            this.btnIconPassword.Name = "btnIconPassword";
            this.btnIconPassword.Size = new System.Drawing.Size(43, 31);
            this.btnIconPassword.TabIndex = 11;
            this.btnIconPassword.UseVisualStyleBackColor = true;
            this.btnIconPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIconPassword_MouseDown);
            this.btnIconPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIconPassword_MouseUp);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 246);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panelLeftHide_LogIn.ResumeLayout(false);
            this.panelLeftHide_LogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeftHide_LogIn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbUserLogin;
        private System.Windows.Forms.Button btnLogInUI;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbPasswordLogin;
        private System.Windows.Forms.Button btnIconUsername;
        private System.Windows.Forms.Button btnIconPassword;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnClose;
    }
}