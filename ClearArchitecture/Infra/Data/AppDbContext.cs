using Domain.Entities;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    internal class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        public DbSet<AreaEntities> Areas { get; set; }
        public DbSet<UserEntities> Users { get; set; }
        
    }
}
