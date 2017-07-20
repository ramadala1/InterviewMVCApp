using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewMvcApp.Models;

namespace InterviewMvcApp.Controllers
{
    public class DepartmentController : Controller
    {
		// GET: Department
		public ActionResult Index()
		{
			Department model = new Department();
			try
			{
				SampleEntities Db = new SampleEntities();
				ViewBag.StateList = Db.Departments.ToList();
				
			}
			catch(Exception ex)
			{
				//Logger.Log(Excption while fetching Departments from DB {0},ex);
			}
			
			return View(model);
		}
    }
}