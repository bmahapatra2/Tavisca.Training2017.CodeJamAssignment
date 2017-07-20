using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Return_Value;
//Write a program in which accept four numbers from the user and returns add, subtraction and
//multiplication of the value using out parameter.
namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            
            int first, second, third, fourth;
            Console.WriteLine(" enter first number");
            if (int.TryParse(Console.ReadLine(), out first))
            { Console.WriteLine(first); }
            if (int.TryParse(Console.ReadLine(), out second))
            { Console.WriteLine(second); }
            if (int.TryParse(Console.ReadLine(), out third))
            { Console.WriteLine(third); }
            if (int.TryParse(Console.ReadLine(), out fourth))
            { Console.WriteLine(fourth); }
            Class_Sum sum = new Class_Sum();
            sum.Sum(first, second);
            Class_Multiply mul = new Class_Multiply();
            mul.Multiply(first, second);
            Calculator c = new Calculator();
            c.Subtract(first, second);
            Console.ReadKey(true);


        }
             int Subtract(  int  first,  int second)
            {
            int result;
            result = first - second;
            Console.WriteLine("Subtraction result"+" "+result);
            
            return result;
            }

    }   }






