using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Bases;
namespace Domain.Entities
{
    public class Brand:BaseWithName
    {
        public bool IsDisplay { get; set; }
        public List<Product> products { get; set; }
    }
}
