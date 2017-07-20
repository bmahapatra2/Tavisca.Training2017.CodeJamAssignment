using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line
{
    public class Calculation

    {
        int number1, number2;
        public int Area_Of_Rectangle(int number1,int number2)
        {
            int result = number1 * number2;
            return result;
        }
        public int Perimeter_Of_Rectangle(int number1, int number2)
        {
            int result = 2*(number1 * number2);
            return result;
        }

    }
}
