using System;
using Tdd;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void ShouldReturnFizz()
        {
            var random = new Random();
            var number = random.Next(33) * 3;
            var generatedNumber = FizzBuzzHandler.Handle(number);
        }

        [Fact]
        public void ShouldReturnBuzz()
        {

        }

        [Fact]
        public void ShouldReturnFizzBuzz()
        {

        }

        [Fact]
        public void ShouldReturnNumber()
        {

        }
    }
}
