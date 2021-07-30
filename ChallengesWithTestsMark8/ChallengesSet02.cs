using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result;
            result = Char.IsLetter(c);
            return result;

            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            
            return (vals.Length % 2 == 0) ? true : false;
                

            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;

            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //double val = numbers.Count();
            if (numbers == null ||  numbers.Count()==0)
                return 0;

             return numbers.Min() + numbers.Max();

            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length)? str1.Length: str2.Length;

           // throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            //int result = 0;
            //int result = 0;

            if (numbers == null || numbers.Length == 0)
                return 0;
            else
            {
                /*for (int i = 0; i < numbers.Length; i++)
                    result += numbers[i]; */
                return numbers.Sum();
            }
            //throw new NotImplementedException();
        }
        
        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return 0;
            else
            {
                
                //Console.WriteLine("the sum of even number is" , SumEvens(numbers));
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                        sum += numbers[i];
                }
                return sum;
               
            }
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                return false;
            else
            {
                if (numbers.Sum() %2 != 0)
                    return true;
                else
                    return false;

            }
            


            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            if (number < 0)
                return 0;
            
            else
                return number / 2;
            //throw new NotImplementedException();
        }
    }
}
