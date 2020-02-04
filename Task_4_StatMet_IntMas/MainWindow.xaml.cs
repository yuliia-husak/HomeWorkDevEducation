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

namespace Task_4_StatMet_IntMas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Напишите программу, в которой есть статический метод. 
    /// Первым аргументом статическому методу передается целочисленный 
    /// массив. Вторым аргументом статическому методу передается ссылка 
    /// на другой метод. У метода-аргумента должен быть целочисленный 
    /// аргумент, и он должен возвращать целочисленный результат. Р
    /// езультатом статический метод возвращает целочисленный массив. Э
    /// лементы этого массива вычисляются как результат вызова м
    /// етода-аргумента, если ему передавать значения элементов из 
    /// массива-аргумента. Предложите механизм проверки функциональности 
    /// данного статического метода

    public partial class MainWindow : Window
    {
        public delegate int MyDelegate(int x);
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnModif_Click(object sender, RoutedEventArgs e)
        {
            string s = txtData.Text;
            string[] arrstring = new string[1];
            MyDelegate del = OtherMethod;

            if (s != "")
            {
                arrstring = s.Split(' ');
            }
            int[] mas = new int[arrstring.Length];
            for (int i = 0; i < arrstring.Length; i++)
            {
                mas[i] = Convert.ToInt32(arrstring[i]);                
            }
            
            foreach(int i in StatMethod(mas, del))
            {
                txtResult.Text += i + " ";
            }            
        }

        public static int[] StatMethod(int[] mas, MyDelegate del)
        {
            int count = mas.Length;
            int[] result = new int[count];
            for(int i = 0; i < count; i++)
            {
                result[i] = del(mas[i]);                
            }
            return result;
        }

        public static int OtherMethod(int x)
        {
            return x * 10;
        }
    }
}
