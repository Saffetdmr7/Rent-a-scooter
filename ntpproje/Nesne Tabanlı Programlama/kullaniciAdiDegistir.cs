using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanlı_Programlama
{
    public partial class kullaniciAdiDegistir : Form
    {
        public kullaniciAdiDegistir()
        {
            InitializeComponent();
        }
        static String constring = "Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=ntp;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
        DataTable dt = new DataTable();
        Database db = new Database();
        private void kullaniciAdiDegistir_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void kullaniciAdiDegistir_Load(object sender, EventArgs e)
        {
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa geri = new AnaSayfa();
            geri.Show();
            this.Hide();
        }
        private void btnDeğiştir_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = db.readData("select * from ntpkisi", "");
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    if ((dt.Rows[i][0].ToString() == txtYeniUser.Text))
                    {
                        MessageBox.Show("İstediğiniz kullanıcı adı şuanda başka bir kullanıcı tarafından kullanılıyor");
                        txtYeniUser.Clear();
                        return;
                    }
                }
                DialogResult sor = new DialogResult();
                sor = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sor == DialogResult.Yes)
                {
                    baglan.Open();
                    #region//ntpkisi veritabanında güncelleme yapılır
                    String ntpkisiUserName = ("Update ntpkisi Set kullaniciAdi=@kullaniciAdi Where kullaniciAdi =@username");
                    SqlCommand komut = new SqlCommand(ntpkisiUserName, baglan);
                    komut.Parameters.AddWithValue("@kullaniciAdi", txtYeniUser.Text);
                    komut.Parameters.AddWithValue("@username", txtuserName.Text);
                    komut.ExecuteNonQuery();
                    #endregion
                    #region//ucretlendirme veritabanında güncelleme yapılır
                    String ucretlendirmeUserName = ("Update ucretlendirme Set kullaniciAdi=@kullaniciAdi Where kullaniciAdi =@username");
                    SqlCommand komut2 = new SqlCommand(ucretlendirmeUserName, baglan);
                    komut2.Parameters.AddWithValue("@kullaniciAdi", txtYeniUser.Text);
                    komut2.Parameters.AddWithValue("@username", txtuserName.Text);
                    komut2.ExecuteNonQuery();
                    #endregion
                    #region//ScSayisi veritabanında güncelleme yapılır
                    String ScSayisiUserName = ("Update ScSayisi Set kullaniciAdi=@kullaniciAdi Where kullaniciAdi =@username");
                    SqlCommand komut3 = new SqlCommand(ScSayisiUserName, baglan);
                    komut3.Parameters.AddWithValue("@kullaniciAdi", txtYeniUser.Text);
                    komut3.Parameters.AddWithValue("@username", txtuserName.Text);
                    komut3.ExecuteNonQuery();
                    #endregion
                    baglan.Close();
                    MessageBox.Show("Kullanıcı Adınız Değiştirildi", "Başarılı");
                    AnaSayfa Mnpg = new AnaSayfa();
                    Mnpg.lblKullanıcıAdı.Text = txtYeniUser.Text;
                    Mnpg.Show();
                    this.Hide();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql hatası");
            }
        }
    }
}
