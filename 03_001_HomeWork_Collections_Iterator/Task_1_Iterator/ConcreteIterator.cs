﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_001_HomeWork_Collections_Iterator
{
    class ConcreteIterator:Iterator
    {
        private Aggregate aggregate; private int current = 0;
        public ConcreteIterator(Aggregate aggregate) { this.aggregate = aggregate; }
        public override object First() { return aggregate[0]; }
        public override object Next() { if (current++ < aggregate.Count - 1) return aggregate[current]; else return null; }
        public override object CurrentItem() { return aggregate[current]; }
        public override bool IsDone()
        {
            if (current < aggregate.Count) return false;
            current = 0; return true;
        }
    }
}
