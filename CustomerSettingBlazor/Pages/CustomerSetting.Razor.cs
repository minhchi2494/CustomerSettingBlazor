using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerSettingBlazor.Services;
using Microsoft.AspNetCore.Components;
using CustomerSettingBlazor.Entities;

namespace CustomerSettingBlazor.Pages
{
    public partial class CustomerSetting
    {
        [Inject] public ICustomerServices services { set; get; }

        public List<CustomerSettingModel> CustomerSettings;

        protected override async Task OnInitializedAsync()
        {
            CustomerSettings = await services.getAll();
        }
    }
}
