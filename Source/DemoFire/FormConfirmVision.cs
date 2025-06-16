using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKVN
{
    public partial class FormConfirmVision : Form
    {
        public int Cam_col = 0;
        public int Cam_row = 0;

        public FormConfirmVision()
        {
            InitializeComponent();
        }

        public void InitializeUI(int row, int col)
        {
            IsConfirmCompleted = false;

            Cam_col = col;
            Cam_row = row;
        }

        public bool IsConfirmCompleted = false;
        public int RESULT_CONFIRM = 0;
        private void btnNG_Click(object sender, EventArgs e)
        {
            IsConfirmCompleted = true;
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            IsConfirmCompleted = true;
            ClassSystemConfig.Ins.m_UserDisplay[Cam_col][Cam_row].Ignore_Warning();
            this.Hide();
        }

        private void FormConfirmVision_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
