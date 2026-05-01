using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace Vezzeta
{
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();

          
            btnAddPatient.Click += new EventHandler(btnAddPatient_Click);
            btnFindDoctor.Click += new EventHandler(btnFindDoctor_Click);
            btnSearchSpecialty.Click += new EventHandler(btnSearchSpecialty_Click);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            conn = new OracleConnection(ordb);
            conn.Open(); 
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            conn.Dispose(); 
        }

       
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Patients (Patient_ID, Patient_Name, Patient_Phone) VALUES (patient_seq.nextval, :name, :phone)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("name", txtPatientName.Text);
            cmd.Parameters.Add("phone", txtPhone.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Patient Added Successfully!");
            }
        }

        private void btnFindDoctor_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetDoctorFee"; 
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("doc_id", txtDoctorId.Text);

         
            cmd.Parameters.Add("doc_fee", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            try
            {
                MessageBox.Show("Doctor Consultation Fee is: " + cmd.Parameters["doc_fee"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Doctor not found.");
            }
        }

        
        private void btnSearchSpecialty_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetDoctorsBySpecialty"; 
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("spec_id", txtSpecialty.Text);
            cmd.Parameters.Add("docs", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
        }

        private void btnFindDoctor_Click_1(object sender, EventArgs e)
        {

        }
    }
}