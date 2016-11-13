using System;
using System.Text;
using System.Security.Cryptography;

namespace Rework
{
    public static class Crypto
    {
        public enum SHA_Type
        {
            SHA1 = 0,
            SHA256 = 1,
            SHA512 = 2
        }

        public static string ToSHA(this string inputString, SHA_Type shaType)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = GetHash(shaType, bytes);
            return GetStringFromHash(hash);
        }

        private static byte[] GetHash(SHA_Type shaType, byte[] bytes)
        {
            byte[] hash = null;
            switch (shaType)
            {
                case SHA_Type.SHA1:
                    SHA1 sha1 = SHA1Managed.Create();
                    hash = sha1.ComputeHash(bytes);
                    break;
                case SHA_Type.SHA256:
                    SHA256 sha256 = SHA256Managed.Create();
                    hash = sha256.ComputeHash(bytes);
                    break;
                case SHA_Type.SHA512:
                    SHA512 sha512 = SHA512Managed.Create();
                    hash = sha512.ComputeHash(bytes);
                    break;
                default:
                    throw new NotSupportedException();
            }

            return hash;
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

    }
}


