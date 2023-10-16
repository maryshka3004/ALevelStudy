int[] A = new int[20];

Random random = new Random();
Console.WriteLine("Input Minimum:");
int Min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Maximum:");
int Max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Array A: ");
for (int i = 0; i < A.Length; i++)
{
    A[i] = random.Next(Min, Max);   
    Console.WriteLine(A[i]);
}
Console.WriteLine();

int[] B = new int[20];
int j = 0;

for (int i = 0; i < A.Length; i++)
{
    if (A[i] <= 888)
    {
        B[j] = A[i];
        j++;
    }
}    

Console.WriteLine("Sorted array B:");
Array.Resize(ref B, j);
Array.Sort(B, (a, b) => b.CompareTo(a));
for (int i = 0; i < j; i++)
{
     Console.WriteLine(B[i]);
}