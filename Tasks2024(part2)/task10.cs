using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2024_part2_
{
    internal class task10
    {
        public static int solution(int[][] x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for(int j = 0; j < x[i].Length; j++)
                {
                    count += x[i][j];
                }
            }
            return count;
        }
    }
}
