using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Channels;
using System.Threading.Tasks;
using Squidex.ClientLibrary;
using Squidex.ClientLibrary.Utils;
using SquidexTest.Models;

namespace SquidexTest.Services
{
    public class ProductService
    {
        private readonly SquidexClientManager _clientManager;

        public ProductService()
        {
            _clientManager = new SquidexClientManager("https://cloud.squidex.io",
                "testing1337", 
                "testing1337:default",
                "oy481dmvis5gdrxnijbpjtkh2eevle0g2i63xvt93gcx");
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var records = _clientManager.CreateContentsClient<Product, ProductData>("product");
            var products = new List<Product>();
            //var records = await _clientManager.GetClient<Product, ProductData>("product").GetAsync();
            await records.GetAllAsync(100, product => { products.Add(product); return Task.CompletedTask; });

            return products;
        }
    }
}