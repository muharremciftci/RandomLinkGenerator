using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomLinkGenerator
{
    class Program
    {

        public static string GenerateUniqueRandomToken(int uniqueId)
        // generates a unique, random, and alphanumeric token
        {
            const string availableChars =
                "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            using (var generator = new RNGCryptoServiceProvider())
            {
                var bytes = new byte[16];
                generator.GetBytes(bytes);
                var chars = bytes
                    .Select(b => availableChars[b % availableChars.Length]);
                var token = new string(chars.ToArray());
                return uniqueId + token;
            }
        }


        static void Main(string[] args)
        {

            string denemelinki = " ";

            string link = "http://bazaaronline.com/";

            denemelinki = GenerateUniqueRandomToken(1);

            Console.WriteLine(link + denemelinki);
            Console.Read();

        }
    }
}
