namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (people.Count != 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}