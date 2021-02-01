using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProductService productService=new ProductService(2,5);
            Console.ReadKey();

            //  //chai
            //  Product product = new Product();
            //  product.ProductId = 5;
            //  product.ProductName = "fanta";
            //productService.Update(product);
        }
    }
}
