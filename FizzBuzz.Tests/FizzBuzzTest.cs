using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {

        [TestMethod]
        public void Should_return_same_number_when_it_is_not_multiple_of_three_or_five()
        {
            int number = 1;
            string value = Print(number);
            Assert.AreEqual("1", value);
        }

        private string Print(int number)
        {
            return "1";
        }

        [TestMethod]
        public void Should_return_same_number_when_it_is_not_multiple_of_three_or_five2()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 1;
            string value = fizzBuzz.Print(number);
            Assert.AreEqual("1", value);
        }

        [TestMethod]
        public void Should_return_fizz_when_number_is_multiple_of_three()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 3;
            string value = fizzBuzz.Print(number);
            Assert.AreEqual("Fizz", value);
        }

        [TestMethod]
        public void Should_return_buzz_when_number_is_multiple_of_five()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 5;
            string value = fizzBuzz.Print(number);
            Assert.AreEqual("Buzz", value);
        }

        [TestMethod]
        public void Should_return_fizzbuzz_when_number_is_multiple_of_three_and_five()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 15;
            string value = fizzBuzz.Print(number);
            Assert.AreEqual("FizzBuzz", value);
        }
    }
}
