using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {

        [Test]
        [TestCase(24,true)]
        [TestCase(12,false)]
        [TestCase(0,false)]
        public void isFizz_DivisibibleBy3(int numberOfLap,bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            Assert.That(fizzBuzz.IsFizz(numberOfLap), Is.EqualTo(value));
        }

        [Test]
        [TestCase(15, true)]
        [TestCase(12, false)]
        [TestCase(0, false)]
        public void isBuzz_DivisibibleBy5(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            Assert.That(fizzBuzz.IsBuzz(numberOfLap), Is.EqualTo(value));
        }
        [Test]
        [TestCase(15, true)]
        [TestCase(12, false)]
        [TestCase(0, false)]
        public void isFizzBuzz_DivisibibleBy3and5(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            bool result = fizzBuzz.IsBuzz(numberOfLap) && fizzBuzz.IsFizz(numberOfLap);
            Assert.That(result, Is.EqualTo(value));
        }
        [Test]
        [TestCase(-1)]
        [TestCase(-20)]
        public void FizzBuzzArgumentExcpetion(int numberOfLap, bool value)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            Assert.Throws<ArgumentException>(() => fizzBuzz.IsFizz(numberOfLap));
            Assert.Throws<ArgumentException>(() => fizzBuzz.IsFizz(numberOfLap));
            Assert.Throws<ArgumentException>(() => fizzBuzz.IsFizz(numberOfLap));
        }

    }
}