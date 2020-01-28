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

namespace Tangram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Point oldPosition { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private new void MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UIElement elem = sender as UIElement;
            oldPosition = e.GetPosition(elem);
            elem.CaptureMouse();
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            UIElement elem = sender as UIElement;
            if (!elem.IsMouseCaptured) return;
            Canvas.SetLeft(elem, e.GetPosition(this).X - oldPosition.X);
            Canvas.SetTop(elem, e.GetPosition(this).Y - oldPosition.Y);
        }

        private new void MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            (sender as UIElement).ReleaseMouseCapture();
        }

        private new void MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == trAqua)
            {
                var transform = trAqua.RenderTransform as RotateTransform;
                transform.Angle += 15;
            }

            if (sender == trBlue)
            {
                var transform = trBlue.RenderTransform as RotateTransform;
                transform.Angle += 15;
            }
        }
    }
}
