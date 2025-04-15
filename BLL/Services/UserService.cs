using System;
using System.Linq;
using DAL.Models;
using Common.Helper;
using System.Security.Policy;

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

                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PasswordHash = Hasher.Hash(plainPassword),
                    Phone = phone,
                    CreatedDate = DateTime.UtcNow,
                    LastUpdatedDate = DateTime.UtcNow
                };

                context.Users.Add(user);
                context.SaveChanges();

                string verificationCode = CodeGenerator.GenerateVerificationCode();

                var verif = new EmailVerification
                {
                    Email = email,
                    Code = verificationCode
                };

                context.EmailVerifications.Add(verif);
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

                var verif = context.EmailVerifications
                    .Where(v => v.Email == email)
                    .OrderByDescending(v => v.CreatedAt)
                    .FirstOrDefault();

                if (verif == null)
                {
                    message = "No se encontró solicitud de verificación.";
                    return false;
                }

                if (verif.IsVerified)
                {
                    message = "Este correo ya fue verificado.";
                    return false;
                }

                if (verif.Code != inputCode)
                {
                    message = "Código incorrecto.";
                    return false;
                }

                verif.IsVerified = true;
                context.SaveChanges();

                message = "¡Correo verificado correctamente!";
                return true;
            }
        }
    }
}
