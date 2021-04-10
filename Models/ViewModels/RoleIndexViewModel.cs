using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace groupauth.Models.ViewModels
{
    public class RoleIndexViewModel
    {   
        public List<IdentityRole> Roles { get; set; }
        public List<IdentityUser> Users { get; set; }
    }
}
