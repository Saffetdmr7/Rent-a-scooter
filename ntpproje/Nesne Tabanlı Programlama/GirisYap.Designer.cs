namespace Nesne_Tabanlı_Programlama
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnHesapOlustur = new System.Windows.Forms.Button();
            this.btnSifreUnuttum = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(386, 393);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(427, 36);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Kullanıcı Adı  veya E-posta Girin";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(386, 490);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(427, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Şifrenizi Girin";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(380, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifrenizi Girin : ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(259, 849);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hesabın yok mu ?";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(259, 791);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifreni mi unuttun ? ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox1.Location = new System.Drawing.Point(648, 550);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 29);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Black;
            this.btnGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGirisYap.Location = new System.Drawing.Point(487, 626);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(216, 57);
            this.btnGirisYap.TabIndex = 11;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.btnHesapOlustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHesapOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapOlustur.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHesapOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnHesapOlustur.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHesapOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapOlustur.Location = new System.Drawing.Point(597, 849);
            this.btnHesapOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(216, 42);
            this.btnHesapOlustur.TabIndex = 12;
            this.btnHesapOlustur.Text = "Hesap Oluştur";
            this.btnHesapOlustur.UseVisualStyleBackColor = false;
            this.btnHesapOlustur.Click += new System.EventHandler(this.btnHesapOlustur_Click);
            // 
            // btnSifreUnuttum
            // 
            this.btnSifreUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.btnSifreUnuttum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSifreUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifreUnuttum.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSifreUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSifreUnuttum.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSifreUnuttum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSifreUnuttum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSifreUnuttum.Location = new System.Drawing.Point(597, 786);
            this.btnSifreUnuttum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSifreUnuttum.Name = "btnSifreUnuttum";
            this.btnSifreUnuttum.Size = new System.Drawing.Size(216, 42);
            this.btnSifreUnuttum.TabIndex = 13;
            this.btnSifreUnuttum.Text = "Şifremi Unuttum";
            this.btnSifreUnuttum.UseVisualStyleBackColor = false;
            this.btnSifreUnuttum.Click += new System.EventHandler(this.btnSifreUnuttum_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl1.Location = new System.Drawing.Point(380, 360);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(406, 31);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "Kullanıcı Adı  veya E-posta Girin:";
            this.lbl1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(992, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Giris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1035);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSifreUnuttum);
            this.Controls.Add(this.btnHesapOlustur);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_FormClosing);
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnHesapOlustur;
        private System.Windows.Forms.Button btnSifreUnuttum;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Diagnostics.Process process1;
    }
}

