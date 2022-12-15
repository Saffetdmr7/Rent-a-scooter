namespace Nesne_Tabanlı_Programlama
{
    partial class EPostaDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPostaDegistir));
            this.txtuserName = new System.Windows.Forms.Label();
            this.txtYeniEposta = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.Onayla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuserName
            // 
            this.txtuserName.AutoSize = true;
            this.txtuserName.Location = new System.Drawing.Point(885, 101);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(0, 16);
            this.txtuserName.TabIndex = 0;
            this.txtuserName.Visible = false;
            // 
            // txtYeniEposta
            // 
            this.txtYeniEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYeniEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtYeniEposta.Location = new System.Drawing.Point(34, 496);
            this.txtYeniEposta.Name = "txtYeniEposta";
            this.txtYeniEposta.Size = new System.Drawing.Size(458, 45);
            this.txtYeniEposta.TabIndex = 18;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(34, 21);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(66, 63);
            this.btnGeri.TabIndex = 21;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Onayla
            // 
            this.Onayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Onayla.ForeColor = System.Drawing.SystemColors.Window;
            this.Onayla.Location = new System.Drawing.Point(124, 569);
            this.Onayla.Name = "Onayla";
            this.Onayla.Size = new System.Drawing.Size(270, 49);
            this.Onayla.TabIndex = 22;
            this.Onayla.Text = "Onayla";
            this.Onayla.UseVisualStyleBackColor = false;
            this.Onayla.Click += new System.EventHandler(this.Onayla_Click);
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
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(29, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Yeni Bir E-Posta Adresi Giriniz : ";
            // 
            // EPostaDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 764);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Onayla);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtYeniEposta);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EPostaDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPostaDegistir";
            this.Load += new System.EventHandler(this.EPostaDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtuserName;
        private System.Windows.Forms.TextBox txtYeniEposta;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button Onayla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}