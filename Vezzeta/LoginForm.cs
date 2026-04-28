using System;
using System.Windows.Forms;

namespace Vezzeta
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            // This tells the form to read the Designer.cs file to build the UI
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                MainForm mainDashboard = new MainForm();
                mainDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}