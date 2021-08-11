using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoshtibaniWinApp.UC
{
    public partial class uc_MenuManager : UserControl
    {
        public uc_MenuManager()
        {
            InitializeComponent();
        }

        private void Uc_MenuManager_Load(object sender, EventArgs e)
        {
            loadClass();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            PoshtibaniWinApp.Forms.frm_DaryaftTankhahAzMali frm = new Forms.frm_DaryaftTankhahAzMali();
            frm.ShowDialog();
            loadClass();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            PoshtibaniWinApp.Forms.frm_OdatTankhahBeMali frm = new Forms.frm_OdatTankhahBeMali();
            frm.ShowDialog();
            loadClass();
        }

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            PoshtibaniWinApp.Forms.frm_TozieTankhahBeKarshenasan frm = new Forms.frm_TozieTankhahBeKarshenasan();
            frm.ShowDialog();
            loadClass();
        }

        private void btnReturnEmp_Click(object sender, EventArgs e)
        {
            PoshtibaniWinApp.Forms.frm_OdatTankhahAzKarshenasan frm = new Forms.frm_OdatTankhahAzKarshenasan();
            frm.ShowDialog();
            loadClass();
        }

        public void loadClass()
        {
            Fund fund = new Fund();
            lbl_R_Vahed.Text = fund.Daryaft(0).ToString("N0");
            lbl_R_Khorram.Text = fund.Daryaft(1).ToString("N0");
            lbl_R_Salimi.Text = fund.Daryaft(2).ToString("N0");
            lbl_R_Maheri.Text = fund.Daryaft(3).ToString("N0");
            lbl_R_Bagheri.Text = fund.Daryaft(4).ToString("N0");
            lbl_R_Mosavi.Text = fund.Daryaft(5).ToString("N0");
            lbl_R_Jam.Text = fund.Jam().ToString("N0");

            lbl_S_Vahed.Text = fund.Jam().ToString("N0");
        }
    }
}
