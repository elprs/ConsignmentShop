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
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        public ConsignmentShop()
        {
            InitializeComponent();
            SetUpData();
            itemsBinding.DataSource = store.Items.Where(x => x.IsSold == false).ToList();
            ItemsListBox.DataSource = itemsBinding;
            ItemsListBox.DisplayMember = "Display";
            ItemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;
            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            VendorListBox.DataSource = vendorsBinding;
            VendorListBox.DisplayMember = "Display";
            VendorListBox.ValueMember = "Display";
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

        private void addToCart_Click(object sender, EventArgs e)
        {
            // Figure out what is selected from the items list
            //Copy that item ti the shopping list
            //Do we remove the item from the items list? - no
            Item selectedItem = (Item)ItemsListBox.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void MakePurchase_Click(object sender, EventArgs e)
        {
            //mark each item in the cart as sold
            //clear the cart

            foreach (var item in shoppingCartData)
            {
                item.IsSold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.IsSold == false).ToList();

            StoreProfitValue.Text = String.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            
        }
    }
}
