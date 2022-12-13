using System.Collections.Generic;
using static System.Console;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> phoneBook = new Dictionary<int,string>();
            AddInPhoneBook(phoneBook);
            SearchOwner(phoneBook);
            ReadLine();
        }

        /// <summary>
        /// Метод для добавления информации в коллекцию
        /// </summary>
        /// <param name="phoneBook"></param>
        private static void AddInPhoneBook(Dictionary<int,string> phoneBook)
        {
            string stop;
            do
            {
                Write("Введите номер телефона : ");
                int phoneNumber = int.Parse(ReadLine());

                Write("Введите Ф.И.О : ");
                string FIO = ReadLine();

                phoneBook.Add(phoneNumber, FIO);

                WriteLine($"Номер телефона +{phoneNumber} присвоен владельцу {FIO}");
                WriteLine();
                Write("Введите любой символ для продолжения, пустая строка - завершить : ");
                stop = ReadLine();
            } while (stop!="");
            WriteLine();
        }

        /// <summary>
        /// Метод поиска владельца по номеру телефона
        /// </summary>
        /// <param name="phoneBook"></param>
        private static void SearchOwner(Dictionary<int, string> phoneBook)
        {
            Write("Введите номер телефона для поиска владельца : ");

            int phoneNumber = int.Parse(ReadLine());

            if (phoneBook.TryGetValue(phoneNumber,out string FIO))
            {
                WriteLine($"Владелец номера {phoneNumber} - {FIO}");
            }
            else
            {
                WriteLine($"По номеру {phoneNumber} владельца не зарегестрировано");
            }
        }
    }
}
