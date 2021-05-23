using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Product
    {
        //European Article Number
        [Key]
        public string Ean { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Validity { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int Weight { get; set; }
    }
}