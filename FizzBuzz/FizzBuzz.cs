using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const int FizzMultiplier = 3;

        public string Print(int number)
        {
            if (number % FizzMultiplier == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}
