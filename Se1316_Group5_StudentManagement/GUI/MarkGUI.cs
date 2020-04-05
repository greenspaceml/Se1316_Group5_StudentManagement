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
    public partial class MarkGUI : Form {
        public MarkGUI() {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            DataTable dt = SubjectDAO.getMark_Hoang();
            DataView dv = new DataView(dt);
            dv.RowFilter = "StudentID = " + textBox1.Text;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dv;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            SubjectDAO.updateMark_Hoang(subid, int.Parse(txt1.Text), int.Parse(txt2.Text), int.Parse(txt3.Text), int.Parse(txt4.Text));
            btnUpdate.Enabled = false;

            DataTable dt = SubjectDAO.getMark_Hoang();
            DataView dv = new DataView(dt);
            dv.RowFilter = "StudentID = " + textBox1.Text;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        string subid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            btnUpdate.Enabled = true;
            txt1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            subid = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            
        }

        private void MarkGUI_Load(object sender, EventArgs e) {

        }
    }
}
