using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Rabee",
                    Email = "rabee.mamdouh922@gmail.com",
                    UserName = "rabee",
                    Address = new Address
                    {
                        FirstName = "rabee",
                        LastName = "mamdouh",
                        Street = "alwasata",
                        City = "Belqas",
                        State = "Daqahlya",
                        ZipCode = "35669"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
