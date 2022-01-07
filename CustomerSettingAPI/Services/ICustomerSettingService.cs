using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerSettingAPI.Entities;

namespace CustomerSettingAPI.Services
{
    public interface ICustomerSettingService
    {
        Task<List<CustomerSetting>> getAll();
    }
}
