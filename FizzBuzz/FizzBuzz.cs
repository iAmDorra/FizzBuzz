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
            string fizzBuzzValue = null;
            if (number % FizzMultiplier == 0)
            {
                fizzBuzzValue += FIZZ;
            }

            if (number % BuzzMultiplier == 0)
            {
                fizzBuzzValue += BUZZ;
            }

            if (fizzBuzzValue != null)
            {
                return fizzBuzzValue;
            }

            return number.ToString();
        }
    }
}
