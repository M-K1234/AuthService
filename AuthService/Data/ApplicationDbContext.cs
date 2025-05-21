using Microsoft.EntityFrameworkCore;
using AuthService.Models;
using System.Collections.Generic;

namespace AuthService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}
