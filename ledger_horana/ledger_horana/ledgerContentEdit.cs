using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledger_horana
{
    public partial class ledgerContentEdit : UserControl
    {
        public ledgerContentEdit()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdown3.selectedValue.ToString() == "CHEQUE")
            {
                new frmCheque(txtInvoiceValue.Text, txtInvoiceNo.Text).Show();
            }
        }
    }
}
