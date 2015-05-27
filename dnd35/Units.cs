using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dnd35
{
    class Units
    {
        private decimal _value;
        private _units _currentunit;
        private enum _units
        {
            inches,
            feet,
            meters,
            ounces,
            grams
        };

        private decimal[][] _conversions;

        public Units()
        {
        }
    }
}
