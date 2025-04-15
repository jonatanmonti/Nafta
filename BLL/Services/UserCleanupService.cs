using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserCleanupService
    {
        public int DeleteExpiredVerifications(TimeSpan expirationTime)
        {
            using (var context = new NaftaDbContext())
            {
                DateTime threshold = DateTime.UtcNow - expirationTime;

                var expired = context.EmailVerifications
                    .Where(v => !v.IsVerified && v.CreatedAt < threshold)
                    .ToList();

                int removed = 0;

                foreach (var verif in expired)
                {
                    var user = context.Users.FirstOrDefault(u => u.Email == verif.Email);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                    }
                    context.EmailVerifications.Remove(verif);
                    removed++;
                }

                if (removed > 0)
                {
                    context.SaveChanges();
                }

                return removed;
            }
        }
    }
}
