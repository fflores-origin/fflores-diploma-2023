using System.Text;

namespace PD.Services
{
    public static class Encryption
    {
        public static string GenerateHash(string input)
        {
            using (var encripter = System.Security.Cryptography.MD5.Create())
            {
                var bytes = Encoding.ASCII.GetBytes(input);
                var hashed = encripter.ComputeHash(bytes);
                return (new ASCIIEncoding()).GetString(hashed);
            }
        }

        public static string Encrypt(string input)
        {
            return input;
        }

        public static string Decrypt(string input)
        {
            return input;
        }
    }
}