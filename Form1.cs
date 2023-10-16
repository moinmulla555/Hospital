using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thorat_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Patient n1 = new New_Patient();
            n1.Show();
            n1.MdiParent = this;
        }
    }
}
