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
    public partial class ShowInventory_2 : Form
    {
        public ShowInventory_2()
        {
            InitializeComponent();
        }

        private void ShowInventory_2_Load(object sender, EventArgs e)
        {
            gridInventory.Columns.Add("ID", "ID");
            gridInventory.Columns.Add("Name", "Name");
            gridInventory.Columns.Add("Price", "Price");
            gridInventory.Columns.Add("Quantity", "Quantity");

            foreach (Product i in Billing.getInstance().inv)
            {
                gridInventory.Rows.Add(new object[] { i.id, i.name, i.price, i.qty });
            }
        }
    }
}
