using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Vezzeta
{
    public partial class ReportForm2 : Form
    {
        ReportDocument rep2;

        public ReportForm2()
        {
            InitializeComponent();
        }

        private void ReportForm2_Load(object sender, EventArgs e)
        {
            rep2 = new ReportDocument();

            rep2.Load(@"CrystalReport2.rpt");

            crystalReportViewer1.ReportSource = rep2;
        }
    }
}