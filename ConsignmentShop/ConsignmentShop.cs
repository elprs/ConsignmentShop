using ConsignmentShopLibrary;
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
        }

        public void SetUpData()
        {
            Vendor demoVendor = new Vendor();
            demoVendor.FirstName = "Bill";
            demoVendor.LastName = "Smith";
            demoVendor.Commission = .5;
            store.Vendors.Add(demoVendor);

            demoVendor = new Vendor();
            demoVendor.FirstName = "Sue";
            demoVendor.LastName = "Jones";
            demoVendor.Commission = .5;
            store.Vendors.Add(demoVendor);
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
