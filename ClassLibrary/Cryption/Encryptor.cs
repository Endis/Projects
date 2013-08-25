using System.Security.Cryptography;
using System;
using System.IO;


namespace Cryption
{
    public class Encryptor
    {
        private EncryptTransformer transformer;

        private byte[] IV { get; set; }//初始化向量
        private byte[] Key { get; set; }//密钥

        public Encryptor(EncryptionAlgorithm algId)
        {
            transformer = new EncryptTransformer(algId);
        }

        public byte[] Encrypt(byte[] bytesData, byte[] bytesKey)
        {
            //创建流保存数据
            MemoryStream memStreamEncryptedData = new MemoryStream();

            transformer.IV = bytesKey;
            ICryptoTransform transform = transformer.GetCryptoServiceProvider(bytesKey);
            CryptoStream encStream = new CryptoStream(memStreamEncryptedData,transform,CryptoStreamMode.Write);
            try
            {
                //加密数据，写入数据至流
                encStream.Write(bytesData, 0, bytesData.Length);
            }
            catch (Exception ex)
            {
                throw new Exception("写入加密的数据至流时出错： \n" + ex.Message);
            }
            //发送初始化向量和密钥给客户端提取
            Key = transformer.Key;
            IV = transformer.IV;
            encStream.FlushFinalBlock();
            encStream.Close();

            //返回数据
            return memStreamEncryptedData.ToArray();
        }

    }
}
