﻿using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class OrderDetail : EntityBase
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
