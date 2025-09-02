using System.Runtime.InteropServices;

namespace Interfaces


{
    class matrix
    {
        private int[,] data;

        public matrix(int rows, int cols)
        {
            data = new int[rows, cols];
        }
        public int this[int row, int cols]
        {
            get { return data[row, cols]; }
            set { data[row, cols] = value; }
        }
    }
    /*
    interface Ishape
    {

        void Area();//by defaulth the methods are public and abstract no need tpo mention public na abstract
    }
    interface I2: Ishape//one interface inheriting from other interface
       //1.2.3.4
        //1 = Major
        //2 = Minor
        //3 = Build
        //4 = Revision
    {
        
        void Show ();
    }
    class Circle : I2 {
        public void Area()
        {
            Console.WriteLine("πr^2");
        }
        public void Show()
        {
            Console.WriteLine("Circle");
        }
    }
    class Reactangle : Circle,Ishape//if inheriting with classes and infterfaces both and the seq
                                    //should be class first and then all the other interfaces
    {
        public void Area()
        {
            Console.WriteLine("L*B");
        }
        public void print()
        {
            Console.WriteLine("Rectangle");
        }

    }

    //child method cannot change access modifer when overriding the parent method
    //abstract class parent
    //{
    //    abstract internal void show();

    //}
    //class child : parent
    //{
    //    public override void show()  //child method cannot change access modifer when overriding the parent method
    //        // so this give error
    // //so the access modifier should be same 
    // //when we not use abstract or virtual then for hiding above works with 
    //    {

    //    }
    //}
    */
    internal class Program
    {
        /*
            static void Disp(Ishape s)
            {
                s.Area();
                if(s is Reactangle R)
                {
                // Reactangle R=(Reactangle)s; this can also be written using as
                //Reactangle ?R = s as Reactangle;

                    R.print();

                }
                else
                {
                //Circle C=(Circle)s;
                Circle ?C = s as Circle;
                    C.show();
                }
            
                }
        */
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Circle c=new Circle();
            //c.Area();
            //c.Show();
            //Ishape s1 = new Circle();
            //s1.Area();
            //I2 s2 = new Reactangle();
            //s2.Show();
            //s2.Area();
            //this is possible as its same as abstract class with no concrete menthod


            //s.show(); // this isnot possible as the child object cannot call its own method with parent
            // refrence which is not overriden by child

            //Ishape s=new Ishape();this 

            //Reactangle r=new Reactangle();
            //Disp(r);


           matrix m=new matrix(2, 2);
            m[0,0] = 1;
            m[0, 1] = 1;
            m[1, 0] = 1;
            m[1, 1] = 1;
            Console.WriteLine("The matrix is ");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {

                    Console.Write(m[i,j]+" ");
                }
                Console.WriteLine();


            }

            //int a=10;
            //name  a
            //type  int
            //value 10
            //address 100


        }
    }
}
using System.Runtime.InteropServices;

namespace Interfaces


{
    class matrix
    {
        private int[,] data;

        public matrix(int rows, int cols)
        {
            data = new int[rows, cols];
        }
        public int this[int row, int cols]
        {
            get { return data[row, cols]; }
            set { data[row, cols] = value; }
        }
    }
    /*
    interface Ishape
    {

        void Area();//by defaulth the methods are public and abstract no need tpo mention public na abstract
    }
    interface I2: Ishape//one interface inheriting from other interface
       //1.2.3.4
        //1 = Major
        //2 = Minor
        //3 = Build
        //4 = Revision
    {
        
        void Show ();
    }
    class Circle : I2 {
        public void Area()
        {
            Console.WriteLine("πr^2");
        }
        public void Show()
        {
            Console.WriteLine("Circle");
        }
    }
    class Reactangle : Circle,Ishape//if inheriting with classes and infterfaces both and the seq
                                    //should be class first and then all the other interfaces
    {
        public void Area()
        {
            Console.WriteLine("L*B");
        }
        public void print()
        {
            Console.WriteLine("Rectangle");
        }

    }

    //child method cannot change access modifer when overriding the parent method
    //abstract class parent
    //{
    //    abstract internal void show();

    //}
    //class child : parent
    //{
    //    public override void show()  //child method cannot change access modifer when overriding the parent method
    //        // so this give error
    // //so the access modifier should be same 
    // //when we not use abstract or virtual then for hiding above works with 
    //    {

    //    }
    //}
    */
    internal class Program
    {
        /*
            static void Disp(Ishape s)
            {
                s.Area();
                if(s is Reactangle R)
                {
                // Reactangle R=(Reactangle)s; this can also be written using as
                //Reactangle ?R = s as Reactangle;

                    R.print();

                }
                else
                {
                //Circle C=(Circle)s;
                Circle ?C = s as Circle;
                    C.show();
                }
            
                }
        */
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Circle c=new Circle();
            //c.Area();
            //c.Show();
            //Ishape s1 = new Circle();
            //s1.Area();
            //I2 s2 = new Reactangle();
            //s2.Show();
            //s2.Area();
            //this is possible as its same as abstract class with no concrete menthod


            //s.show(); // this isnot possible as the child object cannot call its own method with parent
            // refrence which is not overriden by child

            //Ishape s=new Ishape();this 

            //Reactangle r=new Reactangle();
            //Disp(r);


           matrix m=new matrix(2, 2);
            m[0,0] = 1;
            m[0, 1] = 1;
            m[1, 0] = 1;
            m[1, 1] = 1;
            Console.WriteLine("The matrix is ");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {

                    Console.Write(m[i,j]+" ");
                }
                Console.WriteLine();


            }

            //int a=10;
            //name  a
            //type  int
            //value 10
            //address 100


        }
    }
}
