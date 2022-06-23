using DanismanProject.WebUI.Identity;
using DanismanProject.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Controllers
{
    public class MyAccountController : Controller
    {
     
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole> _roleManager;


        public MyAccountController( RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
         
            _roleManager = roleManager;
            _userManager = userManager;
         
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task< IActionResult> UserAccount(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {              
               
                return View(new UserDetailsModel()
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                   
                });
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserAccount(UserDetailsModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                 

                    var result = await _userManager.UpdateAsync(user);
                  
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                   
                    return View(model);
                }
                ModelState.AddModelError("", "Böyle bir kullanıcı yok!");
           
                return View(model);
            }
 
            return View(model);

        }

       
    }
}
