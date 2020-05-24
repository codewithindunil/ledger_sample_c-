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
    public partial class frmAdmin : Form
    {
        String user;
        public frmAdmin(String user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String name, username,password,privilages,addedBy;
            name = txtame.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;
            //addedBy = new frmMain().getUser();
            addedBy = user;
            if (bunifuSwitch1.Value == true)
            {
                privilages = "1";
            }
            else
            {
                privilages = "2";
            }

            new implementActions().register(name, username, password, privilages, addedBy);
        }
    }
}
