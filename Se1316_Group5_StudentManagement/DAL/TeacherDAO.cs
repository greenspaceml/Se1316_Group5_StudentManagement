using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Se1316_Group5_StudentManagement.DTL;
using System.Configuration;

namespace Se1316_Group5_StudentManagement.DAL {
    class TeacherDAO {
        public TeacherDAO() {

        }

        public DataTable selectTeacher_Dat() {
            return DAO.GetDataTable(@"SELECT * FROM[dbo].[Teacher]");
        }

        public bool insertTeacher_Dat(Teacher teacher) {
            string query = @"INSERT INTO [dbo].[Teacher]
                           ([Name]
                           ,[Gender]
                           ,[DoB]
                           ,[Address]
                           ,[Phone]
                           ,[Email])
                     VALUES
                           (@name
                           ,@gender
                           ,@dob
                           ,@address
                           ,@phone
                           ,@email)";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@name", teacher.Name);
            cmd.Parameters.AddWithValue("@gender", teacher.gender);
            cmd.Parameters.AddWithValue("@dob", teacher.Dob);
            cmd.Parameters.AddWithValue("@address", teacher.Address);
            cmd.Parameters.AddWithValue("@phone", teacher.Phone);
            cmd.Parameters.AddWithValue("@email", teacher.Email);
            return DAO.UpdateTable(cmd);
        }

        public bool updateTeacher_Dat(Teacher teacher) {
            string query = @"UPDATE [dbo].[Teacher]
                           SET [Name] = @name
                              ,[Gender] = @gender
                              ,[DoB] = @dob
                              ,[Address] = @address
                              ,[Phone] = @phone
                              ,[Email] = @email
                         WHERE TeacherID = @id";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@name", teacher.Name);
            cmd.Parameters.AddWithValue("@gender", teacher.gender);
            cmd.Parameters.AddWithValue("@dob", teacher.Dob);
            cmd.Parameters.AddWithValue("@address", teacher.Address);
            cmd.Parameters.AddWithValue("@phone", teacher.Phone);
            cmd.Parameters.AddWithValue("@email", teacher.Email);
            cmd.Parameters.AddWithValue("@id", teacher.TeacherID);
            return DAO.UpdateTable(cmd);
        }

        public bool deleteTeacher_Dat(int teacherId) {
            string query = @"DELETE FROM [dbo].[Teacher]
                            WHERE TeacherID = @id";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", teacherId);
            return DAO.UpdateTable(cmd);
        }
        public bool insertTeache_Dat(int teacherId, int subjectID) {
            string query = @"INSERT INTO [dbo].[Teach]
                           ([TeacherID]
                           ,[SubjectID])
                     VALUES
                           (@teacherId
                           ,@subjectID)";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@teacherId", teacherId);
            cmd.Parameters.AddWithValue("@subjectID", subjectID);
            return DAO.UpdateTable(cmd);
        }

        public DataTable selectTeachSubject_Dat() {
            string query = @"SELECT        Teacher.TeacherID, Teacher.Name, Teacher.Gender, Subject.*
                        FROM            Subject INNER JOIN
                                                 Teach ON Subject.SubjectID = Teach.SubjectID INNER JOIN
                                                 Teacher ON Teach.TeacherID = Teacher.TeacherID";
            return DAO.GetDataTable(query);
        }

        public bool deleteTeache_Dat(int teacherId, int subjectID) {
            string query = @"DELETE FROM [dbo].[Teach]
                        WHERE TeacherID = @teacherId and SubjectID = @subjectId";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@teacherId", teacherId);
            cmd.Parameters.AddWithValue("@subjectId", subjectID);
            return DAO.UpdateTable(cmd);
        }
        public DataTable GetAllTeacher_Hieu() {
            return DAO.GetDataTable("select TeacherID, Name from Teacher order by TeacherID asc");
        }

        public DataTable selectTeachSubjectBySubjectCode_Dat(string subjectCode) {
            string query = @"SELECT        Teacher.TeacherID, Teacher.Name, Teacher.Gender, Subject.*
                        FROM            Subject INNER JOIN
                                                 Teach ON Subject.SubjectID = Teach.SubjectID INNER JOIN
                                                 Teacher ON Teach.TeacherID = Teacher.TeacherID
                                Where subjectCode like '" + subjectCode + "'";
            return DAO.GetDataTable(query);
        }

        public DataTable selectTeachSubjectByTeacherId_Dat (int teacherId) {
            string query = @"SELECT        Teacher.TeacherID, Teacher.Name, Teacher.Gender, Subject.*
                            FROM          Subject INNER JOIN
                                          Teach ON Subject.SubjectID = Teach.SubjectID INNER JOIN
                                          Teacher ON Teach.TeacherID = Teacher.TeacherID 

                            Where Teacher.TeacherID = " + teacherId + "";
            return DAO.GetDataTable(query);
        }

        public List<Subject> selectSubject_Dat() {
            List<Subject> subject = new List<Subject>();
            string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(strConn);
            try {
                String sql = @"SELECT * FROM [StudentManagementSystem].[dbo].[Subject]";
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read()) {
                    Subject s = new Subject();
                    s.SubjectID = Convert.ToInt32(reader["SubjectID"]);
                    s.SubjectName = reader["SubjectName"].ToString();
                    s.SubjectCode = reader["SubjectCode"].ToString();
                    subject.Add(s);
                }
            }
            catch (Exception ex) {
                Console.WriteLine("get all sai");
            }
            finally {
                if (connection.State != System.Data.ConnectionState.Closed) {
                    connection.Close();
                }
            }
            return subject;
        }
    }
}
