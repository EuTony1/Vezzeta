using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine; 
namespace Vezzeta
{
    public partial class ReportForm1 : Form
    {
        
        ReportDocument rep2;

        public ReportForm1()
        {
            InitializeComponent();
        }

        private void ReportForm1_Load(object sender, EventArgs e)
        {
            rep2 = new ReportDocument();

            
            rep2.Load(@"CrystalReport1.rpt");

            crystalReportViewer1.ReportSource = rep2;
        }
    }
}