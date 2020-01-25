using System;
using System.Collections.Generic;

namespace EpamTest_task_.net.Tasks
{
    class TaskFive
    {
        private static bool IsBegin(char c)
        {
            return c == '(' || c == '{' || c == '[';
        }

        private static bool IsTrueBraket(char beg, char end)
        {
            return (beg == '(' && end == ')') || (beg == '{' && end == '}') || (beg == '[' && end == ']');
        }

        //Не уверен но вроде работает )))

        public static void ChekerStr()
        {
            string s;
            s = Console.ReadLine();
            List<int> braket_begins = new List<int>();
            braket_begins.Capacity = s.Length;
            bool good = true;
            for(int i = 0; good && i < s.Length; ++i)
            {
                if (IsBegin(s[i]))
                {
                    braket_begins.Add(i);
                }
                else
                {
                    if (braket_begins.Count != 0 && IsTrueBraket(s[braket_begins[braket_begins.Count - 1]], s[i]))
                    {
                        braket_begins.RemoveAt(braket_begins.Count - 1);
                    }
                    else
                    {
                        good = false;
                    }
                }
            }
            good = good && (braket_begins.Count  == 0);
            Console.Write((good ? "Да" : "Нет"));

        }
    }
}
