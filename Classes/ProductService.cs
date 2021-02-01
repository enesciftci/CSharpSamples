using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class ProductService
    {
        public ProductService(int number1, int number2)
        {
            Console.WriteLine("product service başladı");
            Console.WriteLine(number1+number2);
        }

        public ProductService()
        {
            
        }
        public void Update(Product product)
        {
            // bağlantı yap
            // güncelleme
        }

        void Delete(int id)
        {
            // bağlantı yap
            // silme işlemleri
        }
    }
}
