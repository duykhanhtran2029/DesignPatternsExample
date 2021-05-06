using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample
{
    interface SortStrategy
    {
        void sort(List<String> items);
    }
}
