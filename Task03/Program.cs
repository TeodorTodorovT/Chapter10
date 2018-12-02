using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program to generate and print all combinations with duplicates of k elements from a set with n elements.
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Combinations(arr, 0, 1, n);
            Console.ReadLine();
        }
        static void Combinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("), ");
            }
            else
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    Combinations(arr, index + 1, i, end);
                }
        }
    }
}
