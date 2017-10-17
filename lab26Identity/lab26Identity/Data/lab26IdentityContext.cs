using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab26Identity.Models
{
    public class lab26IdentityContext : DbContext
    {
        public lab26IdentityContext (DbContextOptions<lab26IdentityContext> options)
            : base(options)
        {
        }

        public DbSet<lab26Identity.Models.CMS> CMS { get; set; }
    }
}
