using Newtonsoft.Json;
using Squidex.ClientLibrary;

namespace SquidexTest.Models
{
    public class Product : SquidexEntityBase<ProductData>
    {
        
    }

    public class ProductData
    {
        [JsonConverter(typeof(InvariantConverter))]
        public int Id { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Name { get; set; }
    }
}