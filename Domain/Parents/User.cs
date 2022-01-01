using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Parents;
using Domain.Entities;

namespace Domain.Parents
{
    public class User:PeopleGeneralInformation
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public UserRole? userRole { get; set; }
    }
}
