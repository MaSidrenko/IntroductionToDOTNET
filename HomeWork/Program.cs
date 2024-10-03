//#define FACTORIAL 
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if FACTORIAL
			Console.WriteLine("Введите число: ");
			int n = int.Parse(Console.ReadLine());
			double f = 1;
			Console.Write(n + " != ");
			if (n == 0) Console.Write(1 + "\t");
			else
			{
				for (int i = 1; i <= n; i++)
				{
					f *= i;
				}
				Console.Write(f + "\t");
			} 
#endif
			int a = int.Parse(Console.ReadLine());
			string symb = Console.ReadLine();
			int b = int.Parse(Console.ReadLine());
			switch (symb)
			{
				case"+": Console.WriteLine(a + " + " + b + " = " + (a + b));break;
				case"-": Console.WriteLine(a + " - " + b + " = " + (a - b));break;
				case"*": Console.WriteLine(a + " * " + b + " = " + (a * b));break;
				case"/": Console.WriteLine(a + " / " + b + " = " + (a / b));break;
			}

		}
	}
}
