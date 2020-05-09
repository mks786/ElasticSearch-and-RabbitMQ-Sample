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
    }
}
