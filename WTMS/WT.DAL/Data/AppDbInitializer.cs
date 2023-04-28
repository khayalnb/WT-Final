using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WT.DAL.Models.Identity;

namespace WT.DAL.Data
{
    public static class AppDbInitializer
    {
        private const string DefaultRole = "Admin";
        private const string DefaultEmail = "superadmin@admin.com";
        private const string DefaultPassword = "Xm1102@@##";

        public static async Task SeedDefaultUserAndRoleAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            IdentityResult roleCreated;
            if (await roleManager.FindByNameAsync(DefaultRole) == null)
            {
                var defaultRole = new IdentityRole
                {
                    Name = DefaultRole
                };
                roleCreated = await roleManager.CreateAsync(defaultRole);
            }
            else
            {
                roleCreated = IdentityResult.Success;
            }

            if (roleCreated.Succeeded)
            {
                if (await userManager.FindByEmailAsync(DefaultEmail) == null)
                {
                    var defaultUser = new AppUser()
                    {
                        UserName = DefaultEmail,
                        Email = DefaultEmail
                    };
                    var result = await userManager.CreateAsync(defaultUser, DefaultPassword);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(defaultUser, DefaultRole);
                    }
                }
            }
        }


        public static void ApplyDbSeedData(ModelBuilder builder) 
        { 
        
        }
    }
}


