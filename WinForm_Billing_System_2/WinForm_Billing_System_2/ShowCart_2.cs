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
    public partial class ShowCart_2 : Form
    {
        public ShowCart_2()
        {
            InitializeComponent();
        }

        private void ShowCart_2_Load(object sender, EventArgs e)
        {
            gridCart.Columns.Add("ID", "ID");
            gridCart.Columns.Add("Name", "Name");
            gridCart.Columns.Add("Price", "Price");
            gridCart.Columns.Add("Quantity", "Quantity");

            double total = 0.0;

            foreach (Product i in Billing.getInstance().cart)
            {
                gridCart.Rows.Add(new object[] { i.id, i.name, i.price, i.qty });

                total += i.price * i.qty;
            }

            Text += " Total : Rs. " + total.ToString();
        }
    }
}
