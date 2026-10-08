using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeEventGame
{
    public class Attribute
    {
        public int Value { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public Attribute(int value)
        {
            Value = value;
            MinValue = 0;
            MaxValue = 10;
        }
        public Attribute(int value, int minValue, int maxValue)
        {
            Value = value;
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
