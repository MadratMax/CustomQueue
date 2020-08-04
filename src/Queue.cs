using System;
using System.Collections.Generic;
using System.Text;

namespace CustomQueue
{
    class Queue
    {
        private readonly bool isLimited;
        private readonly Node node;
        private int limit = 1;

        public Queue(object firstNode = null, bool isLimited = false)
        {
            if (firstNode != null)
                this.node = new Node(firstNode);

            this.isLimited = isLimited;
        }

        public void SetQueueLimit(int maxNodeQuantity)
        {
            if(!IsLimited)
                throw new ArgumentException("This queue is created with no limit of the number of nodes");

            this.limit = maxNodeQuantity;
        }

        public void Add(object data)
        {
            throw new NotImplementedException();
        }

        public void Remove(object data)
        {
            throw new NotImplementedException();
        }

        public object GetNext()
        {
            throw new NotImplementedException();
        }

        private int Limit => limit;

        private bool IsLimited => isLimited;

        private Node Node => node;
    }
}
