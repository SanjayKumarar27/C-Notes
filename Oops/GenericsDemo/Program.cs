namespace GenericsDemo
{
    //2.Generic collections
    //what is Generics?
    //Generics is a feature of C# and other programming languages that allows you
    //to define classes, interfaces, and methods with a placeholder for the data type.
    //This enables you to create reusable and type-safe code components that can work with
    //different data types without sacrificing performance or safety.
    //Can we pass parameter to class?
    //Yes we can pass parameter to class using generics using <>

    //Method Overloading
    //class Demo {
    //    public void Show(string x) {
    //            Console.WriteLine("Demo String {0}",x);
    //    }
    //    public void Show(int i)
    //    {
    //            Console.WriteLine("Demo Insteger {0} ", i);
    //    }

    //}
    //Generic Class
    //class Demo<D>
    //{
    //    public void Show(D x) 
    //    {
    //        if( x is int[])
    //        {
    //            int[] arr = x as int[];
    //            foreach(var item in arr)
    //            {
    //                Console.WriteLine("Array Element: {0}", item);
    //            }

    //        }
    //        else
    //            Console.WriteLine("Demo Generic {0}", x);
    //    }

    //public void Show(int i)
    //{
    //    Console.WriteLine("Demo Insteger {0} ", i);
    //}
    //public void Show(string s)
    //{
    //    Console.WriteLine("Demo String {0}", s);
    //}
    //}


    //Generic Method
    //class Demo
    //{
    //    public void Show<A,B>(A x,B  y)
    //    {
    //        Console.WriteLine("Demo Generic {0} {1}", x, y);
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo<int> d = new Demo<int>();
            //d.Show(100,200);
            //Demo<string> d1 = new Demo<string>();
            //d1.Show("Hello","World");
            //Demo<float> d2 = new Demo<float>();
            //d2.Show(12.33f,12.4f);
            //Demo<double> d3 = new Demo<double>();
            //d3.Show(12.333, 12.4f);
            //Console.WriteLine("Hello, World!");


            //Demo<int[]> d = new Demo<int[]>();
            //d.Show(new int[] { 10, 20, 30 });


            //generic Method

            //Demo d = new Demo();
            //d.Show("string", 100);
            //d.Show(12.33f, 100);
            //d.Show('A', 100);

            //when to use generics method and generic class?
            //when we want to use multiple data type in single method then we can use generics method
            //when we want to use multiple data type in single class then we can use generics class

            //Generic Collections make the collections strongly typed collection and type safe
            //strongly typed collections 

            //Generic Collections Releated interfaces

            //Generic Collections interfaces
            //IEnumerable<T> parent of 
            //ICollection<T> parent of
            //IList<T> and IDictionary<TKey,Tvalue>


            //Generic comparison interfaces
            //IComparer<T> 
            //IComparable<T>
            //IEqulityComparer<T>


            //Generic enumator interfaces
            //IEnumerator<T>

            List<int> list = new List<int>();//gotr from Array List implemented by IList interface which
                                             //is implemented by 
                                             //ICollection which is implemented by IEnumerable
            //list.GetEnumerator();
            //list.Add(10);
            //list.Add(30);
            //list.Add(20);
            //Console.WriteLine("List Count: {0}", list.Count);
            //list.Sort();
            //list.Reverse();
            //foreach (int item in list)
            //{
            //    Console.WriteLine("List Item: {0}", item);
            //}
            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //int found = list.BinarySearch(x);

            //if (found >0)
            //    Console.WriteLine("Value: {0}", x);
            //else
            //    Console.WriteLine("Invalid Input");










        }

    }
}
