#define FACTORIAL 
//#define CALC
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace HomeWork
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if FACTORIAL
			Console.WriteLine("Введите число: ");
			int n = int.Parse(Console.ReadLine());
			BigInteger f = 1;
			try
			{
				for (int i = 1; i <= n; i++)
				{
					f *= i;
					Console.Write(i + "! = " + f + "\n");
				}
                Console.WriteLine();
				Console.WriteLine(n + "! = " + f);
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
            
#endif
#if CALC
			double a = double.Parse(Console.ReadLine());
			string symb = Console.ReadLine();
			double b = double.Parse(Console.ReadLine());
			switch (symb)
			{
				case "+": Console.WriteLine(a + " + " + b + " = " + (a + b)); break;
				case "-": Console.WriteLine(a + " - " + b + " = " + (a - b)); break;
				case "*": Console.WriteLine(a + " * " + b + " = " + (a * b)); break;
				case "/": Console.WriteLine(a + " / " + b + " = " + (a / b)); break;
			} 
#endif

		}
	}
}
