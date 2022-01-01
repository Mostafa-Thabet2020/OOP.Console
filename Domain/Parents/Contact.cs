using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Bases;
namespace Domain.Parents
{
    public class Contact:Base
    {
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public PeopleGeneralInformation peopleGeneralInformation { get; set; }
    }
}
