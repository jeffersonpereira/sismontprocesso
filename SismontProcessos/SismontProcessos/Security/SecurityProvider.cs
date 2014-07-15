using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace SismontProcessos.Security
{
    public static class SecurityProvider
    {
        public static string HashPassword(string pass, string salt)
        {
            byte[] byteArray4 = null;
            HashAlgorithm hashAlgorithm1;
            byte[] byteArray1 = Encoding.Unicode.GetBytes(pass);
            byte[] byteArray2 = Convert.FromBase64String(salt);
            byte[] byteArray3 = new byte[(byteArray2.Length + byteArray1.Length)];
            Buffer.BlockCopy(((Array)byteArray2), 0, ((Array)byteArray3), 0, byteArray2.Length);
            Buffer.BlockCopy(((Array)byteArray1), 0, ((Array)byteArray3), byteArray2.Length, byteArray1.Length);
            hashAlgorithm1 = HashAlgorithm.Create(HashAlgorithmType.Sha1.ToString());
            byteArray4 = hashAlgorithm1.ComputeHash(byteArray3);
            return Convert.ToBase64String(byteArray4);
        }
    }
}