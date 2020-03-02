namespace ConsignmentShop
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBoxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.ShoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.MakePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(53, 26);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(879, 82);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 40;
            this.ItemsListBox.Location = new System.Drawing.Point(67, 212);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(497, 324);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemsListBoxLabel
            // 
            this.ItemsListBoxLabel.AutoSize = true;
            this.ItemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListBoxLabel.Location = new System.Drawing.Point(60, 135);
            this.ItemsListBoxLabel.Name = "ItemsListBoxLabel";
            this.ItemsListBoxLabel.Size = new System.Drawing.Size(211, 40);
            this.ItemsListBoxLabel.TabIndex = 2;
            this.ItemsListBoxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(587, 330);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(236, 112);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart -->";
            this.addToCart.UseVisualStyleBackColor = true;
            // 
            // ShoppingCartListBoxLabel
            // 
            this.ShoppingCartListBoxLabel.AutoSize = true;
            this.ShoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListBoxLabel.Location = new System.Drawing.Point(841, 135);
            this.ShoppingCartListBoxLabel.Name = "ShoppingCartListBoxLabel";
            this.ShoppingCartListBoxLabel.Size = new System.Drawing.Size(260, 40);
            this.ShoppingCartListBoxLabel.TabIndex = 5;
            this.ShoppingCartListBoxLabel.Text = "Shopping Cart";
            this.ShoppingCartListBoxLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 40;
            this.shoppingCartListBox.Location = new System.Drawing.Point(848, 212);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(497, 324);
            this.shoppingCartListBox.TabIndex = 4;
            this.shoppingCartListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MakePurchase
            // 
            this.MakePurchase.Location = new System.Drawing.Point(1109, 578);
            this.MakePurchase.Name = "MakePurchase";
            this.MakePurchase.Size = new System.Drawing.Size(236, 73);
            this.MakePurchase.TabIndex = 6;
            this.MakePurchase.Text = "Purchase";
            this.MakePurchase.UseVisualStyleBackColor = true;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 791);
            this.Controls.Add(this.MakePurchase);
            this.Controls.Add(this.ShoppingCartListBoxLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.ItemsListBoxLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShop";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsListBoxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label ShoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button MakePurchase;
    }
}

