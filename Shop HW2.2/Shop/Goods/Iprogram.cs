using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Goods
{
    internal interface Iprogram
    {
        static void Goods()
        {
            PersonalGoodInformation[] personalGoodInformation = {
            new PersonalGoodInformation { Id = 1, Name = "Product 1" },
            new PersonalGoodInformation { Id = 2, Name = "Product 2" },
            new PersonalGoodInformation { Id = 3, Name = "Product 3" },
            new PersonalGoodInformation { Id = 4, Name = "Product 4" },
            new PersonalGoodInformation { Id = 5, Name = "Product 5" },
            new PersonalGoodInformation { Id = 6, Name = "Product 6" },
            new PersonalGoodInformation { Id = 7, Name = "Product 7" },
            new PersonalGoodInformation { Id = 8, Name = "Product 8" },
            new PersonalGoodInformation { Id = 9, Name = "Product 9" },
            new PersonalGoodInformation { Id = 10, Name = "Product 10" },
            new PersonalGoodInformation { Id = 11, Name = "Product 11" },
            new PersonalGoodInformation { Id = 12, Name = "Product 12" },
            new PersonalGoodInformation { Id = 13, Name = "Product 13" },
            new PersonalGoodInformation { Id = 14, Name = "Product 14" },
            new PersonalGoodInformation { Id = 15, Name = "Product 15" },
            new PersonalGoodInformation { Id = 16, Name = "Product 16" },
            new PersonalGoodInformation { Id = 17, Name = "Product 17" },
            new PersonalGoodInformation { Id = 18, Name = "Product 18" },
            new PersonalGoodInformation { Id = 19, Name = "Product 19" }

            };


            MyCard card = new MyCard();
            card.AddToCart(personalGoodInformation[0]);
            card.AddToCart(personalGoodInformation[5]);
            card.AddToCart(personalGoodInformation[3]);
            card.AddToCart(personalGoodInformation[1]);
            card.AddToCart(personalGoodInformation[16]);
            card.AddToCart(personalGoodInformation[10]);


            card.ShowMyOrder();


            card.CleanCard();
        }
    }
}
