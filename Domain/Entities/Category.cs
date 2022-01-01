using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Bases;

namespace Domain.Entities
{
    public class Category:BaseWithName
    {
        public List<SubCategory> subCategories { get; set; }
    }
}
