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

namespace Northwind_EmtityFram_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly NorthwindEntities context = new NorthwindEntities();
        public CollectionViewSource custViewSource;
        public CollectionViewSource ordViewSource;
        public MainWindow()
        {
            InitializeComponent();
            custViewSource = ((CollectionViewSource)(FindResource("customerViewSource")));
            ordViewSource = ((CollectionViewSource)(FindResource("customerOrdersViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource customersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customersViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // customersViewSource.Source = [generic data source]

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


           
            System.Windows.Data.CollectionViewSource ordersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerOrdersViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // ordersViewSource.Source = [generic data source]
           

        }
    }
}
