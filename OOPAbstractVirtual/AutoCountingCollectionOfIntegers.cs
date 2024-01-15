using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFancyConsumerProject
{
    using MyFancyLibrary;

    public class AutoCountingCollectionOfIntegers : CollectionOfIntegers
    {
        public int Count { get; private set; } = 0;

        public override sealed void AddElement(int element)
        {
            base.AddElement(element);
            Count++;
        }

        public override sealed void AddCollection(int[] elements)
        {
            base.AddCollection(elements);
            Count += (elements?.Length ?? 0);
        }
    }
}
