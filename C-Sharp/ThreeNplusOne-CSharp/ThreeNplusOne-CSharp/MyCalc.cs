using System;
using System.Collections.Generic;
using System.Text;

// NOT IN USE, CURRENTLY

namespace ThreeNplusOne_CSharp
{
    class MyCalc
    {
        public int Values { get; set; }

        private int iterator;

        public MyCalc(int values, int iterator)
        {
            Values = values;

            this.iterator = iterator;
        }
    }
}
