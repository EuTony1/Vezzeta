using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client; 
namespace Vezzeta
{
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();

            
            btnLoadData.Click += new EventHandler(btnLoadData_Click);
            btnSaveChanges.Click += new EventHandler(btnSaveChanges_Click);
        }

        
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string cmdstr = "SELECT * FROM Appointments";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("id", txtFilterValue.Text);

            ds = new DataSet();
            adapter.Fill(ds, "Appointments");

            dataGridView2.DataSource = ds.Tables[0];
        }

   
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (adapter != null && ds != null)
            {
                
                builder = new OracleCommandBuilder(adapter);

            
                adapter.Update(ds.Tables[0]);

                MessageBox.Show("Database successfully updated!");
            }
            else
            {
                MessageBox.Show("Please load data first before saving.");
            }
        }

        private void btnLoadData_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtFilterValue.Text, out _))
            {
                string cmdstr = "SELECT * FROM Appointments WHERE Patient_ID = :id";

                adapter = new OracleDataAdapter(cmdstr, ordb);
                adapter.SelectCommand.Parameters.Add("id", txtFilterValue.Text);

                ds = new DataSet();
                adapter.Fill(ds, "Appointments");

                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
               
                MessageBox.Show("Please enter a valid numeric Patient ID before searching.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
    }
}   