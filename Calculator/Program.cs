using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            calc calcu = new calc();
            
            Console.WriteLine("Enter date of birth (dd-MM-yyyy");
            String inputdate = Console.ReadLine();
            DateTime result;
            Console.WriteLine(calcu.ParseInput(inputdate, out result));
            while (!calcu.ParseInput(inputdate, out result))
            {
                Console.WriteLine("Enter date of birth (dd-MM-yyyy");
                inputdate = Console.ReadLine();
            }
            if (calcu.ParseInput(inputdate, out result))
            {
                Console.WriteLine(calcu.CalculateAge(result));
                Console.WriteLine("Success!");
                Console.ReadLine();

            }
                
            
        }
    }
}
