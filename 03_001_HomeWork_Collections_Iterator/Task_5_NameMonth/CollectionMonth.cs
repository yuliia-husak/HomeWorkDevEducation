using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_001_HomeWork_Collections_Iterator.Task_5_NameMonth
{
	// Класс, представляющий собой пользовательскую коллекцию.
	public class CollectionMonth<T>: IEnumerable, IEnumerator, IDisposable
	{
		
		readonly Element[] elements = new Element[12];		

		public Element this[int index]
		{
			get { return elements[index]; }
			set { elements[index] = value; }
		}

		int position = -1;

		// Реализация интерфейса IEnumerator:
		// 1. Метод MoveNext().
		bool IEnumerator.MoveNext()
		{
			if (position < elements.Length - 1)
			{
				position++;
				return true;
			}
			return false;
		}

		// 3. Свойство Current.
		object IEnumerator.Current
		{
			get { return elements[position]; }
		}

		// Реализация интерфейса IEnumerable:
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this;
		}

		// 2. Метод Reset().
		void IEnumerator.Reset()
		{
			position = -1;
		}

		public void Dispose()
		{
			((IEnumerator)this).Reset();
		}

	}
}
