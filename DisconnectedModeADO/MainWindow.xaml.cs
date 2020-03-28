using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
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


namespace DisconnectedModeADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection = null;
        String connectionString = null;
        SqlDataAdapter sqlDataAdapter = null;
        DataSet dataset = null;
        SqlCommandBuilder sqlCommandBuilder = null;
        DataTable table;
       
        public MainWindow()
        {
            InitializeComponent();                      
            connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            dataset = new DataSet();          
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            table = new DataTable();
            try
            {                
                sqlConnection = new SqlConnection(connectionString);
                sqlDataAdapter = new SqlDataAdapter(txtInput.Text, sqlConnection);
                dtgrd.DataContext = null;
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Fill(dataset, "myTable");
                dtgrd.DataContext = dataset.Tables["myTable"];                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        { 
           sqlDataAdapter.Update(dataset, "myTable");
        }
    }
}
