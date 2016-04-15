using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Testing_Learning.Controllers
{
    public class StudentsController : ApiController
    {
        studentDBEntities objapi = new studentDBEntities();

        // to Search Student Details and display the result
        [HttpGet]
        public IEnumerable<USP_Student_Select_Result> Get(string StudentName, string StudentEmail)
        {
            if (StudentName == null)
                StudentName = "";
            if (StudentEmail == null)
                StudentEmail = "";
            return objapi.USP_Student_Select(StudentName, StudentEmail).AsEnumerable();
        }

        // to Insert new Student Details
        [HttpGet]
        public IEnumerable<string> instertStudent(string StudentName, string StudentEmail, string Phone, string Address)
        {
            return objapi.USP_Student_Insert(StudentName, StudentEmail, Phone, Address).AsEnumerable();
        }

        // to Update Student Details
        [HttpGet]
        public IEnumerable<string> updateStudent(int stdID, string StudentName, string StudentEmail, string Phone, string Address)
        {
            return objapi.USP_Student_Update(stdID, StudentName, StudentEmail, Phone, Address).AsEnumerable();
        }

        // to Delete Student Details
        [HttpGet]
        public string deleteStudent(int stdID)
        {
            objapi.USP_Student_Delete(stdID);
            return "deleted";
        }
    }
}
