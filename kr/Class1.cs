using System;
using System.Collections.Generic;
using System.Text;

namespace kr
{
    class NumberManipulation
    {
        private int _number;
        public NumberManipulation(int number)
        {
            try
            {
                this._number = number % 10;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
        public NumberManipulation()
        {
            try
            {
                _number = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
        public override string ToString()
        {
            return "Значение числового поля: " + _number;
        }
    }
}
