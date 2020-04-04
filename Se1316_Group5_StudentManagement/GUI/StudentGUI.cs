using Se1316_Group5_StudentManagement.DAL;
using Se1316_Group5_StudentManagement.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Se1316_Group5_StudentManagement.GUI {
    public partial class StudentGUI : Form {
        public StudentGUI() {
            InitializeComponent();
            LoadStudentGridView();
            setEnableOFF();
        }
        private void LoadStudentGridView() {
            DataTable dt = StudentDAO.GetListStudent_Quang();
            DataView dv = new DataView(dt);
            dataGridViewStudent.DataSource = dv;
        }
        void setEnableOFF() {
            txtStudentName.Enabled = false;
            txtStudentDOB.Enabled = false;
            txtStudentAddress.Enabled = false;
            txtStudentPhone.Enabled = false;
            txtStudentEmail.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            rdbFemale.Enabled = false;
            rdbMale.Enabled = false;
        }
        void setEnableForAddnew(bool va) {
            txtStudentName.Enabled = va;
            txtStudentDOB.Enabled = va;
            txtStudentAddress.Enabled = va;
            txtStudentPhone.Enabled = va;
            txtStudentEmail.Enabled = va;
            rdbFemale.Enabled = va;
            rdbMale.Enabled = va;
            btnDelete.Enabled = !va;
            btnEdit.Enabled = !va;
        }
        void setEnableForEdit(bool va) {
            txtStudentName.Enabled = va;
            txtStudentDOB.Enabled = va;
            txtStudentAddress.Enabled = va;
            txtStudentPhone.Enabled = va;
            txtStudentEmail.Enabled = va;
            rdbFemale.Enabled = va;
            rdbMale.Enabled = va;
            btnDelete.Enabled = !va;
            btnAdd.Enabled = !va;
        }
        void setEnableForDelete() {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e) {
            txtStudentID.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
            txtStudentName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            rdbMale.Checked = (bool)dataGridViewStudent.Rows[e.RowIndex].Cells["Gender"].Value;
            rdbFemale.Checked = !(bool)dataGridViewStudent.Rows[e.RowIndex].Cells["Gender"].Value;
            txtStudentDOB.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["DoB"].Value.ToString();
            txtStudentAddress.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Addess"].Value.ToString();
            txtStudentPhone.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            txtStudentEmail.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnFindStudent_Click(object sender, EventArgs e) {
            DataTable dt = StudentDAO.GetListStudent_Quang();
            DataView dv = new DataView(dt);
            dv.RowFilter = "StudentID = " + txtStudentID.Text;
            dataGridViewStudent.DataSource = dv;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (btnAdd.Text == "Add New Student") {
                btnAdd.Text = "Save";
                setEnableForAddnew(true);
            } else {
                int gen = rdbMale.Checked ? 1 : 0;
                bool checking = StudentDAO.InsertStudent_Quang(txtStudentName.Text, gen, txtStudentDOB.Text, txtStudentAddress.Text, txtStudentPhone.Text, txtStudentEmail.Text);
                btnAdd.Text = "Add New Student";
                setEnableForAddnew(false);
                MessageBox.Show(checking ? "New student added successful!" : "Student adding failed!");
                LoadStudentGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            setEnableForDelete();
            bool checking = StudentDAO.DeleteStudent(txtStudentID.Text);
            MessageBox.Show(checking ? "Student delete successful!" : "Student delete failed!");
            LoadStudentGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (btnEdit.Text == "Edit Student") {
                btnEdit.Text = "Update";
                setEnableForEdit(true);
            } else {
                setEnableForEdit(false);
                int gen = rdbMale.Checked ? 1 : 0;
                btnEdit.Text = "Edit Student";
                bool checking = StudentDAO.UpdateStudent_Quang(txtStudentID.Text, txtStudentName.Text, gen, txtStudentDOB.Text, txtStudentAddress.Text, txtStudentPhone.Text, txtStudentEmail.Text);
                MessageBox.Show(checking ? "Student Updated successful!" : "Student Updated failed!");
                LoadStudentGridView();
            }

        }
    }
}
