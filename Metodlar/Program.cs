using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Produts product1 = new Produts();
            product1.Id = "1";
            product1.Explanation = " Amasya Elması";
            product1.Price = 5.5;
            product1.Name = "Elma";

            Produts product2 = new Produts();
            product2.Id = "2";
            product2.Explanation = " Napolyon kirazı";
            product2.Price = 7.2;
            product2.Name = "Kiraz";

            Produts[] products = new Produts[] { product1, product2 };

            foreach (Produts urun in products)
            {
                Console.WriteLine(urun.Id+" : "+ urun.Name);
            }

            Console.WriteLine("---------Metodlar------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(product1);

        }
    }
}
