namespace Vezzeta
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.form1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.report1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsMenu,
            this.reportsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsMenu
            // 
            this.formsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1MenuItem,
            this.form2MenuItem});
            this.formsMenu.Name = "formsMenu";
            this.formsMenu.Size = new System.Drawing.Size(52, 20);
            this.formsMenu.Text = "Forms";
            // 
            // form1MenuItem
            // 
            this.form1MenuItem.Name = "form1MenuItem";
            this.form1MenuItem.Size = new System.Drawing.Size(183, 22);
            this.form1MenuItem.Text = "Connected Mode";
            this.form1MenuItem.Click += new System.EventHandler(this.form1MenuItem_Click);
            // 
            // form2MenuItem
            // 
            this.form2MenuItem.Name = "form2MenuItem";
            this.form2MenuItem.Size = new System.Drawing.Size(183, 22);
            this.form2MenuItem.Text = "Disconnected Mode ";
            this.form2MenuItem.Click += new System.EventHandler(this.form2MenuItem_Click);
            // 
            // reportsMenu
            // 
            this.reportsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.report1MenuItem,
            this.report2MenuItem});
            this.reportsMenu.Name = "reportsMenu";
            this.reportsMenu.Size = new System.Drawing.Size(59, 20);
            this.reportsMenu.Text = "Reports";
            this.reportsMenu.Click += new System.EventHandler(this.reportsMenu_Click);
            // 
            // report1MenuItem
            // 
            this.report1MenuItem.Name = "report1MenuItem";
            this.report1MenuItem.Size = new System.Drawing.Size(188, 22);
            this.report1MenuItem.Text = "Report 1 (Grouped)";
            this.report1MenuItem.Click += new System.EventHandler(this.report1MenuItem_Click);
            // 
            // report2MenuItem
            // 
            this.report2MenuItem.Name = "report2MenuItem";
            this.report2MenuItem.Size = new System.Drawing.Size(188, 22);
            this.report2MenuItem.Text = "Report 2 (Parameters)";
            this.report2MenuItem.Click += new System.EventHandler(this.report2MenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblWelcome.Location = new System.Drawing.Point(193, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(414, 45);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Vezzeta Admin Dashboard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vezzeta - Main Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsMenu;
        private System.Windows.Forms.ToolStripMenuItem form1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenu;
        private System.Windows.Forms.ToolStripMenuItem report1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem report2MenuItem;
        private System.Windows.Forms.Label lblWelcome;
    }
}