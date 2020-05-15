using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace ledger_horana
{
    public partial class chechDueCheckesView : UserControl
    {
        public chechDueCheckesView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            checkDueChequesDaily();
        }

        public void checkDueChequesDaily()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            String serverPassword = new implementActions().serverPassword;
            String serverName = new implementActions().serverName;
            String serveruser = new implementActions().serveruser;
            var d =dateTimePicker1.Value;

            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
            int dateNum = cul.Calendar.GetDayOfYear(d);
            MySqlDataReader rd;
            MySqlConnection conn;
            MySqlDataAdapter adapter;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            int count=0;
            String checkNo, checkVal, bankName, invoiceNo, cod,credited,debited;
            Console.WriteLine("queryta kalin");
            query = "select * from duecheques where dueDayNo = '" + dateNum + "' ";
            Console.WriteLine("queryta passe");
            try
            {
                Console.WriteLine("querya thule");

                conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);
                    rd = command.ExecuteReader();
                dataGridView1.Columns.Add("asd","Cheque No");

                dataGridView1.Columns.Add("asd","Cheque Amount");
               
                dataGridView1.Columns.Add("asd","Bank");
                dataGridView1.Columns.Add("asd","Invoice No");
                dataGridView1.Columns.Add("asd","Credit or Debit");
                dataGridView1.Columns[0].Width = 160;
                dataGridView1.Columns[1].Width = 160;
                dataGridView1.Columns[2].Width = 160;
                dataGridView1.Columns[3].Width = 160;
                dataGridView1.Columns[4].Width = 160;

                while (rd.Read())
                {
                    Console.WriteLine("read eka athuke");

                    checkNo = rd["chequeNo"].ToString();
                    checkVal = rd["chequeValue"].ToString();
                    bankName = rd["bankName"].ToString();
                    invoiceNo = rd["invoiceId"].ToString();
                    credited = rd["credited"].ToString();
                    debited = rd["debited"].ToString();

                    
                    if (debited == "")
                    {
                        cod = "D";
                    }
                    else
                    {
                        cod = "C";
                    }
                    count = count + 1;
                    DataTable dt = new DataTable();
                    dt = (DataTable)dataGridView1.DataSource;
                    
                    string[] row = { checkNo, checkVal,bankName,invoiceNo,cod };
                    dataGridView1.Rows.Add(row);

                }
                conn.Close();

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

         }
        public void checkDueChequesWeekly()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            String serverPassword = new implementActions().serverPassword;
            String serverName = new implementActions().serverName;
            String serveruser = new implementActions().serveruser;
            var d = dateTimePicker1.Value;

            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
            //int dateNum = cul.Calendar.GetDayOfYear(d);
            MySqlDataReader rd;
            MySqlConnection conn;
            MySqlDataAdapter adapter;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            int count = 0;
            String checkNo, checkVal, bankName, invoiceNo, cod, credited, debited;
            Console.WriteLine("queryta kalin");
            query = "select * from duecheques where dueWeekNo = '" + weekNum + "' ";
            Console.WriteLine("queryta passe");
            try
            {
                Console.WriteLine("querya thule");

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                dataGridView1.Columns.Add("asd", "Cheque No");

                dataGridView1.Columns.Add("asd", "Cheque Amount");

                dataGridView1.Columns.Add("asd", "Bank");
                dataGridView1.Columns.Add("asd", "Invoice No");
                dataGridView1.Columns.Add("asd", "Credit or Debit");
                dataGridView1.Columns[0].Width = 160;
                dataGridView1.Columns[1].Width = 160;
                dataGridView1.Columns[2].Width = 160;
                dataGridView1.Columns[3].Width = 160;
                dataGridView1.Columns[4].Width = 160;

                while (rd.Read())
                {
                    Console.WriteLine("read eka athuke");

                    checkNo = rd["chequeNo"].ToString();
                    checkVal = rd["chequeValue"].ToString();
                    bankName = rd["bankName"].ToString();
                    invoiceNo = rd["invoiceId"].ToString();
                    credited = rd["credited"].ToString();
                    debited = rd["debited"].ToString();


                    if (debited == "")
                    {
                        cod = "D";
                    }
                    else
                    {
                        cod = "C";
                    }
                    count = count + 1;
                    DataTable dt = new DataTable();
                    dt = (DataTable)dataGridView1.DataSource;

                    string[] row = { checkNo, checkVal, bankName, invoiceNo, cod };
                    dataGridView1.Rows.Add(row);

                }
                conn.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            checkDueChequesWeekly();
        }
    }
}
