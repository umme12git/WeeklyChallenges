using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool found;
            if (words == null || words.Contains(null))
                found = false;
            else
            {
                if (ignoreCase == true)
                    found = words.Any(x => word.ToLower().Contains(x.ToLower()));
                else
                    found = words.Any(x => word.Contains(x));
            }
            return found;
        }

        public bool IsPrimeNumber(int num)
        {
            int i = 1;
            bool isPrime = true;
            if (num <= 1)
                return false;
            
            else
            {
              while (isPrime == true && i < num +1 )
              {
                    if (num % i == 0 && (i != num && i != 1))
                    {
                        isPrime = false; 
                    }
                    else
                        i += 1;
              }
                return isPrime;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            List<int> uniqueList = new List<int>();
            int unique = 0;
            int i = 0;
            int j = 0;
            char[] charArray = new char[str.Length];
            char repeated;
            
            repeated = ' ';
            charArray = str.ToCharArray();
           
            
            for (i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != repeated && charArray.Length > 1)
                {
                    for (j = 0; j < charArray.Length; j++)
                    {
                        if (charArray[i] == charArray[j])
                        {
                            if (i != j)
                            {
                                repeated = charArray[i];
                                unique = 0;
                            }
                        }
                        else
                        {
                            unique = 1;
                        }
                    }
                }
                
                if ((unique == 1 && charArray[i] != repeated) || charArray.Length ==1)
                   uniqueList.Add(i);
            }

            if (uniqueList.Count > 0)
                return uniqueList[uniqueList.Count() - 1];
            else
                return -1;
        }
        
        public int MaxConsecutiveCount(int[] numbers)
        {
            int count =1;
            int maxCount = 1;
            int maxOccurrence = 0;
            //List<int> numList = new List<int>();
            
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count += 1;
                    maxCount = count;
                  
                }
                else
                    count = 1;

                if (maxOccurrence < maxCount)
                    maxOccurrence = maxCount;
                
            }
            return maxOccurrence;    
        }


        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> elementsList = new List<double>();

            if (elements == null)
            {
                elements = new List<double> { };

                return elements.ToArray();
            }

            else if (elements.Count == 0)
            {
                elements.Clear();
                return elements.ToArray();
            }

            else
            {
                if (elements.Count >= n && n >=1)
                {
                    for (int i = 0; i < elements.Count - (n-1); i = i + n)
                    {
                        elementsList.Add(elements[i + (n-1)]);
                    }

                    return elementsList.ToArray();
                }
                else
                {
                    elements.Clear();
                    return elements.ToArray();
                }
            }
        }
    }
}
