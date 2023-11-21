namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {

        [Fact]
        public void isDivisibleBy3()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = string.Empty;
            string expectedResult = "Fizz";

            result = fizzBuzz.PrintFizzBuzz(24);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void isDivisibleBy5()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = string.Empty;
            string expectedResult = "Buzz";

            result = fizzBuzz.PrintFizzBuzz(20);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void isNotDivisibleBy3and5_DontContains3or5()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = string.Empty;
            string expectedResult = "2";

            result = fizzBuzz.PrintFizzBuzz(2);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void itContains3()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = string.Empty;
            string expectedResult = "Fizz";

            result = fizzBuzz.PrintFizzBuzz(31);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void itContains5()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = string.Empty;
            string expectedResult = "Buzz";

            result = fizzBuzz.PrintFizzBuzz(52);

            Assert.Equal(expectedResult, result);
        }

    }
}