using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to copy one array’s elements to another array without using array function.
namespace Array_Copy
{
    class Array_Copy
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            Console.WriteLine(" enter the elements of array");
            {
                for (int i = 0; i < 5; i++)
                {
                    if (Int32.TryParse(Console.ReadLine(), out array1[i]))
                    {
                        Console.WriteLine(array1[i]);
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    array2[i] = array1[i];
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("elements of array1" + array1[i] + " "+ "\n");
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("elements of arra2" + array2[i] +" "+ "\n");

                }
            }Console.ReadKey(true);
        }
    }
}
