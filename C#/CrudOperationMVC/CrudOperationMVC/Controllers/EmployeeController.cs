using CrudOperationMVC.Models;
using CrudOperationMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperationMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllEmployeeDetails()
        {
            EmployeeRepository EmpRepo= new EmployeeRepository();
            ModelState.Clear();
            return View(EmpRepo.GetEmployeeList());
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel Emp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmployeeRepository EmpRepo = new EmployeeRepository();
                    if(EmpRepo.AddEmployee(Emp))
                    {
                        ViewBag.Message = "Employee Details Added Successfully";
                    }
                }
                return View();
            }
            catch
            {
                return View();  
            }
        }
        public ActionResult EditEmpDetails(int id)
        {
            EmployeeRepository EmpRepo=new EmployeeRepository();
            return View(EmpRepo.GetEmployeeList().Find(Emp=>Emp.ID==id));
        }
        [HttpPost]
        public ActionResult EditEmpDetails(int id, EmployeeModel EmpMod)
        {
            try
            {
                EmployeeRepository EmpRepo = new EmployeeRepository();

                EmpRepo.UpdateEmployee(EmpMod);
                return RedirectToAction("GetAllEmployeeDetails");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteEmp(int id)
        {
            try
            {
                EmployeeRepository EmpRepo = new EmployeeRepository();
                if(EmpRepo.DeleteEmployee(id))
                {
                    ViewBag.AlertMsg = "Employee Details Deleted Successfully";
                }
                return RedirectToAction("GetAllEmployeeDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
