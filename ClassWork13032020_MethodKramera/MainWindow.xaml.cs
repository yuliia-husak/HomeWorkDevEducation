using System;
using System.Collections.Generic;
using System.IO;
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

namespace ClassWork13032020_MethodKramera
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

        int counter = 0;
        string line;
        int found = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamReader f = new StreamReader("text.txt");

            while ((line = f.ReadLine()) != null)
            {
                counter++;
            }
            f.Close();

            f = new StreamReader("text.txt");
            string[] vs = new string[counter];

            for (int i = 0; i < vs.Length; i++)
            {
                line = f.ReadLine();
                vs[i] = line;
            }

            txt0.Text += counter;
            f.Close();

            int[,] m = new int[counter, counter];

            for (int i = 0; i < vs.Length; i++)
            {
                found = vs[i].IndexOf("=");
                string a = vs[i].Substring(0, found);
                string[] b = a.Split('+', '-');
                for(int j = 0; j < b.Length; j++)
                {
                    char[] arrChar = b[i].ToCharArray();
                    for(int z = 0; z < arrChar.Length; z++)
                    {
                        if (arrChar[0] == 'x') m[i, j] = 1;
                        if (Char.IsDigit(arrChar[z]))
                        {
                            string str = arrChar[z].ToString();
                            m[i, j] = Convert.ToInt32(str);
                            break;
                        }
                    }
                    

                }
                
            }

        }


    }
}
    

