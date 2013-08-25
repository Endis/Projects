namespace Test
{
    partial class CryptTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.CryptPanel = new System.Windows.Forms.Panel();
            this.DecryptorBtn = new System.Windows.Forms.Button();
            this.EncryptorBtn = new System.Windows.Forms.Button();
            this.PwdCryptBtn = new System.Windows.Forms.Button();
            this.tbDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DesRdbtn = new System.Windows.Forms.RadioButton();
            this.RijndaelRdbtn = new System.Windows.Forms.RadioButton();
            this.Rc2Rdbtn = new System.Windows.Forms.RadioButton();
            this.TripleDesRdbtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CryptPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(317, 106);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(75, 23);
            this.EncryptBtn.TabIndex = 0;
            this.EncryptBtn.Text = "加密";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CryptPanel
            // 
            this.CryptPanel.BackColor = System.Drawing.SystemColors.Info;
            this.CryptPanel.Controls.Add(this.tbKey);
            this.CryptPanel.Controls.Add(this.label5);
            this.CryptPanel.Controls.Add(this.label4);
            this.CryptPanel.Controls.Add(this.panel1);
            this.CryptPanel.Controls.Add(this.DecryptorBtn);
            this.CryptPanel.Controls.Add(this.EncryptorBtn);
            this.CryptPanel.Controls.Add(this.PwdCryptBtn);
            this.CryptPanel.Controls.Add(this.tbDecrypt);
            this.CryptPanel.Controls.Add(this.label3);
            this.CryptPanel.Controls.Add(this.tbEncrypt);
            this.CryptPanel.Controls.Add(this.label1);
            this.CryptPanel.Controls.Add(this.tbString);
            this.CryptPanel.Controls.Add(this.label2);
            this.CryptPanel.Controls.Add(this.DecryptBtn);
            this.CryptPanel.Controls.Add(this.EncryptBtn);
            this.CryptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptPanel.Location = new System.Drawing.Point(0, 0);
            this.CryptPanel.Name = "CryptPanel";
            this.CryptPanel.Size = new System.Drawing.Size(408, 253);
            this.CryptPanel.TabIndex = 2;
            // 
            // DecryptorBtn
            // 
            this.DecryptorBtn.Location = new System.Drawing.Point(317, 193);
            this.DecryptorBtn.Name = "DecryptorBtn";
            this.DecryptorBtn.Size = new System.Drawing.Size(75, 23);
            this.DecryptorBtn.TabIndex = 11;
            this.DecryptorBtn.Text = "选择解密";
            this.DecryptorBtn.UseVisualStyleBackColor = true;
            this.DecryptorBtn.Click += new System.EventHandler(this.DecryptorBtn_Click);
            // 
            // EncryptorBtn
            // 
            this.EncryptorBtn.Location = new System.Drawing.Point(317, 135);
            this.EncryptorBtn.Name = "EncryptorBtn";
            this.EncryptorBtn.Size = new System.Drawing.Size(75, 23);
            this.EncryptorBtn.TabIndex = 10;
            this.EncryptorBtn.Text = "选择加密";
            this.EncryptorBtn.UseVisualStyleBackColor = true;
            this.EncryptorBtn.Click += new System.EventHandler(this.EncryptorBtn_Click);
            // 
            // PwdCryptBtn
            // 
            this.PwdCryptBtn.Location = new System.Drawing.Point(317, 222);
            this.PwdCryptBtn.Name = "PwdCryptBtn";
            this.PwdCryptBtn.Size = new System.Drawing.Size(75, 23);
            this.PwdCryptBtn.TabIndex = 9;
            this.PwdCryptBtn.Text = "密码加密";
            this.PwdCryptBtn.UseVisualStyleBackColor = true;
            this.PwdCryptBtn.Click += new System.EventHandler(this.PwdCryptBtn_Click);
            // 
            // tbDecrypt
            // 
            this.tbDecrypt.Location = new System.Drawing.Point(107, 86);
            this.tbDecrypt.Name = "tbDecrypt";
            this.tbDecrypt.Size = new System.Drawing.Size(197, 21);
            this.tbDecrypt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "解密后字符串：";
            // 
            // tbEncrypt
            // 
            this.tbEncrypt.Location = new System.Drawing.Point(106, 53);
            this.tbEncrypt.Name = "tbEncrypt";
            this.tbEncrypt.Size = new System.Drawing.Size(197, 21);
            this.tbEncrypt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "加密后字符串：";
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(106, 20);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(197, 21);
            this.tbString.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入字符串：";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(317, 164);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(75, 23);
            this.DecryptBtn.TabIndex = 2;
            this.DecryptBtn.Text = "解密";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TripleDesRdbtn);
            this.panel1.Controls.Add(this.Rc2Rdbtn);
            this.panel1.Controls.Add(this.RijndaelRdbtn);
            this.panel1.Controls.Add(this.DesRdbtn);
            this.panel1.Location = new System.Drawing.Point(111, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 73);
            this.panel1.TabIndex = 12;
            // 
            // DesRdbtn
            // 
            this.DesRdbtn.AutoSize = true;
            this.DesRdbtn.Checked = true;
            this.DesRdbtn.Location = new System.Drawing.Point(16, 13);
            this.DesRdbtn.Name = "DesRdbtn";
            this.DesRdbtn.Size = new System.Drawing.Size(41, 16);
            this.DesRdbtn.TabIndex = 0;
            this.DesRdbtn.TabStop = true;
            this.DesRdbtn.Text = "DES";
            this.DesRdbtn.UseVisualStyleBackColor = true;
            // 
            // RijndaelRdbtn
            // 
            this.RijndaelRdbtn.AutoSize = true;
            this.RijndaelRdbtn.Location = new System.Drawing.Point(63, 13);
            this.RijndaelRdbtn.Name = "RijndaelRdbtn";
            this.RijndaelRdbtn.Size = new System.Drawing.Size(71, 16);
            this.RijndaelRdbtn.TabIndex = 1;
            this.RijndaelRdbtn.Text = "Rijndael";
            this.RijndaelRdbtn.UseVisualStyleBackColor = true;
            // 
            // Rc2Rdbtn
            // 
            this.Rc2Rdbtn.AutoSize = true;
            this.Rc2Rdbtn.Location = new System.Drawing.Point(16, 42);
            this.Rc2Rdbtn.Name = "Rc2Rdbtn";
            this.Rc2Rdbtn.Size = new System.Drawing.Size(41, 16);
            this.Rc2Rdbtn.TabIndex = 2;
            this.Rc2Rdbtn.Text = "Rc2";
            this.Rc2Rdbtn.UseVisualStyleBackColor = true;
            // 
            // TripleDesRdbtn
            // 
            this.TripleDesRdbtn.AutoSize = true;
            this.TripleDesRdbtn.Location = new System.Drawing.Point(63, 42);
            this.TripleDesRdbtn.Name = "TripleDesRdbtn";
            this.TripleDesRdbtn.Size = new System.Drawing.Size(77, 16);
            this.TripleDesRdbtn.TabIndex = 3;
            this.TripleDesRdbtn.Text = "TripleDes";
            this.TripleDesRdbtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "算法选择：";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(108, 123);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(197, 21);
            this.tbKey.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "算法密钥：";
            // 
            // CryptTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Controls.Add(this.CryptPanel);
            this.Name = "CryptTest";
            this.Text = "测试窗口";
            this.CryptPanel.ResumeLayout(false);
            this.CryptPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Panel CryptPanel;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Button PwdCryptBtn;
        private System.Windows.Forms.TextBox tbDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DecryptorBtn;
        private System.Windows.Forms.Button EncryptorBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton TripleDesRdbtn;
        private System.Windows.Forms.RadioButton Rc2Rdbtn;
        private System.Windows.Forms.RadioButton RijndaelRdbtn;
        private System.Windows.Forms.RadioButton DesRdbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label5;
    }
}

