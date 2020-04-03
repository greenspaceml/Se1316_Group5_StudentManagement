using Se1316_Group5_StudentManagement.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Se1316_Group5_StudentManagement.DAL {
    class ClassDAO {
        public static DataTable GetAllClass_Hieu() {
            string cmd = "select c.ClassID, c.ClassName, t.Name as TeacherName from Class c inner join Teacher_Class tc" +
                " on c.ClassID = tc.ClassID inner join Teacher t on tc.TeacherID = t.TeacherID";
            return DAO.GetDataTable(cmd);
        }
        public static Boolean GetClassByID_Hieu(int id) {
            SqlCommand cmd = new SqlCommand("select c.ClassID, c.ClassName, t.Name as TeacherName from Class c inner join Teacher_Class tc" +
                " on c.ClassID = tc.ClassID inner join Teacher t on tc.TeacherID = t.TeacherID where c.ClassID = @id");
            cmd.Parameters.AddWithValue("@id", id);
            return DAO.UpdateTable(cmd);
        }
        public static bool InsertClass_Hieu(Class c) {
            SqlCommand cmd = new SqlCommand("insert into Class(ClassID, ClassName)" +
                    "values (@classID, @className)");
            cmd.Parameters.AddWithValue("@classID", c.ClassID);
            cmd.Parameters.AddWithValue("@className", c.ClassName);
            return DAO.UpdateTable(cmd);
        }
        public static bool InsertTeacherClass_Hieu(Class c, int teacherID) {
            SqlCommand cmd = new SqlCommand("insert into Teacher_Class(ClassID, TeacherID)" +
                    "values (@classID, @teacherID)");
            cmd.Parameters.AddWithValue("@classID", c.ClassID);
            cmd.Parameters.AddWithValue("@teacherID", teacherID);
            return DAO.UpdateTable(cmd);
        }
    }
}
