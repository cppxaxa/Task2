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

    public partial class Main : Form
    {
        string fname = "dataset.xml";

        AddItem it = new AddItem();
        ModifyQuantity mq = new ModifyQuantity();
        ShowCart sc = new ShowCart();
        //ShowInventory si = new ShowInventory();
        AddToCart atc = new AddToCart();
        Welcome welcome = new Welcome();
        Invoice invoice = new Invoice();

        //Updates
        ShowInventory_2 si2 = null;
        ShowCart_2 sc_2 = null;


        public Main()
        {
            InitializeComponent();

            it.ControlBox = false;
            mq.ControlBox = false;
            sc.ControlBox = false;
            //si.ControlBox = false;
            atc.ControlBox = false;
            invoice.ControlBox = false;

            it.MdiParent = this;
            mq.MdiParent = this;
            sc.MdiParent = this;
            //si.MdiParent = this;
            atc.MdiParent = this;
            welcome.MdiParent = this;
            invoice.MdiParent = this;

            welcome.Show();
            welcome.SetBounds(250, 100, welcome.Width, welcome.Height);


            // Updates
            //si2.ControlBox = false;

            //si2.MdiParent = this;

            //si2.Show();


        }

        private void addItemToCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Billing.getInstance().LoadXML(fname);
            }
            catch (Exception)
            {
                Billing.getInstance().cart.Clear();
                Billing.getInstance().inv.Clear();
            }
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sc.Show();

            sc_2 = new ShowCart_2();
            sc_2.MdiParent = this;
            sc_2.Show();
        }

        private void showInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //si.Show();

            si2 = new ShowInventory_2();
            si2.MdiParent = this;
            si2.Show();
        }

        private void modifyItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Billing.getInstance().StoreXML(fname);
            //MessageBox.Show("Hello");
        }

        private void addItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            it.Show();
        }

        private void modifyQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mq.Show();
        }

        private void addItemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            atc.Show();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Billing.getInstance().cart.Count != 0)
            {
                List<Product> cart = Billing.getInstance().CheckOutCart();

                double sum = 0.0;
                foreach (Product i in cart)
                {
                    sum += i.price * i.qty;
                }

                invoice.Show(cart);
                //MessageBox.Show("Total Amount : Rs. " + sum);
            }
            else
            {
                MessageBox.Show("Cart empty");
            }
        }
    }
}
