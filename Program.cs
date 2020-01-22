
﻿using EpamTest_task_.net.Tasks;
using System;

namespace EpamTest_task_.net
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task One;
            //Helper.Print_Format( TaskOne.SortArray( Helper.GetNumArray(5) ) );

            //Task Two;
            Helper.Print_Format( TaskTwo.FindStr( Helper.GetNumArray(10), Helper.ParseToInt(Console.ReadLine()) ) );
        }
    }
}
