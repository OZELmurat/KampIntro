using System;

namespace KampOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Klavye";
            product1.productId = "81515742341";
            product1.productAmount = 99.9;

            Product product2 = new Product();
            product2.productName = "Mouse";
            product2.productId = "9156451451";
            product2.productAmount = 54.9;

            Product product3 = new Product();
            product3.productName = "Kulaklık";
            product3.productId = "72412645645";
            product3.productAmount = 60;

            Product[] products = new Product[] { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("ürün adı: " + products[i].productName +
                " ürünID: " + products[i].productId + " ürün fiyatı: "
                + products[i].productAmount + "TL");

            }

            foreach (var product in products)
            {
                Console.WriteLine("\t ürün adı: " + product.productName +
               " ürünID: " + product.productId + " ürün fiyatı: "
               + product.productAmount + "TL");

            }

            int c = 0;
            while (c < products.Length)
            {
                Console.WriteLine("\t \t ürün adı: " + products[c].productName +
                " ürünID: " + products[c].productId + " ürün fiyatı: "
                + products[c].productAmount + "TL");
                c++;
            }



        }



    }

    class Product
    {
        public string productId { get; set; }
        public string productName { get; set; }
        public double productAmount { get; set; }
    }

}
