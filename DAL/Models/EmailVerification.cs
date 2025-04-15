using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class EmailVerification
    {
        public int Id { get; set; }

        [Required, MaxLength(64)]
        public string Email { get; set; }

        [Required, MaxLength(10)]
        public string Code { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsVerified { get; set; } = false;
    }
}
