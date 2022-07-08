using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoneUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemortProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
