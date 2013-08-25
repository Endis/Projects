using System;
using System.Windows.Forms;
using Cryption;
using System.Text;

namespace Test
{
    public partial class CryptTest : Form
    {
        EncryptionAlgorithm encryptionAlgorithm;
        public CryptTest()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crypt crypt = new Crypt();
            if (tbString.Text !="")
            {
                tbEncrypt.Text = crypt.Encryption(tbString.Text);
            }
            else
            {
                MessageBox.Show("请输入字符串");
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Crypt crypt = new Crypt();
                if (tbEncrypt.Text != "")
                {
                    tbDecrypt.Text = crypt.Decryption(tbEncrypt.Text);
                }
                else
                {
                    MessageBox.Show("请输入加密后的字符串");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("无法识别的字符...解密失败！");
            }
        }

        private void PwdCryptBtn_Click(object sender, EventArgs e)
        {
            Crypt crypt = new Crypt();
            if (tbString.Text != "")
            {
                tbEncrypt.Text = crypt.EncryptPassword(tbString.Text);
            }
            else
            {
                MessageBox.Show("请输入字符串");
            }
        }

        private void EncryptorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButtonSelect();
                Encryptor encryptor = new Encryptor(encryptionAlgorithm);
                if (tbString.Text != "")
                {
                    Byte[] bt = encryptor.Encrypt(System.Text.Encoding.Default.GetBytes(tbString.Text), Encoding.Default.GetBytes(tbKey.Text));
                    tbEncrypt.Text = Convert.ToBase64String(bt);
                }
                else
                {
                    MessageBox.Show("请输入字符串");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("加密失败，确认密钥是否符合数位要求！"); 
            }
        }

        private void DecryptorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButtonSelect();
                Decryptor decryptor = new Decryptor(encryptionAlgorithm);
                if (tbEncrypt.Text != "")
                {
                    Byte[] bt = decryptor.Decrypt(Convert.FromBase64String(tbEncrypt.Text), System.Text.Encoding.Default.GetBytes(tbKey.Text));
                    tbDecrypt.Text = Encoding.Default.GetString(bt);
                }
                else
                {
                    MessageBox.Show("请输入字符串");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("加密失败，确认密钥是否符合数位要求,或者，字符串是否有效...");
            }
        }
        private void RadioButtonSelect()
        {
            if (Rc2Rdbtn.Checked)
            {
                encryptionAlgorithm = EncryptionAlgorithm.Rc2;
            }
            else if (RijndaelRdbtn.Checked)
            {
                encryptionAlgorithm = EncryptionAlgorithm.Rijndael;
            }
            else if (TripleDesRdbtn.Checked)
            {
                encryptionAlgorithm = EncryptionAlgorithm.TripleDes;
            }
            else
            {
                encryptionAlgorithm = EncryptionAlgorithm.Des;
            }
        }
    }
}
