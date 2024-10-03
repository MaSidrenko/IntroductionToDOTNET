using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
        static readonly string delimeter = "\n|---------------------------------|\n";
		static void Main(string[] args)
		{
            Console.WriteLine("Hello DataTypes");
            #region Bool
            //Console.WriteLine(sizeof(bool));
            //Console.WriteLine(true);
            //Console.WriteLine(false);
            //Console.WriteLine(Boolean.FalseString); 
            #endregion
            Console.WriteLine(sizeof(char));
            Console.WriteLine('+'.GetType());

            Console.WriteLine(delimeter);
            Console.WriteLine("\t\tByte:");
            Console.WriteLine("Size: " + sizeof(byte) + " Byte");
            Console.WriteLine("MinValue: " + byte.MinValue);
            Console.WriteLine("MaxValue: " + byte.MaxValue);
            Console.WriteLine(delimeter);

            Console.WriteLine("\t\tSbyte");
            Console.WriteLine("Size: " + sizeof(sbyte) + " Byte");
            Console.WriteLine("MinValue: " + sbyte.MinValue);
            Console.WriteLine("MaxValue: " + sbyte.MaxValue);
            Console.WriteLine(delimeter);

            Console.WriteLine("\t\tfloat: ");
            Console.WriteLine("Size: " + sizeof(float) + " byte");
            Console.WriteLine("MinValue: " + float.MinValue);
            Console.WriteLine("MaxValue: " + float.MaxValue);
            Console.WriteLine(delimeter);

            Console.WriteLine("\t\tdouble: ");
            Console.WriteLine("Size: " + sizeof(double) + " byte");
            Console.WriteLine("MinValue: " + double.MinValue);
            Console.WriteLine("MaxValue: " + double.MaxValue);
            Console.WriteLine(delimeter);

            Console.WriteLine("\t\tDecimal: ");
            Console.WriteLine("Size: " + sizeof(decimal) + " byte");
            Console.WriteLine("MinValue: " + decimal.MinValue);
            Console.WriteLine("MaxValue " + decimal.MaxValue);
            Console.WriteLine(delimeter);

            //Console.WriteLine(5ul.GetType());

            Console.WriteLine(int.MaxValue);
            int a = 2000000000;
            int b = 4;
            try
            {
                Console.WriteLine((a * b).GetType());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
             
            }

        }
	}
}