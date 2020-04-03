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
    public partial class TeacherGUI : Form {
        TeacherDAO tdb;
        public TeacherGUI() {
            InitializeComponent();
            tdb = new TeacherDAO();
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
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            setEnable(true);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            setEnable(false);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            
        }
    }
}
