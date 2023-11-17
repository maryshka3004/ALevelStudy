using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._3
{
    class CandiesComparer : IComparer<Bonbon>
    {
        public int Compare(Bonbon? b2, Bonbon? b1)
        {
            if (b2 is null || b1 is null)
                throw new ArgumentException("Incorrect");
            return b2.BonbonName.Length - b1.BonbonName.Length;
        }
    }

    public abstract class Bonbon
    {
        public string BonbonName { get; set; }
        public int Weight { get; set; }
        public Bonbon(string bonBonName, int weight)
        {

            BonbonName = bonBonName;
            Weight = weight;
        }

    }
}
