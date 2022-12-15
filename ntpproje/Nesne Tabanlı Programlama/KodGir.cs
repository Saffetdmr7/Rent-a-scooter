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
    public partial class KodGir : Form
    {
        public KodGir()
        {
            InitializeComponent();
        }
        byte sny = 59, dk = 2,hak = 2;
        private void KodGir_Load(object sender, EventArgs e)
        {
            dakika.Interval = 60000;
            saniye.Interval = 1000;
            saniye.Start();
            dakika.Start();
        }
        private void KodGir_FormClosing(object sender, FormClosingEventArgs e)
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
            MailKodGonder mailSifre = new MailKodGonder();
            mailSifre.Show();
            this.Hide();
        }

        private void btnDoğrula_Click(object sender, EventArgs e)
        {
            if (dogrulamakodu.Text == txtKodBak.Text)
            {
                SifreSifirla passwordrst = new SifreSifirla();
                passwordrst.txtuserName.Text = txtEposta.Text;
                passwordrst.Show();
                this.Hide();
                return;
            }
            else
            {

                MessageBox.Show("doğrulama kodu yanlış veya eksik " + (hak) + " hakkınız kaldı", "kod hatası");
                txtKodBak.Clear();
                hak--;

            }
            if (hak < 0)
            {
                MessageBox.Show("3 deneme hakkınızı bitirdiniz lütfen yeni kod alıp tekrar deneyiniz", "Fazla deneme");
                return;
            }
        }

        private void dakika_Tick(object sender, EventArgs e)
        {
            if (dk < 0)
            {
                dakika.Stop();
                saniye.Stop();
                MessageBox.Show("Verilen süre içinde doğru kodu giremediniz tekrar kod alınız veya spam kutunuzu kontrol ediniz","Süre Bitti");
                MailKodGonder önceki = new MailKodGonder();
                önceki.Show();
                this.Hide();
            }
            dk--;
        }

        private void saniye_Tick(object sender, EventArgs e)
        {
            second.Text = Convert.ToString(sny);
            minute.Text = Convert.ToString("0"+dk);
            if (sny == 0)
            {
                sny = 59;
            }
            sny--;
        }
    }
}
