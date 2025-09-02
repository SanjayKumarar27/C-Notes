using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] a1 = new int[5] { 1,2,3,4,5};
            //a1=new int[10];//we are assigning a new array to a1 of new memory location

            //Console.WriteLine("Hello, World!");

            //LINQ : Linguage Integrated Query
            //var res=from i in a1
            //         //where i%2==0
            //         orderby i descending
            //        select i;
            //foreach(var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //==take 5 names and store them and write LINQ to print names starting with A
            /*
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Enter name:");
                names[i] = Console.ReadLine();
            }

            var sortedNames = from n in names
                              //where n[0]=='A'|| n[0]=='a'
                              //where n.StartsWith("A",StringComparison.OrdinalIgnoreCase)
                              //where n.ToLower().StartsWith("a")
                              orderby n
                              select n;

            Console.WriteLine("Names starting with A are:");

            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }*/

            //===============================================================================
           

            //===============================================================================
            //Collections in C#
            //3 types of collections
            //1.Object based collections
            // objects are the parent of all data types in C# so it can store any type of data
            //Arraylist,Hashtable,Stack,Queue
            //2.Generic collections
            //3.Specilised collections



            //collection releated interfaces
            // IEnumerable is the parent interface of all collection interfaces like ICollection
            // ICollection is parent of IList,IDictionary

            //Comparison interfaces
            //IComparable
            //IEqualityComparer

            //Enumerable interfaces
            //IEnumerator is parent of IDictonaryEnumerator

            //1.ArrayList

            //ArrayList al = new ArrayList();
            //int i;
            //i=al.Add("KPMG");
            //Console.WriteLine(i);
            //i=al.Add(100);// Add return int which is the index value
            //Console.WriteLine(i);

            //i = al.Add(12.33);
            //Console.WriteLine(i);

            //al.Insert(1, 'A');//Insert(index,value) to insert one value at a time
            //al.InsertRange(2, new object[] { "Hello", 123, 45.67 }); // insert multiple values at a time
            //al.Remove(10);//Remove(value)
            ////if element is not found it run without error
            //al.RemoveAt(3);//RemoveAt(index)
            //Console.WriteLine(al.Capacity);

            //al.

            //foreach (object a in al)
            //{
            //    Console.WriteLine(a);
            //}

            //Console.WriteLine(al[2]);

            //object o1 = al[0];
            //Console.WriteLine(o1);

            //Stack
            //implementaion of LIFO in stack
            //Stack st = new Stack();
            //st.Push("Item 1");
            //st.Push("Item 2");
            //st.Push("Item 3");
            //st.Push("Item 4");
            //int size= st.Count; 
            //for (int i=0;i<size;i++)
            //{
            //    Console.WriteLine("The Poped element {0} ",st.Pop());
            //}
            //Console.WriteLine("After pop stack size is {0}",st.Count);


            //queue
            //implementation of FIFO in queue
            //Queue q = new Queue();
            //q.Enqueue(10);
            //q.Enqueue("Hello");
            //q.Enqueue(12.33);
            //q.Enqueue('A');

            //int qsize = q.Count;
            //for (int i = 0; i < qsize; i++)
            //{
            //    Console.WriteLine(q.Dequeue());
            //}
            //Hashtable
            //Hashtable ht = new Hashtable();//is based on hash of the key

            //ht.Add("KPMG", 1);
            //ht.Add(2, "Hello");
            //ht.Add(1, 12.33);

            //same key cannot be added again will throw exception
            //


            //foreach(var k in ht.Keys)
            //{
            //    Console.WriteLine($"Key: {k}, Value: {ht[k]}");
            //}


            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key +" "+item.Value);
            //}

            //Console.WriteLine(ht[1]);//access value using key
            ///*
            //SortedList

            //SortedList sl = new SortedList();
            //sl.Add(3, "Three");
            //sl.Add(1, "One");
            //sl.Add(4, "Four");
            ////sl.Add(1, "One");doesnot allow duplicate keys

            //sl.Add(2, "Two");

            //foreach (DictionaryEntry item in sl)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            //for (int i = 0; i < sl.Count; i++)
            //{
            //    Console.WriteLine($"Key: {sl.GetKey(i)}, Value: {sl.GetByIndex(i)}");
            //}

            //Console.WriteLine(sl.GetByIndex(2));//access value using index   2nd index value give thrid elelment
            //Console.WriteLine(sl[2]);//access value using key 
            //*/




            //2.Generic collections
            //what is Generics?
            //Generics is a feature of C# and other programming languages that allows you
            //to define classes, interfaces, and methods with a placeholder for the data type.
            //This enables you to create reusable and type-safe code components that can work with
            //different data types without sacrificing performance or safety.
            //Can we pass parameter to class?
            //Yes we can pass parameter to class using generics using <>
            //data type ,
            //what are we 
            String is class

            

        //Generic class





    }
    }
}
