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
    public partial class EPostaDegistir : Form
    {
        public EPostaDegistir()
        {
            InitializeComponent();
        }
        static String constring = "Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=ntp;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
        DataTable dt = new DataTable();
        Database db = new Database();
        private void EPostaDegistir_Load(object sender, EventArgs e)
        {
        }
        private void Onayla_Click(object sender, EventArgs e)
        {
            String eposta = "";
            dt.Clear();
            dt = db.readData("select * from ntpkisi", "");
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if ((dt.Rows[i][1].ToString() == txtYeniEposta.Text))
                {
                    MessageBox.Show("Girilen E-Posta adresi kullanılıyor");
                    txtYeniEposta.Clear();
                    return;
                }
                if (dt.Rows[i][0].ToString() == txtuserName.Text)
                {
                    eposta = dt.Rows[i][1].ToString();
                }
                if (txtYeniEposta.Text != eposta)
                {
                    try
                    {
                            baglan.Open();
                        #region//Veritabanı Eposta değiştiriliyor
                        String postaGuncelle = ("Update ntpkisi Set eposta = @eposta Where eposta = @email or kullaniciAdi =@username");
                            SqlCommand komut = new SqlCommand(postaGuncelle, baglan);
                            komut.Parameters.AddWithValue("@eposta", txtYeniEposta.Text);
                            komut.Parameters.AddWithValue("@email", eposta);
                            komut.Parameters.AddWithValue("@username", txtuserName.Text);
                            komut.ExecuteNonQuery();
                        #endregion
                        baglan.Close();
                            MessageBox.Show("E-Posta adresiniz değiştirildi", "Başarılı");
                            AnaSayfa Mnpg = new AnaSayfa();
                            Mnpg.Show();
                            this.Hide();
                            return;
                    }
                    catch (SqlException ex)
                    {
                            MessageBox.Show(ex.Message, "Değiştirme işlemi başarısız");
                    }
                }
                    else
                    {
                        MessageBox.Show("Eski E-Posta adresinizi girdiniz","Yeni Bİr posta adresi giriniz");
                    }
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
