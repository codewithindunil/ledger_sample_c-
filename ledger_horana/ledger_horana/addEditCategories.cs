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
    public partial class addEditCategories : UserControl
    {
        public addEditCategories()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addCategoryContent item = new addCategoryContent();
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            addSubCategoryContent item = new addSubCategoryContent();
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            editSubCategoryContent item = new editSubCategoryContent();
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
           

        }
    }
}
