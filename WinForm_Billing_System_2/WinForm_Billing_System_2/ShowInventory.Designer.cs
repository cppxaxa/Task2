namespace WinForm_Billing_System_2
{
    partial class ShowInventory
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
            this.lstID = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstName = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.lstQuantity = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstID
            // 
            this.lstID.FormattingEnabled = true;
            this.lstID.Location = new System.Drawing.Point(12, 12);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(95, 199);
            this.lstID.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(113, 12);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(150, 199);
            this.lstName.TabIndex = 2;
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.Location = new System.Drawing.Point(269, 12);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(97, 199);
            this.lstPrice.TabIndex = 3;
            // 
            // lstQuantity
            // 
            this.lstQuantity.FormattingEnabled = true;
            this.lstQuantity.Location = new System.Drawing.Point(372, 12);
            this.lstQuantity.Name = "lstQuantity";
            this.lstQuantity.Size = new System.Drawing.Size(75, 199);
            this.lstQuantity.TabIndex = 4;
            // 
            // ShowInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 252);
            this.Controls.Add(this.lstQuantity);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShowInventory";
            this.Text = "Show Inventory";
            this.Activated += new System.EventHandler(this.ShowInventory_Load);
            this.Load += new System.EventHandler(this.ShowInventory_Load);
            this.Enter += new System.EventHandler(this.ShowInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ListBox lstQuantity;
    }
}