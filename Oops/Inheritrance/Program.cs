using System.Runtime.CompilerServices;

namespace Inheritrance
{
    //-----------------------------------------------------------------------------------------------------------------------------
    //    //overloading 
    //class Addition
    //{ 
    //    internal void Add(int a,int b)
    //    {
    //        Console.WriteLine($"int a is {a} int b is {b} , => {a+b}");
    //    }

    //    internal void Add(int a, int b,int c)
    //    {
    //        Console.WriteLine($"int a is {a} int b is {b} int c is {c} , => {a + b+c}");
    //    }
    //    internal void Add(double a, double b)
    //    {
    //        Console.WriteLine($"double a is {a} double b is {b} , => {a + b}");
    //    }
    //    internal void Add(double a, int b)
    //    {
    //        Console.WriteLine($"douible a is {a} int b is {b} , => {a + b}");
    //    }
    //}//-----------------------------------------------------------------------------------------------------------------------------
    //inheritace with overlaoding 
    //class parent
    //{
    //internal void Add(int a)
    //{
    //    Console.WriteLine(a);
    //}
    //}
    //class child : parent
    //{
    //internal void Add(int a, int b)
    //{
    //    Console.WriteLine($"{a} {b}, +> {a + b}");
    //}

    //}
    //-----------------------------------------------------------------------------------------------------------------------------

    //Overriding with inheritance
    //virtual key word indicates the method should be overridden  // here we have an option not to be overriden also //has body 
    //abstract key word inicates the method must be overridden // here we have no option 
    // has no body in parent have to be implemented in the child method
    //abstract method should be in a abstract classs
    //class parent
    //{
    //    public virtual void Disp()
    //    {
    //        Console.WriteLine("Parent");
    //    }
    //}
    abstract class parent // abstrct class can have both abstract and concret method 
                          //abstract method should be in a abstract classs
                          // abstract class cannot be instantialed  // cannot create a object
    {
        public abstract void Disp();


    }
    class child : parent
   {
        //public new void Disp()// new used to hidding here parent refrence and child object will print the parent
        //{
        //    Console.WriteLine("Child");
        //}
        public override void Disp()// when we override a function the parent refrence of the child object will
                                   // check with the parent if the parent is having the virtual key word it will
                                   // check with the child object for the
                                   // implementationm if the implementaion is done in the child object the it
                                   // goes with it else follow the parent implementaion
                                   //
        {
            Console.WriteLine("Child");
        }
    }

    internal class Program

    {
        //int a = 10;
        ////non static varibale can only be called in non static method 
        ////if we want to call non static variable in a static context we have to create a object in stattic context
        //static int s = 100;//maintain copy for the class not for objects
        ////static variable can be accesed from static and non static context

        //static Program()
        //{
        //    Console.WriteLine("Static Cons {0}",new Program().a);
        //}
        
        //int a = 10;//instantace variable,member,feild,state
        //Program() {// example of the constructor
        //    Console.WriteLine("Hello");
        //}
        //void Disp()
        //{
        //    Console.WriteLine("disp function ,{0}",a);
        //}
        //Program()
        //{
        //    Console.WriteLine("cons");
        //}

        //void increment()
        //{
        //    s++;
        //}
        //void show()
        //{
        //    Console.WriteLine(s);
        //}
        static void Main(string[] args)
        {
            //Program p = new Program();
            //Console.WriteLine("Hello, World!");
            //Constructor
            //constructor are special kind of method used to initailize the member variables of the classs
            //diff method and constructor
            // 1.it has same name as th class
            // 2.it doesnt have anyt return type
            // 3.it is automaticaly called when the object is created

            //note: if we dont create any constructor of a class then compiler will generate default constructor 


            //Program P is only a refrence to the object
            // new Program() is the real object
            // so if we write new Program() the constructor and any method present in the class can be called using the new Program()

            //new Program().Disp();
            //new Program().Disp();

            //Program P=new Program(); //is used to create new refrence of the object once ans use multiple times in  program

            //P.Disp();
            //P.Disp();
            //1.Abstarction
            //2.Encapsulation
            //3.Polymorphism 
            // A.Static -> Overloading 2 methods same name (having diff Signature

            // 1.number of parameter
            // void Add(int a,int b)
            // void Add(int a,int b,int c),

            //2. type of paramenter
            // void Add(int a,int b)
            // void Add(double a,Double b),

            // 3.diffrendt order of the parameter
            // void Add(int a,Double b)
            // void Add(Double a,int b)

            // B.Dynamic -> Overriding 


            //Program P =new Program();
            //Console.WriteLine(s);
            //s = 200;
            //P.increment();
            //Program p1=new Program();
            //p1.a= 20;
            //P.show();
            //p1.show();
            //new otherprogram();
            //Console.WriteLine(a);
            //Console.Write("Heloo");


            //Addition a = new Addition();
            //a.Add(1, 2);
            //a.Add(2, 3, 4);
            //a.Add(3.4, 1);
            //a.Add(1.3, 3.7);

            //parent a=new parent();
            //a.Add(1);
            //child a2 = new child();
            //a2.Add(1);
            //a2.Add(2, 4);
            //parent p1=new parent();//we cannot create instantace of the absteract class
            //p1.Disp();

            child c=new child();
            c.Disp();

            parent p=new child();//parent can hold child object
            p.Disp();

            //child c3=new parent(); child cannot hold parent object

        }
    }
    //internal class otherprogram
    //{
    //    static int a=0;
    //    static otherprogram()
    //    {
    //        a = 100;
    //        Console.Write("Other program");
    //    }
    //}
}
