
namespace CrmBL.Models
{
    public class Sell
    {
        public int SellId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CheckId { get; set; }
        public Check Check { get; set; }
    }
}
