using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Strategy
{
    class QuickSort : SortStrategy
    {
        public void sort(List<String> items)
        {
            Console.WriteLine("Quick Sort");
        }
    }
}
