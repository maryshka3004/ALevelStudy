            int [] mas;
            Console.Write("Input array length:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            mas = new int[(int)n];
            Console.WriteLine("Input numbers:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("mas[{0}] = ", i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your array:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("{0} ", mas[i]);
            }
            Console.WriteLine();
            
            int count = mas.Count(x => x > -100 && x< 100);
            Console.WriteLine("Numbers from -100 to 100: " + count);
            for (int i = 0; i < mas.Length; i++)
                if (mas[i] > -100 && mas[i] < 100)
            Console.WriteLine("{0} ", mas[i]);
