﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.DL.Entities.UserEntites
{
    internal class User : BaseDomain
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
