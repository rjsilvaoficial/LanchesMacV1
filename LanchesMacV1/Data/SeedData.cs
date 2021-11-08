using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Data
{
    public static class SeedData
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roleNames = { "Admin", "Member" };

            IdentityResult roleResult;

            foreach(var name in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(name);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(name));
                }
            }

            var powerUser = new IdentityUser
            {
                UserName = configuration.GetSection("UserSettings")["UserName"],
                Email = configuration.GetSection("UserSettings")["UserEmail"]

            };

            string userPass = configuration.GetSection("UserSettings")["UserPassword"];

            var user = await UserManager.FindByEmailAsync(configuration.GetSection("UserSettings")["UserEmail"]);

            if(user == null)
            {
                var createPwUser = await UserManager.CreateAsync(powerUser, userPass);
                if (createPwUser.Succeeded)
                {
                    await UserManager.AddToRoleAsync(powerUser, "Admin");
                }
            }
        }
    }
}
