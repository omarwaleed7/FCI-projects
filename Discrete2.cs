﻿using System;

namespace SECTION
{
    class FCI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input numbers from");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("To");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfect numbers between this numbers is");
            for(x<=y;x++)
            {
                int sum = 0;
                for(int i =1;i<x;i++)
                {
                    if (x%i == 0)
                    {
                        sum += i;
                    }
                }
                if(x==sum)
                {
                    Console.WriteLine(X);
                }
            }
            Console.ReadLine();
        }
    }
}
