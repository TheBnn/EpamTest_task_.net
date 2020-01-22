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
        public static void Print_Format(int[] array)
        {
            foreach(int i in array)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void Print_Format(string str)
        {
            Console.Write($"{str} ");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void Print_Format(int str)
        {
            Console.Write($"{str} ");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void Print_Format(bool str)
        {
            if(str == true)
            {
                Console.WriteLine("Содержит");
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Не содержит");
                Console.WriteLine();
                Console.ReadKey();
            }
            
        }

        public static int ParseToInt(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат - '{0}'.", str);
                throw new FormatException("Невернвый формат");
                //не додумался как выкатить false вместо интового значения. 
            }
        }
    }
}
