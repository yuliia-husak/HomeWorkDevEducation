using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilderHW
{
    class ConcreteBuilderPlanner:Builder
    {
        Planner planner = new Planner();
        public override void BuildPartA()
        {
            planner.Add("Planner Part A");
        }

        public override void BuildPartB()
        {
            planner.Add("Planner Part B");
        }

        public override void BuildPartC()
        {
            planner.Add("Planner Part C");
        }
        public override Aircraf GetResult()
        {
            return planner;
        }
    }
}
