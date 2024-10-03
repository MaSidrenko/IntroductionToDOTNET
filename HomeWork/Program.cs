//#define FACTORIAL 
#define CALC
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
		
            Console.Write("Введите арифметическое выражение: ");
			string expressinon = Console.ReadLine();
			expressinon = expressinon.Replace('.', ',');
			char[] delimeters = new char[] {'+', '-', '*', '/'};
			string[] numbers = expressinon.Split(delimeters);
			//В классе 'string' есть метод Split(,,), который принимает набор разделителей
			//и возвращает "разрезанную" строку по указанным разделителям в виде массива строк.
			try
			{
				double a = double.Parse(numbers[0]);
				double b = double.Parse(numbers[1]);
				#region IFcalc
				/*if (expressinon.Contains("+")) Console.WriteLine(a + " + " + b + " = " + (a + b));
			else if(expressinon.Contains("-")) Console.WriteLine(a + " - " + b + " = " + (a - b));
			else if(expressinon.Contains("*")) Console.WriteLine(a + " * " + b + " = " + (a * b));
			else if(expressinon.Contains("/")) Console.WriteLine(a + " / " + b + " = " + (a / b));*/
				#endregion
				switch (expressinon[expressinon.IndexOfAny(delimeters)])
				{
					case '+': Console.WriteLine(a + " + " + b + " = " + (a + b));break;
					case '-': Console.WriteLine(a + " - " + b + " = " + (a - b));break;
					case '*': Console.WriteLine(a + " * " + b + " = " + (a * b));break;
					case '/': Console.WriteLine(a + " / " + b + " = " + (a / b));break;
				}
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
#endif
			Main(args);
		}
	}
}
