using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {   //task:  Write a program to simulate n nested loops from 1 to n.
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Loop(arr, 0);
            Console.ReadLine();
        }
        static void Loop(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (int element in arr) Console.Write("{0} ", element);
                Console.WriteLine();
            }
            else
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Loop(arr, index + 1);
                }
        }


    }
}
