namespace Stack_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int count = stack.Count;
            bool exists = stack.Contains(2);
            int[] array = stack.ToArray();
            stack.Clear();
            stack.TrimExcess();
        }
    }
}