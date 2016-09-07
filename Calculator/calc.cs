using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calc : IAgeCalculator
    {

        public bool ParseInput(string input, out DateTime result)
        {
              DateTime dt;
              if(DateTime.TryParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
              {
                  result = dt;
                  return true;
              }
              result = dt;
              return false;
        }

        

        public int CalculateAge(DateTime dateOfBirth)
        {
            int age;
            DateTime now = DateTime.Today;
            age = now.Year - dateOfBirth.Year;
            return age;

        }
    }
}
