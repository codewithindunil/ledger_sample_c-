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
    public partial class ledgerMain : UserControl
    {
        public ledgerMain()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ledgerContentCredit item = new ledgerContentCredit();
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ledgerContentDebit item = new ledgerContentDebit();
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ledgerContentEdit item = new ledgerContentEdit();
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
