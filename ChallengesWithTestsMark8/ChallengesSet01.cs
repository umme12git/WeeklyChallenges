﻿using System;

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
            return minuend - subtrahend;
            //throw new NotImplementedException();
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
            //throw new NotImplementedException();

        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
                return number1;
            else
                return number2;

            //throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
            
            //throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {
            return "Hello!";
            //throw new NotImplementedException();
        }

        public string GetHey()
        {
            return "HEY!";
            //throw new NotImplementedException();
        }
    }
}
