using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniWebApp.Models
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<User> Users { get; set; }
    }
}
