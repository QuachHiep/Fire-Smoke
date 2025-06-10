using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoFire;
using DKVN;

namespace DKVN
{
    public partial class FormLogIn : Form
    {
        Form1 main;
        public FormLogIn()
        {
            InitializeComponent();
            txbUserLogin.Text = "Admin";
        }
        private void txbPasswordLogin_OnValueChanged(object sender, EventArgs e)
        {
            txbPasswordLogin.isPassword = true;
        }
        public void InitializeUI(Form1 obj)
        {
            main = obj;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogInUI_Click(object sender, EventArgs e)
        {
            if (txbUserLogin.Text.Trim() == "")
            {
                MessageBox.Show("User name is empty !");
                return;
            }
            if (txbPasswordLogin.Text.Trim() == "")
            {
                MessageBox.Show("Password is empty !");
                return;
            }
            if(btnLogInUI.Text.Trim() == "Log In")
            {
                switch (txbUserLogin.Text.ToUpper().Trim())
                {
                    case "ADMIN":
                        if (ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[(int)ClassCommon.LOGIN_LEVEL.ADMIN] == txbPasswordLogin.Text.Trim())
                        {
                            
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ADMIN] = true;
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.OPERATOR] = false;
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ENGINEER] = false;
                            btnLogInUI.Text = "Log Out";
                            this.Close();
                        }
                        else
                        {
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ADMIN] = false;
                            MessageBox.Show("Password Wrong!", txbUserLogin.Text);
                        }
                        break;
                    case "ENGINEER":
                        if (ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[(int)ClassCommon.LOGIN_LEVEL.ENGINEER] == txbPasswordLogin.Text.Trim())
                        {
                            
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ADMIN] = false;
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.OPERATOR] = false;
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ENGINEER] = true;
                            btnLogInUI.Text = "Log Out";
                            this.Close();
                        }
                        else
                        {
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ENGINEER] = false;
                            MessageBox.Show("Password Wrong!", txbUserLogin.Text);
                        }
                        break;
                    default:
                        if (ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[(int)ClassCommon.LOGIN_LEVEL.OPERATOR] == txbPasswordLogin.Text.Trim())
                        {
                            
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ADMIN] = false;
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.OPERATOR] = true;
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ENGINEER] = false;
                            btnLogInUI.Text = "Log Out";
                            this.Close();
                        }
                        else
                        {
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ADMIN] = false;
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.OPERATOR] = false;
                            ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ENGINEER] = false;
                            btnLogInUI.Text = "Log In";
                            MessageBox.Show("Wrong User Name or Password!");
                        }
                        break;
                }
            }
            else
            {
                ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ADMIN] = false;
                ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.OPERATOR] = false;
                ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ENGINEER] = false;
                btnLogInUI.Text = "Log In";
                txbPasswordLogin.Text = "";
            }
            btnChangePW.Visible = false;
            main.ShowUILogIn();
        }

        private void txbPasswordLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogInUI_Click(this, null);
            }
        }
        #region Edit Form
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Enable Drag Winform
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion


        #endregion
        DateTime timeStartClick = DateTime.Now;
        private void btnIconPassword_MouseUp(object sender, MouseEventArgs e)
        {
            var timeSpan = (DateTime.Now - timeStartClick).TotalMilliseconds;
            if(timeSpan > 2000 && ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ADMIN])
            {
                btnChangePW.Visible = true;
            }
            else
            {
                btnChangePW.Visible = false;
            }
        }
        private void btnIconPassword_MouseDown(object sender, MouseEventArgs e)
        {
            timeStartClick = DateTime.Now;
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Change Password?", "Change password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                switch (txbUserLogin.Text.ToUpper().Trim())
                {
                    case "ADMIN":
                        if (txbPasswordLogin.Text.Trim() != "")
                        {
                            ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[(int)ClassCommon.LOGIN_LEVEL.ADMIN] = txbPasswordLogin.Text.Trim();
                            main.SavePassLogIn("User.xml", ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin);
                            MessageBox.Show("Changed Password Done", "Admin");
                        }
                        break;
                    case "ENGINEER":
                        if (txbPasswordLogin.Text.Trim() != "")
                        {
                            ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[(int)ClassCommon.LOGIN_LEVEL.ENGINEER] = txbPasswordLogin.Text.Trim();
                            main.SavePassLogIn("User.xml", ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin);
                            MessageBox.Show("Changed Password Done", "Engineer");
                        }
                        break;
                    default:
                        if (txbPasswordLogin.Text.Trim() != "")
                        {
                            ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[(int)ClassCommon.LOGIN_LEVEL.OPERATOR] = txbPasswordLogin.Text.Trim();
                            main.SavePassLogIn("User.xml", ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin);
                            MessageBox.Show("Changed Password Done", "Operator");
                        }
                        break;
                }
                btnChangePW.Visible = false;
            }

        }
        int iUserName = 0;
        private void btnIconUsername_Click(object sender, EventArgs e)
        {
            switch(iUserName)
            {
                case 0:
                    txbUserLogin.Text = "Operator";
                    break;
                case 1:
                    txbUserLogin.Text = "Engineer";
                    break;
                case 2:
                    txbUserLogin.Text = "Admin";
                    break;
                default:
                    iUserName = -1;
                    txbUserLogin.Text = "";
                    break;
            }
            iUserName++;
        }
    }
}
