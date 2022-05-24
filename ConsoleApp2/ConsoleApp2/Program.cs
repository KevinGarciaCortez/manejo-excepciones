using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            Console.WriteLine("Ingrese un número");
            
            try
            {
                num1 = float.Parse(Console.ReadLine());
                num2 = num1 * num1;
                Console.WriteLine("Cuadrado: " + num2);
            }
            
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally {  }
            Console.ReadKey();
        }
    }
}
