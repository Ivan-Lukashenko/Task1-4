using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arrayLength = new int[n];
            List<int> receivedPath = new List<int>();

            for (int i = 0; i < n; i++)
            {
                arrayLength[i] = i + 1;
            }
            receivedPath.Add(arrayLength[0]);

            for (int i = m - 1; ; i += m - 1)
            {
                while (i >= n)
                {
                    i -= n;
                }
                if (receivedPath.Contains(arrayLength[i]))
                {
                    break;
                }
                receivedPath.Add(arrayLength[i]);
            }
            foreach (var part in receivedPath)
            {
                Console.WriteLine(part);
            }
        }
    }
}
