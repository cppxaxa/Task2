using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Billing_Library;

namespace WinForm_Billing_System_2
{
    public partial class ShowCart : Form
    {
        public ShowCart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ShowCart_Load(object sender, EventArgs e)
        {
            lstID.Items.Clear();
            lstName.Items.Clear();
            lstPrice.Items.Clear();
            lstQuantity.Items.Clear();

            lstID.Items.Add("ID");
            lstID.Items.Add("");
            lstName.Items.Add("Name");
            lstName.Items.Add("");
            lstPrice.Items.Add("Price");
            lstPrice.Items.Add("");
            lstQuantity.Items.Add("Quantity");
            lstQuantity.Items.Add("");

            foreach (Product i in Billing.getInstance().cart)
            {
                lstID.Items.Add(i.id.ToString());
                lstName.Items.Add(i.name);
                lstPrice.Items.Add(i.price.ToString());
                lstQuantity.Items.Add(i.qty.ToString());
            }
        }

    }
}
