using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_002_Classes_Consstructors._02_Task_Reservoir
{
    class Reservoir
    {
        public List<Reservoir> reservoirs = new List<Reservoir>(2);
        
        string name;
        double width;
        double length;
        double depth;//глубина
        public string Name { get; set; }
        public string Width { get; set; }
        public string Length { get; set; }
        public string Depth { get; set; }

        public Reservoir()
        {
            name = "Not known";
            width = 0.0;
            length = 0.0;
            depth = 0.0;
        }

        public Reservoir(string n, double w,
            double l, double d)
        {
            this.name = n;
            this.width = w;
            this.length = l;
            this.depth = d;
        }

        //**************Method*************
        public double Volume()
        {
            return width * length * depth;
        }

        public double Area()
        {
            return width * length;
        }

        //public static bool CompareType(Reservoir a, Reservoir b)
        //{
        //    if (a.name == b.name) return true;
        //    return false;
        //}

        public int CompareType(Reservoir a, Reservoir b)
        {
            
            if (a.name == b.name) return 1;
            return 0;
        }

        public bool CompareAreaMore(Reservoir a, Reservoir b)
        {
            double A, B;
            A = a.Area();
            B = b.Area();
            if (A > B)  return true;
            return false;
        }
        public void Copy(Reservoir a,Reservoir b)
        {
            b.name = a.name;
            b.width = a.width;
            b.length = a.length;
            b.depth = a.depth;            
        }

        //public int Count
        //{
        //    get { return reservoirs.Length; }
        //}

        //public void Add(Reservoir item)
        //{
        //    var newArray = new Reservoir[reservoirs.Length + 1];
        //    reservoirs.CopyTo(newArray, 0);
        //    newArray[newArray.Length - 1] = item;
        //    reservoirs = newArray;
        //}

        //public void Remove(Reservoir item)
        //{
        //    var newArray = new Reservoir[reservoirs.Length - 1];
        //    reservoirs.CopyTo(newArray, 0);
        //    newArray[newArray.Length + 1] = item;
        //    reservoirs = newArray;
        //}

        public void CopyTo(Reservoir[] array, int arrayIndex)
        {
            reservoirs.CopyTo(array, arrayIndex);
        }

        public override string ToString()
        {
            //return base.ToString();
            //return string.Format("Reservoir info: {0},{1},{2},{3},{4}", this.name,
            //    this.width,this.length,this.depth, this.reservoirs.Count);

            foreach (Reservoir p in reservoirs)
            {
                return string.Format("Reservoir info: {0}, {1}, {2}, {3}, {4}", this.name,
                this.width, this.length, this.depth, this.reservoirs.Count);
            }

            return string.Format("Reservoir info: {0}, {1}, {2}, {3}, {4}", this.name,
                this.width, this.length, this.depth, this.reservoirs.Count);

        }

        public void Show()
        {
            Console.WriteLine("Reservoir info: {0}, {1}, {2}, {3}, {4}", name,
                width, length, depth, reservoirs.Count);
        }
    }
}
