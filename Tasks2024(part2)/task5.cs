using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2024_part2_
{
    internal class task5
    {
        public static int solution(int x)
        {
            int F = 1;
            for (int i = 1; i <= x; i++)
            {
                F *= i;
            }
            return F;
        }
    }
}
