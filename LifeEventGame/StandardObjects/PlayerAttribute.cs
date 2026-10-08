using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeEventGame.StandardObjects
{
    public class PlayerAttribute
    {
        // When true, this attribute should not be considered when calculating event probabilities
        public bool NotRelevant { get; set; }
        public int Value { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public PlayerAttribute() { MinValue = 0; MaxValue = 10; NotRelevant = false; }
        public PlayerAttribute(int value)
        {
            Value = value;
            MinValue = 0;
            MaxValue = 10;
        }
        public PlayerAttribute(int value, int minValue, int maxValue)
        {
            Value = value;
            MinValue = minValue;
            MaxValue = maxValue;
        }   
        // Implicit conversions to allow concise object initializers like: Fitness = 6 or Fitness = (3,7)
        public static implicit operator PlayerAttribute(int v) => new PlayerAttribute(v);
        public static implicit operator PlayerAttribute((int min, int max) range) => new PlayerAttribute(range.min, range.min, range.max);
        // Allow concise initializer: Fitness = false  -> sets NotRelevant = false (or true)
        public static implicit operator PlayerAttribute(bool notRelevant) => new PlayerAttribute() { NotRelevant = notRelevant };

        // Helper methods
        public PlayerAttribute SetNotRelevant(bool notRelevant)
        {
            NotRelevant = notRelevant;
            return this;
        }

        public static PlayerAttribute FromNotRelevant(bool notRelevant) => new PlayerAttribute() { NotRelevant = notRelevant };
    }
}
