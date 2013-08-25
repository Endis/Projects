using System.Security.Cryptography;
using System.IO;
using System;

namespace Cryption
{
    public class Decryptor
    {
        private DecryptTransformer transformer;
        private byte[] IV { get; set; }//初始化向量

        public Decryptor(EncryptionAlgorithm algId)
        {
            transformer = new DecryptTransformer(algId);
        }
        public byte[] Decrypt(byte[] bytesData, byte[] bytesKey)
        {
            MemoryStream memStreamDecryptedData = new MemoryStream();
            transformer.IV = bytesKey;
            ICryptoTransform transform = transformer.GetCryptoServiceProvider(bytesKey);
            CryptoStream decStream = new CryptoStream(memStreamDecryptedData,transform,CryptoStreamMode.Write);
            try
            {
                decStream.Write(bytesData, 0, bytesData.Length);
            }
            catch (Exception ex)
            {
                throw new Exception("写入解密的数据至流时出错： \n" + ex.Message);
            }
            decStream.FlushFinalBlock();
            decStream.Close();
            return memStreamDecryptedData.ToArray();
        }

    }
}
