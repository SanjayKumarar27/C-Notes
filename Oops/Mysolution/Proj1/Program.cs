
using ClassLibrary1;

namespace Proj1
{
    class Demo {
        //functions associated with class and objecgt is called method
        //the default acess of the class is internal with heart
        //the default acess of method in a class is private 
        //heart is internal
        /*
                In .NET (C#), there are five main access modifiers:

                public
                Accessible from anywhere.also between assebly  i.e between projects

                private
                Accessible only within the same class.

                protected
                Accessible within the same class and by derived classes. symbol star, same or diffrent assembly

                internal
                Accessible within the same assembly (project). sybmol heart, only with in ans assenmbly

                protected internal = protected + internal
                Accessible within the same assembly or from derived classes.

                private protected (C# 7.2 and later)
                Accessible within the same class or derived classes in the same assembly.



                Access Specifiers/Modifiers

                1. public -> Accessible everywhere
                2. private -> Accessible within class
                3. protected -> Accessible within same class and derived class in same or diff assembly
                4. internal -> Accessible within Assembly(exe/dll)
                5. protected internal -> protected or internal
                6. private protected -> Accessible within same assembly's inherited class(can't be accessed in other assembly)

                */

    //    protected void display()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}

    internal class Program:Class1
    {
        static void Main(string[] args)
        {
            //Demo D = new Demo();
            //D.display();

            //Program p=new Program();
            //p.display();
            //byte age;
            //int sal;
            //Console.WriteLine("Enter the Age");
            //byte.TryParse(Console.ReadLine(), out age);

            //Console.WriteLine("Enter the Salary ");
            //int.TryParse(Console.ReadLine(), out sal);

            //if(age <25 ^  sal > 25000)
            //{
            //    Console.WriteLine("A");

            //}else if (age <35 ^ sal > 50000)
            //{
            //    Console.WriteLine("B");
            //}
            //else
            //{
            //    Console.WriteLine("C");
            //}
            ///calling libray int ht project


            //Class1 c = new Class1();
            //c.show1();

            //Program p= new Program();
            //p.show1();
            //p.show3();
            //p.show7(); // by deriving the class through inheeritence we will be acesssible by protected ,public ,protected internal

            //C#







        }
    }
}