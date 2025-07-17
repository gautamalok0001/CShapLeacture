namespace ParallelProgramming.DataParallelism
{
    public class ParallelFor
    {
        public void IterationOfInteger()
        {
            var rnd = new Random();
            int breakIndex = rnd.Next(1, 11);

            Console.WriteLine($"Will call Break at iteration {breakIndex}\n");

            var result = Parallel.For(1, 101, (i, state) =>
            {
                Console.WriteLine($"Beginning iteration {i}");
                int delay;
                lock (rnd)
                    delay = rnd.Next(1, 1001);
                Thread.Sleep(delay);

                if (state.ShouldExitCurrentIteration)
                {
                    if (state.LowestBreakIteration < i)
                        return;
                }

                if (i == breakIndex)
                {
                    Console.WriteLine($"Break in iteration {i}");
                    state.Break();
                }

                Console.WriteLine($"Completed iteration {i}");
            });

            if (result.LowestBreakIteration.HasValue)
                Console.WriteLine($"\nLowest Break Iteration: {result.LowestBreakIteration}");
            else
                Console.WriteLine($"\nNo lowest break iteration.");

        }
    }
}
