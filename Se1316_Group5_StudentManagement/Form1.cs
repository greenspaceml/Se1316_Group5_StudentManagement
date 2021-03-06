﻿using Se1316_Group5_StudentManagement.GUI;
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

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e) {
            TeacherGUI f = new TeacherGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e) {
            ClassGUI f = new ClassGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e) {
            StudentGUI f = new StudentGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e) {
            SubjectGUI f = new SubjectGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            About f = new About();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void markUpdateToolStripMenuItem_Click(object sender, EventArgs e) {
            MarkGUI f = new MarkGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

    }
}
