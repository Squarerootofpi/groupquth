﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace groupauth.Models.ViewModels
{
    public class ManageUserRolesViewModel
    {
        public IdentityUser User { get; set; }
        public List<IdentityRole> Roles { get; set; }
    }
}
