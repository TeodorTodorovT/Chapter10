using System;

namespace Task04
{
    class Program
    {
        static string[] wordsArr;
        static void Main(string[] args)
        {   //task: You are given a set of strings. Write a recursive program, which generates all subsets, consisting exactly k strings chosen among the elements of this set
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            wordsArr = new string[length];
            Console.WriteLine();
            for (int i = 0; i < wordsArr.Length; i++)
            {
                Console.Write("Enter {0} word: ", i + 1);
                wordsArr[i] = Console.ReadLine();
            }
            Console.Write("\nEnter K: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine();
            FindSubsets(arr, 0, 0, length);
            Console.ReadLine();
        }
        static void FindSubsets(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}", wordsArr[arr[i]]);
                    if (i != arr.Length - 1) Console.Write(" ");
                }
                Console.Write("), ");
            }
            else
                for (int i = start; i < end; i++)
                {
                    arr[index] = i;
                    FindSubsets(arr, index + 1, i + 1, end);
                }
        }
    }
}
