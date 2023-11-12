using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Goods
{
    internal class MyCard
    {
        public List<PersonalGoodInformation> Good { get; } = new List<PersonalGoodInformation>();

        public void AddToCart(PersonalGoodInformation personalGoodInformation)
        {
            Good.Add(personalGoodInformation);

            Console.WriteLine($"{personalGoodInformation.Name} You added");
        }

        public void ShowMyOrder()
        {
            Console.WriteLine("My order");
            foreach (var good in Good)
            {
                Console.WriteLine(good.Name);
            }
        }

        public void CleanCard()
        {
            Good.Clear();
        }
    }
}
