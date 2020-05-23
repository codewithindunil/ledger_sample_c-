using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public String dt, ct;
         public  String serverPassword="";
        public String serverName = "localhost";
        public String serveruser = "root";
        public bool addCategory(String cname)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='"+serverName+"';database=ledger_horanadb;uid='"+serveruser+"';pwd='"+serverPassword+"';";
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
            String connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            user = "test";
            query = "insert into ledger_horanadb.ledgerdebit ( category,sub_category,invoice_no,invoice_date,invoice_value,paid_value,credited,debited,cash_or_cheque,bnn,user,igeshe,week_no,date_no) values" +
                " ('" + category + "','" + subCategory + "','"+ invoiceNo +"','"+invoiceDate+"','" +invoiceValue +"','" +paidValue +"','"+paidValue+"','"+0+"','" +cOrCheque +"','" +bnn +"','" +user +"','" +igeshe + "','" + weekNum + "','" + dateNum + "')";
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
            updateCreditTotal(paidValue);
            return status;
        }

        public bool addDebit(String category, String subCategory, String invoiceNo, String invoiceDate, double invoiceValue, double paidValue, String cOrCheque, int bnn, String user, double igeshe, String weekNum, String dateNum)
        {
            

            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            user = "test";
            query = "insert into ledger_horanadb.ledgerdebit ( category,sub_category,invoice_no,invoice_date,invoice_value,paid_value,credited,debited,cash_or_cheque,bnn,user,igeshe,week_no,date_no) values" +
                                                               
                " ('" + category + "','" + subCategory + "','" + invoiceNo + "','" + invoiceDate + "','" + invoiceValue + "','" + paidValue + "','"+0+"','"+ paidValue + "','" + cOrCheque + "','" + bnn + "','" + user + "','" + igeshe + "','"+weekNum+"','"+dateNum+"')";
            Console.WriteLine(DateTime.Now);

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                status = true;
                Console.WriteLine("debit call uno");
                conn.Close();
                updateCredit(igeshe.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
                conn.Dispose();
            }

            updateDebitTotal(paidValue);
            return status;
        }

        public bool addSubCategory(String category,String subCategory)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
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
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
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
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
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
                new frmMain(user, privilages).Show();


            }

            return status;
        }

        public void register(String name,String username,String password,String privilages,String addedBy)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
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

        public void saveCheque(string chequeNo, string chequeValue,String credited,String debited, DateTime dueDate, string bankName, string invoiceNo,String dayNo,String weekNo)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into ledger_horanadb.duecheques (  chequeNo,chequeValue,credited,debited,bankName,invoiceId,dueDayNo,dueWeekNo,dueDate) values" +
                " ('" + chequeNo.ToUpper() + "','" + chequeValue.ToUpper() + "','"+credited+"','"+debited+"','" + bankName.ToUpper() + "','"+invoiceNo.ToUpper()+"','"+dayNo+"','"+weekNo+"','" + dueDate.Date + "')";
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
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
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
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
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

        public void checkDuePayements()
        {
            Console.WriteLine("method called");
            var d = DateTime.Now;

            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
            int dateNum = cul.Calendar.GetDayOfYear(d);
            MySqlDataReader rd;
            String user = "", privilages = "";
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "select * from duecheques where dueDayNo = '" + dateNum + "' ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("ekek innwa");
                    count = count + 1;
                    String chequeNo, chequeValue, bankName, invoiceId, dueDayNo, dueWeekNo, enteredDate, credited,debited;

                    chequeNo = rd["chequeNo"].ToString();
                    chequeValue = rd["chequeValue"].ToString();
                    bankName = rd["bankName"].ToString();
                    invoiceId = rd["invoiceId"].ToString();
                    dueDayNo = rd["dueDayNo"].ToString();
                    dueWeekNo = rd["dueWeekNo"].ToString();
                    chequeValue = rd["chequeValue"].ToString();
                    enteredDate = rd["enteredDate"].ToString();
                    credited = rd["credited"].ToString();
                    debited = rd["debited"].ToString();

                    if (Double.Parse(debited)>0 )
                    {
                        Console.WriteLine("debited");
                        addDebit("CHEQUE", bankName, invoiceId, enteredDate, Double.Parse(chequeValue), Double.Parse(chequeValue), "CHEQUE", 0, "", 0, weekNum.ToString(), dateNum.ToString());

                    }
                    else
                    {
                        Console.WriteLine("credited");

                        addCredit("CHEQUE", bankName, invoiceId, enteredDate, Double.Parse(chequeValue), Double.Parse(chequeValue), "CHEQUE", 0, "", 0, weekNum.ToString(), dateNum.ToString());

                    }


                }


              
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            deleteUpdatedDueCheques();
        }

        public void updateDebitTotal(Double val)
        {
            var d = DateTime.Now;

            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
            int dateNum = cul.Calendar.GetDayOfYear(d);

            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "update ledger_horanadb.dailyTotal set debitTotal = debitTotal +'" + val + "' where dateNo='"+dateNum+"' ";
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

            //viewDailyTotal();
        }

        public void setDailyTotalIfNotSet()
        {

            var d = DateTime.Now;

            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
            int dateNum = cul.Calendar.GetDayOfYear(d);
            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            

            query = "select * from dailyTotal where dateNo='" + dateNum + "'";
            String query2 = "insert into ledger_horanadb.dailyTotal (  dateNo	,wekNo	,monthNo	,creditTotal	,debitTotal) values" +
             " ('" + dateNum + "','" + weekNum + "','" + sMonth + "','" + 0 + "','" + 0 + "')";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    count = count + 1;

                }
                conn.Close();
                if (count == 0)
                {
                    MySqlCommand command2 = new MySqlCommand(query2, conn);

                    try
                    {
                        conn.Open();
                        rd = command2.ExecuteReader();
                        status = true;
                        


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    conn.Close();
                }


            }   catch(Exception e)
            {
                Console.WriteLine(e);
            }

               
        }
        public void updateCreditTotal(Double val)
        {
            var d = DateTime.Now;

            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
            int dateNum = cul.Calendar.GetDayOfYear(d);

            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "update ledger_horanadb.dailyTotal set creditTotal = creditTotal +'" + val + "' where dateNo='" + dateNum + "' ";
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

            //viewDailyTotal();
        }

        public void deleteUpdatedDueCheques()
        {
            var d = DateTime.Now;

            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
            int dateNum = cul.Calendar.GetDayOfYear(d);

            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword+"';";
            conn = new MySqlConnection(connetionString);
            conn.Open();
            try
            {
                MySqlCommand deletecmd = new MySqlCommand("delete from duecheques where dueDayNo = '" + dateNum + "'", conn);
                deletecmd.ExecuteNonQuery();
                Console.WriteLine(dateNum + "cheque deleted");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void viewDailyTotal()
        {
            var d = DateTime.Now;

            CultureInfo cul = CultureInfo.CurrentCulture;
            String serverName = new implementActions().serverName;
            String serveruser = new implementActions().serveruser;
            String serverPassword = new implementActions().serverPassword;

            int dateNum = cul.Calendar.GetDayOfYear(d);
            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ledger_horanadb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "select * from dailyTotal where dateNo='" + dateNum + "'";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                     this.dt = rd["debitTotal"].ToString();
                     this.ct = rd["creditTotal"].ToString();
                    frmMain.ActiveForm.Controls["lblDebit"].Text = dt;
                    Console.WriteLine(dt);
                    Console.WriteLine(ct);
                    


                }
                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
