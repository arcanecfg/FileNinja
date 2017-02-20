using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FileNinja
{
    class AES
    {

        public static byte[] Encrypt(byte[] rawBytes, string password)
        {
            RijndaelManaged AES = new RijndaelManaged();
            byte[] hash = new byte[32];
            byte[] temp = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(password));
            System.Buffer.BlockCopy(temp, 0, hash, 0, 16);
            System.Buffer.BlockCopy(temp, 0, hash, 15, 16);
            AES.Key = hash;
            AES.Mode = CipherMode.ECB;
            ICryptoTransform AESEncrypter = AES.CreateEncryptor();
            return AESEncrypter.TransformFinalBlock(rawBytes, 0, rawBytes.Length);
        }


        public static byte[] Decrypt(byte[] rawBytes, string password)
        {
            RijndaelManaged AES = new RijndaelManaged();
            byte[] hash = new byte[32];
            byte[] temp = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(password));
            System.Buffer.BlockCopy(temp, 0, hash, 0, 16);
            System.Buffer.BlockCopy(temp, 0, hash, 15, 16);
            AES.Key = hash;
            AES.Mode = CipherMode.ECB;
            ICryptoTransform AESDecrypter = AES.CreateDecryptor();
            return AESDecrypter.TransformFinalBlock(rawBytes, 0, rawBytes.Length);
        }
    }
}
