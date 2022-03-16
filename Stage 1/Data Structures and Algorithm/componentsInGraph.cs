using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        n *= 2;
        int[] arr = new int[n];
        int[] size = new int[n];
        Intialize(arr, size, n);

        for (int i = 0; i < n/2; i++)
        {
            int[] ver = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            WeightedUnion(arr, size, ver[0], ver[1]);
        }
        DisplayConnected(size,n);
    }

    private static void DisplayConnected(int[] size, int n)
    {
        int min = int.MaxValue, max = int.MinValue;
        for(int i = 0; i < n; i++)
        {
            if (size[i] > 1)
            {
                if (size[i] < min) min = size[i];
                if (size[i] > max) max = size[i];
            }
        }
        Console.WriteLine(min+" "+max);
    }

    private static void WeightedUnion(int[] arr, int[] size, int a, int b)
    {
        int root_a = root(a, arr);
        int root_b = root(b, arr);
        if (arr[root_a] == arr[root_b]) return;
        else if (size[root_a] < size[root_b])
        {
            arr[root_a] = arr[root_b];
            size[root_b] += size[root_a];
            size[root_a] = 0;
        }
        else
        {
            arr[root_b] = arr[root_a];
            size[root_a] += size[root_b];
            size[root_b] = 0;
        }
    }

    private static int root(int a, int[] arr)
    {
        int i = a - 1;
        while (arr[i] != i)
        {
            i = arr[i];
        }
        return i;
    }

    private static void Intialize(int[] arr, int[] size, int n)
    {
        for (int i = 0; i < n; i++)
        {
            arr[i] = i;
            size[i] = 1;
        }
    }
}
