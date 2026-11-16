using System;

namespace TaskShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rnd = new Random();

            Shop shop = new Shop();

            Shop.count = rnd.Next(20, 101);
            Console.WriteLine("Початкова кількість товару: {0}\n", Shop.count);

            bool stop = false;
            while (!stop)
            {
                int need = rnd.Next(1, 21);
                Buyer buyer = new Buyer(need);

                buyer.Event1 += buyer.SayBought;
                buyer.Event1 += shop.ShowCount;
                buyer.Event2 += buyer.SayNotBought;
                buyer.Event2 += shop.OrderProduct;

                buyer.Buy();

                stop = buyer.NoProduct;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}