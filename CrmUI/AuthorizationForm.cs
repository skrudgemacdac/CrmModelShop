using CrmBL.Models;
using System;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class AuthorizationForm : Form
    {
        public Customer Customer { get; set; }

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Customer = new Customer()
            {
                Name = textBox2.Text
            };
            DialogResult = DialogResult.OK;
        }
    }
}
