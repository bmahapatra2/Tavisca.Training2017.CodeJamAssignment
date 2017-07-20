using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Without_Temp
{
    class Swap_Without_Temp
    {
        static void Main(string[] args)
        {
            Swap_Without_Temp p = new Swap_Without_Temp();
            int number1, number2;
            Console.WriteLine("enter first number you want to swap");
            if (Int32.TryParse( Console.ReadLine(),out number1))
            {
                Console.WriteLine(number1);
            }
            Console.WriteLine("enter second number you want to swap");
           
            if (Int32.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine(number2);
            }
            Console.WriteLine(" VAriables before swapping" +"\n" + number1 +"  " + number2);
            p.Swap(number1, number2);
            Console.ReadKey(true);
        }
        void Swap( int number1, int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine(" VAriables aftr swapping"+"\n" + number1 +"  " +number2);
        }
    }
}
