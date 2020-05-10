using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledger_horana
{
    public partial class frmCheque : Form
    {
        String amount;
        String invoiceNo;
        public frmCheque(String amount,String invoiceNo)
        {
            this.amount = amount;
            this.invoiceNo = invoiceNo;
            InitializeComponent();

        }

        private void frmCheque_Load(object sender, EventArgs e)
        {
            lblInvoiceNo.Text = invoiceNo;
            txtAmount.Text = amount.ToString();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            var d = dateTimePicker1.Value.Date;
           
            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);

            int dateNum = cul.Calendar.GetDayOfYear(d);
            //MessageBox.Show(weekNum.ToString());

            //MessageBox.Show(dateTimePicker1.Value.Date.ToString());
            new implementActions().saveCheque(txtChequeNo.Text, txtAmount.Text, dateTimePicker1.Value.Date, txtBank.Text, lblInvoiceNo.Text, dateNum.ToString(), weekNum.ToString());
        }
    }
}
