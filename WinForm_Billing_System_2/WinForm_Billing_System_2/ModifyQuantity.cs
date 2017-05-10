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
    public partial class ModifyQuantity : Form
    {
        public ModifyQuantity()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();

            txtName.Text = "";
            txtQuantity.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                Billing.getInstance().ModifyQty(
                    txtName.Text, int.Parse(txtQuantity.Text)
                );

                txtName.Text = "";
                txtQuantity.Text = "";

                MessageBox.Show("Inventory Modified Successfully");

                Hide();
            }
        }
    }
}
