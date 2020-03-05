using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstractFactory
{
    class Program
    {
        static void Main()
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();            

            client = new Client(new FantaFactory());
            client.Run();

            client = new Client(new SchweppesFactory());
            client.Run();

            Console.ReadKey();
        }        
    }
}
