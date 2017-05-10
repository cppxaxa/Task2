using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Billing_Library
{
    public class Product
    {
        public string name;
        public int id;
        public double price;
        public int qty;

        public Product() { }
        public Product(string name, int id, double price, int qty)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.qty = qty;
        }

        public Product clone()
        {
            return new Product(name, id, price, qty);
        }
    }

    public class Billing
    {
        bool debug = false;

        public List<Product> inv = new List<Product>();
        public List<Product> cart = new List<Product>();


        // Singleton
        private static Billing obj = null;
        public static Billing getInstance()
        {
            if (obj == null)
            {
                obj = new Billing();
            }

            return obj;
        }

        // Private Constructor for Singleton
        private Billing()
        {  }

        // END Singleton


        public void StoreXML(string fname)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            TextWriter tw = new StreamWriter(fname);
            xml.Serialize(tw, inv);
            tw.Close();
        }

        public void LoadXML(string fname)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            TextReader tr = new StreamReader(fname);
            inv = (List<Product>)xml.Deserialize(tr);
            tr.Close();
        }

        public void cw(string s)
        {
            Console.WriteLine(s);
        }
        public string cr()
        {
            return Console.ReadLine();
        }

        public string menu()
        {
            cw("1. Make Bill");
            cw("2. Add Product");
            cw("3. Modify Product");

            return cr();
        }


        public Product search(string s)
        {
            foreach (Product i in inv)
            {
                if (i.name == s)
                {
                    return i;
                }
            }
            return null;
        }

        public void ModifyQty(string name, int qty)
        {
            Product p = null;

            foreach (Product i in inv)
            {
                if (i.name == name)
                {
                    p = i;
                }
            }

            if (p != null)
            {
                Product n = p.clone();
                inv.Remove(p);
                n.qty = qty;
                inv.Add(n);
            }
        }

        public void Add(string name, int id, double price, int qty)
        {
            Product p;
            p = new Product(name, id, price, qty);
            inv.Add(p);
        }

        public void ClearCart()
        {
            cart.Clear();
        }

        // It returns qty available in inventory
        public int AddItemToCart(string name, int qty = 1)
        {
            Product toSearch = search(name);

            if (toSearch == null)
            {
                throw new Exception("Item not found in inventory");
            }

            if (toSearch != null)
            {
                Product inCart = SearchInCart(name);

                if (inCart == null)
                {
                    if (toSearch.qty < qty)
                    {
                        cw("Insufficient qty in Inventory");
                        throw new Exception("Insufficient qty in Inventory, available qty : " + toSearch.qty);
                        
                        return toSearch.qty;
                    }
                    else
                    {
                        Product tmp = toSearch.clone();
                        tmp.qty = qty;
                        cart.Add(tmp);

                        return toSearch.qty - qty;
                    }
                }
                else if (inCart != null)
                {
                    if (toSearch.qty < inCart.qty + qty)
                    {
                        cw("Insufficiency in modifying qty");
                        throw new Exception("Insufficiency in modifying qty, available qty : " + toSearch.qty);

                        return toSearch.qty;
                    }
                    else
                    {
                        Product tmp = inCart.clone();
                        cart.Remove(inCart);
                        tmp.qty += qty;
                        cart.Add(tmp);

                        return toSearch.qty - inCart.qty - qty;
                    }
                }
            }

            return -1;
        }

        public Product SearchInCart(string name)
        {
            foreach (Product i in cart)
            {
                if (i.name == name)
                {
                    return i;
                }
            }

            return null;
        }

        public List<Product> CheckOutCart()
        {
            foreach (Product i in cart)
            {
                Product toSearch = search(i.name);

                if (toSearch.qty - i.qty == 0)
                {

                }
                else
                {
                    Product tmp = toSearch.clone();
                    tmp.qty -= i.qty;

                    inv.Add(tmp);
                }

                if (toSearch == null)
                    cw("Error searching cart item in inventory");

                bool result = inv.Remove(toSearch);


                if (debug)
                {
                    if (result)
                    {
                        cw("Object Removed");
                    }
                    else
                    {
                        cw("Object Not Removed");
                    }
                }
            }

            return cart;
        }

        public void conPrintCart()
        {
            cw("Cart\n\n");
            foreach (Product i in cart)
            {
                cw(i.name + "\t" + i.qty.ToString());
            }
            cw("--");
        }

        public void conPrintInventory()
        {
            cw("Inventory\n\n");
            foreach (Product i in inv)
            {
                cw(i.name + "\t" + i.qty.ToString());
            }
            cw("--");
        }
    }
}
