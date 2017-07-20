using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Value
{
    public class Class_Multiply
    {
        public int Multiply(int number1, int number2)
        {
            int result;
            result = number1 * number2;
            Console.WriteLine("Multiply result" +" "+result);
            Console.ReadKey(true);
            return result;
           
        }
    }
}
