using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPcConfigure.AbstractClasses;

namespace IPcConfigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new ConcreteHomePcFactory.ConcreteHomePcFactory());
            client.Run();
            Console.WriteLine();
            Console.WriteLine(new string('*', 50));

            client = new Client(new ConcreteOfficePcFactory.ConcreteOfficePcFactory());
            client.Run();
            Console.WriteLine(new string('*', 50));

            Console.ReadKey();
        }
    }
}
