using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerSettingBlazor.Entities;

namespace CustomerSettingBlazor.Services
{
    public interface ICustomerServices
    {
        Task<List<CustomerSettingModel>> getAll();
    }
}
