//#define HW
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
			Random rand = new Random();
#if HW
		char key;
			do
			{
				key = Console.ReadKey(true).KeyChar;
				//Console.WriteLine((int)key);
				try
				{
					switch (key)
					{
						case 'W':
						case 'w':
						case 'ц':
						case 'Ц':
							Console.CursorTop -= 1;
							break;
						case 'D':
						case 'd':
						case 'в':
						case 'В':
							Console.CursorLeft += 1;
							break;
						case 'A':
						case 'a':
						case 'ф':
						case 'Ф':
							Console.CursorLeft -= 1;
							break;
						case 'S':
						case 's':
						case 'ы':
						case 'Ы':
							Console.CursorTop += 1;
							break;
					}
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.Message);
					Console.WriteLine("Press Enter for сontinue");
					Console.ReadLine();
					Console.Clear();
				}

			} while (key != 27); 
#endif
			int x = rand.Next(Console.WindowWidth);
			int y = rand.Next(Console.WindowHeight);
			ConsoleKey key;
			Console.CursorVisible = false;
			do
			{
				Console.Clear();
				Console.SetCursorPosition(0,0);
				Console.ResetColor();
                Console.WriteLine("x = " + x + " y = " + y);
				Console.SetCursorPosition(x, y);
				Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine((char)2);
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.W:
					case ConsoleKey.UpArrow:	
						y--;break;
					case ConsoleKey.S:
					case ConsoleKey.DownArrow:	
						y++;break;
					case ConsoleKey.A:
					case ConsoleKey.LeftArrow:	
						x--;break;
					case ConsoleKey.D:
					case ConsoleKey.RightArrow:		
						x++;break;	
				}
				if(x==0 || y==0 || x==Console.WindowWidth || y==Console.WindowHeight)Console.Beep();	
				if (x == 0)x = 1;
				if(x == Console.WindowWidth)x=Console.WindowWidth - 1;
				if (y == 0)y = 1;
				if(y == Console.WindowHeight)y=Console.WindowHeight - 1;

			} while (key != ConsoleKey.Escape);
		}
	}
}
