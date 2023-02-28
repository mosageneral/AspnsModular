using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.DL.DTO
{
    internal class AddCityDTO
    {
        public Guid RegionId { get; set; }


        public string NameAr { get; set; }
        public string NameEn { get; set; }
    }
}
