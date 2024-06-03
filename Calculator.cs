using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calculator
    {
        private List<int> operationHistory = new List<int>();

        public int Add(int a, int b)
        {
            int result = a + b;
            AddToHistory(result);
            return result;
        }

        public int Subtract(int a, int b)
        {
            int result = a - b;
            AddToHistory(result);
            return result;
        }

        public int Multiply(int a, int b)
        {
            int result = a * b;
            AddToHistory(result);
            return result;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            int result = a / b;
            AddToHistory(result);
            return result;
        }

        public List<int> GetOperationHistory()
        {
            return operationHistory.GetRange(Math.Max(0, operationHistory.Count - 4), Math.Min(4, operationHistory.Count));
        }

        private void AddToHistory(int result)
        {
            operationHistory.Add(result);
        }
    }
}
