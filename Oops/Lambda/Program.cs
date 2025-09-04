using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Lambda
{
    public static class MyExtention// this become extentsion method 
    {
      public static bool IsEven(this int x)// this int x means we are adding this method to int class
        {
            return x % 2 == 0;
        }

        //function contain a number using regular expression
        public static bool IsNumber(this string str)
        {
            return Regex.IsMatch(str, @"\d");
        }
    }
    internal class Program
    {
        delegate void MyDelegate(string name);

        delegate int calculate(int x, int y);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //lambda
            //we avoid the return type in lambda and name is not mandatory

            //void Disp(){
            //} is written as 
            //() => { }
            //is single paramenter no need of () and single line of body no need of {} so we need the seprator =>
            //C#/JS/TS  => fat arrow 
            //Java      -> thin arrow  Function

            //Create a delegate
            //MyDelegate del = (string name )=> Console.WriteLine("Hello " + name);

            //del+= (name) => Console.WriteLine("Welcome " + name);

            ////call the delegate
            //del("Sanjay ");
            //calculate sum = (x, y) => { return x + y; 
            //Console.WriteLine( "the sum of 10 and 20 is "+sum (10, 20));

            // calculate sub=(x, y) => { return x - y; };
            //Console.WriteLine("The substraction of 20 and 10 is "+sub(20, 10));

            //action to return type is void
            //func to return type is other than void these are inbuilt delegates in .Net

            Action<int,int> add = (a,b) => { Console.WriteLine("The sum of 10 and 20 is " + (a + b)); };



            Func<int, int, int> sub = (a, b) => a - b;

           Console.WriteLine( sub(100, sub(30, 60)));


            //square of a number
            Func<int, int> square = a => a * a;
            Console.WriteLine("The square of 5 is " + square(5));

            string abc= "Sanjay123";
            Console.WriteLine("this  contain number "+abc.IsNumber());// we can use our extention method here
         ;

            int[] a1 = new int[5] { 1, 2, 3, 4, 5 };
            //lamda and lINQ can be used interchangeably
            var res = from a in a1
                      where a.IsEven()// we can use our extention method here
                      select a;
            //this same as
           IEnumerable<int> list= a1.Where(a => a % 2 == 0).OrderBy(a => a);
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //array of strings we group by character first character  using lamda storeit in Ienumerable

            string[] names = new string[10] { "Sanjay", "Ajay", "Vijay", "Amar", "Akbar", "Anthony", "Sunil", "Salman", "Yash", "Deepak" };

            var charNames = names.GroupBy(n => n[0]);
        
            foreach (var group in charNames)
            {
                Console.WriteLine("Names starting with " + group.Key);
                foreach (var name in group)
                {
                    Console.WriteLine(name);
                }
            }
            




        }
    }
}
