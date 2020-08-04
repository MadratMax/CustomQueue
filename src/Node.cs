using System;

namespace CustomQueue
{
    public class Node
    {
        private readonly object data;
        private int number;

        public Node(object data, int number)
        {
            this.data = data;
            this.number = number;
        }

        public int NumberInQueue => number;

        public int Id => this.data.GetHashCode();

        public Type DataType => this.data?.GetType();

        public object Data => data;
    }
}
