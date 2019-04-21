using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.DAL
{
    public class AuthenticationContext : IdentityDbContext<ApplicationUser, AppRole, string>
    {
        public string CurrentUserId { get; set; }
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options) { }



        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<IdentityUserRole<Guid>>().HasKey(p => new { p.UserId, p.RoleId });
        //}
    }
}
