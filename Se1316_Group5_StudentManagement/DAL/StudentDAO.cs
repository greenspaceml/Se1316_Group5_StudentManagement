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
    }
}
