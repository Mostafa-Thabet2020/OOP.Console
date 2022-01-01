using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Bases;
using Domain.Parents;

namespace Domain.Entities
{
    public class UserRole:BaseWithName
    {
        public List<User> users { get; set; }   
    }
}
