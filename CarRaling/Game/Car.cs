using System;
using System.Threading;

namespace CarRaling
{
    class Car
    {       
        public double Speed { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public double Time { get; set; }

        readonly CarBody carBody;

        public Car()
        {
            Random rnd = new Random();
            Name = "0";
            Model = "AUDi";
            Thread.Sleep(100);
            Speed = Game.RandomSpeed();
            int left = 20;
            int top = 40;
            carBody = new CarBody(left, top); 

        }
        public Car(int left, int top, string name, string model)
        {
            this.Speed = Game.RandomSpeed();
            this.Model = model;
            this.Name = name;            
            carBody = new CarBody(left, top);
           
        }

        public void Show(string name)
        {
            carBody.Draw(name);
        }         
    }
}
