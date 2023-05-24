﻿
using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
