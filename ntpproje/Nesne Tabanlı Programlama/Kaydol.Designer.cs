namespace Nesne_Tabanlı_Programlama
{
    partial class Kaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaydol));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCheckPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxAge = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(227, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı Giriniz : ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(227, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre Giriniz : ";
            this.label5.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(227, 590);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(415, 36);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Text = "kullanıcı adı giriniz";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(227, 670);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(415, 36);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "Şifre Giriniz";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtCheckPassword
            // 
            this.txtCheckPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCheckPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtCheckPassword.Location = new System.Drawing.Point(227, 750);
            this.txtCheckPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckPassword.Name = "txtCheckPassword";
            this.txtCheckPassword.Size = new System.Drawing.Size(415, 36);
            this.txtCheckPassword.TabIndex = 13;
            this.txtCheckPassword.Text = "Tekrar Şifre Giriniz";
            this.txtCheckPassword.Click += new System.EventHandler(this.txtCheckPassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(227, 720);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tekrar Şifre Giriniz : ";
            this.label6.Visible = false;
            // 
            // cmbxAge
            // 
            this.cmbxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxAge.ForeColor = System.Drawing.Color.Gray;
            this.cmbxAge.FormattingEnabled = true;
            this.cmbxAge.ItemHeight = 29;
            this.cmbxAge.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "60+"});
            this.cmbxAge.Location = new System.Drawing.Point(227, 430);
            this.cmbxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxAge.Name = "cmbxAge";
            this.cmbxAge.Size = new System.Drawing.Size(415, 37);
            this.cmbxAge.TabIndex = 18;
            this.cmbxAge.Click += new System.EventHandler(this.cmbxAge_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtemail.ForeColor = System.Drawing.Color.Gray;
            this.txtemail.Location = new System.Drawing.Point(227, 510);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(415, 36);
            this.txtemail.TabIndex = 20;
            this.txtemail.Text = "e-posta";
            this.txtemail.Click += new System.EventHandler(this.txtemail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(227, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "E-Posta : ";
            this.label3.Visible = false;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.btnOlustur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOlustur.Location = new System.Drawing.Point(476, 862);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(216, 57);
            this.btnOlustur.TabIndex = 22;
            this.btnOlustur.Text = "Hesap Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(227, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad-Soyad Giriniz : ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(227, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Yaş giriniz : ";
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Location = new System.Drawing.Point(227, 25);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(88, 81);
            this.btnGeri.TabIndex = 25;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSifreGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBoxSifreGoster.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxSifreGoster.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(648, 762);
            this.checkBoxSifreGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(148, 24);
            this.checkBoxSifreGoster.TabIndex = 26;
            this.checkBoxSifreGoster.Text = "Şifreyi Göster";
            this.checkBoxSifreGoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSifreGoster.UseVisualStyleBackColor = false;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreGoster_CheckedChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFullName.ForeColor = System.Drawing.Color.Gray;
            this.txtFullName.Location = new System.Drawing.Point(227, 361);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(415, 36);
            this.txtFullName.TabIndex = 28;
            this.txtFullName.Text = "Ad-Soyad Giriniz";
            this.txtFullName.Click += new System.EventHandler(this.txtFullName_Click);
            // 
            // Kaydol
            // 
            this.AcceptButton = this.btnOlustur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1924, 1035);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.checkBoxSifreGoster);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCheckPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmbxAge);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Kaydol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kaydol_FormClosing);
            this.Load += new System.EventHandler(this.Kaydol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCheckPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxAge;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
        private System.Windows.Forms.TextBox txtFullName;
    }
}