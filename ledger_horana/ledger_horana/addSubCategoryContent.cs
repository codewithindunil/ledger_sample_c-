using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ledger_horana
{
    public partial class addSubCategoryContent : UserControl
    {
        ComboBox combobox1 = null;

        public addSubCategoryContent()
        {
       

            InitializeComponent();

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadCategories()
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM ledger_horanadb.categories";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    comboBox1.Items.Add(rd.GetString("cname").ToUpper());

                    Console.WriteLine(rd.GetString("cname"));
                }
                comboBox1.SelectedIndex = 0;

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void addSubCategoryContent_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bool status=new implementActions().addSubCategory(comboBox1.SelectedItem.ToString(),txtCategoryName.Text.ToString());
            if (status == true)
            {
                MessageBox.Show("successfully added");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}
