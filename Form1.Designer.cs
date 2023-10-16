
namespace Thorat_Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyCheckupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientAdmmisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dischargeBilllsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.newPatientToolStripMenuItem,
            this.dailyCheckupToolStripMenuItem,
            this.patientAdmmisionToolStripMenuItem,
            this.dailyTransactionsToolStripMenuItem,
            this.dischargeBilllsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.newPatientToolStripMenuItem.Text = "New Patient";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // dailyCheckupToolStripMenuItem
            // 
            this.dailyCheckupToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.dailyCheckupToolStripMenuItem.Name = "dailyCheckupToolStripMenuItem";
            this.dailyCheckupToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.dailyCheckupToolStripMenuItem.Text = "Daily Checkup";
            // 
            // patientAdmmisionToolStripMenuItem
            // 
            this.patientAdmmisionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.patientAdmmisionToolStripMenuItem.Name = "patientAdmmisionToolStripMenuItem";
            this.patientAdmmisionToolStripMenuItem.Size = new System.Drawing.Size(150, 21);
            this.patientAdmmisionToolStripMenuItem.Text = "Patient Admmision";
            // 
            // dailyTransactionsToolStripMenuItem
            // 
            this.dailyTransactionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.dailyTransactionsToolStripMenuItem.Name = "dailyTransactionsToolStripMenuItem";
            this.dailyTransactionsToolStripMenuItem.Size = new System.Drawing.Size(147, 21);
            this.dailyTransactionsToolStripMenuItem.Text = "Daily Transactions";
            // 
            // dischargeBilllsToolStripMenuItem
            // 
            this.dischargeBilllsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.dischargeBilllsToolStripMenuItem.Name = "dischargeBilllsToolStripMenuItem";
            this.dischargeBilllsToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.dischargeBilllsToolStripMenuItem.Text = "Discharge Billls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyCheckupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientAdmmisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dischargeBilllsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

