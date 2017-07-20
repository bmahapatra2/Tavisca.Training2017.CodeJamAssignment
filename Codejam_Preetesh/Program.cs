using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to check whether input number is even or odd.
namespace Codejam_Preetesh
{
    class Even_Odd
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine(" enter number you want to check");
            number=Convert.ToInt32(Console.ReadLine());

            if (number%2==0)
            {
                Console.WriteLine("entered number is even" + number);
            }
            else
            {
                Console.WriteLine(" entered number is odd" + " "+number);
            }
            Console.ReadLine();

        }
       
    }
}
