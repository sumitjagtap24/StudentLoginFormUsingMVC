using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentLogin.Models;
using System.Net.Http;

namespace StudentLogin.Controllers
{
    public class NeqStudentController : Controller
    {
        // GET: NeqStudent
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(NewStudent std)
        {
            if (ModelState.IsValid)
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44391/api/Students");

                var insertData = hc.PostAsJsonAsync<NewStudent>("Students", std);
                insertData.Wait();

                var saveData = insertData.Result;
                if (saveData.IsSuccessStatusCode)
                {
                    ViewBag.message = "The Student " + " "  + std.Name +  " Is saved Successfully...!!";

                }
            }
            return View();
        }
    }
}