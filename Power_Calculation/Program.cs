using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Calculation
{
    class Power_Calculation
    {
        static void Main(string[] args)
        {
            Power_Calculation p = new Power_Calculation();
            Console.WriteLine("enter number to calculate power");
            int number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the power you want to calculate");
            int power= Convert.ToInt32(Console.ReadLine());
            int result= p.Number_Power(number, power); ;
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
        int Number_Power(int number, int power)
        {
            for(int i=1;i<power;i++)
            {
                number *= number;
            }
            return number;
        }
    }
}
