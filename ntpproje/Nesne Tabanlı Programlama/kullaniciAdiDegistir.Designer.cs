namespace Nesne_Tabanlı_Programlama
{
    partial class kullaniciAdiDegistir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciAdiDegistir));
            this.txtYeniUser = new System.Windows.Forms.TextBox();
            this.txtuserName = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnDeğiştir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYeniUser
            // 
            this.txtYeniUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYeniUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtYeniUser.Location = new System.Drawing.Point(39, 488);
            this.txtYeniUser.Name = "txtYeniUser";
            this.txtYeniUser.Size = new System.Drawing.Size(415, 36);
            this.txtYeniUser.TabIndex = 18;
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(405, 12);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(10, 23);
            this.txtuserName.TabIndex = 19;
            this.txtuserName.Text = "label1";
            this.txtuserName.Visible = false;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Location = new System.Drawing.Point(39, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(67, 67);
            this.btnGeri.TabIndex = 20;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnDeğiştir
            // 
            this.btnDeğiştir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.btnDeğiştir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeğiştir.Location = new System.Drawing.Point(144, 544);
            this.btnDeğiştir.Name = "btnDeğiştir";
            this.btnDeğiştir.Size = new System.Drawing.Size(192, 40);
            this.btnDeğiştir.TabIndex = 21;
            this.btnDeğiştir.Text = "Değiştir";
            this.btnDeğiştir.UseVisualStyleBackColor = false;
            this.btnDeğiştir.Click += new System.EventHandler(this.btnDeğiştir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(39, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Yeni Bir Kullanıcı Adı Giriniz : ";
            // 
            // kullaniciAdiDegistir
            // 
            this.AcceptButton = this.btnDeğiştir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(552, 764);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeğiştir);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.txtYeniUser);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kullaniciAdiDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciAdiDegistir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kullaniciAdiDegistir_FormClosing);
            this.Load += new System.EventHandler(this.kullaniciAdiDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtYeniUser;
        public System.Windows.Forms.Label txtuserName;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnDeğiştir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}