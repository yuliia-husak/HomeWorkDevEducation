using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilderHW
{
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public virtual void BuildPartD() { }
        public virtual void BuildPartE() { }
        public abstract Aircraf GetResult();
    }
}
