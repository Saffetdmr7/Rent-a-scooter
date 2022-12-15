namespace Nesne_Tabanlı_Programlama
{
    partial class KodGir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KodGir));
            this.txtKodBak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dogrulamakodu = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.Label();
            this.dakika = new System.Windows.Forms.Timer(this.components);
            this.saniye = new System.Windows.Forms.Timer(this.components);
            this.minute = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnDoğrula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKodBak
            // 
            this.txtKodBak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodBak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtKodBak.Location = new System.Drawing.Point(51, 513);
            this.txtKodBak.Name = "txtKodBak";
            this.txtKodBak.Size = new System.Drawing.Size(415, 36);
            this.txtKodBak.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(47, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kodu giriniz : ";
            // 
            // dogrulamakodu
            // 
            this.dogrulamakodu.BackColor = System.Drawing.SystemColors.Window;
            this.dogrulamakodu.Location = new System.Drawing.Point(289, 47);
            this.dogrulamakodu.Name = "dogrulamakodu";
            this.dogrulamakodu.Size = new System.Drawing.Size(21, 10);
            this.dogrulamakodu.TabIndex = 14;
            this.dogrulamakodu.Visible = false;
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.SystemColors.Window;
            this.txtEposta.Location = new System.Drawing.Point(289, 25);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(49, 10);
            this.txtEposta.TabIndex = 15;
            this.txtEposta.Visible = false;
            // 
            // dakika
            // 
            this.dakika.Tick += new System.EventHandler(this.dakika_Tick);
            // 
            // saniye
            // 
            this.saniye.Tick += new System.EventHandler(this.saniye_Tick);
            // 
            // minute
            // 
            this.minute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minute.ForeColor = System.Drawing.SystemColors.Window;
            this.minute.Location = new System.Drawing.Point(176, 407);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(80, 25);
            this.minute.TabIndex = 21;
            this.minute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.second.ForeColor = System.Drawing.SystemColors.Window;
            this.second.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.second.Location = new System.Drawing.Point(276, 407);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(80, 25);
            this.second.TabIndex = 22;
            this.second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(255, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = " : ";
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Location = new System.Drawing.Point(30, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(67, 67);
            this.btnGeri.TabIndex = 24;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnDoğrula
            // 
            this.btnDoğrula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.btnDoğrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoğrula.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDoğrula.Location = new System.Drawing.Point(181, 591);
            this.btnDoğrula.Name = "btnDoğrula";
            this.btnDoğrula.Size = new System.Drawing.Size(175, 42);
            this.btnDoğrula.TabIndex = 25;
            this.btnDoğrula.Text = "Doğrula";
            this.btnDoğrula.UseVisualStyleBackColor = false;
            this.btnDoğrula.Click += new System.EventHandler(this.btnDoğrula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // KodGir
            // 
            this.AcceptButton = this.btnDoğrula;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(552, 764);
            this.Controls.Add(this.btnDoğrula);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.dogrulamakodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKodBak);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KodGir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KodGir_FormClosing);
            this.Load += new System.EventHandler(this.KodGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKodBak;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label dogrulamakodu;
        public System.Windows.Forms.Label txtEposta;
        private System.Windows.Forms.Timer dakika;
        private System.Windows.Forms.Timer saniye;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnDoğrula;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}