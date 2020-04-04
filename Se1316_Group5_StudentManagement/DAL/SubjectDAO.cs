using Se1316_Group5_StudentManagement.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Se1316_Group5_StudentManagement.DAL {
    class SubjectDAO {
        public DataTable selectSubject_Dat() {
            return DAO.GetDataTable(@"SELECT * FROM [StudentManagementSystem].[dbo].[Subject]");
        }

        public DataTable selectSubjectById_Dat(int subjectId) {
            return DAO.GetDataTable(@"SELECT * FROM [StudentManagementSystem].[dbo].[Subject] WHERE SubjectID = " + subjectId);
        }

        static string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public static DataTable getSubject_Hoang() {
            string cmd = @"SELECT [SubjectID]
      ,[SubjectName]
      ,[SubjectCode]
      , ROW_NUMBER() OVER(Order by[SubjectID] ASC) as rownum
  FROM[StudentManagementSystem].[dbo].[Subject]";
            return DAO.GetDataTable(cmd);
        }


        public static int countStudent_Hoang(string subjectID) {
            string sql = @"SELECT        count(*)
FROM            Mark INNER JOIN
                         Subject ON Mark.SubjectID = Subject.SubjectID
						 where Subject.SubjectID = @subjectID";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@subjectID", subjectID);
            conn.Open();
            int count = (int) cmd.ExecuteScalar();
            return count;
            conn.Close();
        }
    }
}
