using System.ComponentModel;

namespace Callbyvalue
{
    internal class Program

    {
        //Delegates
        //Type of Delegates
        //1.Single cast delegates
        //it will call one method at a time
        //2.Multi cast delegates
        //it will call more than one method at a time


        //we can make a delegate 


        //callby value
        //void swap(int a,int b)//value type parameter
        //{
        //    Console.WriteLine($" before swaping a= {a} b={b}");
        //    int temp = a;
        //    a=b;
        //    b=temp;
        //    Console.WriteLine($" before swaping a= {a} b={b}");
        //}

        //call by reffrence
        //void swap(ref int a,ref int b)//refrence type parameter
        //{
        //    Console.WriteLine($" before swaping a= {a} b={b}");
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($" before swaping a= {a} b={b}");
        //}

        //outpur type parameter
        //Normal Add
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //with output parameter we have to have return type as void 
        //static void Add(int a, int b,out int sum)
        //{
        //  sum=a + b;

        //}
        //1.Single cast delegates example
        /*
    delegate void MyDel(int i);//same signature as that of the method and same return type of the method
    static void Disp(int i)
    {
          Console.WriteLine("Hello {0}",i);
    }
    static void show()
    {
        Console.WriteLine("Hello ");
    }
        */

        //2.Multi cast delegates example
        //it can have return type as int,string,void but the returned value will be of the last method

        delegate void myDel();
        static void Disp()
        {
            Console.WriteLine("Hello Disp");
        }
        void show()
        {
            Console.WriteLine("Hello Show");
        }
        static void display(myDel d)
        {
            d();
        }
        static void Main(string[] args)
        {

            //MyDel my = new MyDel(Disp);//or
            //MyDel my = Disp;
            ////my();//or
            //my.Invoke(8);
            //Disp();

            Program p = new Program();
            myDel my = p.show;
            my += Disp;
            //my();

            display(my);
            my -= p.show;
                
            display(my);
            //the parmaeter and return type of the method should be same as that of the delegate
            //delgate must have same signature as that of the method and same return type of the method

            //Console.WriteLine("Hello, World!");
            // if non static we have to write program p=new progra() and p.swap(x,y)
            //Program p = new Program();
            //int x = 10, y = 20;
            //Console.WriteLine($" before swaping x= {x} y={y}");
            //p.swap(ref x,ref y);
            //Console.WriteLine($" before swaping x= {x} y={y}");


            //int x = 10, y = 20;
            ////int res=Add(x, y);
            //int res;
            //Add(x,y,out res);
            //Console.WriteLine(res);

            //int a = 10;
            //ref int b = ref a;





        }
    }
}
