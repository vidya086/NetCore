using Microsoft.AspNetCore.Mvc;
using Payroll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payroll.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IDataService dataService;
        public EmployeesController(IDataService dataservice )
        {
            dataService = dataservice;
            //hghghgh
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        public IActionResult Get()
        {
          var result =  dataService.Get();
            if(result !=null && result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}" , Name ="GetById")]
        public IActionResult Get(int id)
        {
            var result = dataService.GetById(id);
            if(result !=null )
            {
                return Ok(result);

            }
            else
            {
                return NotFound();
            }
        }

       
    }
}
