using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Parents;

namespace Domain.Entities
{
    public class Empolyee : User
    {
        public string? Title { get; set; }
        public string? JobDescription { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime ContractExpiryDate { get; set; }
        public Department? department { get; set; }
    }
}
