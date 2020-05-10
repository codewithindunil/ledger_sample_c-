using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledger_horana
{
    class implementActions : actions
    {
        bool status = false;
        int count;
        String serverPassword="";
        public bool addCategory(String cname)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd="+serverPassword+";";
            conn = new MySqlConnection(connetionString);
            String query;
            String user = "test";
            query = "insert into ledger_horanadb.categories ( cname,date, user) values" +
                " ('" + cname + "','" +  DateTime.Now.ToString() + "','" + user + "')";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
            return status;
        }

        public bool addCredit(String category,String subCategory,String invoiceNo,String invoiceDate,double invoiceValue,double paidValue,String cOrCheque,int bnn,String user,double igeshe, String weekNum, String dateNum)
        {


            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            user = "test";
            query = "insert into ledger_horanadb.ledgercredit ( category,sub_category,invoice_no,invoice_date,invoice_value,paid_value,cash_or_cheque,bnn,user,igeshe,week_no,date_no) values" +
                " ('" + category + "','" + subCategory + "','"+ invoiceNo +"','"+invoiceDate+"','" +invoiceValue +"','" +paidValue +"','" +cOrCheque +"','" +bnn +"','" +user +"','" +igeshe + "','" + weekNum + "','" + dateNum + "')";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
                updateCredit(igeshe.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
            return status;
        }

        public bool addDebit(String category, String subCategory, String invoiceNo, String invoiceDate, double invoiceValue, double paidValue, String cOrCheque, int bnn, String user, double igeshe, String weekNum, String dateNum)
        {

            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            user = "test";
            query = "insert into ledger_horanadb.ledgerdebit ( category,sub_category,invoice_no,invoice_date,invoice_value,paid_value,cash_or_cheque,bnn,user,igeshe,week_no,date_no) values" +
                                                               
                " ('" + category + "','" + subCategory + "','" + invoiceNo + "','" + invoiceDate + "','" + invoiceValue + "','" + paidValue + "','" + cOrCheque + "','" + bnn + "','" + user + "','" + igeshe + "','"+weekNum+"','"+dateNum+"')";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
                updateCredit(igeshe.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
            return status;
        }

        public bool addSubCategory(String category,String subCategory)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            String user = "test";
            query = "insert into ledger_horanadb.subcategories ( cname,sname,date, user) values" +
                " ('" + category.ToUpper() + "','"+subCategory.ToUpper()+"','" + DateTime.Now.ToString() + "','" + user + "')";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
            return status;
        }

        public void editCredit()
        {
            throw new NotImplementedException();
        }

        public void editDebit()
        {
            throw new NotImplementedException();
        }

        public void editSubCategory()
        {
            throw new NotImplementedException();
        }

        public void getAdminAccess()
        {
            throw new NotImplementedException();
        }

        public string getCreditFinal()
        {
            MySqlDataReader rd;
            String creditVal="";
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "select * from ledger_horanadb.creditigeshe ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    creditVal = rd["credit"].ToString();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return creditVal;
        }

        public bool Login(String username, String password)
        {
            MySqlDataReader rd;
            String user="", privilages="";
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "select * from users where username = '" + username.ToUpper() + "' and password ='" + password.ToUpper() + "'";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    count = count + 1;
                    user = rd["username"].ToString();
                    privilages = rd["privilages"].ToString();
                }
                if (count == 1)
                {
                    status = true;
                }
                else
                {
                    status = false;
                    MessageBox.Show("Please Enter a Valid Userame & Password");
                    Console.WriteLine("wrong");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            if (status == true)
            {
                new frmMain(user,privilages).Show();


            }

            return status;
        }

        public void register(String name,String username,String password,String privilages,String addedBy)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            String user = "test";
            query = "insert into ledger_horanadb.users (  name,username,password,privilages,addedBy) values" +
                " ('" + name.ToUpper() + "','" + username.ToUpper() + "','" + password.ToUpper() + "','" + privilages + "','" + addedBy.ToUpper() + "')";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
                MessageBox.Show("success");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
        }

        public void saveCheque(string chequeNo, string chequeValue, DateTime dueDate, string bankName, string invoiceNo,String dayNo,String weekNo)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            String user = "test";
            query = "insert into ledger_horanadb.duecheques (  chequeNo,chequeValue,bankName,invoiceId,dueDayNo,dueWeekNo,dueDate) values" +
                " ('" + chequeNo.ToUpper() + "','" + chequeValue.ToUpper() + "','" + bankName.ToUpper() + "','"+invoiceNo.ToUpper()+"','"+dayNo+"','"+weekNo+"','" + dueDate.Date + "')";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);
            
            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
                MessageBox.Show("success");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
        }

        public bool saveDueCheques()
        {
            throw new NotImplementedException();
        }

        public bool updateCredit(String creditNew)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            String user = "test";
            query = "update ledger_horanadb.creditigeshe set credit = '"+creditNew+"' where id=2 ";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
            return true;
            
        }
        public bool updateDebit(String debitNew)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=ledger_horanadb;uid=root;pwd=" + serverPassword + ";;";
            conn = new MySqlConnection(connetionString);
            String query;
            String user = "test";
            query = "update ledger_horanadb.creditigeshe set debit = '" + debitNew + "' where id=2 ";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }
            return true;

        }

    }
}
