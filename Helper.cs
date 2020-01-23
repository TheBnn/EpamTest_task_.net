using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTest_task_.net
{
    class Helper
    {
        public static int[] GetNumArray(int countNums)
        {
            int[] arrayNums = new int[countNums];

            Random rnd = new Random();

            for(int i = 0; i<countNums; i++)
            {
                arrayNums[i] = rnd.Next(0, countNums);
            }

            return arrayNums;
        }

        //Так как представлен вывод ниже не правильно делать но для экономии времени пойдет.
        //Лучше сделать через делегаты.
        public static void Print_Format(int[] array)
        {
            foreach(int i in array)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        internal static void Print_Format(long v)
        {
            Console.Write($"{v} ");
            Console.WriteLine();
        }

        public static void Print_Format(string str)
        {
            Console.Write($"{str} ");
            Console.WriteLine();
        }
        public static void Print_Format(string[] array)
        {
            foreach (string i in array)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        public static void Print_Format(int str)
        {
            Console.Write($"{str} ");
            Console.WriteLine();
        }
        public static void Print_Format(bool str)
        {
            if (str == true)
            {
                Console.WriteLine("Содержит");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Не содержит");
                Console.WriteLine();
            }

        }
    }
}
