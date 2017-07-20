using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program of tax calculation. Accept money as input from the user and calculate the tax
namespace Taxation
{
    class Taxation
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the amount of money");
            int amount;
            if (Int32.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine(amount);
            }
            if (amount <= 10000)
            {
                Console.WriteLine("Percentage recieve=5%"+ " " + (amount * 0.05));
            }
            else if (amount > 10000 && amount < 100000)
            {
                Console.WriteLine("Percentage recieve=8%" + " " + (amount * 0.08));
            }
            else
            {
                if(amount >= 100000)
            {
                    Console.WriteLine("Percentage recieve=8.5%" + " " + (amount * 0.085));
            }

            }
            Console.ReadKey(true);
        }
    }
}
