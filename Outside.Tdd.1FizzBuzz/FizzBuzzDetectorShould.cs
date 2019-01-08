using System;
using Shouldly;
using Xunit;

namespace Outside.Tdd._1FizzBuzz
{
    public class FizzBuzzDetectorShould
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void PrintNumbers(int number, string expectedResult)
        {
            var result = FizzBuzzDetector.IdentifyFizzBuzz(number);
            result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void PrintFizzForMultiplesOfThree(int number)
        {
            var result = FizzBuzzDetector.IdentifyFizzBuzz(number);
            result.ShouldBe("Fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void PrintBuzzForMultiplesOfFive(int number)
        {
            var result = FizzBuzzDetector.IdentifyFizzBuzz(number);
            result.ShouldBe("Buzz");
        }
    }

    public class FizzBuzzDetector
    {
        public static string IdentifyFizzBuzz(int i)
        {
            if (i % 5 == 0)
                return "Buzz";

            if (i % 3 == 0)
                return "Fizz";

            return i.ToString();
        }
    }
}
