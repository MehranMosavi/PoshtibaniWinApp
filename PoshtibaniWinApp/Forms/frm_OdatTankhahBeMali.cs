using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoshtibaniWinApp.Forms
{
    public partial class frm_OdatTankhahBeMali : Form
    {
        public frm_OdatTankhahBeMali()
        {
            InitializeComponent();
            string txt = txtMablagh.Text;
        }
        private void Frm_OdatTankhahBeMali_Load(object sender, EventArgs e)
        {
            lblTozihat.Visible = false;
            txtTozihat.Visible = false;
            comElat.SelectedText = "لطفا یکی را انتخاب کنید";
        }

        private void comElat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comElat.SelectedItem.ToString() == "سایر")
            {
                lblTozihat.Visible = true;
                txtTozihat.Visible = true;
            }
            else
            {
                lblTozihat.Visible = false;
                txtTozihat.Visible = false;
            }
        }

        private void txtMablagh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            string tozi = null;
            string textBoxResult = txtMablagh.Text.Replace(",", "");
            if (txtMablagh.Text == "")
            {
                MessageBox.Show("لطفاً مبلغ را وارد کنید.", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comElat.SelectedItem == null)
            {
                MessageBox.Show("لطفاً توضیحات را وارد کنید.", "ارور", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comElat.SelectedItem.ToString() == "سایر")
                {
                    tozi = "سایر: " + txtTozihat.Text;
                }
                else
                {
                    tozi = comElat.SelectedItem.ToString();
                }


                Fund fund = new Fund();
                fund.sabtDaryafit(Convert.ToInt64(textBoxResult) * -1, lblTitle.Text, tozi, 0);

                frm_Movafagh frm = new frm_Movafagh();
                frm.BringToFront();
                frm.ShowDialog();

                Close();
            }

        }

        private void TxtMablagh_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMablagh.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                long valueBefore = long.Parse(txtMablagh.Text, System.Globalization.NumberStyles.AllowThousands);
                txtMablagh.Text = String.Format(culture, "{0:N0}", valueBefore);
                txtMablagh.Select(txtMablagh.Text.Length, 0);
            }
        }
    }
}
