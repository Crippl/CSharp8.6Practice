using System;
using System.Collections.Generic;
using static System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someList = new List<int>();
            int fromNumber = 25;
            int toNumber = 50;

            AddNumbers(someList);
            ShowList(someList);
            ReadLine();
            DeleteSomeNumbers(someList,fromNumber, toNumber);
            ShowList(someList);
            ReadLine();
        }

        /// <summary>
        /// Метод добавления чисел в коллекцию
        /// </summary>
        /// <param name="someList"></param>
        private static void AddNumbers(List<int> someList)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < 100; i++)
            {
                someList.Add(randomNumber.Next(0, 100));
            }
        }

        /// <summary>
        /// Метод отображения коллекции
        /// </summary>
        /// <param name="someList"></param>
        private static void ShowList(List<int> someList)
        {
            foreach (int number in someList)
            {
                Write($" {number}");
            }
            WriteLine();
        }

        /// <summary>
        /// Метод удаления чисел указанного диапазона
        /// </summary>
        /// <param name="someList">используемая коллекция</param>
        /// <param name="minNumber">начало диапазона</param>
        /// <param name="maxNumber">конец диапазона</param>
        private static void DeleteSomeNumbers(List<int> someList,int minNumber,int maxNumber)
        {
            for (int  i= someList.Count-1; i >=0; i--)
            {
                if (someList[i]>minNumber&&someList[i]<maxNumber)
                {
                    someList.Remove(someList[i]);
                }
            }
        }
    }
}
