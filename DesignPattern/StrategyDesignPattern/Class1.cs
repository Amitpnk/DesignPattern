using System;
using System.Security.Cryptography;
using System.Text;

namespace StrategyDesignPattern
{
    public abstract class HashingStrategy
    {
        public abstract string GenerateHash(string text);
    }

    public class HashingContext
    {
        private HashingStrategy _hashingStrategy;

        public HashingContext(HashingStrategy hashingStrategy)
        {
            _hashingStrategy = hashingStrategy;
        }

        public string HashPassword(string text)
        {
            return _hashingStrategy.GenerateHash(text);
        }
    }

    public class MD5Hash : HashingStrategy
    {
        public override string GenerateHash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);

            Byte[] encodedBytes;
            encodedBytes = md5.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes);
        }
    }


    public class SHA1Hash : HashingStrategy
    {
        public override string GenerateHash(string text)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);

            Byte[] encodedBytes;
            encodedBytes = sha1.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes);
        }
    }

    public class SHA256Hash : HashingStrategy
    {
        public override string GenerateHash(string text)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);

            Byte[] encodedBytes;
            encodedBytes = sha256.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes);
        }
    }

    public class SHA384Hash : HashingStrategy
    {
        public override string GenerateHash(string text)
        {
            SHA384 sha384 = new SHA384CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);

            Byte[] encodedBytes;
            encodedBytes = sha384.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes);
        }
    }
}
