using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Se1316_Group5_StudentManagement.DTL {
    class TeacherClass {
        private int iD;
        private int classID;
        private int teacherID;
        public int ID {
            get { return iD; }
            set { iD = value; }
        }
        public int ClassID {
            get { return classID; }
            set { classID = value; }
        }
        public int TeacherID {
            get { return teacherID; }
            set { teacherID = value; }
        }
        public TeacherClass() {

        }
        public TeacherClass(int iD, int classID, int teacherID) {
            this.iD = iD;
            this.classID = classID;
            this.teacherID = teacherID;
        }

    }
}
