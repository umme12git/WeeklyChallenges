using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public ChallengesSet03()
        {
        }

        public bool ArrayContainsAFalse(bool[] vals)
        {
            
            for(int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                    return true;

            }
            return false;

            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum;
            //int num = 0;
            if (numbers == null || numbers.Count() == 0)
                return false;
            else
            {

                /* for (int i = 0; i < numbers.Count(); i++)
                 {

                     num = numbers.ElementAt(i) / 2;
                     Console.WriteLine("number is ", num);
                     if (Math.Abs(num) != 0)
                         sum = sum + num;

                 }

                 if (sum / 2 != 0)
                     return true;
                 else
                     return false;  */
                sum = numbers.Sum();
                Console.WriteLine("value of sum is ", sum);
                if (sum >= 0)
                    if (sum % 2 != 0)
                        return true;
                    else
                        return false;
                else
                    if (Math.Abs(sum) % 2 != 0)
                    return true;
                else
                    return false;

                //else
                    //return false;

            }


                
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool foundUpper  = false;
            bool foundLower = false;
            bool foundLetter = false;
            
            for (int i = 0; i < password.Length; i++)
               {

                    if (char.IsUpper(password[i]) == true)
                        foundUpper = true;
                    if (char.IsLower(password[i]) == true)
                        foundLower = true;
                    if (char.IsLetter(password[i]) == false)
                    {

                    foundLetter = true;
                    }
                                    
               }
            if (foundUpper == true && foundLower == true && foundLetter == true)
                return true;
            else
                return  false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
                return dividend / divisor;
            else return 0;
                        
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            int i = 0;
            int j = 1;
            int[] oddsBelow100 = new int[50];
                       
            for ( i = 0; i < 50; i++)
            {
                oddsBelow100[i] = j;
                j = j + 2;
            }
            return oddsBelow100;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
