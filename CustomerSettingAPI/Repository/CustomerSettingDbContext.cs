using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerSettingAPI.Entities;

namespace CustomerSettingAPI.Repository
{
    public class CustomerSettingDbContext : DbContext
    {
        public CustomerSettingDbContext(DbContextOptions<CustomerSettingDbContext> options) : base(options) { }
        public DbSet<CustomerSetting> CustomerSettings { get; set; }
    }
}
