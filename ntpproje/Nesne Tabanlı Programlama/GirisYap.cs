using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Hosting;

namespace Nesne_Tabanlı_Programlama
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Database db = new Database();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.readData("select * from ntpkisi", "");
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if ((dt.Rows[i][0].ToString() == txtEmail.Text || dt.Rows[i][1].ToString() == txtEmail.Text) && dt.Rows[i][2].ToString() == txtPassword.Text)
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.txtkullaniciYadaPosta.Text = txtEmail.Text;
                    anaSayfa.Show();
                    this.Hide();
                    return;
                }

            }
            MessageBox.Show("E posta ya da Şifre hatalı", "Hatalı Giriş");
            txtEmail.Clear();
            txtPassword.Clear();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Kullanıcı Adı  veya E-posta Girin" || txtEmail.Text == "")
            {
                txtEmail.Clear();
            }
            lbl1.Visible = true;
            txtEmail.BorderStyle = BorderStyle.Fixed3D;
            if (txtPassword.Text == "" || txtPassword.Text == "Şifrenizi Girin")
            {
                txtPassword.UseSystemPasswordChar = false;
                label2.Visible = false;
                txtPassword.Text = "Şifrenizi Girin";
            }
            
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Şifrenizi Girin" || txtPassword.Text == "")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
                checkBox1.Checked = false;
            }
            label2.Visible = true;
            if (txtEmail.Text == ""|| txtEmail.Text == "Kullanıcı Adı veya E - posta Girin")
            {
                lbl1.Visible = false;
                txtEmail.Text = "Kullanıcı Adı veya E-posta Girin";
            }
        }
        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            Kaydol kayıt = new Kaydol();
            kayıt.Show();
            this.Hide();
        }
        private void btnSifreUnuttum_Click(object sender, EventArgs e)
        {
            MailKodGonder sifre = new MailKodGonder();
            sifre.Show();
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            this.Height = 1080;
            this.Width = 1920;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
