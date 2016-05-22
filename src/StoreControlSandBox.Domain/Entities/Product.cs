﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreControlSandBox.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
    }
}
