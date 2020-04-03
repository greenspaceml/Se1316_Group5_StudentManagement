using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Se1316_Group5_StudentManagement.DAL {
    class ClassDAO {
        public static DataTable GetAllClass_Hieu() {
            string cmd = "select * from Class";
            return DAO.GetDataTable(cmd);
        }
    }
}
