namespace Vezzeta
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInsert = new System.Windows.Forms.GroupBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.grpSelectOne = new System.Windows.Forms.GroupBox();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.btnFindDoctor = new System.Windows.Forms.Button();
            this.grpSelectMultiple = new System.Windows.Forms.GroupBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.btnSearchSpecialty = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpInsert.SuspendLayout();
            this.grpSelectOne.SuspendLayout();
            this.grpSelectMultiple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(347, 30);
            this.lblTitle.Text = "Connected Mode (Patients & Docs)";

            // grpInsert (Abanob's Task)
            this.grpInsert.Controls.Add(this.btnAddPatient);
            this.grpInsert.Controls.Add(this.txtPhone);
            this.grpInsert.Controls.Add(this.txtPatientName);
            this.grpInsert.Location = new System.Drawing.Point(25, 70);
            this.grpInsert.Name = "grpInsert";
            this.grpInsert.Size = new System.Drawing.Size(250, 150);
            this.grpInsert.Text = "1. Add Patient (Insert)";

            this.txtPatientName.Location = new System.Drawing.Point(15, 30);
            this.txtPatientName.Text = "Patient Name";
            this.txtPatientName.Size = new System.Drawing.Size(215, 20);

            this.txtPhone.Location = new System.Drawing.Point(15, 70);
            this.txtPhone.Text = "Phone Number";
            this.txtPhone.Size = new System.Drawing.Size(215, 20);

            this.btnAddPatient.Location = new System.Drawing.Point(15, 110);
            this.btnAddPatient.Size = new System.Drawing.Size(215, 30);
            this.btnAddPatient.Text = "Insert Record";

            // grpSelectOne (Kirolos's Task - One Row)
            this.grpSelectOne.Controls.Add(this.btnFindDoctor);
            this.grpSelectOne.Controls.Add(this.txtDoctorId);
            this.grpSelectOne.Location = new System.Drawing.Point(300, 70);
            this.grpSelectOne.Name = "grpSelectOne";
            this.grpSelectOne.Size = new System.Drawing.Size(200, 150);
            this.grpSelectOne.Text = "2. Find Doctor (Select One)";

            this.txtDoctorId.Location = new System.Drawing.Point(15, 30);
            this.txtDoctorId.Text = "Enter Doctor ID";
            this.txtDoctorId.Size = new System.Drawing.Size(170, 20);

            this.btnFindDoctor.Location = new System.Drawing.Point(15, 110);
            this.btnFindDoctor.Size = new System.Drawing.Size(170, 30);
            this.btnFindDoctor.Text = "Find (Stored Proc)";

            // grpSelectMultiple (Kirolos/Abanob Task - Multiple Rows)
            this.grpSelectMultiple.Controls.Add(this.btnSearchSpecialty);
            this.grpSelectMultiple.Controls.Add(this.txtSpecialty);
            this.grpSelectMultiple.Location = new System.Drawing.Point(525, 70);
            this.grpSelectMultiple.Name = "grpSelectMultiple";
            this.grpSelectMultiple.Size = new System.Drawing.Size(200, 150);
            this.grpSelectMultiple.Text = "3. Search (Select Multiple)";

            this.txtSpecialty.Location = new System.Drawing.Point(15, 30);
            this.txtSpecialty.Text = "Enter Specialty ID";
            this.txtSpecialty.Size = new System.Drawing.Size(170, 20);

            this.btnSearchSpecialty.Location = new System.Drawing.Point(15, 110);
            this.btnSearchSpecialty.Size = new System.Drawing.Size(170, 30);
            this.btnSearchSpecialty.Text = "Search Details";

            // dataGridView1 (Results Table)
            this.dataGridView1.Location = new System.Drawing.Point(25, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 250);

            // Form1 Layout
            this.ClientSize = new System.Drawing.Size(750, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpSelectMultiple);
            this.Controls.Add(this.grpSelectOne);
            this.Controls.Add(this.grpInsert);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form 1 - Connected Mode";
            this.BackColor = System.Drawing.Color.White;

            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();
            this.grpSelectOne.ResumeLayout(false);
            this.grpSelectOne.PerformLayout();
            this.grpSelectMultiple.ResumeLayout(false);
            this.grpSelectMultiple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInsert;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.GroupBox grpSelectOne;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Button btnFindDoctor;
        private System.Windows.Forms.GroupBox grpSelectMultiple;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Button btnSearchSpecialty;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}