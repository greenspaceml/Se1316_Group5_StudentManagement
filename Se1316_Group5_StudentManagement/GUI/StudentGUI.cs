using Se1316_Group5_StudentManagement.DAL;
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
            txtStudentGender.Enabled = false;
            txtStudentDOB.Enabled = false;
            txtStudentAddress.Enabled = false;
            txtStudentPhone.Enabled = false;
            txtStudentEmail.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }
        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e) {
            txtStudentID.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
            txtStudentName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtStudentGender.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            txtStudentDOB.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["DoB"].Value.ToString();
            txtStudentAddress.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Addess"].Value.ToString();
            txtStudentPhone.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            txtStudentEmail.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["Email"].Value.ToString();
        }

        private void btnFindStudent_Click(object sender, EventArgs e) {
            DataTable dt = StudentDAO.GetListStudent_Quang();
            DataView dv = new DataView(dt);
            dv.RowFilter = "StudentID = " + txtStudentID.Text;
            dataGridViewStudent.DataSource = dv;
        }

    }
}
