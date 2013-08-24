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
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PwdCryptBtn = new System.Windows.Forms.Button();
            this.CryptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(114, 197);
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
            this.CryptPanel.Controls.Add(this.PwdCryptBtn);
            this.CryptPanel.Controls.Add(this.textBox3);
            this.CryptPanel.Controls.Add(this.label3);
            this.CryptPanel.Controls.Add(this.textBox2);
            this.CryptPanel.Controls.Add(this.label1);
            this.CryptPanel.Controls.Add(this.textBox1);
            this.CryptPanel.Controls.Add(this.label2);
            this.CryptPanel.Controls.Add(this.DecryptBtn);
            this.CryptPanel.Controls.Add(this.EncryptBtn);
            this.CryptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptPanel.Location = new System.Drawing.Point(0, 0);
            this.CryptPanel.Name = "CryptPanel";
            this.CryptPanel.Size = new System.Drawing.Size(408, 253);
            this.CryptPanel.TabIndex = 2;
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(207, 197);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(75, 23);
            this.DecryptBtn.TabIndex = 2;
            this.DecryptBtn.Text = "解密";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "加密后字符串：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 21);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "解密后字符串：";
            // 
            // PwdCryptBtn
            // 
            this.PwdCryptBtn.Location = new System.Drawing.Point(303, 197);
            this.PwdCryptBtn.Name = "PwdCryptBtn";
            this.PwdCryptBtn.Size = new System.Drawing.Size(75, 23);
            this.PwdCryptBtn.TabIndex = 9;
            this.PwdCryptBtn.Text = "密码加密";
            this.PwdCryptBtn.UseVisualStyleBackColor = true;
            this.PwdCryptBtn.Click += new System.EventHandler(this.PwdCryptBtn_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Controls.Add(this.CryptPanel);
            this.Name = "TestForm";
            this.Text = "测试窗口";
            this.CryptPanel.ResumeLayout(false);
            this.CryptPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Panel CryptPanel;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Button PwdCryptBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

