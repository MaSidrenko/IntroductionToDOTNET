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
		const char UPPER_ARROW = (char)8593;
            Console.WriteLine(UPPER_ARROW);
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
						case '↓':
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
				
			} while (true);
		}
	}
}
