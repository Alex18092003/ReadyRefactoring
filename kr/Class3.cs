using System;
using System.Collections.Generic;
using System.Text;

namespace kr
{
    class CharacterManipulation
    {

        private string _line;
        private char _symbol;
        public CharacterManipulation(string line, char symbol)
        {
            try
            {
                this._line = line;
                this._symbol = symbol;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }

        public static int operator +(CharacterManipulation a, CharacterManipulation b)
        {
            return a._line.Length + b._line.Length;
        }

        public static int operator -(CharacterManipulation a, CharacterManipulation b)
        {
                int ii;

                if (a._symbol >= b._symbol)
                {
                    ii = a._symbol - a._symbol;
                }
                else
                {
                    ii = b._symbol - a._symbol;
                }
                char symd = Convert.ToChar(ii);
                return symd;
        }
    }
}
