using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoneUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();

            DtoTest();


        }

        private static void DtoTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " / " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
                        
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var product in categoryManager.GetAll())
            {
                Console.WriteLine(product.CategoryName);
            }
        }
    }
}
