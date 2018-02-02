using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLive.Tests
{
    public class FizzBuzzer
    {
        public string Get(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            
            return number.ToString();
        }
    }
}
