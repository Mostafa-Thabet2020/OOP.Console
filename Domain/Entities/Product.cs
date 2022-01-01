using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Bases;

namespace Domain.Entities
{
    public class Product:BaseWithName
    {
        public double Price { get; set; }
        public string? Description { get; set; }
        public bool IsDisplay { get; set; }
        public bool IsSale { get; set; }
        public double Discount { get; set; }
        public static int NumberOfProduct { get; set; }
        public Brand brand { get; set; }
        public SubCategory subCategory { get; set; }
    }
}
