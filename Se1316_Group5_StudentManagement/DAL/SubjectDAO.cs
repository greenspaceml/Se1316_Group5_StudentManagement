using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
