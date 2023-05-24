﻿
using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }

        public ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
