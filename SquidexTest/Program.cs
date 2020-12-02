using System;
using System.Threading.Tasks;
using SquidexTest.Services;

namespace SquidexTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var ps = new ProductService();
            var products = await ps.GetProducts();
        }
    }
}
