using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Strategy
{
    class SortedList
    {
        private SortStrategy strategy;
        private List<String> items = new List<String>();

        public void setSortStrategy(SortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void add(String name)
        {
            items.Add(name);
        }

        public void sort()
        {
            strategy.sort(items);
        }
    }
}
