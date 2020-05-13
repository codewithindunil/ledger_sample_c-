using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledger_horana
{
    public partial class frmVoucherPrint : Form
    {
        String user, invoicenNo, amount, coc, date, subcategory;
        public frmVoucherPrint(String user,String invoiceNo,String amount,String coc,String date,String subCategory)
        {
            this.user = user;
            this.invoicenNo = invoiceNo;
            this.amount = amount;
            this.coc = coc;
            this.subcategory = subCategory;

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
