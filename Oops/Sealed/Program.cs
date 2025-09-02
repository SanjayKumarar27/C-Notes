namespace Sealed
{
    //sealed class show //parent class is also know as base class,parent
    //                  //Child clas is also know as derived ,Sub,
    //{

    //}
    // class myclass : show { //sealed class cannot be inherited it give error
    //}

    //NOTES:
    //class Abc { }
    // in C# and java every class is by default inherited by class called Obejct class

    //====================================================================================
    //Constructor Overloading /inheritence

    //

    /*
    class Parent
    {
        //public Parent()
        //{
        //    Console.WriteLine("Parent constructor");

        //}
        public Parent(int i)
        {
            Console.WriteLine("Parent Parametreised constructor {0}",i);

        }
        //~Parent()
        //{
        //    Console.WriteLine("P des");
        //}
        //
        //how garbage collecter decides to remove space is by checking stack space and the heap space if the heap space object is
        //not reffrenced by the stack space then the object is destrocyd,
    }
    class Child : Parent
    {
        //public Child():base(1)
        //// with this the OUTPUT is 
        ////Parent Parametreised constructor 11
        ////       child Parametreised constructor 11
        //{
        //    Console.WriteLine("Child constructor");

        //}
        //If we have atleast one constuctor in the parent we have to create all the other like parameterrisd constructor else
        //it willl flag an error 
        //note: if we dont create any constructor of a class then compiler will generate default constructor
        // this only works if we donot have  construtor in both parent and child

        //public Child(int i):base(i) 
        //{
        //    Console.WriteLine("child Parametreised constructor {0}", i);

        //}
        //~Child(){
        //    Console.WriteLine("C des");
        //}

    }
    */
    /*

    class Demo
    {
        // private int a;
        //// we can use properties to read and write private memebers
        //public int A // this is properties 
        //{
        //    //get { return a; }  read

        //    //set { a = value; } write
        //}


        //public int A { get; set; }//only write is not possible in this method

    }
    */

    /*
    class Menu {
        public string[] beverages;

        public Menu()
        {
            beverages = new string[] { "Black Coffee", "Green tea", "Coffee", "Lemon Tea", "Cappuccino", "Espresso", "Latte", "Americano" };
        }
        //indexer
        public string this[int index] { 
            get {return this.beverages[index];}
            set { this.beverages[index] = value;}   
        }
        public int this[String s]
        {
            
            get
            {
                //for (int i = 0; i < beverages.Length; i++)
                //{
                //    if (s == beverages[i])
                //    {
                //        return i;
                //    }
                //}
                //return -1;

                return Array.IndexOf(beverages, s);
            }
            //set
            //{
            //    for(int i = 0;i < beverages.Length; i++)
            //    {
            //        if (s == beverages[i])
            //        {
            //            beverages[i] = beverages[value];
            //        }
            //    }
            //}
                
            
        }
        public int Length
        {
            get { return this.beverages.Length;}
        }

    }
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent P =new Parent();
            //Child child = new Child(); //everytime we call child object is created then the parent and child both th
            //                           //e memebers and memeber functons are initialsed
            //                           // here that means the output of this is 
            //                                                                     //   Parent constructor
            //                                                                     //  Parent constructor
            //                                                                     //  Child constructor

            //Child c=new Child(11);
            //here this call the parent default constructor and the childs paramenteried constructor because the parent defacult
            //is called beacues of the inheritance of the class the and the child parameteried is called beacuse of the
            //object created by the child,
            //OUTPUT
            //Parent constructor
            //Child Parametreised constructor 11


            //Parent p = new Child();
            //OUTPUT
            //Parent constructor
            //Child constructor

            //Demo d = new Demo();
            //d.A = 10;
            //Console.WriteLine(d.A);


            //Menu menu = new Menu();
            //string b = menu.beverages[0];
            //Console.WriteLine(b);
            //Menu menu = new Menu();
            //string b = menu[0];
            //Console.WriteLine(b);
            //Console.WriteLine(menu.Length);

            //for (int i = 0; i < menu.Length; i++) {
            //    Console.WriteLine(menu[i]);
            //}
            //Console.WriteLine(menu["Green tea"]);
        }
     }
}
