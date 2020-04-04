using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Se1316_Group5_StudentManagement.DTL {
    class Mark {
        string id;
        string studentID;
        string subjectID;
        int test1;
        int test2;
        int test3;
        int final;

        public Mark(string id, string studentID, string subjectID, int test1, int test2, int test3, int final) {
            this.id = id;
            this.studentID = studentID;
            this.subjectID = subjectID;
            this.test1 = test1;
            this.test2 = test2;
            this.test3 = test3;
            this.final = final;
        }

        public Mark() {
        }



        public string Id { get => id; set => id = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string SubjectID { get => subjectID; set => subjectID = value; }
        public int Test1 { get => test1; set => test1 = value; }
        public int Test2 { get => test2; set => test2 = value; }
        public int Test3 { get => test3; set => test3 = value; }
        public int Final { get => final; set => final = value; }
    }
}
