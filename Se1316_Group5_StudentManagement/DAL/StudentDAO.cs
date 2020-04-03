using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Se1316_Group5_StudentManagement.DAL {

    class StudentDAO {
        string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public static DataTable GetListStudent_Quang() {
            string cmd = "Select * from Student";
            return DAO.GetDataTable(cmd);
        }
        public static bool InsertStudent_Quang(string Name, int Gender, string DoB,string Addess, string Phone, string Email) {
            SqlCommand cmd = new SqlCommand(" insert into Student ([Name],Gender,DoB,Addess,Phone,Email) " +
                                            " values (@Name,@Gender,@DoB,@Addess,@Phone,@Email)");
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DoB", DoB);
            cmd.Parameters.AddWithValue("@Addess", Addess);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            return DAO.UpdateTable(cmd);
        }
        public static bool DeleteStudent(string studentID) {
            SqlCommand cmd = new SqlCommand("delete from Student where StudentID=@studentID");
            cmd.Parameters.AddWithValue("@studentID", studentID);
            return DAO.UpdateTable(cmd);
        }

        public static bool UpdateStudent_Quang(string studentID, string Name, int Gender, string DoB, string Addess, string Phone, string Email) {
            SqlCommand cmd = new SqlCommand(" update Student set [Name] =@Name ,Gender=@Gender ,DoB=@DoB ,Addess=@Addess ,Phone=@Phone ,Email=@Email  " +
                                            " where StudentID=@studentID");
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DoB", DoB);
            cmd.Parameters.AddWithValue("@Addess", Addess);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@studentID", studentID);
            return DAO.UpdateTable(cmd);
        }
    }
}
