using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Final_Question1.Models;

namespace Final_Question1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Final_Question1.Models.Passengers> Passengers { get; set; }
        public DbSet<Final_Question1.Models.Airplane> Airplane { get; set; }
    }
}
