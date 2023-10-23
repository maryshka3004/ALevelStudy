using System;
using System.Collections.Generic;

class FindSolutionOfExersize
{
    static void Main()
    {
        Console.Write("Enter the number elements in array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        List<int> mainMas = new List<int>();

        for (int i = 0; i < n; i++)
        {
            mainMas.Add(random.Next(1, 27));
        }

        List<int> evenNums = new List<int>();
        List<int> oddNums = new List<int>();

        foreach (int numer in mainMas)
        {
            if (numer % 2 == 0)
            {
                evenNums.Add(numer);
            }
            else
            {
                oddNums.Add(numer);
            }
        }

        string bukva = "abcdefghijklmnopqrstuvwxyz";

        List<string> evenBukvy = new List<string>();
        List<string> oddBukvy = new List<string>();

        foreach (int numer in evenNums)
        {
            char litera = bukva[numer - 1];
            if ("aeidhj".Contains(litera))
            {
                evenBukvy.Add(litera.ToString().ToUpper());
            }
            else
            {
                evenBukvy.Add(litera.ToString());
            }
        }

        foreach (int numer in oddNums)
        {
            char litera = bukva[numer - 1];
            if ("aeidhj".Contains(litera))
            {
                oddBukvy.Add(litera.ToString().ToUpper());
            }
            else
            {
                oddBukvy.Add(litera.ToString());
            }
        }

        int evenUpperCount = evenBukvy.FindAll(litera => char.IsUpper(litera[0])).Count;
        int oddUpperCount = oddBukvy.FindAll(litera => char.IsUpper(litera[0])).Count;

        Console.WriteLine("Even array with letters: " + string.Join(" ", evenBukvy));
        Console.WriteLine("Odd array with letters: " + string.Join(" ", oddBukvy));

        if (evenUpperCount > oddUpperCount)
        {
            Console.WriteLine("Even array has more upper letters");
        }
        else if (oddUpperCount > evenUpperCount)
        {
            Console.WriteLine("Odd array has more upper letters");
        }
        else
        {
            Console.WriteLine("Arrays have the same nomber of upper letters");
        }
    }
}
