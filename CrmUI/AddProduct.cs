using CrmBL.Models;
using System;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class AddProduct : Form
    {
        public Product Product { get; set; }

        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = textBox1.Text,
                Price = numericUpDown1.Value,
                Count = Convert.ToInt32(numericUpDown2.Value)
            };
            Close();
        }
    }
}
