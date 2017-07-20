using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Return_Value;

namespace Return_Value
{
    public class Program_Mul_Sum
    {
        public static void Main(string[] args)
        {
            int number1, number2, solution;
            Console.WriteLine(" enter the values of the number");
            number1= Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            Class_Sum add = new Class_Sum();
            Class_Multiply multiply = new Class_Multiply();
            solution = add.Sum(number1, number2);
            Console.WriteLine("Result of sum operation" + " " + solution);
            solution = multiply.Multiply(number1, number2);
            Console.WriteLine("Result of multiply operation" + " " + solution);
            Console.ReadKey(true);
        }
    }
}
