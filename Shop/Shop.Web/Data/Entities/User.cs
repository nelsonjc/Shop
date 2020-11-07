﻿namespace Shop.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class User: IdentityUser
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }
    }
}