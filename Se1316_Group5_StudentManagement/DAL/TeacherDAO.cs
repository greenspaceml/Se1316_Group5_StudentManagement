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
            return DAO.UpdateTable(cmd);
        }
    }
}
