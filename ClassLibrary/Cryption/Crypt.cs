using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Cryption
{
     public class Crypt
    {
         string DesKey = "CRYPTION";

         public string Encryption(string inputString)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = System.Text.Encoding.Default.GetBytes(inputString);
            des.Key = ASCIIEncoding.ASCII.GetBytes(DesKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(DesKey);
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, des.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
            cryptoStream.FlushFinalBlock();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in memoryStream.ToArray())
            {
                stringBuilder.AppendFormat("{0:X2}", b);
            }
            stringBuilder.ToString();
            return stringBuilder.ToString();
        }

         public string Decryption(string inputString)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = new byte[inputString.Length / 2];
            for (int x = 0; x < inputString.Length / 2; x++)
            {
                int i = (Convert.ToInt32(inputString.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(DesKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(DesKey);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, des.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
            cryptoStream.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            return System.Text.Encoding.Default.GetString(memoryStream.ToArray());
        }

         public string EncryptPassword(string password)
         {
             System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
             byte[] inputByteArray = System.Text.Encoding.ASCII.GetBytes(password + DesKey);
             StringBuilder stringBuilder = new StringBuilder();
             foreach (byte b in inputByteArray)
             {
                 stringBuilder.AppendFormat("{0:X2}", b);
             }
             inputByteArray = x.ComputeHash(inputByteArray);
             return System.Text.Encoding.ASCII.GetString(inputByteArray);
         }
	}
}
