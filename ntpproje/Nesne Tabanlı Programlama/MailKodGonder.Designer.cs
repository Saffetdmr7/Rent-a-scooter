namespace Nesne_Tabanlı_Programlama
{
    partial class MailKodGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailKodGonder));
            this.kodGonder = new System.Windows.Forms.Button();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kodGonder
            // 
            this.kodGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.kodGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodGonder.ForeColor = System.Drawing.SystemColors.Window;
            this.kodGonder.Location = new System.Drawing.Point(129, 534);
            this.kodGonder.Name = "kodGonder";
            this.kodGonder.Size = new System.Drawing.Size(270, 49);
            this.kodGonder.TabIndex = 16;
            this.kodGonder.Text = "Kod Gönder";
            this.kodGonder.UseVisualStyleBackColor = false;
            this.kodGonder.Click += new System.EventHandler(this.kodGonder_Click);
            // 
            // txtEposta
            // 
            this.txtEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEposta.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEposta.Location = new System.Drawing.Point(35, 453);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(453, 45);
            this.txtEposta.TabIndex = 17;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Location = new System.Drawing.Point(35, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(88, 81);
            this.btnGeri.TabIndex = 21;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(30, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mail Adresinizi Giriniz : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // MailKodGonder
            // 
            this.AcceptButton = this.kodGonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(552, 764);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.kodGonder);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MailKodGonder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MailSifre_FormClosing);
            this.Load += new System.EventHandler(this.MailKodGonder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kodGonder;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}