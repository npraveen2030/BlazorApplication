using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorServerApp.Model.EntityModel;
using Microsoft.EntityFrameworkCore; 

namespace BlazorServerApp.DLL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } // Example model
        public DbSet<Models> Models { get; set; } // Example model
    }
}