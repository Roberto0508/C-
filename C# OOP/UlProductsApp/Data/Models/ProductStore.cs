﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class ProductStore
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int Stock { get; set; }
    }
}
