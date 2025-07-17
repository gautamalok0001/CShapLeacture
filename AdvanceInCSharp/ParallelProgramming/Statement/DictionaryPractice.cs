using System.Collections.Concurrent;

namespace ParallelProgramming.Statement
{
    public class DictionaryPractice
    {
        public void GenericDictionary()
        {
            Dictionary<int, Queue<int>> paymentMethods = new Dictionary<int, Queue<int>>();
            

            try
            {
                AddQueue(paymentMethods, 1, 100);
                AddQueue(paymentMethods, 1, 200);
                AddQueue(paymentMethods, 1, 300);
                AddQueue(paymentMethods, 2, 100);
                AddQueue(paymentMethods, 2, 800);
                AddQueue(paymentMethods, 3, 100);
                AddQueue(paymentMethods, 3, 600);
                RemoveValueFromQueue(paymentMethods, 1);
            }
            catch(Exception ex) 
            {

            }
        }

        private void RemoveValueFromQueue(Dictionary<int, Queue<int>> paymentMethods, int v)
        {
            if (paymentMethods.TryGetValue(v, out Queue<int>? queueValue) && queueValue?.Count > 0)
            {
                queueValue?.Dequeue();
            }
        }

        private void AddQueue(Dictionary<int, Queue<int>> paymentMethods, int v1, int v2)
        {
            if (!paymentMethods.ContainsKey(v1))
            {
                paymentMethods.Add(v1, new Queue<int>());
            }
            paymentMethods[v1].Enqueue(v2);
        }
        public void ConcurrentDictionary()
        {
            ConcurrentDictionary<int, Queue<int>> paymentMethods = new ConcurrentDictionary<int, Queue<int>>();
            AddQueueConcurrent(paymentMethods, 1, 100);
            AddQueueConcurrent(paymentMethods, 1, 200);
            AddQueueConcurrent(paymentMethods, 1, 300);
            AddQueueConcurrent(paymentMethods, 2, 100);
            AddQueueConcurrent(paymentMethods, 2, 800);
            AddQueueConcurrent(paymentMethods, 3, 100);
            AddQueueConcurrent(paymentMethods, 3, 600);
            RemoveValueFromQueueConcurrent(paymentMethods, 1);
        }
        private void RemoveValueFromQueueConcurrent(ConcurrentDictionary<int, Queue<int>> paymentMethods, int v)
        {
            if (paymentMethods.TryGetValue(v, out Queue<int>? queueValue) && queueValue?.Count > 0)
            {
                queueValue?.Dequeue();
            }
        }

        private void AddQueueConcurrent(ConcurrentDictionary<int, Queue<int>> paymentMethods, int v1, int v2)
        {
            if (!paymentMethods.ContainsKey(v1))
            {
                paymentMethods.TryAdd(v1, new Queue<int>());
            }
            paymentMethods[v1].Enqueue(v2);
        }
        public void CocurrentDictionary1()
        {
            var dictionary = new ConcurrentDictionary<int, string>();

            // Populate the dictionary with initial values
            for (int i = 0; i < 5; i++)
            {
                dictionary.TryAdd(i, $"Value {i}");
            }

            int taskCount = 5;
            Task[] tasks = new Task[taskCount];

            for (int i = 0; i < taskCount; i++)
            {
                int taskId = i;
                tasks[i] = Task.Run(() =>
                {
                    for (int j = 0; j < 5; j++)
                    {
                        int key = j;

                        // Simulate a delay
                        Thread.Sleep(new Random().Next(10, 100));

                        // Safe access using ConcurrentDictionary methods
                        dictionary.AddOrUpdate(
                            key,
                            $"Value {key} - Updated by Task {taskId}",
                            (k, oldValue) => oldValue + $" - Updated by Task {taskId}"
                        );
                    }
                });
            }

            Task.WaitAll(tasks);

            Console.WriteLine("Dictionary contents after safe updates:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
