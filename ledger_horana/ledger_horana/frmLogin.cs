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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //new implementActions().updateDebitTotal(100);
            bool status = new implementActions().Login(txtUserName.Text.ToString(), txtPassword.Text.ToString());
            txtUserName.Text = "";
            txtPassword.Text = "";

            if (status == true)
            {
                this.Hide();
            }

            //new implementActions().checkDuePayements();


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            new implementActions().checkDuePayements();
            new implementActions().setDailyTotalIfNotSet();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
