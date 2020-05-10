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
    public partial class addCategoryContent : UserControl
    {
        public addCategoryContent()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bool status = new implementActions().addCategory(txtCategoryName.Text.ToString());
            if (status == true)
            {
                MessageBox.Show("Added Succcesfully");
            }
            else
            {
                MessageBox.Show("fail");
            }
        }
    }
}
