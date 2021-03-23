using Microsoft.EntityFrameworkCore;
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
    
        public async Task<List<Department>> FindAllAsync()
        {
            return await _salesWebMVC.Department.OrderBy(x => x.Name).ToListAsync();
        }
    
    
    }


}
