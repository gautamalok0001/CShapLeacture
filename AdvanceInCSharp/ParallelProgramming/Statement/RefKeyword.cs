namespace ParallelProgramming.Statement
{
    public class RefKeyword
    {
        public void RefIterator()
        {
            int[] xs = [10, 20, 30, 40];
            ref int found = ref FindFirst(xs, s => s == 30);
            found = 0;
            Console.WriteLine(string.Join(" ", xs));  // output: 10 20 0 40

            ref int FindFirst(int[] numbers, Func<int, bool> predicate)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (predicate(numbers[i]))
                    {
                        return ref numbers[i];
                    }
                }
                throw new InvalidOperationException("No element satisfies the given condition.");
            }
        }
    }
}
