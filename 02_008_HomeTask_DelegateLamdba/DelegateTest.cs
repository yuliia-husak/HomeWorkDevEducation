using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace _02_008_HomeTask_DelegateLamdba
{
    [TestFixture]
    class DelegateTest
    {
        MainWindow mainWindow = new MainWindow();
        

        [Test]
        public void SizeWindows()
        {
            double height = 440;
            double widht = 330;
            double actualheight = mainWindow.Height;
            double actualwidht = mainWindow.Width;


            Assert.AreEqual(height, actualheight);
            Assert.AreEqual(widht, actualwidht);
        }
    }
}
