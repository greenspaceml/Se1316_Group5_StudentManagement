using Se1316_Group5_StudentManagement.DAL;
using Se1316_Group5_StudentManagement.DTL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Se1316_Group5_StudentManagement.GUI {
    public partial class ClassGUI : Form {
        ClassDAO classDAO;
        TeacherDAO teacherDAO;
        string flag;
        public ClassGUI() {
            InitializeComponent();
            classDAO = new ClassDAO();
            teacherDAO = new TeacherDAO();
            flag = "";
            
        }
        private void loadData() {
            DataTable dt = new DataTable();
            dt = classDAO.GetAllClass_Hieu();
            dataGridView1.DataSource = dt;
        }
        private void setEnable(bool status) {
            txtClassName.Enabled = status;
            txtTeacher.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
        }
        
        private void btnAdd_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                MessageBox.Show("Please don't select a row!");
                return;
            }
            setEnable(true);
            flag = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count <= 0) {
                MessageBox.Show("Please select a row!");
                return;
            }

            setEnable(true);
            flag = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count <= 0) {
                MessageBox.Show("Please select a row!");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to delete this teacher?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                Teacher t = classDAO.GetTeacherByName_Hieu(txtTeacher.Text);
                TeacherClass tc = classDAO.GetTeacherClassID_Hieu(int.Parse(txtClassID.Text), t.TeacherID);
                int id = tc.ID;
                classDAO.deleteTeacherClass_Hieu(id);
                MessageBox.Show("Delete Complete!");
                loadData();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            dt = classDAO.GetAllClass_Hieu();
            DataView dv = new DataView(dt);
            dv.RowFilter = " ClassName like '%" + txtFilter.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Class c = new Class();
            TeacherClass tc = new TeacherClass();
            c.ClassID = int.Parse(txtClassID.Text);
            c.ClassName = txtClassName.Text;
            Teacher t = classDAO.GetTeacherByName_Hieu(txtTeacher.Text);
            if (flag.Equals("add")) {
                bool isDoneC = classDAO.InsertClass_Hieu(c);
                if (isDoneC) {
                    Class c1 = classDAO.GetClassByName_Hieu(c.ClassName);
                    tc.ClassID = c1.ClassID;
                    tc.TeacherID = t.TeacherID;
                    bool isDoneTC = classDAO.InsertTeacherClass_Hieu(tc);
                    if (isDoneTC) {
                        MessageBox.Show("Insert Complete!");
                        setEnable(false);
                    }
                }
            }

            if (flag.Equals("edit")) {
                tc.ID = int.Parse(txtID.Text);
                tc.ClassID = c.ClassID;
                tc.TeacherID = t.TeacherID;
                bool isDoneC = classDAO.UpdateClass_Hieu(c);
                bool isDoneTC = classDAO.UpdateTeacherClass_Hieu(tc);
                if (isDoneC && isDoneTC) {
                    MessageBox.Show("Update Complete!");
                    setEnable(false);
                }
            }
            loadData();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            setEnable(false);
        }

        private void ClassGUI_Load(object sender, EventArgs e) {
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtClassID.Text = dataGridView1.Rows[e.RowIndex].Cells["ClassID"].Value.ToString();
            txtClassName.Text = dataGridView1.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
            txtTeacher.Text = dataGridView1.Rows[e.RowIndex].Cells["TeacherName"].Value.ToString();
        }
    }
}
