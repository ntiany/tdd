using System;
using Tdd;
using Xunit;

namespace Tests
{
    public class Tests
    {
        private const int boundary = 100;

        [Fact]
        public void ShouldReturnFizz()
        {
            var generatedNumber = ReturnDivisableNumber(3);

            var fizzBuzzResult = FizzBuzzHandler.Handle(generatedNumber);

            Assert.Equal(fizzBuzzResult, "Fizz");
        }

        [Fact]
        public void ShouldReturnBuzz()
        {
            var generatedNumber = ReturnDivisableNumber(5);

            var fizzBuzzResult = FizzBuzzHandler.Handle(generatedNumber);

            Assert.Equal(fizzBuzzResult, "Buzz");
        }

        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            var generatedNumber = ReturnDivisableNumber(15);

            var fizzBuzzResult = FizzBuzzHandler.Handle(generatedNumber);

            Assert.Equal(fizzBuzzResult, "FizzBuzz");
        }

        [Fact]
        public void ShouldReturnNumber()
        {
            var generatedNumber = ReturnDivisableNumber(15);
            var testNumber = generatedNumber + 1;
            var fizzBuzzResult = FizzBuzzHandler.Handle(generatedNumber);

            Assert.Equal(fizzBuzzResult, testNumber.ToString());

        }

        private int ReturnDivisableNumber(int number)
        {
            var random = new Random();
            var generatedNumber = random.Next(boundary / number) * number;
            return generatedNumber;
        }
    }
}
