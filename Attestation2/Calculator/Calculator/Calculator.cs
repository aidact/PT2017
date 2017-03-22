using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator1
{
    public class Calculator
    {
        public enum Operation
        {
            NONE,
            NUMBER,
            PLUS,
            MINUS,
            MULT,
            DIV,
            PERS,
            SQRT,
            SQR,
            COMP,
            MS,
            MPLUS,
            MMINUS,
            EQUAL
        };
        public Operation operation;
        public double firstNumber, secondNumber, memoryNumber;

        public Calculator()
        {
            operation = Operation.NONE;
            firstNumber = 0;
            secondNumber = 0;
            memoryNumber = 0;
        }

        public void saveFirstNumber(string s)
        {
            firstNumber = int.Parse(s);
        }

        public void saveSecondNumber(string s)
        {
            secondNumber = int.Parse(s);
        }
        public double getResultPlus() // plus
        {
            return firstNumber + secondNumber;
        }
        public double getResultMinus() // minus
        {
            return firstNumber - secondNumber;
        }
        public double getResultMult() // multiplication
        {
            return firstNumber * secondNumber;
        }
        public double getResultDiv() // division
        {
            return firstNumber / secondNumber;
        }
        public double getResultPer() // percent
        {
            return firstNumber / 100;
        }
        public double getResultSqrt() // sqrt
        {
            return Math.Sqrt(firstNumber);
        }
        public double getResultSqr() // square
        {
            return firstNumber* firstNumber;
        }
        public double getResultComp() // complex
        {
            return 1 / firstNumber;
        }
        public double getMemoryPlus() // memory plus
        {
            return memoryNumber + firstNumber;
        }
        public double getMemoryMinus() // memory minus
        {
            return memoryNumber - firstNumber;
        }
    }
}
