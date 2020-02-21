using System;

namespace CarRaling
{
    class Car
    {       
        public double Speed { get; set; }

        public string Model { get; set; }
        public string Name { get; set; }

        public double Time { get; set; }

        readonly CarBody carBody;
        
        public Car(int left, int top, string n, string m)
        {
            this.Speed = Game.RandomSpeed();
            this.Model = m;
            this.Name = n;            
            carBody = new CarBody(left, top);
           
        }

        public void Show(string name)
        {
            carBody.Draw(name);
        }

         
    }
}
