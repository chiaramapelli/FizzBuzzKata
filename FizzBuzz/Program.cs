using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Logic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzLogic = new FizzBuzzLogic();
            var results = fizzBuzzLogic.Get();
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }

            Console.ReadLine();

        }
    }
}
