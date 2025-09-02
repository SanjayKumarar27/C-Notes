using System.Linq.Expressions;
using System.Transactions;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //what is System in java and System in c# .net?
            //.Net System is namespace
            //Java System is class
            try
            {

                Console.WriteLine("Enter a number ");

                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((double)a / b);

            }
            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace); Developwrs only
                Console.WriteLine("Enter numbers only ");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Number cannot be divided by zero");
            }
            catch (Exception ex) //generic exception
                                 //Sequence of the exception matter as they are executed in order,
            {
                Console.WriteLine(ex.Message);
            }
            finally //always executes even if there is exeption or not
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("Done");
    
        }
    }
}
