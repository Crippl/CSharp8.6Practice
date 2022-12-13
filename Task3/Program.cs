using System.Collections.Generic;
using static System.Console;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> someHashSet = new HashSet<int>();

            string stop;
            int number;
            do
            {
                Write("Введите число : ");
                number = int.Parse(ReadLine());
                if (someHashSet.Contains(number))
                {
                    WriteLine($" Число {number} уже вводилось ранее ");
                }
                else
                {
                    someHashSet.Add(number);
                    WriteLine($" Число {number} успешно добавлено! ");
                }

                Write("Введите любой символ для продолжения, пустая строка - завершить : ");
                stop = ReadLine();
            } while (stop != "");
        }
    }
}
