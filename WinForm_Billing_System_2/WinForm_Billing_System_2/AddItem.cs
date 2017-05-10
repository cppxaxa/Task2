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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Billing.getInstance().Add(
                //txtName.Text, int.Parse(txtID.Text), double.Parse(txtPrice.Text), int.Parse(txtQuantity.Text)
                //"ABC", 1, 1.1, 1
                txtName.Text, int.Parse(txtID.Text), double.Parse(txtPrice.Text), int.Parse(txtQuantity.Text)
                );


            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            
            Hide();

            MessageBox.Show("Item Added to Inventory");
        }

    }
}
