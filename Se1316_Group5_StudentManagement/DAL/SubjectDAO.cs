using Se1316_Group5_StudentManagement.DTL;
using Se1316_Group5_StudentManagement.GUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Se1316_Group5_StudentManagement.DAL {
    class SubjectDAO {
        static string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public DataTable selectSubject_Dat() {
            return DAO.GetDataTable(@"SELECT * FROM [StudentManagementSystem].[dbo].[Subject]");
        }

        public DataTable selectSubjectById_Dat(int subjectId) {
            return DAO.GetDataTable(@"SELECT * FROM [StudentManagementSystem].[dbo].[Subject] WHERE SubjectID = " + subjectId);
        }

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
        
        public static List<Mark> getListMarks(string SubjectID) {
            SqlConnection conn = new SqlConnection(strConn);
            List<Mark> listMark = new List<Mark>();
            try {

                String sql = @"SELECT        Subject.SubjectID, Mark.StudentID, Mark.Test1, Mark.Test2, Mark.Test3, Mark.FinalTest, Mark.MarkID
FROM            Mark INNER JOIN
                         Subject ON Mark.SubjectID = Subject.SubjectID
WHERE        Subject.SubjectID = @SubjectID";
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SubjectID", SubjectID);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read()) {
                    Mark m = new Mark();
                    m.Id = reader["MarkID"].ToString();
                    m.StudentID = reader["StudentID"].ToString();
                    m.SubjectID = reader["SubjectID"].ToString();
                    m.Test1 = Convert.ToInt32(reader["Test1"]);
                    m.Test2 = Convert.ToInt32(reader["Test2"]);
                    m.Test3 = Convert.ToInt32(reader["Test3"]);
                    m.Final = Convert.ToInt32(reader["FinalTest"]);
                    listMark.Add(m);
                }
            }
            catch(Exception ex) {
                Console.WriteLine("get all sai");
            }
            finally {
                if(conn.State != System.Data.ConnectionState.Closed) {
                    conn.Close();
                }
            }
            return listMark;
        }


        public static string getSubjectName_Hoang(string subjectID) {
            string sql = @"SELECT TOP (1) 
      [SubjectName]
  
  FROM [StudentManagementSystem].[dbo].[Subject]
  where [SubjectID] = @subjectID";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@subjectID", subjectID);
            conn.Open();
            string count = (string) cmd.ExecuteScalar();
            return count;
            conn.Close();
        }


    }
}
