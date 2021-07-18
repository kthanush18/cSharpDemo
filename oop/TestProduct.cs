using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo.oop
{
    class Product
    {
        private readonly String name;
        private readonly int price;
        private int qoh;
        private readonly static double taxrate = 7.5;

        public static double GetTaxRate()
        {
            return taxrate;
        }

        // Constructor 
        public Product(String n, int p)
        {
            name = n;
            price = p;
            qoh = 0;
        }
        // Methods 
        public void Print()
        {
            Console.WriteLine($"{name} - {price} - {qoh}");
        }

        public void Purchase(int qty)
        {
            qoh += qty;
        }

        // Readonly property 
        public double NetPrice
        {
            get
            {
                return this.price + this.price * taxrate / 100;
            }
        }

    }
    class TestProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product.GetTaxRate());

            Product p1 = new("PowerBeats Pro", 21500);    // Object 
            p1.Purchase(5);
            p1.Purchase(10);
            p1.Print();
            Console.WriteLine(p1.NetPrice);
        }
    }

}

