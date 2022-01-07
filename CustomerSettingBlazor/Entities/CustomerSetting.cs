using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CustomerSettingBlazor.Entities
{
    public class CustomerSettingModel
    {
        public Guid Id { get; set; }

        [StringLength(5)]
        public string AttributeId { get; set; }

        [StringLength(30)]
        public string AttributeName { get; set; }

        [StringLength(40)]
        public string Description { get; set; }

        public bool IsDistributorAttribute { get; set; }
        public bool IsCustomerAttribute { get; set; }
        public bool Used { get; set; }
    }
}
