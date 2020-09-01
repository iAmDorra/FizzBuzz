using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const int FizzMultiplier = 3;
        private const int BuzzMultiplier = 5;
        private const string BUZZ = "Buzz";
        private const string FIZZ = "Fizz";

        public string Print(int number)
        {
            if (number % FizzMultiplier == 0 && number % BuzzMultiplier == 0)
            {
                return FIZZ + BUZZ;
            }

            if (number % BuzzMultiplier == 0)
            {
                return BUZZ;
            }

            if (number % FizzMultiplier == 0)
            {
                return FIZZ;
            }

            return number.ToString();
        }
    }
}
