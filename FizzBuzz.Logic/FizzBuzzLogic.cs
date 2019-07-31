using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Logic
{
    public class FizzBuzzLogic
    {
        public List<string> Get()
        {
            var results = new List<string>();
            
            for (int i = 1; i < 101; i++)
            {
                var result = i.ToString();


                 if (i % 3 == 0 && i % 5 == 0)
                {
                    result = "FizzBuzz";
                }

                else if (i % 3 == 0)
                {
                    result = "Fizz";
                }

                else if (i % 5 == 0)
                {
                    result = "Buzz";
                }

                results.Add(result);
            }

            return results;
        }
    }
}
