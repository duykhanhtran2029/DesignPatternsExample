using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Strategy
{
    class SelectionSort : SortStrategy
    {
        public void sort(List<String> items)
        {
            Console.WriteLine("Selection Sort");
        }
    }
}
