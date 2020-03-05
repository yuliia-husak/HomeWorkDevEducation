using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilderHW
{
    class Director
    {
        Builder builder;       
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        
        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
            builder.BuildPartD();
            builder.BuildPartE();
        }
    }
}
