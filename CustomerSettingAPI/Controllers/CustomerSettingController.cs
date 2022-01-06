using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerSettingAPI.Entities;
using CustomerSettingAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSettingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSettingController : ControllerBase
    {
        private readonly ICustomerSettingService _services;

        public CustomerSettingController(ICustomerSettingService services)
        {
            _services = services;   
        }

        [HttpGet]
        public Task<IEnumerable<CustomerSetting>> getAll()
        {
            return _services.getAll();
        }
    }
}
