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

namespace Task_5_Lambda_Number3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate int MyDelegate(int x);

        MyDelegate myDelegate = null;

        int x, result;
        
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (o, e) =>
            {
                this.Title = "Loaded";
            };
        }

        private void btnTrans_Click(object sender, RoutedEventArgs e)
        {
            x = int.Parse(txtEnter.Text);

            myDelegate = x => 
            {
                int[] numb3 = new int[3];
                int count = 2;
                do
                {
                    numb3[count] = x % 10;
                    count--;
                } while ((x /= 10) != 0);

                string s="";

                for (int i = 1; i <= 1; i++)
                {
                    s += numb3[2];
                    s += numb3[0];
                    s += numb3[1];
                }

                result = int.Parse(s); 
                
                return result;                
            };

            txtExit.Text += myDelegate(x);
        }
    }
}
