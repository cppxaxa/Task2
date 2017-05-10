namespace WinForm_Billing_System_2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.shoppingCartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCartToolStripMenuItem,
            this.showInventoryToolStripMenuItem});
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cartToolStripMenuItem.Text = "Report";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // showCartToolStripMenuItem
            // 
            this.showCartToolStripMenuItem.Name = "showCartToolStripMenuItem";
            this.showCartToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showCartToolStripMenuItem.Text = "Show Cart";
            this.showCartToolStripMenuItem.Click += new System.EventHandler(this.showCartToolStripMenuItem_Click);
            // 
            // showInventoryToolStripMenuItem
            // 
            this.showInventoryToolStripMenuItem.Name = "showInventoryToolStripMenuItem";
            this.showInventoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showInventoryToolStripMenuItem.Text = "Show Inventory";
            this.showInventoryToolStripMenuItem.Click += new System.EventHandler(this.showInventoryToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem1,
            this.modifyQuantityToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addItemToolStripMenuItem1
            // 
            this.addItemToolStripMenuItem1.Name = "addItemToolStripMenuItem1";
            this.addItemToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.addItemToolStripMenuItem1.Text = "Add Item";
            this.addItemToolStripMenuItem1.Click += new System.EventHandler(this.addItemToolStripMenuItem1_Click);
            // 
            // modifyQuantityToolStripMenuItem
            // 
            this.modifyQuantityToolStripMenuItem.Name = "modifyQuantityToolStripMenuItem";
            this.modifyQuantityToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modifyQuantityToolStripMenuItem.Text = "Modify Quantity";
            this.modifyQuantityToolStripMenuItem.Click += new System.EventHandler(this.modifyQuantityToolStripMenuItem_Click);
            // 
            // shoppingCartToolStripMenuItem
            // 
            this.shoppingCartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.checkoutToolStripMenuItem});
            this.shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            this.shoppingCartToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.shoppingCartToolStripMenuItem.Text = "Shopping Cart";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click_1);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.checkoutToolStripMenuItem.Text = "Checkout !";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 688);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Billing System ( XML Source : dataset.xml )";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
    }
}

