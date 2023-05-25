using System;
using CrmBL.Models;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class Main : Form
    {
        CrmContext db;

        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks, db);
            catalogCheck.Show();
        }

        private void addSellerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new AddSeller();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddCustomer();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddProduct();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }
    }
}