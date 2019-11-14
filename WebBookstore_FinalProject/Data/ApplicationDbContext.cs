using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebBookstore_FinalProject.Models;

namespace FantasEBooks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebBookstore_FinalProject.Models.Book> Book { get; set; }
        public DbSet<WebBookstore_FinalProject.Models.Genre> Genre { get; set; }
        public DbSet<WebBookstore_FinalProject.Models.User> User { get; set; }
        public DbSet<WebBookstore_FinalProject.Models.ShoppingCart> ShoppingCart { get; set; }
        public DbSet<WebBookstore_FinalProject.Models.Recommendations> Recommendations { get; set; }
        public DbSet<WebBookstore_FinalProject.Models.Library> Library { get; set; }
    }
}
