using System;
using System.Linq;
using DAL.Models;
using Common.Helper;

namespace BLL.Services
{
    public class UserService
    {
        public bool RegisterUser(string firstName, string lastName, string email, string plainPassword, string phone, out string message)
        {
            using (var context = new NaftaDbContext())
            {
                if (context.Users.Any(u => u.Email == email))
                {
                    message = "El email ya está registrado.";
                    return false;
                }

                string hashedPassword = Hasher.Hash(plainPassword);
                string verificationCode = CodeGenerator.GenerateVerificationCode();

                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PasswordHash = hashedPassword,
                    Phone = phone,
                    CreatedDate = DateTime.UtcNow,
                    LastUpdatedDate = DateTime.UtcNow,
                    IsVerified = false,
                    VerificationCode = verificationCode
                };

                context.Users.Add(user);
                context.SaveChanges();

                var emailService = new EmailService();
                if (!emailService.SendVerificationCode(email, verificationCode))
                {
                    message = "No se pudo enviar el correo de verificación.";
                    return false;
                }

                message = "Usuario registrado correctamente. Verifica tu correo.";
                return true;
            }
        }

        public bool VerifyEmailCode(string email, string inputCode, out string message)
        {
            using (var context = new NaftaDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email);

                if (user == null)
                {
                    message = "Usuario no encontrado.";
                    return false;
                }

                if (user.IsVerified)
                {
                    message = "Este correo ya fue verificado.";
                    return false;
                }

                if (user.VerificationCode != inputCode)
                {
                    message = "Código incorrecto.";
                    return false;
                }

                user.IsVerified = true;
                context.SaveChanges();

                message = "¡Correo verificado correctamente!";
                return true;
            }
        }
    }
}
