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
    public partial class New_Patient : Form
    {
        public New_Patient()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Patients_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void New_Patient_Load(object sender, EventArgs e)
        {
            lodadata();
        }



        void lodadata()
        {
            Dbhelper db = new Dbhelper();


            string command = "select top(18) Patient_Id,Patient_Name,Patient_Mobile,Patient_city,Patient_Gender,CreatedBy from  Tbl_Patients order by Patient_Id desc";

         var ds=   db.GetDataset(command);

            PatientGrid.DataSource = ds.Tables[0];
            db.Closeconnection();
            

        }
    }
}
