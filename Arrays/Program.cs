#define ARRAYS_1
//#define ARRAYS_2
//#define JAGGED_ARRAY

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static double sum(int[] arr)
		{
			double sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			return sum;
		}
		static double sum_2(int[,] arr_2)
		{
			double sum = 0;
			for(int i =0; i < arr_2.GetLength(0); i++)
			{
				for(int j = 0; j < arr_2.GetLength(1); j++)
				{
					sum += arr_2[i, j];
				}
			}
			return sum;
		}
		static double sum_jagged(int[][] arr_jagged)
		{
			double sum = 0;
			for(int i = 0; i < arr_jagged.Length; i++)
			{
				for(int j = 0; j < arr_jagged[i].Length; j++)
				{
					sum += arr_jagged[i][j];
				}
			}
			return sum;
		}
		static int minValue(int[] arr)
		{
			int minValue = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (minValue > arr[i])
				{
					minValue = arr[i];
				}
			}
			return minValue;
		}
		static int minValue_2(int[,] arr_2)
		{
			int minValue = arr_2[0,0];
			for(int i = 0; i < arr_2.GetLength(0); i++)
			{
				for(int j =0; j < arr_2.GetLength(1);j++)
				{
					if(minValue > arr_2[i,j])
					{
						minValue = arr_2[i,j];
					}
				}
			}
			return minValue;
		}
		static int minValue_jagged(int[][] arr_jagged)
		{
			int minValue = arr_jagged[0][0];
			for(int i = 0; i < arr_jagged.Length; i++)
			{
				for(int j = 0;  j < arr_jagged[i].Length; j++)
				{
					if(arr_jagged[i][j] < minValue)	
					{
						minValue = arr_jagged[i][j];
					}
				}
			}
			return minValue;
		}
		static int maxValue(int[] arr)
		{
			int maxValue = arr[0];
			for(int i = 0; i < arr.Length;i++)
			{
				if(maxValue < arr[i])
				{
					maxValue = arr[i];
				}
			}
			return maxValue;
		}
		static int maxValue_2(int[,] arr_2)
		{
			int maxValue = arr_2[0,0];
			for(int i = 0; i < arr_2.GetLength(0);i++)
			{
				for(int j =0; j< arr_2.GetLength(1);j++)
				{
					if( maxValue < arr_2[i,j])
					{
						maxValue = arr_2[i,j];
					}
				}
			}
			return maxValue;
		}
		static int maxValue_jagged(int[][] arr_jagged)
		{
			int maxValue = arr_jagged[0][0];
			for(int i =0; i < arr_jagged.Length;i++)
			{
				for(int j = 0; j< arr_jagged[i].Length; j++)
				{
					if(maxValue <  arr_jagged[i][j])
					{
						maxValue = arr_jagged[i][j];
					}
				}
			}
			return maxValue;
		}
		static void bubble_sort(ref int value, ref int next_value)
		{
			int buffer = value;
			value = next_value;
			next_value = buffer;
		}
		static void Main(string[] args)
		{
#if ARRAYS_1
			Console.Write("Введите размер массива: ");
			int n = int.Parse(Console.ReadLine());
			Random rand = new Random(0);//0 - Seed value
										//int[] arr = new[] { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();

			//Сортировка:
			for (int i = 1; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length - i; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						bubble_sort(ref arr[j], ref arr[j + 1]);
					}
				}
			}

			//Сумма и среднее арифметическое:
			Console.WriteLine("Сумма значений всего массива: " + sum(arr));
			Console.WriteLine("Среднее арифметическогое всего массива: " + sum(arr) / arr.Length);

			//Минимальное и максимальное значение в массиве 
			Console.WriteLine("Минимальное значение в массиве: " + minValue(arr));
			Console.WriteLine("Максимальное значение в массиве: " + maxValue(arr));

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
#endif

#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = int.Parse(Console.ReadLine());
			Console.Write("Введетие количество элементов стрроки: ");
			int cols = int.Parse(Console.ReadLine());
			int[,] arr_2 = new int[rows, cols];
			Random rand = new Random(0);
			for (int i = 0; i < arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < arr_2.GetLength(1); j++)
				{
					arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < arr_2.GetLength(1); j++)
				{
					Console.Write(arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			for(int i = 0; i < (arr_2.GetLength(0)*arr_2.GetLength(1) - 1); i++)
			{
				for(int j = 1; j < arr_2.GetLength(0); j++)
				{
					for(int k = 0; k < arr_2.GetLength(1) - j; k++)
					{
				
					}
				}
			}
            Console.WriteLine("Сумма всех значений в массиве: " + sum_2(arr_2));
            Console.WriteLine("Среднее арифметическое всех значений в массиве: " + sum_2(arr_2) / (arr_2.GetLength(0) * arr_2.GetLength(1)));
            Console.WriteLine("Минимальное значение в массиве: "+ minValue_2(arr_2));
            Console.WriteLine("Максимльное значение в массиве: " + maxValue(arr_2));
			for (int i = 0; i < arr_2.GetLength(0); i++)
			{
				for(int j = 0; j < arr_2.GetLength(1);j++)
				{
					Console.Write(arr_2[i,j] + "\t");
				}
			Console.WriteLine(); 
			}
            Console.WriteLine();
#endif
#if JAGGED_ARRAY
			int[][] arr_jagged = new int[][]
			{
					new int[] {0, 1, 1,2},
					new int[] {3,5,8,13,21 },
					new int[] {34,55,89 },
					new int[] {144,233,377,610, 987}
			};
			int length = 0;
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
					length++;
				}
				Console.WriteLine();
			}
           
            Console.WriteLine("Сумма всех элементов массива: " + sum_jagged(arr_jagged));
            Console.WriteLine("Среднее арифметическое всех элементов массива: " + sum_jagged(arr_jagged)/length);
            Console.WriteLine("Минимально значение в массиве: " + minValue_jagged(arr_jagged));
            Console.WriteLine("Максимальное значение в массиве: " + maxValue_jagged(arr_jagged));
#endif
		}
	}
}