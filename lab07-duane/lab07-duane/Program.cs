using System;
using System.Collections.Generic;

namespace lab07_duane
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Estore<Products> ECommerseStore = new Estore<Products>();

            Products phone = new Products();

            phone.NewProduct = Product.phone;

            ECommerseStore.Add(phone);
            ECommerseStore.Add(new Products() { NewProduct = Product.backpack });
            ECommerseStore.Add(new Products() { NewProduct = Product.bike });
            ECommerseStore.Add(new Products() { NewProduct = Product.book });
            ECommerseStore.Add(new Products() { NewProduct = Product.chair });
            ECommerseStore.Add(new Products() { NewProduct = Product.computer });
            ECommerseStore.Add(new Products() { NewProduct = Product.glasses });
            ECommerseStore.Add(new Products() { NewProduct = Product.hat });
            ECommerseStore.Add(new Products() { NewProduct = Product.jacket });
            ECommerseStore.Add(new Products() { NewProduct = Product.shoes });
            ECommerseStore.Add(new Products() { NewProduct = Product.table });

            foreach (Products p in ECommerseStore)
            {
                Console.WriteLine(p.NewProduct);
                Console.WriteLine();
                Console.WriteLine(p.Clearance);
                Console.WriteLine(p.Sale);
                Console.WriteLine();
            }
        Console.Read();
        }
    }
}
