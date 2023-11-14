using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._3.Candies
{
    public abstract class ChocolateCandy : Bonbon
    { 

        public ChocolateCandy(string bonBonName, int weight) : base(bonBonName, weight)
        {
        }
    }
}
