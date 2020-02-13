using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace _02_008_HomeTask_Event_Tamagotchi
{
    class Program
    {        
        static private void PressKeyA()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine(new string(' ', 10) + "  ()()   ");
            Console.WriteLine(new string(' ', 10) + "  (* *)  ");
            Console.WriteLine(new string(' ', 10) + " (_____)*");         
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
        private static System.Timers.Timer aTimer;

        static void Main(string[] args)
        {
            Thread thread = new Thread(SetTimer);
            thread.Priority = ThreadPriority.Lowest;
            thread.Start();
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.WriteLine("Press key:  agree - A, ignore - I ");
            PressKeyA();
            Tamagtchi tamagtchi = new Tamagtchi();
            tamagtchi.LifeTama();            
            aTimer.Stop();
            aTimer.Dispose();              
            
            Console.ReadKey();
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(60000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;            
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {               
            Console.Clear();
            Console.WriteLine(new string(' ',20)+"Game the end");
            
        }   
    }
}

