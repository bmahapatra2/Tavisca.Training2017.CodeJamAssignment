using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Reverse a string using array.
namespace Reverse_String
{
    class Reverse_String
    {
        static void Main(string[] args)
        {
            string str = "hello bandana";
            Console.WriteLine(str);
            char[] character_of_array = str.ToCharArray();
            for (int i = 0; i < character_of_array.Length; i++)
            {
                Console.WriteLine(" ELEMENTS OF ARRAY"+"  "+ character_of_array[i]);
            }
            // reversing a string using array
            for( int i=character_of_array.Length-1; i>=0; i--)
            {
               Console.WriteLine(character_of_array[i]);
            }
            Console.ReadKey(true);
        }
    }
}
