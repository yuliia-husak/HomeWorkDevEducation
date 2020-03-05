using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilderHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilderHangGlider();
            Director director = new Director(builder);
            director.Construct();
            Aircraf aircraf = builder.GetResult();
            aircraf.Show();
            Console.WriteLine(new string('*', 50));

            builder = new ConcreteBuilderPlanner();
            director = new Director(builder);
            director.Construct();
            Aircraf aircraf1 = builder.GetResult();
            aircraf1.Show();

            Console.WriteLine(new string('*', 50));

            Console.ReadKey();
        }
    }
}
