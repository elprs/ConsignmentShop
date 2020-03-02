﻿using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShop
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        public ConsignmentShop()
        {
            InitializeComponent();
            SetUpData();
        }

        public void SetUpData()
        {
            Vendor demoVendor = new Vendor();
            demoVendor.FirstName = "Bill";
            demoVendor.LastName = "Smith";
            demoVendor.Commission = .5;
            store.Vendors.Add(demoVendor);

            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "Whale's book",
                Price = 4.5M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Harry Potter",
                Description = "A boy's book",
                Price = 5.5M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "A tale of Cities",
                Description = "Revolution",
                Price = 3.8M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A girl's book",
                Price = 3.5M,
                Owner = store.Vendors[1]
            });

            store.Name = "Second's the better";

        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
