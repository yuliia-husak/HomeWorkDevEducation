using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork27012020_Interface_HumanShop
{
    abstract class  Employee:Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\n Должность: " +
                $"{Position} Заработная плата: {Salary}$";
        }
    }
}
