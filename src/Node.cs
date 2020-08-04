using System;

namespace CustomQueue
{
    public class Node <T>
    {
        private readonly T data;
        private int number;
        private object p;
        private int nodeNumber;

        public Node(T data, int number)
        {
            this.data = data;
            this.number = number;
        }

        public Node(object p, int nodeNumber)
        {
            this.p = p;
            this.nodeNumber = nodeNumber;
        }

        public int NumberInQueue => number;

        public int Id => this.data.GetHashCode();

        public Type DataType => this.data?.GetType();

        public object Data => data;
    }
}
