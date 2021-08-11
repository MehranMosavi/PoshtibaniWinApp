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
    public partial class frm_Movafagh : Form
    {
        public frm_Movafagh()
        {
            InitializeComponent();
        }

        private void frm_Movafagh_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
