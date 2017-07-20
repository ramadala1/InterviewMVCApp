using InterviewMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterviewMvcApp.Controllers
{
    public class EmployeeController : Controller
    {
		// GET: Employee
		public ActionResult GetEmployee(string id)
		{
			List<Employee> employees = null;
			try
			{
				SampleEntities Db = new SampleEntities();
				employees = (from x in Db.Employees where x.DepartmentCode == id select x).ToList();
				return Json(employees, JsonRequestBehavior.AllowGet);
			}
			catch(Exception ex)
			{
				return Json(employees);
				//Logger.Log("Exception while fetching Employee records {0}",ex);
			}
			
		}
    }
}