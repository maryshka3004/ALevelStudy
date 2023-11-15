using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._5
{
    class Salad : IComparer<Vegetable>
    {
        public int Compare(Vegetable? v1, Vegetable? v2)
        {
            if (v1 is null || v2 is null)
                throw new ArgumentException("Incorrect value");
            return v1.Calories - v2.Calories;
        }
    }
    public abstract class Vegetable 
    {
        public string VegetableName { get; set; }
        public int Calories { get; set; }
        public Vegetable(string vegetableName, int calories)
        {

            VegetableName = vegetableName;
            Calories = calories;
        }
        public abstract void Sliced();
    }
}

