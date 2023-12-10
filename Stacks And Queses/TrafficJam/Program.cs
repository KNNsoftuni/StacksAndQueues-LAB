﻿namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cars = int.Parse(Console.ReadLine());
            int n = 0;
            Queue<string> traffic = new Queue<string>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < cars; i++)
                    {
                        if (traffic.Count == 0)
                        {
                            break;
                        }

                        string car = traffic.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        n++;
                    }
                }
                else
                {
                    traffic.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{n} cars passed the crossroads.");
        }
    }
}