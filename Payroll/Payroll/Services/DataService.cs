using Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Services
{
    public class DataService : IDataService
    {
        private readonly List<Employee> lstEmployee = new List<Employee>();
        public DataService()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.FirstName = "Joydip";
            employee.LastName = "Kanjilal";
            employee.Address = "India";
            lstEmployee.Add(employee);
        }
        public List<Employee> Get()
        {
            if (lstEmployee.Count > 0)
            {
                return lstEmployee;
            }
            return null;
        }

        public Employee GetById(int id)
        {
            if(lstEmployee.Count > 0)
            {
                return lstEmployee.Where(s => s.Id == id).FirstOrDefault();
            }
            return null;
        }
    }
}
