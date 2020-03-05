using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilderHW
{
    class ConcreteBuilderHangGlider : Builder
    {
        HangGlider hangGlider = new HangGlider();
        public override void BuildPartA()
        {
            hangGlider.Add("HangGlider Part A");
        }

        public override void BuildPartB()
        {
            hangGlider.Add("HangGlider Part B");
        }

        public override void BuildPartC()
        {
            hangGlider.Add("HangGlider Part C");
        }

        public override void BuildPartD()
        {
            hangGlider.Add("HangGlider Part D");
        }

        public override void BuildPartE()
        {
            hangGlider.Add("HangGlider Part E");
        }
        public override Aircraf GetResult()
        {
            return hangGlider;
        }
    }
}
