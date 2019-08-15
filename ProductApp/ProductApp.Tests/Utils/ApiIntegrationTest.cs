﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using ProductApp.Models;

namespace ProductApp.Tests.Utils
{
    [TestClass]
    public class ApiIntegrationTest
    {
        /// <summary>
        /// Test product response from API.
        ///</summary>
        [TestMethod]
        public void TestGetProducts()
        {
            ProductApp.Utils.ApiIntegration api = new ProductApp.Utils.ApiIntegration();

            JObject products = api.GetProducts();

            Assert.IsNotNull(products);
            Assert.IsInstanceOfType(products, typeof(JObject));
        }

        /// <summary>
        /// Test product pages count.
        ///</summary>
        [TestMethod]
        public void TestGetProductPagesCount()
        {
            ProductApp.Utils.ApiIntegration api = new ProductApp.Utils.ApiIntegration();

            JObject products = api.GetProducts();
            string productsCount = api.GetProductPagesCount(products);

            Assert.IsNotNull(productsCount);
            Assert.IsInstanceOfType(productsCount, typeof(string));
        }

        /// <summary>
        /// Test products json object casting to list of ProductsModel objects.
        ///</summary>
        [TestMethod]
        public void TestCastProducts()
        {
            ProductApp.Utils.ApiIntegration api = new ProductApp.Utils.ApiIntegration();

            JObject products = api.GetProducts();
            List<ProductsModel> productsList = api.CastProducts(products);

            Assert.IsNotNull(productsList);
            Assert.IsInstanceOfType(productsList, typeof(List<ProductsModel>));
        }
    }
}