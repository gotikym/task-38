using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int[] massiv1 = new int[] { 1, 2, 3, 1, 1, 1, 2, 2, 4, 4, 7 };
        int[] massiv2 = new int[] { 1, 1, 1 };
        List<int> list1 = new List<int>();

        OperateMassiveItem(list1, massiv1);
        
        OperateMassiveItem(list1, massiv2);

        for (int i = 0; i < list1.Count; i++)
        {
            Console.WriteLine(list1[i]);
        }
    }

    static void OperateMassiveItem(List<int> list1, int[] massiv)
    {
        for (int i = 0; i < massiv.Length; i++)
        {
            if (list1.Contains(massiv[i]) == false)
            {
                list1.Add(massiv[i]);
            }
        }
    }
}
