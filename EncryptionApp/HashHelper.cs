using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionApp
{
    public class HashHelper
    {

        /// <summary>
        /// Converts the given text to base64 
        /// </summary>
        /// <param name="text">Pure string</param>
        /// <returns></returns>
        public static string EncodeBase64(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Converts the given base64 string to string 
        /// </summary>
        /// <param name="text">Base64 encoded string</param>
        /// <returns></returns>
        public static string DecodeBase64(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(data);
        }

        /// <summary>
        /// Converts the given base64 string to string 
        /// </summary>
        /// <param name="encodedText">Encoded Base64 String</param>
        /// <param name="plainText">Decoded string result</param>
        /// <returns></returns>
        public static bool TryDecode(string encodedText, out string plainText)
        {
            plainText = string.Empty;
            try
            {
                plainText = DecodeBase64(encodedText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Create a data hash
        /// </summary>
        /// <param name="data">The data for calculating the hash</param>
        /// <param name="hashAlgorithm">Hash algorithm</param>
        /// <param name="trimByteCount">The number of bytes, which will be used in the hash algorithm; leave 0 to use all array</param>
        /// <returns>Data hash</returns>
        public static string CreateHash(byte[] data, string hashAlgorithm, int trimByteCount = 0)
        {
            if (string.IsNullOrEmpty(hashAlgorithm))
                throw new ArgumentNullException(nameof(hashAlgorithm));

            var algorithm = (HashAlgorithm)CryptoConfig.CreateFromName(hashAlgorithm);
            if (algorithm == null)
                throw new ArgumentException("Unrecognized hash name");

            if (trimByteCount > 0 && data.Length > trimByteCount)
            {
                var newData = new byte[trimByteCount];
                Array.Copy(data, newData, trimByteCount);

                return BitConverter.ToString(algorithm.ComputeHash(newData)).Replace("-", string.Empty);
            }

            return BitConverter.ToString(algorithm.ComputeHash(data)).Replace("-", string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="randomString"></param>
        /// <returns></returns>
        public static string Sha256(string randomString)
        {
            SHA256Managed shA256Managed = new SHA256Managed();
            StringBuilder stringBuilder = new StringBuilder();
            byte[] bytes = Encoding.UTF8.GetBytes(randomString);
            foreach (byte num in shA256Managed.ComputeHash(bytes))
                stringBuilder.Append(num.ToString("x2"));
            return stringBuilder.ToString();
        }


    }
}
