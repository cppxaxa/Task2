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
    public partial class AddToCart : Form
    {
        public AddToCart()
        {
            InitializeComponent();
        }

        private void AddToCart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text == "")
                {
                    Billing.getInstance().AddItemToCart(
                        txtName.Text,
                        1
                        );
                }
                else
                {
                    try
                    {
                        Billing.getInstance().AddItemToCart(
                            txtName.Text,
                            int.Parse(txtQuantity.Text)
                            );

                        Hide();
                        MessageBox.Show("Items added to Cart Successfully");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
