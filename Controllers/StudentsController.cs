using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentLogin.Models;

namespace StudentLogin.Controllers
{
    public class StudentsController : ApiController
    {
            public IHttpActionResult addStudent(Student student)
        {
            enexionEntities db = new enexionEntities();
            db.InsertStudent(student.Name, student.DOB, student.Email, student.Gender, student.Lang);
             // db.InsertStudent(student.Name, student.Email, student.DOB, student.Gender, student.Lang);
            //db.InsertStudent(student.Name, student.Email, student.Gender, student.DOB, student.Lang);
            db.SaveChanges();
            
            // db.InsertStudent(student.);
            return Ok();
        }
    }
}
