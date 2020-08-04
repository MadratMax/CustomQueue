using System;

namespace CustomQueue
{
    class Node
    {
        private readonly object data;

        public Node(object data)
        {
            if(data == null)
                throw new ArgumentNullException(nameof(data));

            this.data = data;
        }

        public int Id => this.data.GetHashCode();

        public Type DataType => this.data.GetType();
    }
}
