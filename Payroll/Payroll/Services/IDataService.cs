using Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Services
{
    public interface IDataService
    {
        List<Employee> Get();
        Employee GetById(int id);
    }
}
