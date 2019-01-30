using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment_2.Models;

namespace Assignment_2.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext (DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment_2.Models.User> User { get; set; }

        public DbSet<Assignment_2.Models.Member> Member { get; set; }

        public DbSet<Assignment_2.Models.Project> Project { get; set; }
    }
}