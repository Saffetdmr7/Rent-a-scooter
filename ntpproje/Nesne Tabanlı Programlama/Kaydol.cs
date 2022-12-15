using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanlı_Programlama
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Database db = new Database();
        private void Kaydol_Load(object sender, EventArgs e)
        {
            this.Height = 1080;
            this.Width = 1920;
        }
        private void Kaydol_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris yeni = new Giris();
            yeni.Show();
            this.Hide();
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            #region // Mantıksal Değişkenler Atanır
            bool b1 = txtFullName.Text != "" && cmbxAge.Text != ""
                && txtUserName.Text != "" && txtPassword.Text != ""
                && txtCheckPassword.Text != "" && txtemail.Text != "";
            bool b2 = txtFullName.Text != "Ad-Soyad Giriniz" && cmbxAge.Text != "Yaş giriniz" &&
                txtUserName.Text != "Kullanıcı Adı Giriniz" && txtPassword.Text != "Şifre Giriniz" &&
                txtCheckPassword.Text != "Tekrar Şifre Giriniz" && txtemail.Text != "E-Posta";
            #endregion
            if (b1 && b2)
            {
                if (txtCheckPassword.Text == txtPassword.Text)
                {
                    if (txtUserName.Text == txtemail.Text)
                    {
                        MessageBox.Show("Yazdığınız E-Posta ve Kullanıcı Aynı olamaz", "Kayıt olmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtemail.Clear();
                        txtUserName.Clear();
                        return;
                    }
                    dt.Clear();
                    dt = db.readData("select * from ntpkisi", "");
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        if ((dt.Rows[i][0].ToString() == txtUserName.Text) || (dt.Rows[i][1].ToString() == txtemail.Text))
                        {
                            MessageBox.Show("Yazdığınız E-Posta veya Kullanıcı Adı Alınmış", "Kayıt olmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtemail.Clear();
                            txtUserName.Clear();
                            return;
                        }

                    }
                    addDelete yenile = new addDelete();
                    if ((yenile.epostaKontrol(txtemail.Text)))
                    {
                        if ((yenile.sifreKontrol(txtPassword.Text)))
                        {
                            #region// Veritabanı ekleme işlemi
                            yenile.ekle(txtUserName.Text, txtemail.Text, txtPassword.Text, txtFullName.Text, cmbxAge.Text);
                            #endregion
                            Giris yeni = new Giris();
                            yeni.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            txtPassword.Clear();
                            txtCheckPassword.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("E-posta sonu @gmail.com,@outlook.com,@yandex.com ya da @hotmail.com şeklinde bitmelidir", "domain desteklenmiyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtemail.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Girilen şifreler farklı", "Şifreler uyuşmuyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtCheckPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgileri girdiğinize emin olun", "Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmbxAge_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Ad-Soyad Giriniz";
                label1.Visible = false;
            }
            if (txtemail.Text == "")
            {
                txtemail.Text = "E-Posta";
                label3.Visible = false;
            }
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Kullanıcı Adı Giriniz";
                label4.Visible = false;
            }
            if (txtPassword.Text == "" || txtPassword.Text == "Şifre Giriniz")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Şifre Giriniz";
                label5.Visible = false;
            }
            if (txtCheckPassword.Text == "" || txtCheckPassword.Text == "Tekrar Şifre Giriniz")
            {
                txtCheckPassword.UseSystemPasswordChar = false;
                txtCheckPassword.Text = "Tekrar Şifre Giriniz";
                label6.Visible = false;
            }
        }
        private void txtemail_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "e-posta") {txtemail.Clear();}
            label3.Visible = true;
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Ad-Soyad Giriniz";
                label1.Visible = false;
            }
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "kullanıcı adı giriniz";
                label4.Visible = false;
            }
            if (txtPassword.Text == "" || txtPassword.Text == "Şifre Giriniz")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Şifre Giriniz";
                label5.Visible = false;
            }
            if (txtCheckPassword.Text == "" || txtCheckPassword.Text == "Tekrar Şifre Giriniz")
            {
                txtCheckPassword.UseSystemPasswordChar = false;
                txtCheckPassword.Text = "Tekrar Şifre Giriniz";
                label6.Visible = false;
            }
        }
        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "kullanıcı adı giriniz") { txtUserName.Clear();}
            label4.Visible = true;
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Ad-Soyad Giriniz";
                label1.Visible = false;
            }
            if (txtemail.Text == "")
            {
                txtemail.Text = "e-posta";
                label3.Visible = false;
            }
            if (txtPassword.Text == "" || txtPassword.Text == "Şifre Giriniz")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Şifre Giriniz";
                label5.Visible = false;
            }
            if (txtCheckPassword.Text == "" || txtCheckPassword.Text == "Tekrar Şifre Giriniz")
            {
                txtCheckPassword.UseSystemPasswordChar = false;
                txtCheckPassword.Text = "Tekrar Şifre Giriniz";
                label6.Visible = false;
            }
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            label5.Visible = true;
            if (txtPassword.Text == "Şifre Giriniz"){ txtPassword.Clear();
            }
            if (txtFullName.Text == ""){
                txtFullName.Text = "Ad-Soyad Giriniz";
                label1.Visible = false;
            }
            if (txtemail.Text == "")
            {
                txtemail.Text = "e-posta";
                label3.Visible = false;
            }
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "kullanıcı adı giriniz";
                label4.Visible = false;
            }
            if (txtCheckPassword.Text == "" || txtCheckPassword.Text == "Tekrar Şifre Giriniz")
            {
                txtCheckPassword.UseSystemPasswordChar = false;
                txtCheckPassword.Text = "Tekrar Şifre Giriniz";
                label6.Visible = false;
            }
        }
        private void txtCheckPassword_Click(object sender, EventArgs e)
        {
            if (txtCheckPassword.Text == "Tekrar Şifre Giriniz")
            {
                txtCheckPassword.Clear();
            }
            txtCheckPassword.UseSystemPasswordChar = true;
            label6.Visible = true;
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Ad-Soyad Giriniz";
                label1.Visible = false;
            }
            if (txtemail.Text == "")
            {
                txtemail.Text = "e-posta";
                label3.Visible = false;
            }
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "kullanıcı adı giriniz";
                label4.Visible = false;
            }
            if (txtPassword.Text == "" || txtPassword.Text == "Şifre Giriniz")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Şifre Giriniz";
                label5.Visible = false;
            }
        }
        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            bool a = txtPassword.Text.EndsWith("Şifre Giriniz");
            bool b = txtCheckPassword.Text.EndsWith("Tekrar Şifre Giriniz");
            if (checkBoxSifreGoster.Checked)
            {
                if (!a) { txtPassword.UseSystemPasswordChar = false; }
                if (!b) { txtCheckPassword.UseSystemPasswordChar = false; }
            }
            else if (checkBoxSifreGoster.Checked == false)
            {
                if (!a) { txtPassword.UseSystemPasswordChar = true; }
                else { txtPassword.UseSystemPasswordChar = false; }
                if (!b) { txtCheckPassword.UseSystemPasswordChar = true; }
                else { txtCheckPassword.UseSystemPasswordChar = false; }
            }
        }
        private void txtFullName_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Ad-Soyad Giriniz") { txtFullName.Clear(); }
            label1.Visible = true;
            if (cmbxAge.Text == "")
            {
                label2.Visible = true;
            }
            if (txtemail.Text == "")
            {
                txtemail.Text = "e-posta";
                label3.Visible = false;
            }
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "kullanıcı adı giriniz";
                label4.Visible = false;
            }
            if (txtPassword.Text == "" || txtPassword.Text == "Şifre Giriniz")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Şifre Giriniz";
                label5.Visible = false;
            }
            if (txtCheckPassword.Text == "" || txtCheckPassword.Text == "Tekrar Şifre Giriniz")
            {
                txtCheckPassword.UseSystemPasswordChar = false;
                txtCheckPassword.Text = "Tekrar Şifre Giriniz";
                label6.Visible = false;
            }
        }
    }
}
