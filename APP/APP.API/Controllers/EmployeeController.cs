using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.BUSINESS;
using APP.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult Get()
        {            
            var items = this.employeeService.GetEmployees();
            return new OkObjectResult(items);
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            Employee employee = this.employeeService.GetEmployeeById(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            else
                return NotFound();
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee emp)
        {
            if (ModelState.IsValid)
            {
                this.employeeService.InsertEmployee(emp);
                return Ok(emp);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Employee employee)
        {

            if (ModelState.IsValid)
            {
                this.employeeService.UpdateEmployee(employee);
                return Ok(employee);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = this.employeeService.GetEmployeeById(id);
            if (emp != null)
            {
                this.employeeService.DeleteEmployee(emp);
                return Ok(emp);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
