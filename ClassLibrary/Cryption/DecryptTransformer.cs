using System.Security.Cryptography;

namespace Cryption
{
    internal class DecryptTransformer
    {
        private EncryptionAlgorithm algorithmID;

        internal byte[] IV { get; set; }//初始化向量

        internal DecryptTransformer(EncryptionAlgorithm deCryptId)
        {
            algorithmID = deCryptId;
        }
        internal ICryptoTransform GetCryptoServiceProvider(byte[] bytesKey)
        {
            // 获取解密服务端の提供者
            switch (algorithmID)
            {
                case EncryptionAlgorithm.Des:
                    {
                        DES des = new DESCryptoServiceProvider();
                        des.Mode = CipherMode.CBC;
                        des.Key = bytesKey;
                        des.IV = IV;
                        return des.CreateDecryptor();
                    }
                case EncryptionAlgorithm.TripleDes:
                    {
                        TripleDES tripleDes = new TripleDESCryptoServiceProvider();
                        tripleDes.Mode = CipherMode.CBC;
                        return tripleDes.CreateDecryptor(bytesKey, IV);
                    }
                case EncryptionAlgorithm.Rc2:
                    {
                        RC2 rc2 = new RC2CryptoServiceProvider();
                        rc2.Mode = CipherMode.CBC;
                        return rc2.CreateDecryptor(bytesKey, IV);
                    }
                case EncryptionAlgorithm.Rijndael:
                    {
                        Rijndael rijndael = new RijndaelManaged();
                        rijndael.Mode = CipherMode.CBC;
                        return rijndael.CreateDecryptor(bytesKey, IV);
                    }
                default:
                    {
                        throw new CryptographicException("不支持の" + "解密算法ID： '" + algorithmID + "' ");
                    }
            }
        }

    }
}
