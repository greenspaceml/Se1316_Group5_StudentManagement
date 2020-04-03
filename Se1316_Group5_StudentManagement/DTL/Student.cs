using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Se1316_Group5_StudentManagement.DTL {
    class Student {
        private int studentID;
        private string name;
        private bool gender;
        private DateTime DoB;
        private string address;
        private string phone;
        private string email;

        public Student(int studentID, string name, bool gender, DateTime doB, string address, string phone, string email) {
            this.studentID = studentID;
            this.name = name;
            this.gender = gender;
            DoB = doB;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string Name { get => name; set => name = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime DoB1 { get => DoB; set => DoB = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

    }
}
