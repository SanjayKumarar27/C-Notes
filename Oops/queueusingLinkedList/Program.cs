namespace queueusingLinkedList
{
    class q<T> {

        LinkedList<T> list = new LinkedList<T>();

        
        public void push(T item) {
            list.AddLast(item);
        }
        public T pop()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            T item = list.First.Value;
            list.RemoveFirst();
            return item;
           

        }
        public int size()
        {
            return list.Count;
        }

        public void show()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }


        }

    internal class Program
    {
        static void Main(string[] args)
        {
           //q<int> que=new q<int>();
           // que.push(1);
           // que.push(2);
           // que.push(3);
           // que.show();
            //Console.WriteLine(q);
            //Console.WriteLine("The poped element {0} ",que.pop());
            //Console.WriteLine(que.size());

            ////stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine("The Elements in the stack are:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //int size=stack.Count;
            //for (int i=0;i<size;i++)
            //{
            //    Console.WriteLine(stack.ElementAt(i));
            //}
            //Console.WriteLine("The poped element {0} ", stack.Pop());






            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine("The Elements in the queue are:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //for(int i=0;i<queue.Count;i++)
            //{
            //    Console.WriteLine(queue.ElementAt(i));
            //}
            //Console.WriteLine("The dequeued element {0} ", queue.Dequeue());
            

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "One");
            //dict.Add(2, "Two");
            //dict.Add(3, "Three");
            //Console.WriteLine("The Elements in the dictionary are:");
            //foreach (var item in dict)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            //}

            //for(int i=1;i<=dict.Count;i++)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", i, dict[i]);
            //}
            foreach(var item in dict.Keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item, dict[item]);
            }

        }
    }
}
