using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeEventGame
{
    public class Attribute
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public Attribute(string name, int value)
        {
            Name = name;
            Value = value;
            MinValue = 0;
            MaxValue = 10;
        }
        public Attribute(string name, int value, int minValue, int maxValue)
        {
            Name = name;
            Value = value;
            MinValue = minValue;
            MaxValue = maxValue;
        }   
    }
}
