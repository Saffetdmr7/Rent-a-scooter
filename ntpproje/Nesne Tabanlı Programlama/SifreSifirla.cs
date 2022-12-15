using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nesne_Tabanlı_Programlama
{
    public partial class SifreSifirla : Form
    {
        public SifreSifirla()
        {
            InitializeComponent();
        }
        static String constring = "Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=ntp;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
        private void SifreSifirla_FormClosing(object sender, FormClosingEventArgs e)
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
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
        private void chckbxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxSifreGoster.Checked)
            {
                txtYeniSifre.UseSystemPasswordChar = false;
                txtYeniSifreTekrar.UseSystemPasswordChar = false;
            }
            else
            {
                txtYeniSifre.UseSystemPasswordChar = true;
                txtYeniSifreTekrar.UseSystemPasswordChar = true;
            }
        }
        private void btnSifreYenile_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text != "" && txtYeniSifreTekrar.Text != "" && txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                addDelete check = new addDelete();
                if (check.sifreKontrol(txtYeniSifre.Text))
                {
                    try
                    {
                        baglan.Open();
                        #region //Şifre veritabanında değiştiliyor
                        String sifreGuncelle = ("Update ntpkisi Set sifre=@sifre Where kullaniciAdi =@username");
                        SqlCommand komut = new SqlCommand(sifreGuncelle, baglan);
                        komut.Parameters.AddWithValue("@sifre", txtYeniSifre.Text);
                        komut.Parameters.AddWithValue("@username", txtuserName.Text);
                        komut.ExecuteNonQuery();
                        #endregion
                        baglan.Close();
                        MessageBox.Show("Yeni Şifre oluşturuldu", "Başarılı");
                        Giris giris = new Giris();
                        giris.Show();
                        this.Hide();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Hata");
                    }
                }
                else
                {
                    txtYeniSifre.Clear();
                    txtYeniSifreTekrar.Clear();
                }

            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Şifreleri Tekrar Kontrol Ediniz.", "Şifre hatalı");
                txtYeniSifre.Clear();
                txtYeniSifreTekrar.Clear();
            }
        }

        private void SifreSifirla_Load(object sender, EventArgs e)
        {
        }
    }
}
