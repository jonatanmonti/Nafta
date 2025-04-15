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
        public int DeleteUnverifiedUsers(TimeSpan expirationTime)
        {
            int deletedCount = 0;

            using (var context = new NaftaDbContext())
            {
                DateTime threshold = DateTime.UtcNow - expirationTime;

                var usersToDelete = context.Users
                    .Where(u => !u.IsVerified && u.CreatedDate < threshold)
                    .ToList();

                if (usersToDelete.Any())
                {
                    context.Users.RemoveRange(usersToDelete);
                    deletedCount = usersToDelete.Count;
                    context.SaveChanges();
                }
            }

            return deletedCount;
        }
    }
}
