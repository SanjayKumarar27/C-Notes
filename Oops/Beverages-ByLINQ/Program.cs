namespace Beverages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Dictionary<string, double> beverages = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);

            beverages.Add("Coffee", 250);
            beverages.Add("Cold Coffee", 300);
            beverages.Add("Black Coffee", 150);
            beverages.Add("Tea", 200);
            beverages.Add("Green Tea", 250);
            beverages.Add("Soup", 30);

            Console.WriteLine("Beverages Are");

            foreach (var beverage in beverages)
            {
                Console.WriteLine(beverage.Key);
            }   
            Console.WriteLine("Enter the Beverage You want: ");
            string ?userInput = Console.ReadLine();

            if (beverages.ContainsKey(userInput))
            {
                Console.WriteLine($"The beverage {userInput} is available and its price is {beverages[userInput]}");
            }
            else
            {
                Console.WriteLine($"The beverage {userInput} is not available");
            }
            //Sort the dictionary based on the value using LINQ
            var sortedBeverages = from beverage in beverages 
                                   orderby beverage.Value 
                                        select beverage;
            Console.WriteLine("Beverages sorted by price:");
            foreach (var beverage in sortedBeverages)
            {
                Console.WriteLine($"{beverage.Key}: {beverage.Value}");
            }

            //Group the beverages based on first character of Beverage name using LINQ
            var groupedBeverages = from beverage in beverages
                                   group beverage by beverage.Key[0] into beverageGroup
                                   orderby beverageGroup.Key
                                   select beverageGroup;

            Console.WriteLine("Beverages grouped by first character:");
           
            foreach (var beverageGroup in groupedBeverages)
            {
                Console.WriteLine($"Beverages starting with '{beverageGroup.Key}':");
                foreach (var beverage in beverageGroup)
                {
                    Console.WriteLine($"  {beverage.Key}: {beverage.Value}");
                }
            }


        }
    }
}
