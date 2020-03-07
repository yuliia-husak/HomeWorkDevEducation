using DecoratorCoffee.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Основы кофе для декорации
            Bevegare bevegare = new Espresso();
            Bevegare bevegare1 = new DarkRoast();
            Bevegare bevegare2 = new Decaf();
            Bevegare bevegare3 = new HouseBlind();

            Console.WriteLine($"{bevegare.description} UAH {bevegare.cost()}");
            Console.WriteLine($"{bevegare1.description} UAH {bevegare1.cost()}");
            Console.WriteLine($"{bevegare2.description} UAH {bevegare2.cost()}");
            Console.WriteLine($"{bevegare3.description} UAH {bevegare3.cost()}");
            Console.WriteLine(new string('-', 50));

            //Decorators coffee
            Chocolate chocolate = new Chocolate();
            Milk milk = new Milk();
            Mocha mocha = new Mocha();
            Whip whip = new Whip();

            //Decorator with coffee
            chocolate.SetComponent(bevegare);
            milk.SetComponent(chocolate);
            mocha.SetComponent(milk);
            whip.SetComponent(mocha);

            //Display in screen
            Console.WriteLine($"{chocolate.GetDescription()} UAH {chocolate.cost()}");
            Console.WriteLine($"{milk.GetDescription()} UAH {milk.cost()}");
            Console.WriteLine($"{mocha.GetDescription()} UAH {mocha.cost()}");
            Console.WriteLine($"{whip.GetDescription()} UAH {whip.cost()}");

            Console.ReadLine();
        }
    }
}
