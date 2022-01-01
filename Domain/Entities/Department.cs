using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Bases;
namespace Domain.Entities
{
    public class Department:BaseWithName
    {
        public List<Empolyee>? employees { get; set; }
    }
}
