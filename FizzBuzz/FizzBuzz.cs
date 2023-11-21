using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int fizzDivisibleBy { get; set; } = 3;
        private int buzzDivisibleBy { get; set; } = 5;

        public string PrintFizzBuzz(int numberOfLap)
        {
            string result = string.Empty;
            if (numberOfLap % fizzDivisibleBy == 0)
                result += "Fizz";

            if (numberOfLap % buzzDivisibleBy == 0)
                result += "Buzz";

            if(numberOfLap.ToString().Contains(fizzDivisibleBy.ToString()))
                result += "Fizz";

            if (numberOfLap.ToString().Contains(buzzDivisibleBy.ToString()))
                result += "Buzz";

            return result != string.Empty ? result : numberOfLap.ToString();
        }
    }
}
