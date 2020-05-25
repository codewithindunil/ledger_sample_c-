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
            //if (bunifuDropdown3.selectedValue.ToString() == "CHEQUE")
            //{
            //    new frmCheque(txtInvoiceValue.Text, txtInvoiceNo.Text,"").Show();
            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSubCategories(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadCategories()
        {
            MySqlDataReader rd;
            String serverPassqord = new implementActions().serverPassword;
            String serveruser = new implementActions().serveruser;
            String serverName = new implementActions().serverName;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassqord + "';";
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

                    //Console.WriteLine(rd.GetString("cname"));
                }
                comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void loadSubCategories(String categ)
        {
            MySqlDataReader rd;
            String serverPassqord = new implementActions().serverPassword;
            String serverName = new implementActions().serverName;
            String serveruser = new implementActions().serveruser;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassqord + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM ledger_horanadb.subcategories where cname = '" + categ + "'";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                comboBox2.Items.Clear();
                while (rd.Read())
                {
                    comboBox2.Items.Add(rd.GetString("sname").ToUpper());

                    //Console.WriteLine(rd.GetString("sname"));
                }
                comboBox2.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void ledgerContentEdit_Load(object sender, EventArgs e)
        {
            loadCategories();
        }


        public void getInvoice(String invoiceNo)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            String serverName = new implementActions().serverName;
            String serveruser = new implementActions().serveruser;
            String serverPassword = new implementActions().serverPassword;

            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "select * from ledgerdebit where invoice_no='" + invoiceNo + "'";


            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    txtBmn.Text = rd["bnn"].ToString();
                    bunifuMetroTextbox1.Text = rd["invoice_no"].ToString();
                    txtInvoiceValue.Text = rd["invoice_value"].ToString();
                    txtPaidAmount.Text = rd["paid_value"].ToString();

                }
                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            getInvoice(txtInvoiceNo.Text);
        }

        public void deleteInvoice(String invoiceNo)
        {

            MySqlDataReader rd;
            String serverName = new implementActions().serverName;
            String serveruser = new implementActions().serveruser;
            String serverPassword = new implementActions().serverPassword;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            conn.Open();
            try
            {
                MySqlCommand deletecmd = new MySqlCommand("delete from ledgerdebit where invoice_no = '" + invoiceNo + "'", conn);
                deletecmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string message = "Do you want logout ?";
            string title = "logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                deleteInvoice(txtInvoiceNo.Text);
                clearForm();
            }
            else
            {
                // Do something  
            }

        }

        public void clearForm()
        {

            txtBmn.Text = "";
            txtInvoiceNo.Text = "";
            txtInvoiceValue.Text = "";
            txtPaidAmount.Text = "";
            bunifuMetroTextbox1.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
