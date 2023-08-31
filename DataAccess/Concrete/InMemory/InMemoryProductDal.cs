using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
               new Product{ProductId=1,ProductName="kalem",UnitPrice=12,UnitsInStock=24 },
               new Product{ProductId=2,ProductName="bardak",UnitPrice=3,UnitsInStock=4 },
               new Product{ProductId=3,ProductName="masa",UnitPrice=160,UnitsInStock=8 },
               new Product{ProductId=4,ProductName="sandalye",UnitPrice=55,UnitsInStock=15 },
               new Product{ProductId=5,ProductName="dolap",UnitPrice=134,UnitsInStock=85 },
               new Product{ProductId=6,ProductName="tabure",UnitPrice=35,UnitsInStock=35 },
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
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
            return _products;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Uptade(Product product)
        {
            Product productToUptade = _products.SingleOrDefault(p => p.UnitPrice == product.UnitPrice);
            productToUptade.UnitsInStock = product.UnitsInStock;
            productToUptade.ProductName = product.ProductName;
        }
    }
}
