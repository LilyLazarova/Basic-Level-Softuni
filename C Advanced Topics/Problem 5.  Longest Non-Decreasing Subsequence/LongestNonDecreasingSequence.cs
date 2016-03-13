using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestNonDecreasingSequence
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a sequence of numbers separated by space or comma:");
        string input = Console.ReadLine();
        string[] separatedInput = input.Split(new char[] {' ',',',';','/'},StringSplitOptions.RemoveEmptyEntries);
        int[] nums = Array.ConvertAll(separatedInput, int.Parse);

        FindLongestNondecreasingSequence(nums);
    }

    public static void FindLongestNondecreasingSequence(int[] nums)
    {
        int[] size = new int[nums.Length];
        string[] sequence = new string[nums.Length];
        int maxLength = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            size[i] = 1;
            sequence[i] = nums[i] + " ";
        }

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] >= nums[j] && size[i] < size[j] + 1)
                {
                    size[i] = size[j] + 1;
                    sequence[i] = sequence[j] + nums[i] + " ";

                }
                if (maxLength < size[i])
                {
                    maxLength = size[i];
                }
            }
        }
        for (int i = 1; i < nums.Length; i++)
        {
            if (maxLength == size[i])
            {
                Console.Write(sequence[i] + " ");
                break;
            }


        }
    }
}
