using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Detail
{
    public class Student_Validation
    {
        public bool Rollnumber(int roll_number)
        {
            if (roll_number.ToString().Length != 10)
            {
                return false;
            }

            else
                return true;
        }
    }
}
