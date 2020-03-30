using System;
using System.Collections.Generic;
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
using System.Data.Entity;

namespace ShopTest_WF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShopTestEntities context = new ShopTestEntities();
        CollectionViewSource custViewSource;
        CollectionViewSource ordViewSource;

        public MainWindow()
        {
            InitializeComponent();
            custViewSource = ((CollectionViewSource)(FindResource("customerViewSource")));
            ordViewSource = ((CollectionViewSource)(FindResource("customerOrdersViewSource")));
            DataContext = this;
        }

        private void btnZak_GotFocus(object sender, RoutedEventArgs e)
        {
            btnZak.Background = Brushes.White;
        }

        private void btnZak_Click(object sender, RoutedEventArgs e)
        {
            grdWindowStart.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grdWindowZak.Visibility = Visibility.Hidden;

        }

        private void LastCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToLast();            
        }

        private void PreviousCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToPrevious();
        }

        private void NextCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToNext();
        }

        private void FirstCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToFirst();
        }

        private void DeleteCustomerCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // If existing window is visible, delete the customer and all their orders.  
            // In a real application, you should add warnings and allow the user to cancel the operation.  
            var cur = custViewSource.View.CurrentItem as Customers;

            var cust = (from c in context.Customers
                        where c.cust_id == cur.cust_id
                        select c).FirstOrDefault();

            if (cust != null)
            {
                foreach (var ord in cust.Orders.ToList())
                {
                    Delete_Order(ord);
                }
                context.Customers.Remove(cust);
            }
            context.SaveChanges();
            custViewSource.View.Refresh();
        }

        // Commit changes from the new customer form, the new order form,  
        // or edits made to the existing customer form.  
        private void UpdateCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (newCustomerGrid.IsVisible)
            {
                // Create a new object because the old one  
                // is being tracked by EF now.  
                Customers newCustomer = new Customers
                {
                    cust_id = add_customerIDTextBox.Text,
                    cust_name = add_contactNameTextBox.Text,
                    cust_address = add_addressTextBox.Text,
                    cust_city = add_cityTextBox.Text,
                    cust_state = add_stateTextBox.Text,
                    cust_zip = add_zipTextBox.Text,
                    cust_country = add_countryTextBox.Text,
                    cust_contact = add_contactNameTextBox.Text,
                    cust_email = add_emailTextBox.Text,
                };

                // Perform very basic validation  
                if (newCustomer.cust_id.Length == 5)
                {
                    // Insert the new customer at correct position:  
                    int len = context.Customers.Local.Count();
                    int pos = len;
                    for (int i = 0; i < len; ++i)
                    {
                        if (String.CompareOrdinal(newCustomer.cust_id, context.Customers.Local[i].cust_id) < 0)
                        {
                            pos = i;
                            break;
                        }
                    }
                    context.Customers.Local.Insert(pos, newCustomer);
                    custViewSource.View.Refresh();
                    custViewSource.View.MoveCurrentTo(newCustomer);
                }
                else
                {
                    MessageBox.Show("CustomerID must have 5 characters.");
                }

                newCustomerGrid.Visibility = Visibility.Collapsed;
                existingCustomerGrid.Visibility = Visibility.Visible;
            }
            else if (newOrderGrid.IsVisible)
            {
                // Order ID is auto-generated so we don't set it here.  
                // For CustomerID, address, etc we use the values from current customer.  
                // User can modify these in the datagrid after the order is entered.  

                Orders newOrder = new Orders()
                {
                    order_date = add_orderDatePicker.DisplayDate, //SelectedDate ????????
                    cust_id = add_order_cust_id.Text,
                    
                };
                
                // Add the order into the EF model  
                context.Orders.Add(newOrder);
                ordViewSource.View.Refresh();
            }

            // Save the changes, either for a new customer, a new order  
            // or an edit to an existing customer or order.
            context.SaveChanges();
        }

        // Sets up the form so that user can enter data. Data is later  
        // saved when user clicks Commit.  
        private void AddCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            existingCustomerGrid.Visibility = Visibility.Collapsed;
            newOrderGrid.Visibility = Visibility.Collapsed;
            newCustomerGrid.Visibility = Visibility.Visible;

            // Clear all the text boxes before adding a new customer.  
            foreach (var child in newCustomerGrid.Children)
            {
                var tb = child as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }
            }
        }

        private void NewOrder_click(object sender, RoutedEventArgs e)
        {
            var cust = custViewSource.View.CurrentItem as Customers;
            if (cust == null)
            {
                MessageBox.Show("No customer selected.");
                return;
            }

            Orders newOrder = new Orders();
            newOrder.cust_id = cust.cust_id;

            // Get address and other mostly constant fields from   
            // an existing order, if one exists  
            var coll = custViewSource.Source as IEnumerable<Customers>;
            var lastOrder = (from c in coll
                             from ord in c.Orders
                             select ord).LastOrDefault();
            if (lastOrder != null)
            {
                newOrder.order_date = lastOrder.order_date;
                newOrder.cust_id = lastOrder.cust_id;
            }

            //existingCustomerGrid.Visibility = Visibility.Collapsed;
            newCustomerGrid.Visibility = Visibility.Collapsed;
            newOrderGrid.UpdateLayout();
            newOrderGrid.Visibility = Visibility.Visible;
        }

        // Cancels any input into the new customer form  
        private void CancelCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            add_customerIDTextBox.Text = "";
            add_contactNameTextBox.Text = "";
            add_addressTextBox.Text = "";
            add_cityTextBox.Text = "";
            add_stateTextBox.Text = "";
            add_zipTextBox.Text = "";
            add_countryTextBox.Text = "";
            add_contactNameTextBox.Text = "";
            add_emailTextBox.Text = "";

            //existingCustomerGrid.Visibility = Visibility.Visible;
            newCustomerGrid.Visibility = Visibility.Collapsed;
            newOrderGrid.Visibility = Visibility.Collapsed;
        }

        private void Delete_Order(Orders order)
        {
            // Find the order in the EF model.  
            var ord = (from o in context.Orders.Local
                       where o.order_num == order.order_num
                       select o).FirstOrDefault();

            // Delete all the order_details that have  
            // this Order as a foreign key  
            //foreach (var detail in ord.order_num.ToString())
            //{
            //    context.Orders.Remove(detail);
            //}

            // Now it's safe to delete the order.  
            context.Orders.Remove(ord);
            context.SaveChanges();

            // Update the data grid.  
            ordViewSource.View.Refresh();
        }

        private void DeleteOrderCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // Get the Order in the row in which the Delete button was clicked.  
            Orders obj = e.Parameter as Orders;
            Delete_Order(obj);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load is an extension method on IQueryable,    
            // defined in the System.Data.Entity namespace.   
            // This method enumerates the results of the query,    
            // similar to ToList but without creating a list.   
            // When used with Linq to Entities, this method    
            // creates entity objects and adds them to the context.   
            context.Customers.Load();

           

            // After the data is loaded, call the DbSet<T>.Local property    
            // to use the DbSet<T> as a binding source.   
            custViewSource.Source = context.Customers.Local;
        }        

        private void btnVendors_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
