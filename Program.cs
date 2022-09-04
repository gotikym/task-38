using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int[] massiv = new int[] { 1, 2, 3, 1, 1, 1, 2, 2, 4, 4, 7 };
        int[] massiv2 = new int[] { 1, 1, 1 };
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        list1.AddRange(massiv);

        list1.AddRange(massiv2);

        CheckRepetition(list1, list2);

        for (int i = 0; i < list2.Count; i++)
        {
            Console.WriteLine(list2[i]);
        }
    }

    static void CheckRepetition(List<int> list1, List<int> list2)
    {
        for (int i = 0; i < list1.Count; i++)
        {
            if (list2.Contains(list1[i]) == false)
            {
                list2.Add(list1[i]);
            }
        }
    }
}