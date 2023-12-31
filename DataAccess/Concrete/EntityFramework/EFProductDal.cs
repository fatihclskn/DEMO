﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                var result = from p in context.Products join c in context.Categories on p.CategoryId equals c.categoryId select new ProductDetailDto 
                {
                    ProductId=p.ProductId,
                    ProductName = p.ProductName,
                    CategoryName=c.CategoryName,
                    UnitsInStock=p.UnitsInStock,
                };

                return result.ToList();
            }
        }
    }
}
