using System;

public static class extensionmethodclass
{
	public static bool extensionmethodname(this int str, int val)
	{
		return str>val;
	}
}

class Program
{
	static void Main(string[] args)
	{
		int stri = 565;
		bool z = stri.extensionmethodname(200);
		Console.WriteLine("theresult {0},z");
		Console.ReadLine();
	}
}
