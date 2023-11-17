using HomeWork_2._5;
using HomeWork_2._5.Colours.Green;
using HomeWork_2._5.Colours.Blue;
using HomeWork_2._5.Colours.Red;
using HomeWork_2._5.Colours.Yellow;
class Program
{
    static void Main()
    {
        EggPlant egg = new EggPlant("Fresh eggplants", 330);
        Cucumber cucu = new Cucumber("Fresh cucumbers", 200);
        Dill dil = new Dill("Fresh dill", 112);
        Onions on = new Onions("Fresh onions", 78);
        Beet be = new Beet("Fresh beet", 450);
        Tomato tom = new Tomato("Fresh tomatoes", 243);
        Pepper pep = new Pepper("Fresh peppers", 198);

        Vegetable[] veg = { egg, cucu, dil, on, be, tom, pep };

        foreach (var vegetable in veg)
        {
            vegetable.Sliced();
        }

        Console.WriteLine("Sorting vegetables by calories:");

        Array.Sort(veg, new Salad());

        foreach (Vegetable ve in veg)
        {
            Console.WriteLine($"{ve.VegetableName} have {ve.Calories} calories");
        }
        Console.WriteLine("Calculating of all salad calories");

        double allCalories = veg.Sum(a => a.Calories);
        Console.WriteLine($"There are: {allCalories} calories.");

        Console.WriteLine("Show vagetables that have calories from 167 to 213 calories.");
        int minCalories = 167;
        int maxCalories = 213;
        var findCalories = veg.Where(a => a.Calories >= minCalories && a.Calories <= maxCalories);

        Console.WriteLine($"Vegetables in the range from {minCalories} to {maxCalories} calories");
        foreach (var vegetable in findCalories)
        {
            Console.WriteLine($"{vegetable.VegetableName} have {vegetable.Calories} Calories");
        }
    }
}