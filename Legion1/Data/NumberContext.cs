using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Legion1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Legion1.Data
{
     public class NumberContext : IdentityDbContext<IdentityUser>
    {
        public NumberContext(DbContextOptions options) : base(options) { }

        public DbSet<Recent> Recent { get; set; }
        
        }

    
}
