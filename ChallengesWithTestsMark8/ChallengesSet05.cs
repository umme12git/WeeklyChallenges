using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber %n == 0)
            {
                startNumber = startNumber + n;
            }
            
            else
            {
                int found = 0;
                while (found == 0)
                {
                    startNumber += 1;
                    if (startNumber % n == 0)
                    {
                        found = 1;
                    }

                }
                
            }
            return startNumber;
           
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var Businss in businesses)
            {
                if(Businss.TotalRevenue == 0)
                {
                    Businss.Name = "CLOSED";
                }

            }
           
        
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            
            bool ascend = true;
            int i = 0; ;
            if (numbers == null || numbers.Length == 0)
                ascend = false;
            else if (numbers.Length == 1)
                ascend = true;
            else
            {
                while ((ascend == true) && (i < numbers.Length-1))
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        ascend = false;
                    }
                    else
                    {
                        i += 1;
                    }
                }
            }
            return ascend;   
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Length == 0)
                return 0;
            else
            {

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i + 1];
                    }
                }
                return sum;
            }
                         
        }
            
        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            if (words == null || words.Length == 0)
                return "";
            else if (words[0] == "")
                return "";
            else
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Trim() != "" && words[i] != "")
                    {
                        if (i == words.Length - 1)
                            sentence += $"{words[i].Trim()}.";
                        else
                            sentence += $"{words[i].Trim()} ";
                    }
                    
                }
                return sentence;
            }

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> elementsList = new List<double>();
            
            if (elements == null)
            {
               elements = new List<double>{ };
              
               return elements.ToArray();
            }
             
            else if(elements.Count == 0)
            {
                elements.Clear();
                return elements.ToArray();
            }
               
            else
            {
                if (elements.Count >= 4)
                {
                    for (int i = 0; i < elements.Count - 3; i = i + 4)
                    {
                        elementsList.Add(elements[i + 3]);
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

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool answer = true;
            bool found = false;
            bool more = true;
            int i = 0;
            int j = 1;
            if (nums == null || nums.Length == 0 || nums.Length == 1)
                answer = false;
            else
            {

                while (found == false && i < nums.Length -1)
                {
                    while(more == true && j < nums.Length)
                    {
                        if (nums[i] + nums[j] == targetNumber)
                        {
                            answer = true;
                            found = true;
                            more = false;
                        }
                        else
                        {
                            answer = false;
                            //found = false;
                            //more = true;
                            j += 1;
                        }
                    }

                    i += 1;
                    j = i + 1;
                }
            }
            return answer;
        }
    }
}
