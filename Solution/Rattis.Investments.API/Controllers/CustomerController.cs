using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rattis.Investments.Application.Contracts.Interfaces;

namespace Rattis.Investments.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerApp _customerApp;

        public CustomerController(ILogger<CustomerController> logger, ICustomerApp customerApp)
        {
            _logger = logger;
            _customerApp = customerApp;
        }

        [HttpGet]
        [Route("/{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            return Ok(_customerApp.GetCustumerDocument(id));
        }
    }
}
