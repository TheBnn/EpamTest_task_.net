using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpamTest_task_.net.Tasks
{
    class TaskThree
    {
        public static void findWord(string str) { 
            //На мой взгляд самое оптимальное решение. 
            //Либо см ниже
            var result = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .GroupBy(x => x)
              .Where(x => x.Count() == 1)
              .Select(x => x.Key);

            foreach(var item in result) Console.Write(item + " ");

            Console.ReadKey();
        }

        /*
         * Console.WriteLine(string.Join(" ", str.Split(splitChars, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray()));
         */
    }
}
