using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products("Logitech mouse", 70.00, 14);
            Products product2 = new Products("iPhone 5s", 999.99, 3);
            Products product3 = new Products("Epson EB-U05", 440.46, 1);

            product1.PrintProduct();
            product2.PrintProduct();
            product3.PrintProduct();

            product1.amountAtStart = 3;
            product1.priceAtStart = 10.40;
            product1.PrintProduct();

            Console.ReadKey();
        }
    }
}
