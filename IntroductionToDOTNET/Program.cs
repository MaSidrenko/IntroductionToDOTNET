//#define CONSOLE_CLASS 
//#define STRING_OPERATIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{

	internal class Program
	{
		static readonly string delimiter = "\n|---------------------------------|\n";
		static void Main(string[] args)
		{
#if CONSOLE_CLASS

			Console.Title = "Introduction to .NET";
			Console.WriteLine("\t\t\tHello .NET");
			//Console.CursorLeft = 25;
			//Console.CursorTop = 8;
			Console.SetCursorPosition(24, 5);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Привет .NET");
			Console.ResetColor();

			Console.WriteLine(delimiter);


			Console.WriteLine("позиция окна консоли: " + Console.WindowLeft + " знакопозиций");
			Console.WriteLine("позиция окна консоли: " + Console.WindowTop + " знакопозиций");

			Console.SetWindowSize(91, 22);
			Console.SetBufferSize(91, 22);
			Console.WriteLine("ширина окна консоли: " + Console.WindowWidth + " знакопозиций");
			Console.WriteLine("высота окна консоли: " + Console.WindowHeight + " знакопозиций");

			Console.WriteLine(delimiter);

			Console.WriteLine("ширина буфера консоли: " + Console.BufferWidth + " знакопозиций");
			Console.WriteLine("высота буфера консоли: " + Console.BufferHeight + " знакопозиций"); 
#endif
#if STRING_OPERATIONS

			Console.Write("Введите ваше имя: ");
			string first_name = Console.ReadLine();
			Console.Write("Введите вашу фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(first_name + " " + last_name + " " + age); //Конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age)); //Форматированиеи строк
			Console.WriteLine($"{first_name} {last_name} {age}"); //Интерполяция строк  
#endif
            Console.WriteLine("Введите размер фигуры: ");
			int n = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++) Console.Write("  ");
				for (int j = i; j < n; j++) Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n - 1; j++) Console.Write("  ");
				for (int j = 0; j < i + 1; j++) Console.Write("* ");
				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
				for (int j = 0; j < i; j++) Console.Write("  "); Console.Write("\\");
				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
				for (int j = i; j < n - 1; j++) Console.Write("  "); Console.Write("/");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < n; j++)
				{
					Console.Write((i + j) % 2 == 0 ? "+ " : "- ");
				}
                    Console.WriteLine();
			} 
			Console.WriteLine(delimiter);
			for(int i = 0; i < n;i++)
				{
					for(int j = 0; j < n; j++)
					{
						for(int  k = 0; k < n; k++)
						{
							for(int  l = 0; l < n;l++)
							{
								Console.Write(i % 2 == k % 2 ? "* " : "  ");
							}
						}
                        Console.WriteLine();
					}
				}	
		}
	}
}
