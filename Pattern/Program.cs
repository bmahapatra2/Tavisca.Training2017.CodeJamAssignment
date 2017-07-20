using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using for loop print the following output on console.

//      1

//     121

//     12321

//    1234321

//   123454321
namespace Pattern
{
    class Pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Ready To See THe Pattern and enter the number till you want to see it");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                for (int column = 1; column < number - row; column++)
                {
                    Console.Write(" ");

                }
                for (int column2 = 1; column2 <= row; column2++)
                {
                    Console.Write(column2);
                }
                for (int column3 = row - 1; column3 >= 1; column3--)
                {
                    Console.Write(column3);
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }

    }
}
