namespace StockApp
{
    abstract internal class Stock_App
    {
        abstract internal void getPrice();
        abstract internal void getQuantity();

    }
    class Shirt : Stock_App {

        int price;
        int quantity;
        public Shirt(int a,int b)
        {
            price = a;
            quantity = b;

        }
        internal override void  getPrice()
        {
            Console.WriteLine("The price {0} ",price);
        }
        internal override void getQuantity()
        {
            Console.WriteLine("The Quantity {0}",quantity);
        }
    }

    class Pant : Stock_App
    {
        int price;
        int quantity;
        public Pant(int a, int b)
        {
            price = a;
            quantity = b;

        }
        internal override void getPrice()
        {
            Console.WriteLine("The price {0} ", price);
        }
        internal override void getQuantity()
        {
            Console.WriteLine("The Quantity {0}", quantity);
        }
    }
    class Jacket : Stock_App
    {
        int price;
        int quantity;
        public Jacket(int a, int b)
        {
            price = a;
            quantity = b;

        }
        internal override void getPrice()
        {
            Console.WriteLine("The price {0} ", price);
        }
        internal override void getQuantity()
        {
            Console.WriteLine("The Quantity {0}", quantity);
        }
    }

    class Shoe : Stock_App
    {
        int price;
        int quantity;
        public Shoe(int a, int b)
        {
            price = a;
            quantity = b;

        }
        internal override void getPrice()
        {
            Console.WriteLine("The price {0} ", price);
        }
        internal override void getQuantity()
        {
            Console.WriteLine("The Quantity {0}", quantity);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Stock_App[] sa = new Stock_App[]{
            new Shirt(1000,10),
            new Pant(1500,12)
            };

          
            for(int i = 0; i < sa.Length; i++)
            {
                if(sa[i] is Shirt)
                {
                    Console.WriteLine("Shirt");
                }
                if( sa[i] is Pant)
                {
                    Console.WriteLine("Pant");
                }
                if (sa[i] is Jacket)
                {
                    Console.WriteLine("Jacket");
                }
                if (sa[i] is Shoe)
                {
                    Console.WriteLine("Shoe");
                }

                sa[i].getPrice();
                sa[i].getQuantity();
            }
        }
    }
}
