using DAL.Models;
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
        public NaftaDbContext() : base("Server=JONI\\SQLEXPRESS;Database=Nafta;Integrated Security=True;TrustServerCertificate=True") { }

        public DbSet<User> Users { get; set; }
        public DbSet<EmailVerification> EmailVerifications { get; set; }
    }
}
