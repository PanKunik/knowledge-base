﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
    }
}
