using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemortProductDal : IProductDal
    {

        List<Product> _products;

        public InMemortProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15, CategoryId=1},
                new Product {ProductId=2, ProductName="Kamera", UnitPrice=500, UnitsInStock=3, CategoryId=2},
                new Product {ProductId=3, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2, CategoryId=3},
                new Product {ProductId=4, ProductName="Klavye", UnitPrice=150, UnitsInStock=65, CategoryId=4},
                new Product {ProductId=5, ProductName="Mouse", UnitPrice=85, UnitsInStock=1, CategoryId=5}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);

        }

        public void Delete(Product product)
        {
            var productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            var productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
