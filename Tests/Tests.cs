using System;
using System.Collections.Generic;
using System.Linq;
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
            // should add option to return 0
            var baseNumber = ReturnDivisibleNumber(15);
            var divisbleBy3List = GenerateListWithDivisibleNumbers(3, 15);
            var testNumber = baseNumber + divisbleBy3List[ReturnRandomNumber(divisbleBy3List.Count)];

            var fizzBuzzResult = FizzBuzzHandler.Handle(testNumber);

            Assert.Equal("Fizz", fizzBuzzResult);
        }

        [Fact]
        public void ShouldReturnBuzz()
        {
            // should add option to return 0
            var baseNumber = ReturnDivisibleNumber(15);
            var divisbleBy5List = GenerateListWithDivisibleNumbers(5, 15);
            var testNumber = baseNumber + divisbleBy5List[ReturnRandomNumber(divisbleBy5List.Count)];

            var fizzBuzzResult = FizzBuzzHandler.Handle(testNumber);

            Assert.Equal("Buzz", fizzBuzzResult);
        }

        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            
            var generatedNumber = ReturnDivisibleNumber(15);

            var fizzBuzzResult = FizzBuzzHandler.Handle(generatedNumber);

            Assert.Equal("FizzBuzz", fizzBuzzResult);
        }

        [Fact]
        public void ShouldReturnNumber()
        {
            var baseNumber = ReturnDivisibleNumber(15);

            var notDivisibleBy3 = GenerateListWithNotDivisibleNumbers(3, 15);
            var notDivisibleBy5 = GenerateListWithNotDivisibleNumbers(5, 15);
            var allowedNumbersList = notDivisibleBy3.Intersect(notDivisibleBy5).ToList();

            var testNumber = baseNumber + allowedNumbersList[ReturnRandomNumber(allowedNumbersList.Count)];
            var fizzBuzzResult = FizzBuzzHandler.Handle(testNumber);

            Assert.Equal(testNumber.ToString(), fizzBuzzResult);

        }

        private int ReturnRandomNumber(int upperBound, int lowerBound = 0)
        {
            var random = new Random();
            if (lowerBound == 0)
            {
                return random.Next(upperBound);
            }
            else
            {
                return random.Next(lowerBound, upperBound);
            }

        }

        private int ReturnDivisibleNumber(int number)
        {
            var lowerBound = 1;
            var generatedNumber = ReturnRandomNumber(boundary / number, lowerBound) * number;
            return generatedNumber;
        }

        private List<int> GenerateListWithDivisibleNumbers(int divisionNumber, int maxNumber)
        {
            List<int> newList = new List<int>();
            for (int i = 1; i < maxNumber; i++)
            {
                if (i % divisionNumber == 0)
                {
                    newList.Add(i);
                }
            }

            return newList;
        }



        private List<int> GenerateListWithNotDivisibleNumbers(int divisionNumber, int maxNumber)
        {
            List<int> newList = new List<int>();
            for (int i = 1; i < maxNumber; i++)
            {
                if (i % divisionNumber != 0)
                {
                    newList.Add(i);
                }
            }

            return newList;
        }


    }
}
