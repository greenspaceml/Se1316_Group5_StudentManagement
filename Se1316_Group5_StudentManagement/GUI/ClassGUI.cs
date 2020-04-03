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
    public partial class ClassGUI : Form {
        DataView dv;
        public ClassGUI() {
            InitializeComponent();
            View();

        }
        private void View() {
            DataTable dt = ClassDAO.GetAllClass_Hieu();
            dv = new DataView(dt);
            dataGridView1.DataSource = dv;
        }

        private void btnAdd_Click(object sender, EventArgs e) {

        }
    }
}
