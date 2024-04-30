using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StundetController : Controller
    {
        static IList<StudentModel> students = new List<StudentModel>()
        {
            new StudentModel(){Student_ID=1,Student_Name="Deepti",Age=22,Contact="9386346628"},
            new StudentModel(){Student_ID=2,Student_Name="Jimmy",Age=21,Contact="8836463892"},
            new StudentModel(){Student_ID=2,Student_Name="Jhon",Age=23,Contact="9867468892"}
        };
        // GET: Stundet
        public ActionResult Index()
        {
            return View(students);
         
        }


    }
}