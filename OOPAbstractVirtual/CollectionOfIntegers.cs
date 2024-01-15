using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFancyLibrary
{
    public class CollectionOfIntegers
    {
        const int MaxCapacity = 100;
        private readonly int[] array = new int[MaxCapacity];
        private int tail = 0;
        public virtual void AddElement(int element)
        {
            this.array[tail] = element;
            tail++;
        }

        public virtual void AddCollection(int[] elements)
        {
            for (int i = 0; i < (elements?.Length ?? 0); i++)
            {
                // this.array[tail] = elements[i];
                // tail++;

                AddElement(elements[i]);
            }
        }
    }
}
