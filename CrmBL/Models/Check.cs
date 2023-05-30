
using System;
using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Check
    {
        public int CheckId { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal Price { get; set; }

        public ICollection<Sell> Sells { get; set; }

        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"{CheckId} от {Created.ToString("dd.MM.yy hh:mm")}";
        }
    }
}
