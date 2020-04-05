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
    public partial class SubjectATeacher : Form {
        TeacherDAO tdb;
        public int TeacherId { get; set; }
        List<CheckBox> checkBox = new List<CheckBox>();
        List<int> listId = new List<int>();

        public SubjectATeacher() {
            InitializeComponent();
            tdb = new TeacherDAO();
            TeacherId = 0;
        }

        private void SubjectATeacher_Load(object sender, EventArgs e) {
            loadData();
            createCheckBox();
        }

        private CheckBox addCheckBox(string code, string name) {
            CheckBox cb = new CheckBox();
            cb.Name = code;
            cb.Text = name;
            cb.Visible = true;
            cb.Enabled = false;
            flowLayoutPanel1.Controls.Add(cb);
            return cb;
        }

        private void createCheckBox() {
            List<Subject> list = tdb.selectSubject_Dat();
            int i = 0;
            foreach (Subject l in list) {
                checkBox.Add(addCheckBox(l.SubjectID.ToString(), l.SubjectName));
                DataTable dt = tdb.selectTeachSubjectByTeacherId_Dat(TeacherId);
                DataView dv = new DataView(dt);
                dv.RowFilter = "SubjectCode like '" + l.SubjectCode + "'";
                if (dv.Count > 0) {
                    checkBox[i].Checked = true;
                }
                i++;
            }
        }

        private void loadData() {
            dataSubjectATeacher.DataSource = tdb.selectTeachSubjectByTeacherId_Dat(TeacherId);
        }

        private void btnModefile_Click(object sender, EventArgs e) {
            if (btnModefile.Text.Equals("Save")) {
                foreach (CheckBox l in checkBox) {
                    bool isInsert = true;
                    if (l.Checked) {
                        foreach (DataGridViewRow row in dataSubjectATeacher.Rows) {
                            if (l.Name.Equals(row.Cells["SubjectID"].Value.ToString())) {
                                isInsert = false;
                                break;
                            }
                        }

                        if(isInsert) {
                            tdb.insertTeache_Dat(TeacherId, Convert.ToInt32(l.Name));
                        }
                    }

                    foreach (DataGridViewRow row in dataSubjectATeacher.Rows) {
                        if (l.Name.Equals(row.Cells["SubjectID"].Value.ToString())) {
                            if(!l.Checked) {
                                tdb.deleteTeache_Dat(TeacherId, Convert.ToInt32(l.Name));
                            }
                        }
                    }
                }

                loadData();
                setEnable(false);
                btnModefile.Text = "Modefile";
            } else {
                btnModefile.Text = "Save";
                setEnable(true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            setEnable(false);
            btnModefile.Text = "Modefile";
        }

        private void setEnable(bool state) {
            btnCancel.Enabled = state;
            foreach (CheckBox l in checkBox) {
                l.Enabled = state;
            }
        }
    }
}
