using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class GameFizzBuzz
    {
        public string FizzBuzz(int value)
        {
            string result = "";
            int checkMod3;
            int checkMod5;

            checkMod3 = value % 3;
            checkMod5 = value % 5;

            if (checkMod3 == 0 && checkMod5 != 0)
            {
                result =  "Fizz";
            }
            if(checkMod5 == 0 && checkMod3 != 0)
            {
                result =  "Buzz";
            }
            if (checkMod3 == 0 && checkMod5 == 0)
                result = "FizzBuzz";

            if (checkMod3 != 0 && checkMod5 != 0)
                result = Convert.ToString(value);

            return result;
        }
    }
}
