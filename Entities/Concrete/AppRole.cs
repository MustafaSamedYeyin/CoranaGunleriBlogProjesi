﻿using Entities.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AppRole :IdentityRole<int>, ITablo
    {
        //public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
