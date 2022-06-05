using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Identity
{
    public class SeedIdentity
    {
        public static async Task Seed(UserManager<User> usermanager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            //ADMİN OLUŞTURMA KODLARI
            var adminUserName = configuration["UserData:AdminUser:UserName"];
            var adminPassword = configuration["UserData:AdminUser:Password"];
            var adminEmail = configuration["UserData:AdminUser:Email"];
            var adminRole = configuration["UserData:AdminUser:Role"];
            if (await usermanager.FindByNameAsync(adminUserName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
                var adminUser = new User()
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    UserName = adminUserName,
                    Email = adminEmail,
                    EmailConfirmed = true
                };
                var result = await usermanager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await usermanager.AddToRoleAsync(adminUser, adminRole);
                }
            }

            //User OLUŞTURMA KODLARI
            var customerUserName = configuration["UserData:CustomerUser:UserName"];
            var customerPassword = configuration["UserData:CustomerUser:Password"];
            var customerEmail = configuration["UserData:CustomerUser:Email"];
            var customerRole = configuration["UserData:CustomerUser:Role"];
            if (await usermanager.FindByNameAsync(customerUserName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(customerRole));
                var customerUser = new User()
                {
                    FirstName = "Customer",
                    LastName = "Customer",
                    UserName = customerUserName,
                    Email = customerEmail,
                    EmailConfirmed = true
                };
                var result = await usermanager.CreateAsync(customerUser, customerPassword);
                if (result.Succeeded)
                {
                    await usermanager.AddToRoleAsync(customerUser, customerRole);
                }
            }

            //advisor oluşturma kodları
            var advisorUserName = configuration["UserData:AdvisorUser:UserName"];
            var advisorPassword = configuration["UserData:AdvisorUser:Password"];
            var advisorEmail = configuration["UserData:AdvisorUser:Email"];
            var advisorRole = configuration["UserData:AdvisorUser:Role"];
            if (await usermanager.FindByNameAsync(advisorUserName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(advisorRole));
                var advisorUser = new User()
                {
                    FirstName = "Advisor",
                    LastName = "Advisor",
                    UserName = advisorUserName,
                    Email = advisorEmail,
                    EmailConfirmed = true
                };
                var result = await usermanager.CreateAsync(advisorUser, advisorPassword);
                if (result.Succeeded)
                {
                    await usermanager.AddToRoleAsync(advisorUser, advisorRole);
                }
            }

        }


    }
}
