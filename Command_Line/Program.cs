using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to demonstrate command line argument. Accept 2 numbers from the user
//and calculate area and perimeter of rectangle.
namespace Command_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            int number1, number2;
            Console.WriteLine("enter one side of the rectangle");
            if(int.TryParse(Console.ReadLine(), out number1))
            {

            }

            Console.WriteLine("enter another side of the rectangle");
            if (int.TryParse(Console.ReadLine(), out number2))
            {

            }

            Console.WriteLine("area of rectangle \t"+ " "+calculation.Area_Of_Rectangle(number1, number2));
            Console.WriteLine("perimeter of rectangle \t" + " " + calculation.Perimeter_Of_Rectangle(number1, number2));
            Console.ReadKey(true);




        }
    }
}
