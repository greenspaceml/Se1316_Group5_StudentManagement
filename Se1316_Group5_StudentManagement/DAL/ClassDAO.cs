using Se1316_Group5_StudentManagement.DTL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Se1316_Group5_StudentManagement.DAL {
    class ClassDAO {
        static string strConn = @"Data Source=localhost;Initial Catalog=StudentManagementSystem;Integrated Security=True";
        public ClassDAO() {

        }
        public DataTable GetAllClass_Hieu() {
            String sql = @"select tc.ID, c.ClassID, c.ClassName, t.Name as TeacherName," +
                         " (select count(StudentID) from Student where classID = 1) as Students" +
                         " from Class c inner join Teacher_Class tc" +
                         " on c.ClassID = tc.ClassID" +
                         " inner join Teacher t on tc.TeacherID = t.TeacherID";
            return DAO.GetDataTable(sql);
        }
        public Class GetClassByName_Hieu(string name) {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select ClassID" +
                         " from Class where ClassName = @className",conn);
            cmd.Parameters.AddWithValue("@className", name);
            Class c = new Class();
            using (SqlDataReader reader = cmd.ExecuteReader()) {
                while (reader.Read()) {
                    c.ClassID = (int)reader["ClassID"];
                }
                conn.Close();
            }
            return c;
        }
        public Teacher GetTeacherByName_Hieu(string name) {
            Teacher t = new Teacher();
            try {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select TeacherID" +
                             " from Teacher where Name = @name", conn);
                cmd.Parameters.AddWithValue("@name", name);
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        t.TeacherID = (int)reader["TeacherID"];
                    }
                    conn.Close();
                }
            } catch(Exception ex) {
            }
            return t;
        }
        public TeacherClass GetTeacherClassID_Hieu(int classID, int teacherID) {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select ID from Teacher_Class where ClassID = @classID and TeacherID = @teacherID",conn);
            cmd.Parameters.AddWithValue("@classID", classID);
            cmd.Parameters.AddWithValue("@teacherID", teacherID);
            TeacherClass tc = new TeacherClass();
            using (SqlDataReader reader = cmd.ExecuteReader()) {
                while (reader.Read()) {
                    tc.ID = (int)reader["ID"];
                }
                conn.Close();
            }
            return tc;
        }
        public bool InsertClass_Hieu(Class c) {
            SqlCommand cmd = new SqlCommand("insert into Class(ClassName)" +
                    "values (@className)");
            cmd.Parameters.AddWithValue("@className", c.ClassName);
            return DAO.UpdateTable(cmd);
        }
        public bool InsertTeacherClass_Hieu(TeacherClass tc) {
            SqlCommand cmd = new SqlCommand("insert into Teacher_Class(ClassID, TeacherID)" +
                    "values (@classID, @teacherID)");
                cmd.Parameters.AddWithValue("@classID", tc.ClassID);
                cmd.Parameters.AddWithValue("@teacherID", tc.TeacherID);
            return DAO.UpdateTable(cmd);
        }
        public bool UpdateClass_Hieu(Class c) {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Class]
                                            SET [ClassName] = @className
                                            WHERE ClassID = @classID");
            cmd.Parameters.AddWithValue("@className", c.ClassName);
            cmd.Parameters.AddWithValue("@classID", c.ClassID);
            return DAO.UpdateTable(cmd);
        }
        public bool UpdateTeacherClass_Hieu(TeacherClass tc) {
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Teacher_Class]
                                            SET[ClassID] = @classID
                                            ,[TeacherID] = @teacherID WHERE ID = @ID");
            cmd.Parameters.AddWithValue("@ID", tc.ID);
            cmd.Parameters.AddWithValue("@teacherID", tc.TeacherID);
            cmd.Parameters.AddWithValue("@classID",tc.ClassID);
            return DAO.UpdateTable(cmd);
        }
        public bool deleteClass_Hieu(int classID) {
            SqlCommand cmd = new SqlCommand();
            try {
                string query = "DELETE FROM Class WHERE ClassID = @id";

                cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@id", classID);
            } catch {
                MessageBox.Show("Can't delete this Class");
            }
            
            return DAO.UpdateTable(cmd);
        }
        public bool deleteTeacherClass_Hieu(int ID) {
            string query = "DELETE FROM Teacher_Class WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", ID);
            return DAO.UpdateTable(cmd);
        }
    }
}
