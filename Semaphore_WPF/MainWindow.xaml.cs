using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Semaphore_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // SemaphoreSlim  - легковесный класс-семафор, который не использует объекты синхронизации ядра.
        static SemaphoreSlim slim; // = new SemaphoreSlim(1, 2);
        static int count = 0;
        string str = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (str == "") MessageBox.Show("Select amount threads if semaphore.");
            else
            {
                count++;
                Thread thread = new Thread(Work) ;
                thread.Name = Convert.ToString(count);
                //thread.Start();
                txtCreat.Text += $"\nThread created " + thread.Name;//+ Thread.CurrentThread.GetHashCode().ToString();
            }
            
        }

        private void UpdateTextRight()
        {
            // Задержка на 5 секунд.
            Thread.Sleep(TimeSpan.FromSeconds(5));

            // v1.0
            ThreadStart threadStart = new ThreadStart(WorkerMethod);
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, threadStart);

            // v2.0
            txtCreat.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (Action)delegate () { txtCreat.Text += $"\nThread created " + Thread.CurrentThread.GetHashCode().ToString(); });
        }

        /// v1.0
        private void WorkerMethod()
        {
            //MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString());
            // Этот метод выполняется в потоке диспетчера, поэтому трудоемкие операции подвесят приложение
            // точно так же, как если бы оно работало в одном потоке.
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            txtCreat.Text = "Test";
        }

        private void cmb2_Selected(object sender, RoutedEventArgs e)
        {
            str = "2";
            slim = new SemaphoreSlim(2, 4);
        }

        private void cmb3_Selected(object sender, RoutedEventArgs e)
        {
            str = "3";
            slim = new SemaphoreSlim(3, 4);
        }

        private void cmb4_Selected(object sender, RoutedEventArgs e)
        {
            str = "4";
            slim = new SemaphoreSlim(4, 4);
        }

        static void Function()
        {
            slim.Wait();

            Console.WriteLine("Поток {0} начал работу.", Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Console.WriteLine("Поток {0} закончил работу.\n", Thread.CurrentThread.Name);

            slim.Release();
        }

        private void txtCreat_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            slim.Wait();
            txtPend.Text += ("Thread " + Thread.CurrentThread.Name);
            Thread.Sleep(20000);
        }

        private static void Work(object number)
        {
            Thread.Sleep(10000);
            //pool.WaitOne();

            //Console.WriteLine("Поток {0} занял слот семафора.", number);
            //Thread.Sleep(1000);
            //Console.WriteLine("Поток {0} -----> освободил слот.", number);

            //pool.Release();
        }

        private void txtCreat_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
