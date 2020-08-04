using System;

namespace CustomQueue
{
    public class Queue
    {
        /// <summary>
        /// Represents a custom queue.
        /// </summary>
        private readonly QueueType queueType;
        private readonly Nodes nodes;
        private bool isLimited;
        private Node node;
        private int limit;
        private int limitCounter;

        public Queue(QueueType queueType)
        {
            this.queueType = queueType;
            this.nodes = new Nodes(queueType);
        }

        /// <summary>
        /// Sets max queue size. New nodes won't be added when the limit is exceeded.
        /// </summary>
        public void SetQueueLimit(int maxNodeQuantity)
        {
            this.limit = maxNodeQuantity;
            this.isLimited = true;
        }

        /// <summary>
        /// Returns true if all node type in queue are equal to the specified type.
        /// </summary>
        public bool NodeTypesAre(Type type)
        {
            return nodes.AllNodeTypesAre(type);
        }

        /// <summary>
        /// Add new node to queue.
        /// </summary>
        public Node Add(object data)
        {
            if(data == null || (IsLimited && limitCounter == limit))
                return null;
            
            var newNode = nodes.AddNode(data);
            limitCounter++;

            return newNode;
        }

        /// <summary>
        /// Removes the entire node data. Actual node is replaced by null.
        /// </summary>
        public void Remove(Node node)
        {
            this.nodes.RemoveNode(node);
            limitCounter--;
        }

        /// <summary>
        /// Removes data from node. Actual node remains the same.
        /// </summary>
        public void RemoveDataFromNode(Node node)
        {
            this.nodes.RemoveDataFromNode(node);
        }

        /// <summary>
        /// Returns queue with set current node as the first node.
        /// </summary>
        public Queue First()
        {
            this.node = nodes.GetFirstNode();
            return this;
        }

        /// <summary>
        /// Returns queue with set current node as the last node.
        /// </summary>
        public Queue Last()
        {
            this.node = nodes.GetLastNode();
            return this;
        }

        /// <summary>
        /// Set current node as the next node. Returns Queue instance.
        /// </summary>
        public Queue Next()
        {
            var currentNode = nodes.GetNode();

            if (queueType == QueueType.CircleFIFO || queueType == QueueType.CircleLIFO)
            {
                if (nodes.IsLastNode(currentNode))
                {
                    nodes.Reset();
                } 
            }

            this.node = currentNode;
            return this;
        }

        public void Clear()
        {
            this.nodes.RemoveNodes();
        }

        public Node Node => node;

        private int Limit => limit;

        private bool IsLimited => isLimited;
    }
}
