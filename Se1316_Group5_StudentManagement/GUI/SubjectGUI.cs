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
    public partial class SubjectGUI : Form {
        public SubjectGUI() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            DataTable dt = SubjectDAO.getSubject_Hoang();
            DataView dv = new DataView(dt);
            dv.RowFilter = "[SubjectName] like '%" + txtSearch.Text + "%'";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView senderGrid = sender as DataGridView;
            if(senderGrid.Columns[e.ColumnIndex].HeaderText == "Detail" && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) {
                string subid = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                SubjectDetailGUI subjectDetail = new SubjectDetailGUI(subid);
                subjectDetail.ShowDialog();
                //edit ed = new edit(id, lastname, firstname, issue, exprise);
                //ed.ShowDialog();

                //loadData();
            }
        }
    }
}
