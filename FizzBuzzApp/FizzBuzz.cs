using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    internal class FizzBuzz
    {
        public string answer;
        public string GetNumber()
        {

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Miałeś podać liczbę całkowitą");
                }

                else
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        answer = "FizzBuzz";
                        return answer;
                    }
                    else if (number % 3 == 0)
                    {
                        answer = "Fizz";
                        return answer;
                    }
                    else if (number % 5 == 0)
                    {
                        answer = "Buzz";
                        return answer;

                    }
                    else
                        Console.WriteLine($"Twoja liczba to {number}. Spróbuj jeszcze raz:");
                }
            }
        }
    }
}
