using CrmBL.Models;
using System;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class AddCustomer : Form
    {
        public Customer Customer { get; set; }

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer = new Customer()
            {
                Name = textBox1.Text
            };
            Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
