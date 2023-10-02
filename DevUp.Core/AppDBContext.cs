using DevUp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevUp.Core
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        { 
        }
        
    }
}
