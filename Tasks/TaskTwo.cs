using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTest_task_.net.Tasks
{
    class TaskTwo
    {
        public static bool FindStr(int[] array, int findNum)
        {
            Console.WriteLine($"{findNum} ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            //Пожалуй вставлю ссылку на мой гитхаб, ибо писал один из поисковых алгоритмов уже
            //https://github.com/TheBnn/MYCOmputerScience/tree/master/MYComputerScience/Search
            //Можно вроде как использовать Array.Find(array,point);

            foreach (int item in array)
            {
                if (item == findNum)
                    return true;
            }
            return false;
        }
    }
}