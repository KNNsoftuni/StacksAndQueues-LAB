﻿namespace HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> children = new Queue<string>(input);

            while (children.Count > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        Console.WriteLine($"Removed {children.Dequeue()}");
                    }
                    else
                    {
                        children.Enqueue(children.Dequeue());
                    }
                }
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }

    }
}