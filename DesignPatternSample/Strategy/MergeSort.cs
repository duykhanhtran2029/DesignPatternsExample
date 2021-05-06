using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Strategy
{
    class MergeSort : SortStrategy
    {
        public void sort(List<String> items)
        {
            Console.WriteLine("Merge Sort");
        }
    }
}
