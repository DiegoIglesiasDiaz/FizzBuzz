using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        const int FIZZ_DIVISIBLE_BY = 3;
        const int BUZZ_DIVISIBLE_BY = 5;
        const int NUMBER_OF_LAPS = 100;
        public void run()
        {
            for (int i = 1; i < NUMBER_OF_LAPS; i++)
            {
                PrintFizzBuzz(i);
            }
        }
        public void PrintFizzBuzz(int numberOfLap)
        {
            string result = string.Empty;
            if (IsFizz(numberOfLap))
                result += "Fizz";

            if (IsBuzz(numberOfLap))
                result += "Buzz";

            if (IsFizz_Contains(numberOfLap))
                result += "Fizz";

            if (IsBuzz_Contains(numberOfLap))
                result += "Buzz";
            if (result == string.Empty)
                result = numberOfLap.ToString();
            Console.WriteLine(result);

        }
        private void ThrowArguentExceptionIfIsNegativeNumber(int numberOfLap)
        {
            if (numberOfLap < 0) throw new ArgumentException("Can not have negative numbers");
        }
        public bool IsFizz(int numberOfLap)
        {
            ThrowArguentExceptionIfIsNegativeNumber(numberOfLap);
            return numberOfLap % FIZZ_DIVISIBLE_BY == 0;
        }
        public bool IsBuzz(int numberOfLap)
        {
            ThrowArguentExceptionIfIsNegativeNumber(numberOfLap);
            return numberOfLap % BUZZ_DIVISIBLE_BY == 0;
        }
        public bool IsFizz_Contains(int numberOfLap)
        {
            ThrowArguentExceptionIfIsNegativeNumber(numberOfLap);
            return numberOfLap.ToString().Contains(FIZZ_DIVISIBLE_BY.ToString());
        }
        public bool IsBuzz_Contains(int numberOfLap)
        {
            ThrowArguentExceptionIfIsNegativeNumber(numberOfLap);
            return numberOfLap.ToString().Contains(BUZZ_DIVISIBLE_BY.ToString());
        }
    }
}
