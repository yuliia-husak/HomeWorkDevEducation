using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade facade = new HomeTheaterFacade();

            Console.WriteLine("Beginning of work: ");

            facade.WatchMovie();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("End of work: ");

            facade.EndMovie();

            Console.ReadLine();
        }
    }
}
