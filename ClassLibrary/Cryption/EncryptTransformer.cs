using System.Security.Cryptography;

namespace Cryption
{
    public enum EncryptionAlgorithm { Des = 1, Rc2, Rijndael, TripleDes };
    internal class EncryptTransformer
    {
        private EncryptionAlgorithm algorithmID;

        internal byte[] IV { get; set; }//初始化向量
        internal byte[] Key { get; set; }//密钥
        
        internal EncryptTransformer(EncryptionAlgorithm algId)
        {
            //记录采用的算法
            algorithmID = algId;
        }

        internal ICryptoTransform GetCryptoServiceProvider(byte[] bytesKey)
        {
            // 选择加密客户端の提供者
            switch (algorithmID)
            {
                case EncryptionAlgorithm.Des:
                    {
                        DES des = new DESCryptoServiceProvider();
                        des.Mode = CipherMode.CBC;

                        // 判断密钥是否提供
                        if (null == bytesKey)
                        {
                            Key = des.Key;
                        }
                        else
                        {
                            des.Key = bytesKey;
                            Key = des.Key;
                        }
                        //判断客户端是否提供一个初始化向量
                        if (null == IV)//不存在
                        {
                            //创建向量
                            IV = des.IV;
                        }
                        else//存在
                        {
                            //赋值给算法
                            des.IV = IV;
                        }
                        return des.CreateEncryptor();
                    }
                case EncryptionAlgorithm.TripleDes:
                    {
                        TripleDES tripleDES = new TripleDESCryptoServiceProvider();
                        tripleDES.Mode = CipherMode.CBC;
                        if (null == bytesKey)
                        {
                            Key = tripleDES.Key;
                        }
                        else
                        {
                            tripleDES.Key = bytesKey;
                            Key = tripleDES.Key;
                        }
                        if (null == IV)
                        {
                            IV = tripleDES.IV;
                        }
                        else
                        {
                            tripleDES.IV = IV;
                        }
                        return tripleDES.CreateEncryptor();
                    }
                case EncryptionAlgorithm.Rc2:
                    {
                        RC2 rc2 = new RC2CryptoServiceProvider();
                        rc2.Mode = CipherMode.CBC;
                        if (null == bytesKey)
                        {
                            Key = rc2.Key;
                        }
                        else
                        {
                            rc2.Key = bytesKey;
                            Key = rc2.Key;
                        }
                        if (null == IV)
                        {
                            IV = rc2.IV;
                        }
                        else
                        {
                            rc2.IV = IV;
                        }
                        return rc2.CreateEncryptor();
                    }
                case EncryptionAlgorithm.Rijndael:
                    {
                        Rijndael rijndael = new RijndaelManaged();
                        rijndael.Mode = CipherMode.CBC;
                        if (null == bytesKey)
                        {
                            Key = rijndael.Key;
                        }
                        else
                        {
                            rijndael.Key = bytesKey;
                            Key = rijndael.Key;
                        }
                        if (null == IV)
                        {
                            IV = rijndael.IV;
                        }
                        else
                        {
                            rijndael.IV = IV;
                        }
                        return rijndael.CreateEncryptor();
                    }
                default:
                    {
                        throw new CryptographicException("不支持の" + "加密算法ID： '" + algorithmID + "' ");
                    }
            }
        }
    }
}
