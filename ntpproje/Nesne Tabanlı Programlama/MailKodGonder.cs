using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace Nesne_Tabanlı_Programlama
{
    public partial class MailKodGonder : Form
    {     
        public MailKodGonder()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Database db = new Database();
        private void MailKodGonder_Load(object sender, EventArgs e)
        {
        }
        private void kodGonder_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.readData("select * from ntpkisi", "");
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if ((dt.Rows[i][1].ToString() == txtEposta.Text))
                {
                    String kullanıcıAdı = dt.Rows[i][0].ToString();
                    #region//Doğrulama kodu oluşturulur
                    Random rnd = new Random();
                    int kodum = rnd.Next(100000,1000000);
                    String DogrulamaKodu = kodum.ToString();
                    #endregion
                    MessageBox.Show("Doğrulama kodu gönderiliyor");
                    
                    if (epostaGonder.EPostaGonder("Şifre yenileme talebinde bulundunuz", "(" + kullanıcıAdı + ") Kullanıcı adına gönderilen kodu yazınız\n" + DogrulamaKodu, txtEposta.Text))
                    {
                        KodGir kod = new KodGir();
                        MessageBox.Show("Doğrulama Kodu Gönderildi");
                        kod.dogrulamakodu.Text = DogrulamaKodu;
                        kod.txtEposta.Text = txtEposta.Text;
                        kod.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("E-Posta adresinizi doğru girdiğinize emin olun", "E-posta bulunamadı");
            txtEposta.Clear();

        }
        private void MailSifre_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
