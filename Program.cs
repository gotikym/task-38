using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int[] massiv1 = new int[] { 1, 2, 3, 1, 1, 1, 2, 2, 4, 4, 7 };
        int[] massiv2 = new int[] { 1, 1, 1 };
        List<int> list = new List<int>();

        AddWithoutRepititions(list, massiv1);
        
        AddWithoutRepititions(list, massiv2);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }

    static void AddWithoutRepititions(List<int> list, int[] massiv)
    {
        for (int i = 0; i < massiv.Length; i++)
        {
            if (list.Contains(massiv[i]) == false)
            {
                list.Add(massiv[i]);
            }
        }
    }
}
