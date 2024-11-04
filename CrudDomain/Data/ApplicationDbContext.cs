using CrudDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CrudDomain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
