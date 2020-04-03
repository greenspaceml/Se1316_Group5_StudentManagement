using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Se1316_Group5_StudentManagement.DTL;

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
    }
}
