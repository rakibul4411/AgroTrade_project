using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using WebAPI.DAL;

namespace WebAPI.Models
{
    public class Seedvalue
    {
        public static async Task Initialize(AuthenticationContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<AppRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Operator";
            string desc2 = "This is the members role";

            string password = "Rakib123.";
            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new AppRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new AppRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("http.rakib@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "http.rakib@gmail.com",
                    Email = "http.rakib@gmail.com",
                    FullName = "Rakibul Islam",
                    PhoneNumber = "+8801737104448"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("http.gazi@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "http.gazi@gmail.com",
                    Email = "http.gazi@gmail.com",
                    FullName = "Farid",
                    PhoneNumber = "+8801783881623"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId2 = user.Id;
            }

            if (await userManager.FindByNameAsync("http.golap@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "mdfaridgazi@gmail.com",
                    Email = "mdfaridgazi@gmail.com",
                    FullName = "Farid Uddin",
                    PhoneNumber = "+8801712-681695"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

            if (await userManager.FindByNameAsync("https.mizan@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "https.mizan@gmail.com",
                    Email = "https.mizan@gmail.com",
                    FullName = "Mizan",
                    PhoneNumber = "+8801765910578"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }

    }
}
