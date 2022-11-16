using System;
using System.Collections.Generic;
using System.Text;

namespace kr
{
    class CheckCharacterCount
    {
        public static string line;
        public static void RemovalOfExcess(int NumberOfLeft)
        {
            try
            {
                if (NumberOfLeft >= line.Length)
                {
                    Console.WriteLine("В строке нет столько символов");
                }
                else
                {
                    line = line.Remove(NumberOfLeft);
                    Console.WriteLine(line);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
    }
}
