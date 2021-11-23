using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJSDemoApp.Models;

namespace AngularJSDemoApp.Repository
{
    public interface IRepository
    {
        List<EmployeeModel> GetEmployees();
        string AddEmployee(EmployeeModel empDetails);
        string updateEmployee(EmployeeModel empdetails);
        string deleteEmployee(int id); 
    }
}
