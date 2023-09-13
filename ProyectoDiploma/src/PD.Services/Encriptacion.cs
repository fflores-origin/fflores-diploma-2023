using System.Text;

namespace PD.Services
{
    public static class Encriptacion
    {
        public static string Hash(string input)
        {
            using (var encripter = System.Security.Cryptography.MD5.Create())
            {
                var bytes = Encoding.ASCII.GetBytes(input);
                var hashed = encripter.ComputeHash(bytes);
                return (new ASCIIEncoding()).GetString(hashed);
            }
        }
    }
}