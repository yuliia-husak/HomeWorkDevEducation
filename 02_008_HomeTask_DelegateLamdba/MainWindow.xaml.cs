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
using NUnit.Framework;
using System.Reflection;

namespace _02_008_HomeTask_DelegateLamdba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public delegate void MyDelegate();
        MyDelegate myDelegate;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myDelegate = MoreWindow;
            myDelegate();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {            
            myDelegate = CloseWindow;
            myDelegate();   
        }

        private void CloseWindow()
        {
            this.Close();
        }

        private void MoreWindow()
        {
            Window1.Width = 440;
            Window1.Height = 330;            
        }

        private double _windowWidth;
        private double _windowHeight;
    }
}
