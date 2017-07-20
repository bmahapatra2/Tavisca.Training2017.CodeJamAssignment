using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Explain difference between value type and reference type by writing a suitable C# example.
namespace Method_Value_And_Reference
{
    class Method_Value_And_Reference
    {
        static void Main(string[] args)
        {
            Method_Value_And_Reference p = new Method_Value_And_Reference();
            int number1, number2;
            //  by value
            Console.WriteLine("enter first number you want to swap");
            if (Int32.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine(number1);
            }
            Console.WriteLine("enter second number you want to swap");

            if (Int32.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine(number2);
            }
            Console.WriteLine(" VAriables before swapping with value" + "\n" + number1 + "  " + number2);
            p.Swap_by_Value(number1, number2);
            Console.WriteLine(" VAriables after swapping with value" + "\n" + number1 + "  " + number2);
            //by reference
            Console.WriteLine("enter first number you want to swap");
            if (Int32.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine(number1);
            }
            Console.WriteLine("enter second number you want to swap");

            if (Int32.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine(number2);
            }
            Console.WriteLine(" VAriables before swapping with reference" + "\n" + number1 + "  " + number2);
            p.Swap_by_Reference(ref number1, ref number2);
            Console.WriteLine(" VAriables after swapping with reference" + "\n" + number1 + "  " + number2);
            Console.ReadKey(true);
        }
        void Swap_by_Value(int number1, int number2) // swapping by method of value type
        {
            int temp;
            temp= number1;
            number1 = number2;
            number2 = temp;
       
        }

        void Swap_by_Reference(ref int number1, ref int number2 )
        {
            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;

        }
    }
}
