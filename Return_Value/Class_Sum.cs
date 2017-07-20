using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Value
{
    public class Class_Sum
    {
        public int Sum (int number1, int number2)
        {
            int result;
            result = number1 + number2;
            Console.WriteLine("Sum result" +" "+result);

            return result;
            Console.ReadKey(true);
        }
    }
}
