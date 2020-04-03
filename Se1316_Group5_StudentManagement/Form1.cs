using Se1316_Group5_StudentManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Se1316_Group5_StudentManagement {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void embed(Panel panel, Form f) {
            panel.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Show();

            panel.Controls.Add(f);

        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e) {
            ClassGUI f = new ClassGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }
        //ReserveGUI f = new ReserveGUI();
        //embed(toolStripContainer1.ContentPanel, f);
    }
}
