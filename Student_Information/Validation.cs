using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Users_Details
{
    public class Validation
    {
        public bool Phone_Number(string phone_number)
        {
            return Regex.Match(phone_number, @"^(\+[0-9]{9})$").Success;
        }

        public bool Pin(int pin)
        {

            if (pin.ToString().Length != 6)
            {
                return false;
            }

            else
                return true;
        }

    }
}
