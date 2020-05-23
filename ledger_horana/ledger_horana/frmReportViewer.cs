using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledger_horana
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Hide();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDaily rd = new ReportDaily();
            rd.SetParameterValue("startDateIndex","2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = dateTimePicker1.Value;
            

            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekNum = cul.Calendar.GetWeekOfYear(
                 d,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Monday);
            int dateNum = cul.Calendar.GetDayOfYear(d);
            Console.WriteLine(dateNum);

            ReportDaily rd = new ReportDaily();
            rd.SetParameterValue("startDateIndex",dateNum.ToString());
            
            crystalReportViewer1.ReportSource = rd;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Show();

            Console.WriteLine("refreshed");




        }
    }
}
