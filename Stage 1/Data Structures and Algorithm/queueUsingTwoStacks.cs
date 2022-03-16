using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {
    static Stack<int> firstStack = new Stack<int>();
    static Stack<int> secondStack = new Stack<int>();

    public static int front()
    {
        if (secondStack.Count == 0)
        {
            while (firstStack.Count != 0)
            {
                secondStack.Push(firstStack.First());
                firstStack.Pop();
            }
        }

        return secondStack.First();
    }

    static void Main(String[] args)
    {
        var queryIteration = Convert.ToInt32(Console.ReadLine());


        bool queryFrontStack = false;

        for (int i = 0; i < queryIteration; i++)
        {
            var queryString = Console.ReadLine().Split(' ');
            int queryType = Convert.ToInt32(queryString[0]);
            switch (queryType)
            {
                case 1:
                    firstStack.Push(Convert.ToInt32(queryString[1]));
                    break;
                case 2:
                    front();
                    secondStack.Pop();
                    break;
                case 3:
                    Console.WriteLine(front());
                    break;
            }
        }
    }
}
