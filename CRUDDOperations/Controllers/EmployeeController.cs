  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDDOperations.Data_Access;
using CRUDDOperations.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDDOperations.Controllers
{
    public class EmployeeController : Controller
    {
        DAEmployees objDAEmployees = new DAEmployees();
      
        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<TblEmployee> tblEmployees()
        {
            return objDAEmployees.GetTblEmployees();
        }
    }
}
