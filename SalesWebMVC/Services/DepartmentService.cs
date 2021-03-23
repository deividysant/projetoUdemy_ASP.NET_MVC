using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _salesWebMVC;

        public DepartmentService(SalesWebMVCContext salesWebMVC)
        {
            _salesWebMVC = salesWebMVC;
        }
    
        public List<Department> FindAll()
        {
            return _salesWebMVC.Department.OrderBy(x => x.Name).ToList();
        }
    
    
    }


}
