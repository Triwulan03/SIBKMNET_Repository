using Microsoft.EntityFrameworkCore;
using SIBKMNET_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_WebApp.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<Region> Regions { get; set; }
            
    }
}
