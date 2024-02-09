using System;

namespace Tasks2024_part2_;
class Tasks2024()
{
    public static void Main(string[] args)
    {
        Console.WriteLine(task1.solution(2, 6));
        Console.WriteLine(task2.solution(5));
        Console.WriteLine(task3.solution("ЭЩКЕРЕ"));
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(task4.solution(nums));
        Console.WriteLine(task5.solution(5));
        Console.WriteLine(task6.solution("боб"));
        int[] nums1 = { 1, 2, 3, 4 };
        int[] nums2 = {5, 6, 7 };
        int[] Fnums = task7.solution(nums1, nums2);
        for(int i = 0; i < Fnums.Length; i++)
        {
            Console.Write(Fnums[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine(task8.solution(12));
        Console.WriteLine(task9.solution("ЭЩКЕРЕ"));
        int[][] nums3 = new int[3][];
        for(int i = 0;i < nums3.Length;i++)
        {
            nums3[i] = new int[3];
        }

        for(int i = 0;i<nums3.Length ; i++) 
        {
            for(int j = 0;j < nums3[i].Length ; j++) 
            {
                nums3[i][j] = j + i;
            }
        }
        Console.WriteLine(task10.solution(nums3));








    }
}