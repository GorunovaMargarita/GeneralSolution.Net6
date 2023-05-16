using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home8
{
    public class Product
    {
        public string Name { get; set; }
        public int NumberOfCalories { get; set; }
        public Product (string name, int numberOfCalories)
        {
            Name = name;
            NumberOfCalories = numberOfCalories;
        }
        public override string ToString()
        {
            return $"{Name}, calories: {NumberOfCalories}";
        }
    }
}
