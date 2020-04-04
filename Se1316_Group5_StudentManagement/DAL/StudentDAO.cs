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
        public static bool InsertStudent_Quang(string ClassID,string Name, int Gender, string DoB,string Addess, string Phone, string Email) {
            SqlCommand cmd = new SqlCommand(" insert into Student ([Name],Gender,DoB,Addess,Phone,Email,ClassID) " +
                                            " values (@Name,@Gender,@DoB,@Addess,@Phone,@Email,@ClassID)");
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DoB", DoB);
            cmd.Parameters.AddWithValue("@Addess", Addess);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@ClassID", ClassID);
            return DAO.UpdateTable(cmd);
        }
        public static bool DeleteStudent_Quang(string studentID) {
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

        public static DataTable GetListClassesByStudentID_Quang(string studentID) {
            string cmd = @"	    Select distinct(cl.ClassID), cl.ClassName
	                            From Student st inner join Class cl
	                            On st.ClassID = cl.ClassID inner join Teacher_Class tc
	                            On cl.ClassID = tc.ClassID inner join Teach te
	                            On tc.TeacherID = te.TeacherID inner join Subject su
	                            On te.SubjectID = su.SubjectID
	                            where st.StudentID = " + studentID;
            return DAO.GetDataTable(cmd);
        }

        public static DataTable GetListClasses_Quang() {
            string cmd = @" Select * From Class ";
            return DAO.GetDataTable(cmd);
        }
        public static DataTable GetListSubjectByClass_Quang(string classID) {
            string cmd = @" Select distinct(su.SubjectName)
	                        From Student st inner join Class cl
	                        On st.ClassID = cl.ClassID inner join Teacher_Class tc
	                        On cl.ClassID = tc.ClassID inner join Teach te
	                        On tc.TeacherID = te.TeacherID inner join Subject su
	                        On te.SubjectID = su.SubjectID
	                        where cl.ClassID = " + classID;
            return DAO.GetDataTable(cmd);
        }

        public static bool ChangeClass(string ClassID, string StudentID) {
            SqlCommand cmd = new SqlCommand(@" Update Student set ClassID = @ClassID
                                                 where StudentID = @StudentID");
            cmd.Parameters.AddWithValue("@ClassID", ClassID);
            cmd.Parameters.AddWithValue("@StudentID", StudentID);
            return DAO.UpdateTable(cmd);
        }
    }
}
