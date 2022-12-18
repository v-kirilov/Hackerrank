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



class Solution
{
    public static void Main(string[] args)
    {
        //int n = int.Parse(Console.ReadLine());
        List<int> a = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        
        for ( int i = 0; i < a.Count; i++)
        {
            bool isRepeated = false;
            for (int j = i + 1; j < a.Count; j++)
            {
                if (a[i] == a[j])
                {
                    isRepeated = true;
                    a.RemoveAt(j);
                    j--;
                }
                
            }
            if (isRepeated)
            {
                a.RemoveAt(i);
                i--;
            }
            if (a.Count==1)
            {
                Console.WriteLine(a[0]);
                return;
            }
        }
       
    }
}
