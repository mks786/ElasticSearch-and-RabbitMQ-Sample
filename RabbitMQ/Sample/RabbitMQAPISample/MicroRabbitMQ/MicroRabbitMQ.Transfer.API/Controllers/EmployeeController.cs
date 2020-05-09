using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbitMQ.Transfer.Application.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMQ.Transfer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeTransferService _employeeTransferService;

        public EmployeeController(IEmployeeTransferService employeeTransferService)
        {
            _employeeTransferService = employeeTransferService;
        }

        // GET: api/Employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Employee> Get(int id)
        {
            return Ok();
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            _employeeTransferService.TransferInsertEmployee(employee);
            return Ok(employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            _employeeTransferService.TransferUpdateEmployee(id, employee);
            return Ok(employee);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _employeeTransferService.TransferDeleteEmployee(id);
        }
    }
}
