using System;

namespace CarRaling
{
    class Car
    {        
        int currentDistanse;
        const int maxDistanse = 90;
        bool stopedDistanse;
        public string Name { get; set; }

        readonly CarBody carBody;
        
        public Car(int left, int top, string n)
        {
            this.Name = n;
            //engine = new Engine();
            carBody = new CarBody(left, top);
            currentDistanse = 0;
        }

        public void Show(string name)
        {
            carBody.Draw(name);
        }

        // Ускорение.
        public int Acceleration()
        {
            int delta = Game.RandomSpeed();

            if (stopedDistanse)
            {
                return 0;
            }
            else
            {
                currentDistanse += delta;
                if (currentDistanse > maxDistanse)
                {

                    stopedDistanse = true;
                    Console.Title = "Finish: " + Name;
                    EngineIsDeadException ex = new EngineIsDeadException("Дистанция пройдена.");
                    //ex.Data.Add("Время поломки   :", string.Format("Двигатель вышел из строя {0}", DateTime.Now));
                    ex.Data.Add(" Гонка завершена :", string.Format("К финишу пришел первым номер: {0}", Name));

                    throw ex;
                }
                else
                {
                    Console.Title = "До финиша: " + (maxDistanse-currentDistanse);
                    return currentDistanse;
                }
            }   
        }

        // Торможение.
        public void Braking()
        {

        }
    }
}
