using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cryption;

namespace Test
{
    public partial class CryptTest : Form
    {
        public CryptTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cryption.Crypt crypt = new Cryption.Crypt();
            if (textBox1.Text !="")
            {
                textBox2.Text = crypt.Encryption(textBox1.Text);
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
                Cryption.Crypt crypt = new Cryption.Crypt();
                if (textBox2.Text != "")
                {
                    textBox3.Text = crypt.Decryption(textBox2.Text);
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
            Cryption.Crypt crypt = new Cryption.Crypt();
            if (textBox1.Text != "")
            {
                textBox2.Text = crypt.EncryptPassword(textBox1.Text);
            }
            else
            {
                MessageBox.Show("请输入字符串");
            }
        }
    }
}
