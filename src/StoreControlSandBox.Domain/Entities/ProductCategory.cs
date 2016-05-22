using StoreControlSandBox.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreControlSandBox.Domain.Entities
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public ECategoryType Type { get; set; }
        public string Description { get; set; }
    }
}
