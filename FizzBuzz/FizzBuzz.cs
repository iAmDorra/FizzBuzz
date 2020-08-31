﻿using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const int FizzMultiplier = 3;
        private const int BuzzMultiplier = 5;

        public string Print(int number)
        {
            if (number % BuzzMultiplier == 0)
            {
                return "Buzz";
            }

            if (number % FizzMultiplier == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}
