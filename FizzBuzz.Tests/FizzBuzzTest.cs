using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Should_return_same_number_when_it_is_not_multiple_of_three_or_five()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 1;
            string value = fizzBuzz.Print(number);
            Assert.AreEqual("1", value);
        }
    }
}
