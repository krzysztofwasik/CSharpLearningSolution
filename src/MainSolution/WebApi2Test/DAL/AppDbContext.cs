using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi2Test.DAL.Entities;

namespace WebApi2Test.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DefaultConnection")
        {
        }
        
        public DbSet<User> Users { get; set; } 
    }
}