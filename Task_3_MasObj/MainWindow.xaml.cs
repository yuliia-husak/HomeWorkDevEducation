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

namespace Task_3_MasObj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Напишите программу, в которой объявляется делегат для методов 
    /// с символьным аргументом, не возвращающих результат. 
    /// Опишите класс, в котором должно быть символьное поле и метод, 
    /// позволяющий присвоить значение символьному полю объекта. 
    /// У метода один символьный аргумент и метод не возвращает результат.
    /// Создайте массив объектов данного класса. 
    /// Создайте экземпляр делегата. В список вызовов этого делегата 
    /// необходимо добавить ссылки на метод (присваивающий значение 
    /// символьному полю) каждого объекта из массива. 
    /// Проверить результат вызова такого экземпляра делегата. 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            int size = int.Parse(txtSize.Text);
            char symbol = char.Parse(txtChar.Text);

            MyDelegate myDelegate=null;

            

            MyClass[] myClasses = new MyClass[size];
            for(int i = 0; i < myClasses.Length; i++)
            {
                myClasses[i] = new MyClass();  
            }

            foreach (MyClass my in myClasses)
            {
                myDelegate += my.Method;
            }

            myDelegate(symbol);

            for (int i = 0; i < myClasses.Length; i++)
            {
                
                txtResult.Text += "MyClass["+i+"] = " + myClasses[i].c+Environment.NewLine;
            }

            foreach(MyClass my1 in myClasses)
            {
                Console.WriteLine(my1.c);
            }
        }
    }
}
