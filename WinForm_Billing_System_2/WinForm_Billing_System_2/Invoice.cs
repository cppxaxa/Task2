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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        public void Show(List<Product> list)
        {
            Show();

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

            Billing.getInstance().cart.Clear();

            /*
            lstID.Items.Add("ID");
            lstID.Items.Add("");
            lstName.Items.Add("Name");
            lstName.Items.Add("");
            lstPrice.Items.Add("Individual Price");
            lstPrice.Items.Add("");
            lstQuantity.Items.Add("Quantity");
            lstQuantity.Items.Add("");
            lstTotal.Items.Add("Total");
            lstTotal.Items.Add("");


            double total = 0.0;
            foreach (Product i in list)
            {
                lstID.Items.Add(i.id.ToString());
                lstName.Items.Add(i.name);
                lstPrice.Items.Add(i.price.ToString());
                lstQuantity.Items.Add(i.qty.ToString());
                lstTotal.Items.Add((i.qty * i.price).ToString());

                total += i.qty * i.price;
            }
            */

            lblTotal.Text = "Rs. " + total.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
