using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSDemoApp.Models;
using AngularJSDemoApp.Repository;
using Newtonsoft.Json;

namespace AngularJSDemoApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IRepository _repository;
        //public HomeController(IRepository repository)
        //{
        //    this._repository = repository;
        //}

        //[HttpGet]
        //public ActionResult getEmployee()
        //{
        //    List<EmployeeModel> list = new List<EmployeeModel>();

        //    list = _repository.GetEmployees();

        //    string json_data = JsonConvert.SerializeObject(list);

        //    return Json(json_data, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult AddEmployee(EmployeeModel empdetails)
        //{
        //    string result = _repository.AddEmployee(empdetails);

        //    List<EmployeeModel> list = new List<EmployeeModel>();
        //    list = _repository.GetEmployees();

        //    string json_data = JsonConvert.SerializeObject(list);

        //    return Json(json_data, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult UpdateEmployee(EmployeeModel empdetails)
        //{
        //    string result = _repository.updateEmployee(empdetails);

        //    List<EmployeeModel> list = new List<EmployeeModel>();
        //    list = _repository.GetEmployees();

        //    string json_data = JsonConvert.SerializeObject(list);

        //    return Json(json_data, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult DeleteEmployee(int ID)
        //{
        //    string result = _repository.deleteEmployee(ID);

        //    List<EmployeeModel> list = new List<EmployeeModel>();
        //    list = _repository.GetEmployees();

        //    string json_data = JsonConvert.SerializeObject(list);

        //    return Json(json_data, JsonRequestBehavior.AllowGet);
        //} 

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}