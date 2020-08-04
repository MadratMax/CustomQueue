# CustomQueue
Queue with customization features

Create custom queue using one of four modes:
- FIFO - first added item will be pushed first.
- LIFO - last added item will be pushed first.
- CircleFIFO - like FIFO with loop.
- CircleLIFO - like LIFO with loop.

Queue features:
- Node<T> Add(T data); - add new node type of T.
- void SetQueueLimit(int maxNodeQuantity); - set max number of possible nodes within queue.
- bool NodeTypesAre(Type type); - check that entire nodes belong to one type.
- void Remove(Node<T> node); - removes specified node.
- RemoveDataFromNode(Node<T> node); - removes data from each node.
- Queue<T> Next(); - sets next node and returns queue instance.
- Node<T> Node; => node - get current node.
- void Clear(); - remove all nodes
- int Limit => limit; - get max node quantity limit.
