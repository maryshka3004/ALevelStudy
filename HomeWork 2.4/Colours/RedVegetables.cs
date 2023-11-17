using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._5.Colours
{
    public abstract class RedVegetables : Vegetable
    {
        public bool Cut { get; private set; }

        protected RedVegetables(string vegetableName, int calories) : base(vegetableName, calories)
        {
            Cut = false;
        }

        public override void Sliced()
        {
            Cut = true;
            Console.WriteLine($"{VegetableName} were sliced");
        }
    }
}
