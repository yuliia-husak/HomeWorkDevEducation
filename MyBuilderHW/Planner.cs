using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilderHW
{
    class Planner : Aircraf
    {
        ArrayList partPlan = new ArrayList();
        public override void Add(string part)
        {
            partPlan.Add(part);
        }

        public override void Show()
        {
            foreach (string part in partPlan)
                Console.WriteLine(part);
        }
    }
}
