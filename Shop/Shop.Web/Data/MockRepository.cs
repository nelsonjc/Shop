﻿//using Shop.Web.Data.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Shop.Web.Data
//{
//    public class MockRepository : IRepository
//    {
//        #region Products
//        public void AddProduct(Product product)
//        {
//            throw new NotImplementedException();
//        }

//        public Product GetProduct(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Product> GetProducts()
//        {
//            var products = new List<Product>
//            {
//                new Product { Id = 1, Name = "One", Price = 10 },
//                new Product { Id = 2, Name = "Two", Price = 20 },
//                new Product { Id = 3, Name = "Three", Price = 30 },
//                new Product { Id = 4, Name = "Four", Price = 40 },
//                new Product { Id = 5, Name = "Five", Price = 50 },
//                new Product { Id = 6, Name = "Six", Price = 60 },
//                new Product { Id = 7, Name = "Seven", Price = 70 }
//            };

//            return products;
//        }

//        public bool ProductExists(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void RemoveProduct(Product product)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> SaveAllAsync()
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdateProduct(Product product)
//        {
//            throw new NotImplementedException();
//        } 
//        #endregion
//    }
//}
