using HomeWork_2._3;
using HomeWork_2._3.Candies.Chocolate;
using HomeWork_2._3.Candies.Lolli_pops;

class Program
{
    static void Main()
    {
        WithHazelNuts whn = new WithHazelNuts("Millenium", 150);
        WithWaffels wwf = new WithWaffels("Funny Cow", 300);
        Sour sour = new Sour("Toffix", 100);
        Sweety swe = new Sweety("Ravlic", 350);
        
        Bonbon[] bb = { whn, wwf, sour, swe };
        Console.WriteLine("Calculating full weight of gift");
        foreach (var bonbons in bb)
        {
        }
        int fullWeight = bb.Sum(a => a.Weight);
        Console.WriteLine($"Fool weight is: {fullWeight} g");

        Console.WriteLine("Sorting candies by alphabet");
        Array.Sort(bb, new CandiesComparer());

        foreach (Bonbon bbs in bb)
        {
            Console.WriteLine($"{bbs.BonbonName} - {bbs.Weight}");
        }

        Console.WriteLine("Find a candies in range from 200 to 310 g");
        int minWeight = 200;
        int maxWeight = 310;
        var candiesInRange = bb.Where(a => a.Weight >= minWeight && a.Weight <= maxWeight);

        Console.WriteLine($"Candies in the weight range from {minWeight} to {maxWeight} g:");
        foreach (var b in candiesInRange)
        {
            Console.WriteLine($"{b.BonbonName} - {b.Weight} g");
        }
    }
}
