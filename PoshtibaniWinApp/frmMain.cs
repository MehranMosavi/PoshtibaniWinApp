using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoshtibaniWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlSide.Visible = false;

            
        }

        private void btnMenuMan_Click(object sender, EventArgs e)
        {
            allButClick();
            pnlSide.Height = btnMenuMan.Height;
            pnlSide.Top = btnMenuMan.Top;
            pnlMain.Controls.Add(new UC.uc_MenuManager());
        }

        private void btnSalaryMan_Click(object sender, EventArgs e)
        {
            allButClick();
            pnlSide.Height = btnSalaryMan.Height;
            pnlSide.Top = btnSalaryMan.Top;
        }

        private void btnReportMan_Click(object sender, EventArgs e)
        {
            allButClick();
            pnlSide.Height = btnReportMan.Height;
            pnlSide.Top = btnReportMan.Top;
        }

        private void btnMenuEmp_Click(object sender, EventArgs e)
        {
            allButClick();
            pnlSide.Height = btnMenuEmp.Height;
            pnlSide.Top = btnMenuEmp.Top;
        }

        private void btnReportEmp_Click(object sender, EventArgs e)
        {
            allButClick();
            pnlSide.Height = btnReportEmp.Height;
            pnlSide.Top = btnReportEmp.Top;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlSide.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        #region ButtonsChangeColor
        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = PoshtibaniWinApp.Properties.Resources.CloseDown;
        }

        private void btnClose_MouseUp(object sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = PoshtibaniWinApp.Properties.Resources.Close;
        }

        private void btnSetting_MouseDown(object sender, MouseEventArgs e)
        {
            btnSetting.BackgroundImage = PoshtibaniWinApp.Properties.Resources.SettingDown;
        }

        private void btnSetting_MouseUp(object sender, MouseEventArgs e)
        {
            btnSetting.BackgroundImage = PoshtibaniWinApp.Properties.Resources.Setting;
        }

        #endregion

        void allButClick()
        {
            pnlSide.Visible = true;
            pnlMain.Controls.Clear();
        }

        public void reloadPnl()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UC.uc_MenuManager());
        }
    }
}
