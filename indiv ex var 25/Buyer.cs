using System;

namespace TaskShop
{
    class Buyer
    {
        public delegate void Handler();
        public event Handler Event1; 
        public event Handler Event2; 

        private int need;       
        private bool noProduct = false;

        public Buyer(int need)
        {
            this.need = need;
        }

        public bool NoProduct
        {
            get { return noProduct; }
        }

        public void Buy()
        {
            if (Shop.count >= need)
            {
                Shop.count -= need;
                Event1();
            }
            else
            {
                noProduct = true;
                Event2();
            }
        }

        public void SayBought()
        {
            Console.WriteLine("Купил товару = {0}", need);
        }

        public void SayNotBought()
        {
            Console.WriteLine("Не зміг купити товару = {0}", need);
        }
    }
}