using System;
using System.Windows.Forms;

namespace Vezzeta
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void form1MenuItem_Click(object sender, EventArgs e)
        {
   
            Form1 f1 = new Form1();
            f1.Show();
        }

        
        private void form2MenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void report1MenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Report 1 (Grouped & Summarized) will open here.");
        }

        
        private void report2MenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Report 2 (Parameters) will open here.");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reportsMenu_Click(object sender, EventArgs e)
        {

        }
    }
}