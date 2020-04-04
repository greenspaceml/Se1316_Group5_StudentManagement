using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Se1316_Group5_StudentManagement.DTL {
    class Class {
        private int classID;

        private string className;

        public int ClassID {
            get { return classID; }
            set { classID = value; }
        }
        public string ClassName {
            get { return className; }
            set { className = value; }
        }
        public Class() {

        }
        public Class(int classID, string className){
            this.classID = classID;
            this.className = className;
        }

        public override string ToString() {
            return (classID.ToString() + '\t' + className);
        }
    }
}
