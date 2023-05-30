using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Models
{
    public class ShopComputerModel
    {
        Generator Generator = new Generator();
        Random rnd = new Random();
        bool isWorking;

        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public ShopComputerModel() 
        {
            var sellers = Generator.GetNewSellers(20);
            Generator.GetNewProducts(630);
            Generator.GetNewCustomers(120);

            foreach (var seller in sellers) 
            {
                Sellers.Enqueue(seller);
            }
            for (int i = 0; i < 3; i++) 
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue(), null));
            }
        }

        public void Start() 
        {
            isWorking = true;
            Task.Run(() => CreateCarts(10, 100));

            var cashDeskTasks = CashDesks.Select(c => new Task(() => CashDeskWork(c, 100)));
            foreach (var task in cashDeskTasks) 
            {
                task.Start();
            }
        }

        public void Stop() 
        {
            isWorking = false;
        }

        private void CashDeskWork(CashDesk cashDesk, int sleep) 
        {
            while (isWorking) 
            {
                if (CashDesks.Count > 0) 
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(sleep);
                }
            }
        }

        private void CreateCarts(int customersCount, int sleep) 
        {
            while (isWorking)
            {
                var customers = Generator.GetNewCustomers(customersCount);

                foreach (var customer in customers)
                {
                    var cart = new Cart(customer);

                    foreach (var product in Generator.GetRandomProducts(10, 20)) 
                    {
                        cart.Add(product);
                    }

                    var cash = CashDesks[rnd.Next(CashDesks.Count)];
                    cash.Enqueue(cart);
                }
                Thread.Sleep(sleep);
            }
        }
    }
}
