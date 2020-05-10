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
            bool status = new implementActions().Login(txtUserName.Text.ToString(), txtPassword.Text.ToString());
            txtUserName.Text = ""; 
                txtPassword.Text = "";

            if (status == true)
            {
                this.Hide();
            }
            
            //if (status == true)
            //{
            //new frmMain().Show();
            //}
            //else
            //{
            //    MessageBox.Show("invalid");
            //}

        }
    }
}
