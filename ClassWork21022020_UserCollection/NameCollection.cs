using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork21022020_UserCollection
{
    class NameCollection : IEnumerable
    {

        string[] array = new string[4] { "Саша", "Грег", "Дима", "Сергей"};

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        class Iterator : IEnumerable
        {
            string[] namearray;
            int curentPosition = -1;
            //private NameCollection nameCollection;

            public Iterator(NameCollection vs)
            {
                namearray = vs.array;
            }

            
            public object Current
            {
                get
                {
                    return namearray[curentPosition];
                }
            }

            public bool MoveNext()
            {
                if (curentPosition < namearray.Length - 1)
                {
                    curentPosition++;
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                curentPosition = -1;
            }

            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
       
    }
}
