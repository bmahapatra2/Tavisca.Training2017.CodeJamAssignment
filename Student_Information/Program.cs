using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Users_Details;

namespace Users_Details
{
    class User_Details
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();

            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter your phone number:");
            string phone_number = Console.ReadLine();
            Console.WriteLine("enter your city:");
            string city = Console.ReadLine();
            Console.WriteLine("enter your pin:");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your house number");
            int house_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("house number is : {0}", house_number);
            validation.Phone_Number(phone_number);
            Console.WriteLine("phone number : {0}", phone_number);
            Console.WriteLine("city : {0} ", city);
            if (int.TryParse(Console.ReadLine(),out pin))
            {
                
            }
             validation.Pin(pin);
            Console.WriteLine("pin is : {0}", pin);
            Console.ReadLine();


        }
        


    }
}