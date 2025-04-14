using Nafta.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class NaftaDbContext : DbContext
    {
        public NaftaDbContext() : base("name=DefaultConnection") { }

        public DbSet<User> Users { get; set; }
    }
}
