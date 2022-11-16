using System;

namespace kr
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // вариант 4 
                // задание 1
                Console.WriteLine("Введите число:");
                int number = Convert.ToInt32(Console.ReadLine());
                NumberManipulation obj = new NumberManipulation(number);
                NumberManipulation obj2 = new NumberManipulation();
                Console.WriteLine(obj);
                Console.WriteLine(obj2);

                //задание 2
                Console.WriteLine("Введите строку:");
                CheckCharacterCount.line = Console.ReadLine();
                Console.WriteLine("Введите индекс:");
                int NumberOfCharacters = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(Class2.removal(n));
                CheckCharacterCount.RemovalOfExcess(NumberOfCharacters);

                //задание 3
                Console.WriteLine("Введите первую строку:");
                string FirstLine = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите первый символ:");
                char FirstCharacter = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите вторую строку:");
                string SecondLine = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите второй символ:");
                char SecondCharacter = Convert.ToChar(Console.ReadLine());
                CharacterManipulation A = new CharacterManipulation(FirstLine, FirstCharacter);
                CharacterManipulation B = new CharacterManipulation(SecondLine, SecondCharacter);
                Console.WriteLine(A + B);
                Console.WriteLine(A - B);

                // задание 4 
                ShowCorrectWeightRatio WeightHeight = new ShowCorrectWeightRatio();
                Console.WriteLine("Ведите вес");
                WeightHeight.GetGrowth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите рост");
                WeightHeight.GetWeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(WeightHeight.ShowWeight);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }

    }
}
