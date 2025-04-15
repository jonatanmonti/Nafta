using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public static class CodeGenerator
    {
        public static string GenerateVerificationCode(int length = 6)
        {
            var random = new Random();
            var code = new StringBuilder();

            for (int i = 0; i < length; i++)
                code.Append(random.Next(0, 10)); // dígitos 0-9

            return code.ToString();
        }
    }
}
