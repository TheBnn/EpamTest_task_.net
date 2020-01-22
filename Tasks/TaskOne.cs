using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTest_task_.net
{
    class TaskOne
    {
        public static int[] SortArray(int[] arrayNums)
        {
            //https://github.com/TheBnn/MYCOmputerScience/tree/master/MYComputerScience/Sorts -> уже писал несколько. 
            //сортировка -> return Array.sort(arrayNums); 

            for (int i = 1; i < arrayNums.Length; i++)
            {
                int j;
                int buffer = arrayNums[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (arrayNums[j] < buffer)
                        break;

                    arrayNums[j + 1] = arrayNums[j];
                }
                arrayNums[j + 1] = buffer;
            }

            return arrayNums;
        }
    }
}
