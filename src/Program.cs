using System;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Queue<int>(QueueType.LIFO);

            Console.WriteLine("add nodes:");
            Console.WriteLine(1);
            var y = q.Add(1);
            Console.WriteLine(q.Add(2).Data);
            Console.WriteLine(q.Add(3).Data);
            Console.WriteLine(q.Add(4).Data);
            Console.WriteLine(q.Add(5).Data);
            Console.WriteLine(q.Add(6).Data);
            Console.WriteLine(7);
            var x = q.Add(7);
            
            Console.WriteLine(q.Add(8).Data);
            //q.Remove(x);
            q.Remove(y);

            Console.WriteLine("get nodes:");
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.ReadKey();

            Console.WriteLine("remove - press key");
            q.Clear();
            Console.WriteLine("q cleared");

            Console.WriteLine("after clear:");
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);

            Console.ReadKey();

            Console.WriteLine("add nodes:");
            Console.WriteLine(q.Add(1).Data);
            q.SetQueueLimit(2);
            Console.WriteLine(q.Add(2)?.Data);
            Console.WriteLine(q.Add(3)?.Data);
            

            Console.WriteLine("get nodes:");
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);
            Console.WriteLine(q.Next().Node?.Data);

            Console.ReadKey();
        }
    }
}
