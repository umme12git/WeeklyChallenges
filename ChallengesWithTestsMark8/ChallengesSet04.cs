using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            
            int sumEven = 0;
            int sumOdd = 0;
            if (numbers.Length == 0)
                return 0;

            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                        sumEven += numbers[i];

                    else
                        sumOdd += numbers[i];
                }
                return sumEven - sumOdd;

            }
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strList = new List<string>{ str1, str2, str3, str4 };
            var shortestLength = strList.Min(len => len.Length);
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int> { number1, number2, number3, number4 };
            var smallestNumber = numList.Min(smallest => smallest);
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
           
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2 <= sideLength3) ||
                (sideLength1 + sideLength3 <= sideLength2) ||
                (sideLength2 + sideLength3 <= sideLength1))
                return false;
            else
                return true;

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            foreach (var word in objs)
            {
                if (word == null)
                    count++;

            }
            if (count > objs.Length - count)
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0.0;
            int j = 0;
            double average = 0.0;
            string numstring = Convert.ToString(numbers);

            if (numbers == null || numbers.Length == 0)
                return 0.0;
            else
            {

                j = 0;
                average = 0.0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (Math.Abs(numbers[i]) % 2 == 0)
                    {
                        sum += numbers[i];
                        j++;
                    }
                }
                if (j == 0)
                    return 0.0;
                else
                {
                    average = sum / j;
                    return average;
                }
            }
            
        }

        public int Factorial(int number)
        {
            
                int factorial = 1;
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            else
            {
                for (int i = number; i > 0; i--)
                {
                    factorial = factorial * i;
                }
                return factorial;
            }
            
        }
        public void NegativeFactorialShouldThrowArgumentOutOfRangeException()
        {
            int num1 = -1;
            int num2 = -2;
            int num3 = -3;
            int result;

            result = Factorial(num1);
            result = Factorial(num2);
            result = Factorial(num3);
        }

    }
}
