using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpamTest_task_.net.Tasks
{
    class TaskFour
    {
        //Так
        public static int LinealFactorial(int x)
        {
            int res = 1;
            for (int i = x; i > 1; i--)
                res *= i;
            return res;
        }
        //Можно так 
        public static int RecursionFactorial(int x)
        {
            return (x == 0) ? 1 : x * RecursionFactorial(x - 1); ;
        }
        //Ну или вот так вот 

        public static int TypeThreeFactorial(int x)
        {
            return Enumerable.Range(1, x).Aggregate((p, i) => p * i);
        }
    }
}
