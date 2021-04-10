using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using groupauth.Models;
using groupauth.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace groupauth.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> roleManager;

        UserManager<IdentityUser> userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        //[AllowAnonymous]
        [Authorize(Policy = "researcherpolicy")]
        public IActionResult Index()
        {

            var roles = roleManager.Roles.ToList();
            var users = userManager.Users.ToList();
            return View(new RoleIndexViewModel
            {
                Roles = roles,
                Users = users
            });
        }

        //[AllowAnonymous]
        [Authorize(Policy = "superadminpolicy")]
        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        //[AllowAnonymous]
        [Authorize(Policy = "superadminpolicy")]
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// This is to manage a single user's roles
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        //[AllowAnonymous]
        [Authorize(Policy = "superadminpolicy")]
        [HttpGet]
        public IActionResult ManageUserRoles(string UserId)
        {
            IdentityUser user = userManager.Users.Where(u => u.Id == UserId).FirstOrDefault();

            List<IdentityRole> roles = roleManager.Roles.ToList();
            return View(new ManageUserRolesViewModel
            {
                Roles = roles,
                User = user
            });
        }

        //////
        //[AllowAnonymous]
        [Authorize(Policy = "superadminpolicy")]
        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(string UserId, string roleId, bool addOrRemove)
        {
            var role = await roleManager.FindByIdAsync(roleId);
            //await roleManager.CreateAsync(role);
            var user = await userManager.FindByIdAsync(UserId);
            if (addOrRemove)
            {
                IdentityResult result = await userManager.AddToRoleAsync(user, role.Name);
            }
            else if (!addOrRemove)
            {
                IdentityResult result = await userManager.RemoveFromRoleAsync(user, role.Name);
            }
            else
            {
                Console.Out.WriteLine("what? not sure of the input on that one...");
            }

            return RedirectToAction("Index");

        }

        ///////

        //[Route("ManageUsersInRole")]
        //public async Task<IHttpActionResult> ManageUsersInRole(UsersInRoleModel model)
        //{
        //    var role = await this.roleManager.FindByIdAsync(model.Id);

        //    if (role == null)
        //    {
        //        ModelState.AddModelError("", "Role does not exist");
        //        return BadRequest(ModelState);
        //    }

        //    foreach (string user in model.EnrolledUsers)
        //    {
        //        var appUser = await this.roleManager.FindByIdAsync(user);

        //        if (appUser == null)
        //        {
        //            ModelState.AddModelError("", String.Format("User: {0} does not exists", user));
        //            continue;
        //        }

        //        if (!this.roleManager.IsInRole(user, role.Name))
        //        {
        //            IdentityResult result = await this.roleManager.AddToRoleAsync(user, role.Name);

        //            if (!result.Succeeded)
        //            {
        //                ModelState.AddModelError("", String.Format("User: {0} could not be added to role", user));
        //            }

        //        }
        //    }

        //    foreach (string user in model.RemovedUsers)
        //    {
        //        var appUser = await this.AppUserManager.FindByIdAsync(user);

        //        if (appUser == null)
        //        {
        //            ModelState.AddModelError("", String.Format("User: {0} does not exists", user));
        //            continue;
        //        }

        //        IdentityResult result = await this.AppUserManager.RemoveFromRoleAsync(user, role.Name);

        //        if (!result.Succeeded)
        //        {
        //            ModelState.AddModelError("", String.Format("User: {0} could not be removed from role", user));
        //        }
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return Ok();
        //}
        /////
    }
}
