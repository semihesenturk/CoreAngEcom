﻿using CoreAngEcom.Domain.Entities.Common;

namespace CoreAngEcom.Domain.Entities
{
    public class Product : BaseEntity
	{
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

