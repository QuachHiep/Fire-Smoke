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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DKVN
{
    public partial class FormSetting : Form
    {
        public Form1 main;
        public FormSetting()
        {
            InitializeComponent();
            radioButtonSystemSetting.Checked = true;
        }
        public void InitializeUI(Form1 obj)
        {
            main = obj;

            // Mảng các TextBox để dễ dàng duyệt qua
            System.Windows.Forms.TextBox[] textBoxes = new System.Windows.Forms.TextBox[]
            {
                txbRtsp_Cam1,
                txbRtsp_Cam2,
                txbRtsp_Cam3,
                txbRtsp_Cam4,
                txbRtsp_Cam5,
                txbRtsp_Cam6,
                txbRtsp_Cam7,
                txbRtsp_Cam8,
                txbRtsp_Cam9
            };

            //for (int i = 0; i < textBoxes.Length; i++)
            //{
            //    textBoxes[i].Text = ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam[i];
            //}


            txbSavingPath.Text = ClassSystemConfig.Ins.m_ClsCommon.m_CommonPath;
            cbAutoDeleteImage.Checked = ClassSystemConfig.Ins.m_ClsCommon.m_bAutoDeleteImg;
            if (ClassSystemConfig.Ins.m_ClsCommon.m_iPeriodDelete < (int)numericAutoDelete.Minimum || ClassSystemConfig.Ins.m_ClsCommon.m_iPeriodDelete > (int)numericAutoDelete.Maximum)
                ClassSystemConfig.Ins.m_ClsCommon.m_iPeriodDelete = (int)numericAutoDelete.Minimum;
            if (ClassSystemConfig.Ins.m_ClsCommon.m_iTimeBetween2Trigger < (int)numericBetween2Trigger.Minimum || ClassSystemConfig.Ins.m_ClsCommon.m_iTimeBetween2Trigger > (int)numericBetween2Trigger.Maximum)
                ClassSystemConfig.Ins.m_ClsCommon.m_iTimeBetween2Trigger = (int)numericBetween2Trigger.Minimum;
            if (ClassSystemConfig.Ins.m_ClsCommon.m_iTimeoutCheckReady < (int)numericUpDownTimeoutReady.Minimum || ClassSystemConfig.Ins.m_ClsCommon.m_iTimeoutCheckReady > (int)numericUpDownTimeoutReady.Maximum)
                ClassSystemConfig.Ins.m_ClsCommon.m_iTimeoutCheckReady = (int)numericUpDownTimeoutReady.Minimum;

            numericAutoDelete.Value = ClassSystemConfig.Ins.m_ClsCommon.m_iPeriodDelete;
            numericBetween2Trigger.Value = ClassSystemConfig.Ins.m_ClsCommon.m_iTimeBetween2Trigger;
            numericUpDownTimeoutReady.Value = ClassSystemConfig.Ins.m_ClsCommon.m_iTimeoutCheckReady;


            cbAutoReconnect.Checked = ClassSystemConfig.Ins.m_ClsCommon.m_bAutoReconnect;
            cbSaveLog.Checked = ClassSystemConfig.Ins.m_ClsCommon.IsSaveLog_Local;
            cbSaveGraphicImg.Checked = ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgGraphic_Local;
            cbSaveOriginImg.Checked = ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgOKNG_Local;
            cbCheckTimeoutReady.Checked = ClassSystemConfig.Ins.m_ClsCommon.m_bCheckTimeoutReady;
            switch (ClassSystemConfig.Ins.m_ClsCommon.m_iFormatSavingMode)
            {
                case 1: radioJPG.Checked = true; break;
                case 2: radioPNG.Checked = true; break;
                default: radioBMP.Checked = true; break;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
         {
            // Mảng các TextBox
            System.Windows.Forms.TextBox[] textBoxes = new System.Windows.Forms.TextBox[]
            {
                txbRtsp_Cam1,
                txbRtsp_Cam2,
                txbRtsp_Cam3,
                txbRtsp_Cam4,
                txbRtsp_Cam5,
                txbRtsp_Cam6,
                txbRtsp_Cam7,
                txbRtsp_Cam8,
                txbRtsp_Cam9
            };

            // Duyệt qua các TextBox và lấy giá trị, thêm vào danh sách
            ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam.Clear();
            foreach (var textBox in textBoxes)
            {
                string rtspValue = textBox.Text;  // Lấy giá trị từ TextBox
                if (!string.IsNullOrEmpty(rtspValue))  // Kiểm tra nếu không phải là chuỗi rỗng
                {
                    ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam.Add(rtspValue);  // Thêm vào danh sách
                }
            }

            ClassSystemConfig.Ins.m_ClsCommon.m_iPeriodDelete = (int)numericAutoDelete.Value;
            ClassSystemConfig.Ins.m_ClsCommon.m_iTimeBetween2Trigger = (int)numericBetween2Trigger.Value;
            ClassSystemConfig.Ins.m_ClsCommon.m_iTimeoutCheckReady = (int)numericUpDownTimeoutReady.Value;
            ClassSystemConfig.Ins.m_ClsCommon.m_bAutoDeleteImg = cbAutoDeleteImage.Checked;
            ClassSystemConfig.Ins.m_ClsCommon.m_bCheckTimeoutReady = cbCheckTimeoutReady.Checked;

            ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgOKNG_Local = cbSaveOriginImg.Checked;
            ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgGraphic_Local = cbSaveGraphicImg.Checked;
            ClassSystemConfig.Ins.m_ClsCommon.IsSaveLog_Local = cbSaveLog.Checked;
            ClassSystemConfig.Ins.m_ClsCommon.m_bAutoReconnect = cbAutoReconnect.Checked;
            if (radioJPG.Checked)
                ClassSystemConfig.Ins.m_ClsCommon.m_iFormatSavingMode = 1;
            else
                if (radioPNG.Checked)
                    ClassSystemConfig.Ins.m_ClsCommon.m_iFormatSavingMode = 2;
                else
                    ClassSystemConfig.Ins.m_ClsCommon.m_iFormatSavingMode = 0;

            main.SaveDeviceConfig(true);

        }

        #region Header UI
        bool bLastStateNormal = true;
        public void ShowOnScreen()
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = bLastStateNormal ? FormWindowState.Normal : FormWindowState.Maximized;

            this.BringToFront();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                bLastStateNormal = true;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                bLastStateNormal = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void FormVisionSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

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

        private void btnChangeSavingLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDialog = new FolderBrowserDialog();
            if(System.IO.Directory.Exists(ClassSystemConfig.Ins.m_ClsCommon.m_CommonPath))
            {
                fldDialog.SelectedPath = ClassSystemConfig.Ins.m_ClsCommon.m_CommonPath;
            }
            if(fldDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ClassSystemConfig.Ins.m_ClsCommon.m_CommonPath = fldDialog.SelectedPath;
                txbSavingPath.Text = ClassSystemConfig.Ins.m_ClsCommon.m_CommonPath;
            }
        }

        private void btnChangeRecipePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDialog = new FolderBrowserDialog();
            //if (System.IO.Directory.Exists(ClassSystemConfig.Ins.m_ClsCommon.m_strRecipePath))
            //{
            //    fldDialog.SelectedPath = ClassSystemConfig.Ins.m_ClsCommon.m_strRecipePath;
            //}
            //if (fldDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    ClassSystemConfig.Ins.m_ClsCommon.m_strRecipePath = fldDialog.SelectedPath;
            //    txbRecipePath.Text = ClassSystemConfig.Ins.m_ClsCommon.m_strRecipePath;
            //}
        }


        private void radioButtonSystemSetting_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSystemSetting.Checked)
            {
                panelSystemSetting.Visible = true;
                panelSettingIP.Visible = false;
            }
        }

        private void radioButtonIpSetting_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIpSetting.Checked)
            {
                panelSystemSetting.Visible = false;
                panelSettingIP.Visible = true;
            }
        }

        private void cbAutoReconnect_CheckedChanged(object sender, EventArgs e)
        {
            cbCheckTimeoutReady.Enabled = cbAutoReconnect.Checked;
            numericUpDownTimeoutReady.Enabled = cbAutoReconnect.Checked;
        }


    }
}
