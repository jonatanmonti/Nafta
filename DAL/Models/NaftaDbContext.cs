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
        public NaftaDbContext() : base("Server=DESKTOP-MUCUS81\\SQLEXPRESS01;Database=Nafta;Integrated Security=True;TrustServerCertificate=True") { }

        public DbSet<User> Users { get; set; }
    }
}
