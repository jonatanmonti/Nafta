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

                if (expired.Any())
                {
                    context.EmailVerifications.RemoveRange(expired);
                    context.SaveChanges();
                    return expired.Count;
                }

                return 0;
            }
        }
    }
}
