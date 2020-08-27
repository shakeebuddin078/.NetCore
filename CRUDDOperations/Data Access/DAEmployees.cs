using CRUDDOperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDOperations.Data_Access
{
    public class DAEmployees
    {
        TestdbContext dbcontext = new TestdbContext();
        public IEnumerable<TblEmployee> GetTblEmployees()
        {

            try { return dbcontext.TblEmployee.ToList(); }
            catch { throw; }
        }
    }
}
