using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork28022020_Tasks
{
    class Program
    {
        static string progravfName;
        static void ShowTaskInfo(object taskName)
        {
            Console.WriteLine("Task name: {0}, Task ID: {1}, " +
                "thread id: {2}, Program name: {3}",
                taskName, Task.CurrentId,
                Thread.CurrentThread, progravfName);
        }
        static void Main(string[] args)
        {

            progravfName = "Working with data";
            Task t1 = Task.Factory.StartNew(new Action<object>(ShowTaskInfo), "First worker");
            Task t2 = Task.Factory.StartNew(o=>ShowTaskInfo(o), "Second worker");
            string t2Name = "Third worker";
            Task t3 = Task.Factory.StartNew(()=>ShowTaskInfo(t2Name));
            //---------------------------Screen-----------------------------------
            //Task name: First worker, Task ID: 1, thread id: System.Threading.Thread, Program name: Working with data
            //Task name: Second worker, Task ID: 2, thread id: System.Threading.Thread, Program name: Working with data
            //Task name: Third worker, Task ID: 3, thread id: System.Threading.Thread, Program name: Working with data


            long iNumber = 123456789;
            Task<double> SqrtTask = Task.Factory.StartNew((obj) =>
              {
                  return Math.Sqrt((long)obj);
              }, iNumber);
            double sqrtNumber = SqrtTask.Result;
            Console.WriteLine("Result: {0}", sqrtNumber);
            //------------------------Screen------------------------------------
            //Result: 11111.1110605556


            Console.ReadKey();
           
        }
    }
}
