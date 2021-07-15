using System;

namespace CalculatorImplementat
{
    public sealed class Calculator
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _result;
        public void SetFirstNumber(int firstNumber)
        {
            _firstNumber = firstNumber;
        }

        public void SetSecondNumber(int secondNumber)
        {
            _secondNumber = secondNumber;
        }

        public void AddNumbers()
        {
            _result = _firstNumber + _secondNumber;
        }

        public int GetResult()
        {
            return _result;
        }

        public void MultiplyNumbers()
        {
            _result = _firstNumber * _secondNumber;
        }
    }
}
