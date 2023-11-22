using Microsoft.VisualStudio.TestPlatform.Utilities;
using Moq;
using System.IO;
using System.Text.RegularExpressions;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(24, true)]
        [TestCase(12, true)]
        [TestCase(13, false)]
        public void isFizz_DivisibibleBy3(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            Assert.That(fizzBuzz.IsFizz(numberOfLap), Is.EqualTo(value));
        }

        [Test]
        [TestCase(15, true)]
        [TestCase(12, false)]
        public void isBuzz_DivisibibleBy5(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            Assert.That(fizzBuzz.IsBuzz(numberOfLap), Is.EqualTo(value));
        }
        [Test]
        [TestCase(15, true)]
        [TestCase(12, false)]
        public void isFizzBuzz_DivisibibleBy3and5(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            bool result = fizzBuzz.IsBuzz(numberOfLap) && fizzBuzz.IsFizz(numberOfLap);
            Assert.That(result, Is.EqualTo(value));
        }
        [Test]
        [TestCase(-1)]
        [TestCase(-20)]
        public void FizzBuzzArgumentExcpetion(int numberOfLap)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            Assert.Throws<ArgumentException>(() => fizzBuzz.IsFizz(numberOfLap));
        }
        [Test]
        [TestCase(1, false)]
        [TestCase(24, true)]
        public void PrintFizz(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            fizzBuzz.PrintFizzBuzz(numberOfLap);

            Assert.That(stringWriter.ToString().Contains("Fizz"), Is.EqualTo(value));
        }
        [Test]
        [TestCase(1, false)]
        [TestCase(25, true)]
        public void PrintBuzz(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            fizzBuzz.PrintFizzBuzz(numberOfLap);

            Assert.That(stringWriter.ToString().Contains("Buzz"), Is.EqualTo(value));
        }
        [Test]
        [TestCase(15, true)]
        [TestCase(25, false)]
        [TestCase(24, false)]
        [TestCase(1, false)]
        public void PrintFizzBuzz(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            fizzBuzz.PrintFizzBuzz(numberOfLap);
            bool result = stringWriter.ToString().Contains("Buzz") && stringWriter.ToString().Contains("Fizz");
            Assert.That(result, Is.EqualTo(value));
        }

        [Test]
        [TestCase(15, true)]
        [TestCase(25, false)]
        [TestCase(24, false)]
        [TestCase(1, false)]
        public void CompareOutput(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var exectedResult = new string[]
            {
        "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz",
        "11","Fizz","13","14","FizzBuzz","16","17","Fizz","19","Buzz"
            };

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            fizzBuzz.run();

            var capturedOutput = stringWriter.ToString();
            var spltedOutput = capturedOutput.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var result = spltedOutput.Take(20).ToArray();
            Assert.That(result, Is.EqualTo(exectedResult));
        }

    }
}