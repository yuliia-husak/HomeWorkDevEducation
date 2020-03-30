using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopTest_EmtityFram_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ShopTestEntities context = new ShopTestEntities();
        
        public MainWindow()
        {
            InitializeComponent();  
        }
       
        private void btnZak_GotFocus(object sender, RoutedEventArgs e)
        {
            btnZak.Background = Brushes.White;
        }

        private void btnZak_Click(object sender, RoutedEventArgs e)
        {
            grdWindowStart.Visibility = Visibility.Hidden;
            grdWindowCustomers.Visibility = Visibility.Hidden;
            grdWindowZak.Visibility = Visibility.Visible;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVendors_Click(object sender, RoutedEventArgs e)
        {
            grdWindowZak.Visibility = Visibility.Hidden;
            grdWindowVendors.Visibility = Visibility.Visible;
        }

        private void grdWindowVendors_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Vendors tempVend = new Vendors();
                tempVend.vend_id = txtVendorId.Text;
                tempVend.vend_name = txtVendorName.Text;
                tempVend.vend_address = txtVendorAddress.Text;
                tempVend.vend_city = txtVendorCity.Text;
                tempVend.vend_state = txtVendorState.Text;
                tempVend.vend_zip = txtVendorZip.Text;
                tempVend.vend_country = txtVendorCountry.Text;

                context.Vendors.Add(tempVend);
                context.SaveChanges();

                var au = context.Vendors.ToList();
                dgrVendors.Visibility = Visibility.Visible;

                dgrVendors.ItemsSource = au.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            dgrVendors.Visibility = Visibility.Visible;
            var au = context.Vendors.ToList();   

            dgrVendors.ItemsSource = au;
        }

        private void btnProd_Click(object sender, RoutedEventArgs e)
        {
            grdWindowZak.Visibility = Visibility.Hidden;
            grdWindowVendors.Visibility = Visibility.Hidden;
            grdWindowStart.Visibility = Visibility.Hidden;
            grdWindowCustomers.Visibility = Visibility.Visible;
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNavugution_Click(object sender, RoutedEventArgs e)
        {
            grdWindowStart.Visibility = Visibility.Visible;
            grdWindowVendors.Visibility = Visibility.Hidden;
            grdWindowZak.Visibility = Visibility.Hidden;
            grdWindowVendors.Visibility = Visibility.Hidden;
            dgrVendors.Visibility = Visibility.Hidden;
            grdWindowCustomers.Visibility = Visibility.Hidden;
            grdWindowZvit.Visibility = Visibility.Hidden;
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource customersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customersViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // customersViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource ordersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ordersViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // ordersViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource orderItemsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("orderItemsViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // orderItemsViewSource.Source = [generic data source]
        }

        private void btnShowAllc_Click(object sender, RoutedEventArgs e)
        {
           
            if (rbCust.IsChecked == true)
            {
                dgrProd.Visibility = Visibility.Visible;
                var prob = context.Customers.ToList();


                dgrProd.ItemsSource = prob;
            }

            if (rbOrd.IsChecked == true)
            {
                dgrProd.Visibility = Visibility.Visible;
                var prob = context.Orders.ToList();


                dgrProd.ItemsSource = prob;
            }
            if (rbOrdIt.IsChecked == true)
            {
                dgrProd.Visibility = Visibility.Visible;
                var prob = context.OrderItems.ToList();


                dgrProd.ItemsSource = prob;
            }

        }

        private void btnSearchc_Click(object sender, RoutedEventArgs e)
        {
            if (rbCust.IsChecked == true)
            {
                if (cust_idTextBox.Text != "")
                {
                    var query =
                    from product in context.Customers
                    where product.cust_id == cust_idTextBox.Text
                    select  new
                    {
                        product.cust_id,
                        product.cust_name,
                        CategoryName = product.cust_address,
                        product.cust_contact,
                        product.cust_country                        
                    };

                    dgrProd.ItemsSource = query.ToList();
                }                
            }

            if (rbOrd.IsChecked == true)
            {
                Orders orders = new Orders();
                orders.order_num = int.Parse(order_numTextBox.Text);
                if (order_numTextBox.Text != "")
                {                    
                    var query =
                    from product in context.Orders
                    where product.order_num == orders.order_num
                    select new
                    {
                        product.order_num,
                        product.order_date,
                        product.cust_id
                    };

                    dgrProd.ItemsSource = query.ToList();
                }
            }
            if (rbOrdIt.IsChecked == true)
            {
                OrderItems items = new OrderItems();
                items.order_num = int.Parse(order_numTextBox1.Text);
                if (order_numTextBox1.Text != "")
                {                    
                    var query =
                    from product in context.OrderItems
                    where product.order_num == items.order_num
                    select new
                    {
                        product.order_num,
                        product.order_item,
                        product.quantity,
                        product.item_price,
                        product.prod_id
                    };

                    dgrProd.ItemsSource = query.ToList();
                }
            }
        }

        private void btnReports_Click(object sender, RoutedEventArgs e)
        {
            grdWindowStart.Visibility = Visibility.Hidden;
            grdWindowVendors.Visibility = Visibility.Hidden;
            grdWindowZak.Visibility = Visibility.Hidden;
            grdWindowVendors.Visibility = Visibility.Hidden;
            dgrVendors.Visibility = Visibility.Hidden;
            grdWindowCustomers.Visibility = Visibility.Hidden;
            grdWindowZvit.Visibility = Visibility.Visible;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtVendorId.Text != "")
            {
                var query =
                from product in context.Vendors
                where product.vend_id == txtVendorId.Text
                select new
                {
                    product.vend_id,
                    product.vend_name,
                    CategoryName = product.vend_address,
                    product.vend_country
                };

                dgrVendors.ItemsSource = query.ToList();
            }
        }
    }
}

   
