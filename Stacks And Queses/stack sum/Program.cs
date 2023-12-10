namespace stack_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numStack = new Stack<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (int num in input)
                numStack.Push(num);
            
            string[] commandInfo = Console.ReadLine().Split();
            while (commandInfo[0].ToLower() != "end")
            {
                switch (commandInfo[0].ToLower())
                {
                    case "add":
                        numStack.Push(int.Parse(commandInfo[1]));
                        numStack.Push(int.Parse(commandInfo[2]));
                        break;

                    case "remove":
                        if (int.Parse(commandInfo[1]) <= numStack.Count())
                            for (int i = 0; i < int.Parse(commandInfo[1]); i++)
                            {
                                numStack.Pop();
                            }
                        break;

                    default:
                        break;
                }
                commandInfo = Console.ReadLine().Split();
            }

            Console.WriteLine($"Sum: {numStack.Sum()}");
        }
    }
}