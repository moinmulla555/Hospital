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


        private void btnSave_Click(object sender, EventArgs e)
        {


            if(cell<=0)
            { 
            try
            {
                Dbhelper db = new Dbhelper();
                string gender = "M";
                if (rbfemale.Checked)
                {
                    gender = "F";
                }

                string command = "insert into Tbl_Patients(Patient_Name,Patient_Mobile,Patient_city,Patient_Gender,CreatedBy) values('" + txtName.Text + "','" + txtMobile.Text + "','" + txtAddress.Text + "','" + gender + "',1)";

                db.Doadd(command);
                MessageBox.Show("Patient added Suceesfully...");
                lodadata();
                Clearform();

            }
            catch (Exception er)
            {

            }

            }
            else
            {
                Dbhelper db = new Dbhelper();

                string gender = "F";

                if(rbMale.Checked)
                {
                    gender = "M";
                }

                string command = "update tbl_patients set Patient_Name='" + txtName.Text + "', Patient_Mobile='" + txtMobile.Text + "',Patient_City='" + txtAddress.Text + "',Patient_Gender='"+gender+"' where Patient_Id="+cell+"";
                db.Doadd(command);
               MessageBox.Show("Updated Succefully");
                Clearform();
                lodadata();
                cell = 0;

            }

        }


        void Clearform()
        {
            txtMobile.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            rbMale.Checked = false;
            rbMale.Checked = false;
            txtCreatedBy.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dbhelper db = new Dbhelper();


            string command = "delete from Tbl_Patients where Patient_Id=" + cell + "";

            DialogResult dr = MessageBox.Show("Are You Sure?", "Confirmation?", MessageBoxButtons.YesNo);
            if (dr==DialogResult.Yes)
            {
                db.Doadd(command);
                MessageBox.Show("Deleted Succefully");
                lodadata();
                cell = 0;

            }
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        int cell ;
        private void PatientGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cell =Convert.ToInt32(PatientGrid.Rows[e.RowIndex].Cells[0].Value);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dbhelper db = new Dbhelper();


            string command = "select Patient_id, Patient_Name, Patient_Mobile,Patient_City,Patient_Gender from Tbl_Patients where Patient_Id="+cell+"";
        var dr=    db.GetDataReader(command);
            if(dr.Read())
            {
                dr["Patient_id"].ToString();
                txtName.Text=dr["Patient_Name"].ToString();
                txtMobile.Text = dr["Patient_Mobile"].ToString();
                txtAddress.Text = dr["Patient_City"].ToString();
                if(dr["Patient_Gender"].ToString()=="M")
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbfemale.Checked = true;
                }
            }

            dr.Close();

         
           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Dbhelper db = new Dbhelper();


            string command = "select * from Tbl_Patients where Patient_Name like '%"+txtsearch.Text+"%' ";
           var ds= db.GetDataset(command);
            

            PatientGrid.DataSource = ds.Tables[0];
            db.Closeconnection();
        }
    }
}
