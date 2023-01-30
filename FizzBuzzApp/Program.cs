using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze FizzBuzz. Proszę podaj liczbę całkowitą:");
            
            FizzBuzz game = new FizzBuzz();

            var answer = game.GetNumber();

            Console.WriteLine(answer);

            Console.ReadLine();

            
        }
    }
}
