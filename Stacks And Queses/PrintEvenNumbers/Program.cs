namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> nums = new Queue<int>(input);
            int numsLength = nums.Count();

            for (int i = 0; i < numsLength; i++)
            {
                if (nums.Peek() % 2 != 0)
                {
                    nums.Dequeue();
                }
                else
                {
                    int num = nums.Dequeue();
                    nums.Enqueue(num);
                }
            }
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}