using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int length = vals.Length;
            return length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (!numbers?.Any() ?? false)
            {
                return 0;
            }
            var min = numbers.Min(i => i);
            var max = numbers.Max(k => k);

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            var total = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var item in numbers)
            {
                total += item;
            }

            return total;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers?.Any() != true)
            {
                return sum;
            }
            else
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }

                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers?.Any() != true)
            {
                return false;
            }
            else
            {
                var sum = numbers.Sum();
                return sum % 2 != 0;
            }

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long oddSum = 0;
            for (var i = 1; i < number; i += 2)
            {
                oddSum += 1;
            }

            return oddSum;
        }
    }
}
    }
}
