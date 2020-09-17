using System;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double result = minuend - subtrahend;
            return result; 
            
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int smallestNumber = 0;
            int[] a = new int[2];
            a[0] = number1;
            a[1] = number2;
            Array.Sort(a);
            smallestNumber = a[0];
            return smallestNumber;
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            var greeting = "Hello!";
            if (nameOfPerson.Length > 0)
            {
                greeting = $"Hello, {nameOfPerson}!";
            }

            return greeting;
        }

        public string GetHey()
        {
            return "Hey";
        }
    }
}
