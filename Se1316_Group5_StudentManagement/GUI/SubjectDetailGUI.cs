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
    public partial class SubjectDetailGUI : Form {
        public SubjectDetailGUI() {
            InitializeComponent();
        }

        public SubjectDetailGUI(string subid) {
            this.subid = subid;
            count = SubjectDAO.countStudent_Hoang(subid);
            InitializeComponent();
        }

        string subid;
        int count = 0;

        private void SubjectDetailGUI_Load(object sender, EventArgs e) {
            string text = label1.Text;
            text += SubjectDAO.getSubjectName_Hoang(subid);
            label1.Text = text + " is " + count + " students";
            txt1.Text = getTest1(subid);
            txt2.Text = getTest2(subid);
            txt3.Text = getTest3(subid);
            txt4.Text = getFinal(subid);

        }

        private string getTest1(string subid) {
            int countTest1 = 0;
            List<Mark> listMark = SubjectDAO.getListMarks(subid);
            foreach(var i in listMark) {
                if(i.Test1 >= 5) {
                    countTest1++;
                }
            }
            float percent = 0;
            try {
                 percent = countTest1 * 100 / count;
            }
            catch(Exception ex) {

            }
            return percent + "%";
        }
        
        private string getTest2(string subid) {
            int countTest1 = 0;
            List<Mark> listMark = SubjectDAO.getListMarks(subid);
            foreach(var i in listMark) {
                if(i.Test2 >= 5) {
                    countTest1++;
                }
            }
            float percent = 0;
            try {
                 percent = countTest1 * 100 / count;
            }
            catch(Exception ex) {

            }
            return percent + "%";
        }
        
        private string getTest3(string subid) {
            int countTest1 = 0;
            List<Mark> listMark = SubjectDAO.getListMarks(subid);
            foreach(var i in listMark) {
                if(i.Test3 >= 5) {
                    countTest1++;
                }
            }
            float percent = 0;
            try {
                 percent = countTest1 * 100 / count;
            }
            catch(Exception ex) {

            }
            return percent + "%";
        }
        
        private string getFinal(string subid) {
            int countTest1 = 0;
            List<Mark> listMark = SubjectDAO.getListMarks(subid);
            foreach(var i in listMark) {
                if(i.Final >= 5) {
                    countTest1++;
                }
            }
            float percent = 0;
            try {
                 percent = countTest1 * 100 / count;
            }
            catch(Exception ex) {

            }
            return percent + "%";
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
