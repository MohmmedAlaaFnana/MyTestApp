using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyTestApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppRole> AppRoles { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
