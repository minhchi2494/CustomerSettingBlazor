using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerSettingAPI.Entities;
using CustomerSettingAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace CustomerSettingAPI.Services
{
    public class CustomerSettingService : ICustomerSettingService
    {
        private readonly CustomerSettingDbContext _context;

        public CustomerSettingService(CustomerSettingDbContext context)
        {
            _context = context; 
        }

        public async Task<List<CustomerSetting>> getAll()
        {
            return _context.CustomerSettings.ToList();
        }
    }
}
