using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 0;
            GameFizzBuzz FizzBuzz = new GameFizzBuzz();

            while (true)
            {
                Console.WriteLine("Podaj liczbę");

                var userValue = getValue();
    
                Console.WriteLine(FizzBuzz.FizzBuzz(userValue));
               
            }

        }
        private static int getValue()
        {
            while (true)
            {
                var val = Console.ReadLine();

                if (val.ToUpper() == "T")
                    Environment.Exit(0);

                if (!int.TryParse(val, out int value))
                {
                    Console.WriteLine("Podana Wartość jest nieprawidłowa, spróbuj ponownie");
                    continue;
                }

                return value;

            }
        }
    }
}
