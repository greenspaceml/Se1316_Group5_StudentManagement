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
    public partial class TeacherSubjectManagement : Form {
        SubjectDAO sdb;
        TeacherDAO tdb;
        string flag;
        bool check;
        public TeacherSubjectManagement() {
            InitializeComponent();
            sdb = new SubjectDAO();
            tdb = new TeacherDAO();
            flag = "";
            check = false;
        }

        private void TeacherSubjectManagement_Load(object sender, EventArgs e) {
            loadCombobox();
            loadComBoBoxSubjectId();
            loadComBoBoxTeacherId();
            loadData();
            check = true;
        }

        private void loadCombobox() {
            DataTable dt = sdb.selectSubject_Dat();
            var dr = dt.NewRow();
            dr["SubjectCode"] = -1;
            dr["SubjectName"] = "All";
            dt.Rows.InsertAt(dr, 0);
            cbxSubject.DataSource = dt;
            cbxSubject.DisplayMember = "SubjectName";
            cbxSubject.ValueMember = "SubjectCode";
        }

        private void loadComBoBoxSubjectId() {
            cbbSubjectId.DataSource = sdb.selectSubject_Dat();
            cbbSubjectId.DisplayMember = "SubjectId";
            cbbSubjectId.ValueMember = "SubjectCode";
        }

        private void loadComBoBoxTeacherId() {
            cbbTeacherId.DataSource = tdb.selectTeacher_Dat();
            cbbTeacherId.DisplayMember = "TeacherID";
            cbbTeacherId.ValueMember = "Name";
        }

        private void loadData() {
            dataTeacherSubject.DataSource = tdb.selectTeachSubject_Dat();
        }

        private void cbxSubject_SelectedValueChanged(object sender, EventArgs e) {
            if(check) {
                try {
                    txtSubjectCode.Text = cbxSubject.SelectedValue.ToString();
                    if(txtSubjectCode.Text.Equals("-1")) {
                        loadData();
                    } else {
                        dataTeacherSubject.DataSource = tdb.selectTeachSubjectBySubjectCode_Dat(txtSubjectCode.Text);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbbSubjectId_SelectedValueChanged(object sender, EventArgs e) {
            txtId.Text = cbbSubjectId.SelectedValue.ToString();
        }

        private void setEnable(bool state) {
            cbbSubjectId.Enabled = state;
            cbbTeacherId.Enabled = state;
            btnSave.Enabled = state;
            btnCancel.Enabled = state;
        }


        private void cbbTeacherId_SelectedValueChanged(object sender, EventArgs e) {
            txtName.Text = cbbTeacherId.SelectedValue.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            setEnable(false);
            groupBox1.Text = "Infor";
        }

        private void btnSave_Click(object sender, EventArgs e) {
            int teacherId = Convert.ToInt32(((DataRowView) cbbTeacherId.Items[cbbTeacherId.SelectedIndex]).Row[0]);
            int subjectId = Convert.ToInt32(((DataRowView) cbbSubjectId.Items[cbbSubjectId.SelectedIndex]).Row[0]);

            if (flag.Equals("add")) {
                bool isDone = tdb.insertTeache_Dat(teacherId, subjectId);

                if (isDone) {
                    MessageBox.Show("Insert done!");
                    setEnable(false);
                }
            }

            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            setEnable(true);
            flag = "add";
            groupBox1.Text = "Add Infor";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dataTeacherSubject.SelectedRows.Count <= 0) {
                MessageBox.Show("Please select a row!");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this data?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                int teacherID = Convert.ToInt32(txtIdTeacher.Text);
                int subjectID = Convert.ToInt32(txtSubjectId.Text);
                tdb.deleteTeache_Dat(teacherID, subjectID);

                loadData();
            }
        }

        private void dataTeacherSubject_CellClick(object sender, DataGridViewCellEventArgs e) {
            txtIdTeacher.Text = dataTeacherSubject.Rows[e.RowIndex].Cells["TeacherId"].Value.ToString();
            txtSubjectId.Text = dataTeacherSubject.Rows[e.RowIndex].Cells["subjectID"].Value.ToString();
        }
    }
}
