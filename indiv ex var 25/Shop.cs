using System;

namespace TaskShop
{
    class Shop
    {
        public static int count;

        public void ShowCount()
        {
            Console.WriteLine("Товара в магазині {0}", Shop.count);
        }

        public void OrderProduct()
        {
            Console.WriteLine("Замовити товар на базі");
        }
    }
}