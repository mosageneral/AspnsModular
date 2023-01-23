using Module.Account.DL.Entities.UserEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.DL.DTO
{
    internal class AddUserDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Guid? CityId { get; set; }
     
        public string UserType { get; set; }
        public Guid? VendorId { get; set; }
     
    }
}
