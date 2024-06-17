using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCtutorial.Models;

namespace MVCtutorial.Data
{
    public class MVCtutorialContext : DbContext
    {
        public MVCtutorialContext (DbContextOptions<MVCtutorialContext> options)
            : base(options)
        {
        }

        public DbSet<MVCtutorial.Models.Movie> Movie { get; set; } = default!;
    }
}
