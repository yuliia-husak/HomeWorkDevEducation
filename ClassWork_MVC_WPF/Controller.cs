using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_MVC_WPF
{
    class Controller
    {
        Model model;
        MainWindow mainWindow;

        public Controller(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        private void MainWindow_SomeEvent(object sender, EventArgs e)
        {

            mainWindow.txt1.Text = this.model.SomeMethod(this.mainWindow.txt1.Text);
        }
    }
}
