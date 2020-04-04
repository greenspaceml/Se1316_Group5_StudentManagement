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
    public partial class TeacherGUI : Form {
        TeacherDAO tdb;
        string flag;
        public TeacherGUI() {
            InitializeComponent();
            tdb = new TeacherDAO();
            flag = "";
        }

        private void TeacherGUI_Load(object sender, EventArgs e) {
            loadData();
        }

        private void loadData() {
            DataTable dt = tdb.selectTeacher_Dat();
            dataTeacher.DataSource = dt;
        }

        private void setEnable(bool status) {
            txtName.Enabled = status;
            txtAddress.Enabled = status;
            dtDOB.Enabled = status;
            txtPhone.Enabled = status;
            txtEmail.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            radMale.Enabled = status;
            radFemale.Enabled = status;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            setEnable(true);
            flag = "add";
            groupBox1.Text = "Add Infor";
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            setEnable(false);
            groupBox1.Text = "Infor";
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Teacher teacher = new Teacher();
            teacher.Name = txtName.Text;
            teacher.gender = radMale.Checked;
            teacher.Email = txtEmail.Text;
            teacher.Address = txtAddress.Text;
            teacher.Phone = txtPhone.Text;
            teacher.Dob = dtDOB.Value;

            if (flag.Equals("add")) {
                bool isDone = tdb.insertTeacher_Dat(teacher);

                if (isDone) {
                    MessageBox.Show("Insert done!");
                    setEnable(false);
                }
            }

            if (flag.Equals("edit")) {
                teacher.TeacherID = Convert.ToInt32(txtTeacherId.Text);

                bool isDone = tdb.updateTeacher_Dat(teacher);

                if (isDone) {
                    MessageBox.Show("Update done!");
                    setEnable(false);
                }
            }

            groupBox1.Text = "Infor";
            loadData();
        }

        private void dataTeacher_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;

            txtTeacherId.Text = dataTeacher.Rows[e.RowIndex].Cells["TeacherId"].Value.ToString();
            txtName.Text = dataTeacher.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtAddress.Text = dataTeacher.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            txtEmail.Text = dataTeacher.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            txtPhone.Text = dataTeacher.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            radMale.Checked = (bool) dataTeacher.Rows[e.RowIndex].Cells["Gender"].Value;
            radFemale.Checked = !(bool) dataTeacher.Rows[e.RowIndex].Cells["Gender"].Value;
            dtDOB.Value = (DateTime) dataTeacher.Rows[e.RowIndex].Cells["DoB"].Value;
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            DataTable dt = tdb.selectTeacher_Dat();
            DataView dv = new DataView(dt);
            dv.RowFilter = "name like '%" + txtFilter.Text + "%'";
            dataTeacher.DataSource = dv;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dataTeacher.SelectedRows.Count <= 0) {
                MessageBox.Show("Please select a row!");
                return;
            }

            setEnable(true);
            flag = "edit";
            groupBox1.Text = "Edit Infor";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dataTeacher.SelectedRows.Count <= 0) {
                MessageBox.Show("Please select a row!");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this teacher?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                int teacherID = Convert.ToInt32(txtTeacherId.Text);
                tdb.deleteTeacher_Dat(teacherID);

                loadData();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            TeacherSubjectManagement f = new TeacherSubjectManagement();
            f.ShowDialog();
        }
    }
}
