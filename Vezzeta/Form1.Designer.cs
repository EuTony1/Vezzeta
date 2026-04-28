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
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.grpSelectOne = new System.Windows.Forms.GroupBox();
            this.btnFindDoctor = new System.Windows.Forms.Button();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.grpSelectMultiple = new System.Windows.Forms.GroupBox();
            this.btnSearchSpecialty = new System.Windows.Forms.Button();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpInsert.SuspendLayout();
            this.grpSelectOne.SuspendLayout();
            this.grpSelectMultiple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(358, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Connected Mode (Patients & Docs)";
            // 
            // grpInsert
            // 
            this.grpInsert.Controls.Add(this.btnAddPatient);
            this.grpInsert.Controls.Add(this.txtPhone);
            this.grpInsert.Controls.Add(this.txtPatientName);
            this.grpInsert.Location = new System.Drawing.Point(25, 70);
            this.grpInsert.Name = "grpInsert";
            this.grpInsert.Size = new System.Drawing.Size(250, 150);
            this.grpInsert.TabIndex = 3;
            this.grpInsert.TabStop = false;
            this.grpInsert.Text = "1. Add Patient (Insert)";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(15, 110);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(215, 30);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Insert Record";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(15, 70);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(215, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Text = "Phone Number";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPatientName.Location = new System.Drawing.Point(15, 30);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(215, 20);
            this.txtPatientName.TabIndex = 2;
            this.txtPatientName.Text = "Patient Name";
            // 
            // grpSelectOne
            // 
            this.grpSelectOne.Controls.Add(this.btnFindDoctor);
            this.grpSelectOne.Controls.Add(this.txtDoctorId);
            this.grpSelectOne.Location = new System.Drawing.Point(300, 70);
            this.grpSelectOne.Name = "grpSelectOne";
            this.grpSelectOne.Size = new System.Drawing.Size(200, 150);
            this.grpSelectOne.TabIndex = 2;
            this.grpSelectOne.TabStop = false;
            this.grpSelectOne.Text = "2. Find Doctor (Select One)";
            // 
            // btnFindDoctor
            // 
            this.btnFindDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnFindDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDoctor.ForeColor = System.Drawing.Color.White;
            this.btnFindDoctor.Location = new System.Drawing.Point(15, 110);
            this.btnFindDoctor.Name = "btnFindDoctor";
            this.btnFindDoctor.Size = new System.Drawing.Size(170, 30);
            this.btnFindDoctor.TabIndex = 0;
            this.btnFindDoctor.Text = "Find (Stored Proc)";
            this.btnFindDoctor.UseVisualStyleBackColor = false;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDoctorId.Location = new System.Drawing.Point(15, 30);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(170, 20);
            this.txtDoctorId.TabIndex = 1;
            this.txtDoctorId.Text = "Enter Doctor ID";
            // 
            // grpSelectMultiple
            // 
            this.grpSelectMultiple.Controls.Add(this.btnSearchSpecialty);
            this.grpSelectMultiple.Controls.Add(this.txtSpecialty);
            this.grpSelectMultiple.Location = new System.Drawing.Point(525, 70);
            this.grpSelectMultiple.Name = "grpSelectMultiple";
            this.grpSelectMultiple.Size = new System.Drawing.Size(200, 150);
            this.grpSelectMultiple.TabIndex = 1;
            this.grpSelectMultiple.TabStop = false;
            this.grpSelectMultiple.Text = "3. Search (Select Multiple)";
            // 
            // btnSearchSpecialty
            // 
            this.btnSearchSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSearchSpecialty.FlatAppearance.BorderSize = 0;
            this.btnSearchSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSpecialty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchSpecialty.Location = new System.Drawing.Point(15, 110);
            this.btnSearchSpecialty.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchSpecialty.Name = "btnSearchSpecialty";
            this.btnSearchSpecialty.Size = new System.Drawing.Size(170, 30);
            this.btnSearchSpecialty.TabIndex = 0;
            this.btnSearchSpecialty.Text = "Search Details";
            this.btnSearchSpecialty.UseVisualStyleBackColor = false;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSpecialty.Location = new System.Drawing.Point(15, 30);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(170, 20);
            this.txtSpecialty.TabIndex = 1;
            this.txtSpecialty.Text = "Enter Specialty ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(25, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(750, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpSelectMultiple);
            this.Controls.Add(this.grpSelectOne);
            this.Controls.Add(this.grpInsert);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form 1 - Connected Mode";
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