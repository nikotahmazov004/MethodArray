﻿using System;

namespace ArrayinENKicikElementiMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 14, 30, 8, 20, 39, 4 };
            Console.WriteLine(Min(arr));
        }
        static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
