using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Project.Models;

namespace Web_Project.DataContext
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = localhost; Database = aspnetnotedb; Uid = sa; Pwd = 1234");
        }

    }
}
