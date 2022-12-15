using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


// @SaffetDmr7
// en son bazı butonlar tıklanınca renklendirildi
// Scooter sayılarında problem var byte dizi ikibeyaz...
namespace Nesne_Tabanlı_Programlama
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        #region Veritabanı işlemleri için Database ve Datatable tanımlamaları
        DataTable dt = new DataTable();
        Database db = new Database();
        DataTable dt2 = new DataTable();
        Database db2 = new Database();
        #endregion
        #region//Değişkenler
        byte ikiSiyah = 0, ikiBeyaz = 0, ikiSarı = 0, ikiGri = 0, ikiYesil = 0, ikiTuruncu = 0, ikiMavi = 0, ikiKırmızı = 0;
        byte ucSiyah = 0, ucBeyaz = 0, ucSarı = 0, ucGri = 0, ucYesil = 0, ucTuruncu = 0, ucMavi = 0, ucKırmızı = 0;
        Boolean iade = false;
        short ikiliFiyat = 60,ucluFiyat = 90;
        String FiyatFarki = "0";
        byte ikiToplam = 0, ucToplam = 0;
        #endregion
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            this.Height = 1080;
            this.Width = 1920;
            menuPaneli.Visible = false;
            dt.Clear();
            dt = db.readData("select * from ntpkisi", "");
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if (dt.Rows[i][0].ToString() == txtkullaniciYadaPosta.Text)
                {
                    lblKullanıcıAdı.Text = txtkullaniciYadaPosta.Text;
                    return;
                }
                if (dt.Rows[i][1].ToString() == txtkullaniciYadaPosta.Text)
                {
                    lblKullanıcıAdı.Text = dt.Rows[i][0].ToString();
                    return;
                }
            }
        }
        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
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
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
        
        #region Sağ üst menü işlemleri
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (menuPaneli.Visible == false)
            {
                menuPaneli.Visible = true;
            }
            else
            {
                menuPaneli.Visible = false;
            }
        }
        private void Password_Click(object sender, EventArgs e)
        {
            SifreSifirla passwordReset = new SifreSifirla();
            passwordReset.txtuserName.Text = lblKullanıcıAdı.Text;
            passwordReset.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciAdiDegistir yeni = new kullaniciAdiDegistir();
            yeni.txtuserName.Text = lblKullanıcıAdı.Text;
            yeni.Show();
            this.Hide();
        }
        private void SilmeButonu_Click(object sender, EventArgs e)
        {
            addDelete addDelete = new addDelete();
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Hesabı tamamen silmek istediğinize emin misiniz?\n(Bu işlem geri alınamaz)", "Onaylayınız", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                if (addDelete.sil(lblKullanıcıAdı.Text))
                {
                    MessageBox.Show("Hesap silindi giriş sayfasına yönlendiriliyorsunuz...", "Silme işlemi başarılı");
                    Giris giris = new Giris();
                    giris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Silinemedi", "Hata");
                }
            }
        }
        private void PostaSifirla_Click(object sender, EventArgs e) {
            EPostaDegistir ePostaDegistir = new EPostaDegistir();
            ePostaDegistir.txtuserName.Text = lblKullanıcıAdı.Text;
            ePostaDegistir.Show();
            this.Hide();
        }
        #endregion
        private void ikiTeker_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                ikiTeker.BackColor = Color.Red;
                ucTeker.BackColor = Color.White;
                #region buton görünürlüğü açılıyor
                fotoGorunumAc();
                #endregion
                ////////////////////////////////////////////
                #region butonların içine scooter sayıları yazılıyor
                if (iade)
                {
                    dt.Clear();
                    dt = db.readData("select * from ScSayisi", "");
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        if (dt.Rows[i][16].ToString() == lblKullanıcıAdı.Text)
                        {
                            if (dt.Rows[i][0].ToString() != "-1")
                            {
                                btnBeyazSayısı.Text = dt.Rows[i][0].ToString();
                                btnSiyahSayısı.Text = dt.Rows[i][1].ToString();
                                btnGriSayısı.Text = dt.Rows[i][2].ToString();
                                btnSarıSayısı.Text = dt.Rows[i][3].ToString();
                                btnMaviSayısı.Text = dt.Rows[i][4].ToString();
                                btnYeşilSayısı.Text = dt.Rows[i][5].ToString();
                                btnTuruncuSayısı.Text = dt.Rows[i][6].ToString();
                                btnKırmızıSayısı.Text = dt.Rows[i][7].ToString();
                            }
                        }
                    }
                }
                else
                {
                    btnBeyazSayısı.Text = ikiBeyaz.ToString();
                    btnGriSayısı.Text = ikiGri.ToString();
                    btnKırmızıSayısı.Text = ikiKırmızı.ToString();
                    btnSarıSayısı.Text = ikiSarı.ToString();
                    btnSiyahSayısı.Text = ikiSiyah.ToString();
                    btnYeşilSayısı.Text = ikiYesil.ToString();
                    btnTuruncuSayısı.Text = ikiTuruncu.ToString();
                    btnMaviSayısı.Text = ikiMavi.ToString();
                }
                #endregion
                ///////////////////////////////////////////
                #region diğer butonların görünürlüğü kapatılıyor
                ucTekerGorunumKapa();
                #endregion
            }
            else
            {
                panel1.Visible = false;
                ikiTeker.BackColor = Color.White;
                ucTeker.BackColor = Color.White;
                #region Buton görünürlüğü kapatılıyor
                fotoGorunumKapa();
                #endregion
            }

        }
        private void ucTeker_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                ucTeker.BackColor = Color.Red;
                ikiTeker.BackColor = Color.White;
                #region buton görünürlüğü açılıyor
                ucTekerGorunumAc();
                #endregion
                ///////////////////////////////////////////////
                #region butonların içine scooter sayıları yazılıyor
                if (iade)
                {
                    dt.Clear();
                    dt = db.readData("select * from ScSayisi", "");
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        if (dt.Rows[i][16].ToString() == lblKullanıcıAdı.Text)
                        {

                            if (dt.Rows[i][0].ToString() != "-1")
                            {
                                btnBeyazSayısı.Text = dt.Rows[i][8].ToString();
                                btnSiyahSayısı.Text = dt.Rows[i][9].ToString();
                                btnGriSayısı.Text = dt.Rows[i][10].ToString();
                                btnSarıSayısı.Text = dt.Rows[i][11].ToString();
                                btnMaviSayısı.Text = dt.Rows[i][12].ToString();
                                btnYeşilSayısı.Text = dt.Rows[i][13].ToString();
                                btnTuruncuSayısı.Text = dt.Rows[i][14].ToString();
                                btnKırmızıSayısı.Text = dt.Rows[i][15].ToString();

                            }
                        }
                    }
                }
                else
                {
                    btnBeyazSayısı.Text = ucBeyaz.ToString();
                    btnGriSayısı.Text = ucGri.ToString();
                    btnKırmızıSayısı.Text = ucKırmızı.ToString();
                    btnSarıSayısı.Text = ucSarı.ToString();
                    btnSiyahSayısı.Text = ucSiyah.ToString();
                    btnYeşilSayısı.Text = ucYesil.ToString();
                    btnTuruncuSayısı.Text = ucTuruncu.ToString();
                    btnMaviSayısı.Text = ucMavi.ToString();
                }

                #endregion
                ///////////////////////////////////////////////
                #region diğer butonların görünürlüğü kapatılıyor 
                fotoGorunumKapa();
                #endregion
            }
            else
            {
                panel1.Visible = false;
                ucTeker.BackColor = Color.White;
                ikiTeker.BackColor = Color.White;
                #region butonların görünürlüğü kapatılıyor
                ucTekerGorunumKapa();
                #endregion
            }
        }
        #region Tümünü Sil İşlemi
        private void button2_Click_2(object sender, EventArgs e)
        {
            if (btnSilEvet.Visible == false)
            {
                btnSilEvet.Visible = true;
                btnSilHayır.Visible = true;
                btnSil.Text = "Emin Misin?";
            }
        }
        private void btnSilEvet_Click(object sender, EventArgs e)
        {
            if (!(lblSayi.Text.Equals("0") && lblToplam.Text.Equals("0")))
            {
                herSeyiSıfırla();
                degiskenSifirla();
            }
            btnSilEvet.Visible = false;
            btnSilHayır.Visible = false;
            btnSil.Text = "Tümünü temizle";
        }
        private void btnSilHayır_Click(object sender, EventArgs e)
        {
            btnSilEvet.Visible = false;
            btnSilHayır.Visible = false;
            btnSil.Text = "Tümünü temizle";
        }
        #endregion
        #region Sipariş verme işlemi
        private void btnSipariş_Click(object sender, EventArgs e)
        {
            if (btnOnaylaHayır.Visible == false)
            {
                btnOnaylaEvet.Visible = true;
                btnOnaylaHayır.Visible = true;
                btnSipariş.Text = "Emin Misin?";
            }
        }
        private void btnOnaylaEvet_Click(object sender, EventArgs e)
        {
            if (lblSayi.Text.Equals("0") || lblToplam.Text.Equals("0"))
            {
                MessageBox.Show("Kiralamak için öncelikle scooter seçimi yapınız", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnOnaylaEvet.Visible = false;
                btnOnaylaHayır.Visible = false;
                btnSipariş.Text = "Onayla";

            }
            else
            {
                #region // Değişkenlerin atanması
                DateTime alısTarihi = DateTime.Now;
                String Tarih = tarihOlustur(alısTarihi);
                String ToplamFiyat = lblToplam.Text, ToplamSc = lblSayi.Text;
                //tarihKontrol(tarihDizi);
                byte[] dizi = {ikiBeyaz, ikiSiyah, ikiGri, ikiSarı, ikiMavi, ikiYesil, ikiTuruncu, ikiKırmızı,
                   ucBeyaz ,ucSiyah, ucGri,ucSarı,ucMavi,ucYesil,ucTuruncu,ucKırmızı};
                
                #endregion
                #region //Veritabanı Scooter Sayısı
                Scsayisi scooterSayi = new Scsayisi(); // veritabanıortak class
                dt.Clear();
                dt = db.readData("select * from ScSayisi", "");
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    if (dt.Rows[i][16].ToString() == lblKullanıcıAdı.Text)
                    {

                        if (dt.Rows[i][0].ToString() != "-1")
                        {
                            // Veritabanında toplama işlemi yapılıyor.
                            for (int j = 0; j < dizi.Length; j++)
                            {
                                dizi[j] += Convert.ToByte(dt.Rows[i][j].ToString());
                                if (j < 8)
                                {
                                    ikiToplam += Convert.ToByte(dt.Rows[i][j].ToString());
                                }
                                else
                                {
                                    ucToplam += Convert.ToByte(dt.Rows[i][j].ToString());
                                }
                            }
                        }
                    }
                }
                scooterSayi.guncelle(lblKullanıcıAdı.Text, dizi);
                #endregion
                #region //Veritabanı ücretlendirme
                ucretlendirmeNtp ucret = new ucretlendirmeNtp(); // veritabanı ortak class
                dt.Clear();
                dt = db.readData("select * from ucretlendirme", "");
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    if (dt.Rows[i][0].ToString() == lblKullanıcıAdı.Text)
                    {

                        if (dt.Rows[i][1].ToString() != "-1") // eğer veritabanına hiç giriş yapılmadıysa normal
                                                              // ama giriş yapıldıysa toplayarak işlem yapar.
                        {
                            FiyatFarki = tarihFarkıAl(Tarih,lblKullanıcıAdı.Text,ikiToplam,ucToplam);
                            // Önceki veriyle toplanır
                            FiyatFarki = (Convert.ToInt32(FiyatFarki) + Convert.ToInt32(dt.Rows[i][6].ToString())).ToString();
                            // Önceki Toplam Ücret Alınır ve toplanır
                            lblToplam.Text = (Convert.ToInt32(lblToplam.Text) + Convert.ToInt32(dt.Rows[i][5].ToString())).ToString();
                            // Önceki Scooter Sayısı alınır ve toplanır
                            lblSayi.Text = (Convert.ToInt32(lblSayi.Text) + Convert.ToInt32(dt.Rows[i][4].ToString())).ToString();
                        }
                    }
                }
                ucret.guncelle(lblKullanıcıAdı.Text, Tarih, lblSayi.Text, lblToplam.Text, FiyatFarki);
                lblSayi.Text = ToplamSc;
                lblToplam.Text = ToplamFiyat;
                #endregion
                btnOnaylaEvet.Visible = false;
                btnOnaylaHayır.Visible = false;
                btnSipariş.Text = "Onayla";
                MessageBox.Show(" Siparişiniz Alındı ", "İşlem Onaylandı", MessageBoxButtons.OK);
                ikiToplam = 0;
                ucToplam = 0;
                herSeyiSıfırla();
                degiskenSifirla();
            }
        }
        private void tarihKontrol(String[] tarihDizi) {
            for (int i = 1; i < tarihDizi.Length; i++)
            {
                if (tarihDizi[i].Length == 1)
                {
                    tarihDizi[i] = "0" + tarihDizi[i];
                }
            }
        }
        private void btnOnaylaHayır_Click(object sender, EventArgs e)
        {
            btnOnaylaEvet.Visible = false;
            btnOnaylaHayır.Visible = false;
            btnSipariş.Text = "Onayla";
        }
        #endregion
        #region İade işlemi
        private void btnIade_Click(object sender, EventArgs e)
        {
            iade = true;
            dt.Clear();
            dt = db.readData("select * from ScSayisi", "");
            dt2.Clear();
            dt2 = db2.readData("select * from ucretlendirme", "");
            for (int i = 0; i <= dt2.Rows.Count - 1; i++)
                {
                    if (dt2.Rows[i][0].ToString() == lblKullanıcıAdı.Text)
                    {
                        if (dt2.Rows[i][1].ToString() != "-1")
                        {
                            lblSayi.Text = dt2.Rows[i][4].ToString();
                            lblToplam.Text = dt2.Rows[i][5].ToString();
                        }
                    }
                }
            #region İki Teker İşlemleri
            if (fotoBeyaz.Visible)
            {
                #region Butonların içine scooter sayıları yazılıyor //İki teker olanlar için
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    if (dt.Rows[i][16].ToString() == lblKullanıcıAdı.Text)
                    {
                        if (dt.Rows[i][0].ToString() != "-1")
                        {
                            btnBeyazSayısı.Text = dt.Rows[i][0].ToString();
                            btnSiyahSayısı.Text = dt.Rows[i][1].ToString();
                            btnGriSayısı.Text = dt.Rows[i][2].ToString();
                            btnSarıSayısı.Text = dt.Rows[i][3].ToString();
                            btnMaviSayısı.Text = dt.Rows[i][4].ToString();
                            btnYeşilSayısı.Text = dt.Rows[i][5].ToString();
                            btnTuruncuSayısı.Text = dt.Rows[i][6].ToString();
                            btnKırmızıSayısı.Text = dt.Rows[i][7].ToString();
                            btnIadeOnayla.Visible = true;
                            btnIadeIptal.Visible = true;
                            if (ikiToplam == 0)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    ikiToplam += Convert.ToByte(dt.Rows[i][j].ToString());
                                }
                                ikiToplam -= (byte)(ikiSiyah+ ikiBeyaz+ ikiGri+ ikiSarı+ ikiYesil+ ikiMavi + ikiTuruncu+ ikiKırmızı);

                            }
                            btnArtıErisimKapa();
                        }
                        else
                        {
                            MessageBox.Show("Henüz Sipariş Vermediniz\nİade etmeden önce sipariş vermeyi deneyin", "Sipariş bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                #endregion
                #region Toplam Scooter sayısı ve saatlik ücret ilgili yerlere yazılıyor
                
                #endregion
            }
            #endregion
            #region  Üç Teker İşlemleri
            else if (uctekerBeyaz.Visible)
            {
                # region Butonların içine scooter sayıları yazılıyor //Üç teker olanlar için
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    if (dt.Rows[i][16].ToString() == lblKullanıcıAdı.Text)
                    {

                        if (dt.Rows[i][0].ToString() != "-1")
                        {
                            btnBeyazSayısı.Text = dt.Rows[i][8].ToString();  
                            btnSiyahSayısı.Text = dt.Rows[i][9].ToString();
                            btnGriSayısı.Text = dt.Rows[i][10].ToString();
                            btnSarıSayısı.Text = dt.Rows[i][11].ToString();
                            btnMaviSayısı.Text = dt.Rows[i][12].ToString();
                            btnYeşilSayısı.Text = dt.Rows[i][13].ToString();
                            btnTuruncuSayısı.Text = dt.Rows[i][14].ToString();
                            btnKırmızıSayısı.Text = dt.Rows[i][15].ToString();
                            btnIadeOnayla.Visible = true;
                            btnIadeIptal.Visible = true;
                            if (ucToplam == 0)
                            {
                                for (int j = 8; j < 16; j++)
                                {
                                    ucToplam += Convert.ToByte(dt.Rows[i][j].ToString());
                                }
                                ucToplam -= (byte)(ucSiyah+ucBeyaz+ucGri+ucSarı+ucYesil+ucMavi+ucTuruncu+ucKırmızı);
                            }
                            btnArtıErisimKapa();
                        }
                        else
                        {
                            MessageBox.Show("Daha Hiç Sipariş Vermediniz\nİade etmeden önce sipariş vermeyi deneyin", "Sipariş bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                #endregion
                #region Toplam Scooter sayısı ve Saatlik ücret ilgili yerlere yazılıyor
                for (int i = 0; i <= dt2.Rows.Count - 1; i++)
                {
                    if (dt2.Rows[i][0].ToString() == lblKullanıcıAdı.Text)
                    {
                        if (dt2.Rows[i][1].ToString() != "-1")
                        {
                            lblSayi.Text = dt2.Rows[i][4].ToString();
                            lblToplam.Text = dt2.Rows[i][5].ToString();
                        }
                    }
                }
                #endregion
            }
            #endregion
        }
        private void btnIadeIptal_Click(object sender, EventArgs e)
        {
            btnIadeIptal.Visible = false;
            btnIadeOnayla.Visible = false;
            btnIade.Visible = true;
            btnArtıErisimAc();
            herSeyiSıfırla();
            degiskenSifirla();
        }
        private void btnIadeOnayla_Click(object sender, EventArgs e)
        {
            #region Değişken tanımalamaları
            String ucret = "0";
            Scsayisi sc = new Scsayisi();
            ucretlendirmeNtp ucretlendirme = new ucretlendirmeNtp();
            byte kontroladet = 0;
            int kontrolToplamFiyat = 0;
            dt.Clear();
            dt = db.readData("select * from Scsayisi","");
            dt2.Clear();
            dt2 = db2.readData("select * from ucretlendirme","");
            #endregion
            #region Kontrol kısmı
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i][0].ToString().Equals(lblKullanıcıAdı.Text))
                {
                    kontroladet = Convert.ToByte(dt2.Rows[i][4].ToString());
                    kontrolToplamFiyat = Convert.ToInt16(dt2.Rows[i][5].ToString());
                }
            }
            if (kontroladet.ToString().Equals(lblSayi.Text) && kontrolToplamFiyat.ToString().Equals(lblToplam.Text))
            {
                MessageBox.Show("Scooter iade etmediniz","İade işlemi başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnIade.Visible = true;
                btnIadeIptal.Visible = false;
                btnIadeOnayla.Visible = false;
                herSeyiSıfırla();
                degiskenSifirla();
                
            }
            #endregion
            else
            {
                #region ücretlendirme database
                DateTime iadeTarihi = DateTime.Now;
                String iadetarihi = tarihOlustur(iadeTarihi);
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (dt2.Rows[i][0].ToString().Equals(lblKullanıcıAdı.Text))
                    {
                        ucret = tarihFarkıAl(iadetarihi,lblKullanıcıAdı.Text,ikiToplam,ucToplam);
                        ucret = (Convert.ToInt32(ucret) + Convert.ToInt32(FiyatFarki)).ToString();
                        FiyatFarki = "0";
                    }
                }
                ucretlendirme.guncelle(lblKullanıcıAdı.Text,"0",lblSayi.Text,lblToplam.Text,FiyatFarki,iadetarihi);
                #endregion
                #region Scsayisi veritabanı işlemleri

                    byte[] dizi = {ikiBeyaz, ikiSiyah, ikiGri, ikiSarı, ikiMavi, ikiYesil, ikiTuruncu, ikiKırmızı,
                        ucBeyaz ,ucSiyah, ucGri,ucSarı,ucMavi,ucYesil,ucTuruncu,ucKırmızı};
                    sc.guncelle(lblKullanıcıAdı.Text, dizi);
                #endregion
                #region bilgilendirme epostası gönderilir
                dt.Clear();
                dt = db.readData("select * from ntpkisi","");
                String eposta = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].Equals(lblKullanıcıAdı.Text))
                    {
                        eposta = dt.Rows[i][1].ToString();
                    }
                }
                if (epostaGonder.EPostaGonder("Ödeme talebinde bulundunuz", "(" + lblKullanıcıAdı.Text + ") kullanıcı adının hesaplanan ücret tutarı\n" + ucret + " Tl dir", eposta))
                {
                    MessageBox.Show("Bilgilendirme e-postası gönderilmiştir.");
                }
                btnArtıErisimAc();
                herSeyiSıfırla();
                degiskenSifirla();
                ucToplam = 0;
                ikiToplam = 0;
                #endregion
            }
        }
        #endregion
        #region Motor Seçimi Yapılıyor
        private void btnSarı_Click(object sender, EventArgs e)
        {
            if (fotoSarı.Visible)
            {
                btnSarıSayısı.Text = Add(ref ikiSarı, btnSarıSayısı.Text, ikiliFiyat);
            }
            else if (uctekerSarı.Visible)
            {
                btnSarıSayısı.Text = Add(ref ucSarı, btnSarıSayısı.Text, ucluFiyat);
            }
        }
        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            if (fotoBeyaz.Visible)
            {
                btnBeyazSayısı.Text = Add(ref ikiBeyaz, btnBeyazSayısı.Text, ikiliFiyat);
            }
            else if (uctekerBeyaz.Visible)
            {
                btnBeyazSayısı.Text = Add(ref ucBeyaz, btnBeyazSayısı.Text, ucluFiyat);
            }
            
        }
        private void btnTuruncu_Click(object sender, EventArgs e)
        {
            if (fotoTuruncu.Visible)
            {
                btnTuruncuSayısı.Text = Add(ref ikiTuruncu, btnTuruncuSayısı.Text, ikiliFiyat);
            }
            else if (uctekerTuruncu.Visible)
            {
                btnTuruncuSayısı.Text = Add(ref ucTuruncu, btnTuruncuSayısı.Text, ucluFiyat);
            }
        }
        private void btnMavi_Click(object sender, EventArgs e)
        {
            if (fotoMavi.Visible)
            {
                btnMaviSayısı.Text = Add(ref ikiMavi, btnMaviSayısı.Text, ikiliFiyat);
            }
            else if (uctekerMavi.Visible)
            {
                btnMaviSayısı.Text = Add(ref ucMavi, btnMaviSayısı.Text, ucluFiyat);
            }
        }
        private void btnGri_Click(object sender, EventArgs e)
        {
            if (fotoGri.Visible)
            {
                btnGriSayısı.Text = Add(ref ikiGri, btnGriSayısı.Text, ikiliFiyat);
            }
            else if (uctekerGri.Visible)
            {
                btnGriSayısı.Text = Add(ref ucGri, btnGriSayısı.Text, ucluFiyat);
            }
        }
        private void btnYeşil_Click(object sender, EventArgs e)
        {
            if (fotoYeşil.Visible)
            {
                btnYeşilSayısı.Text = Add(ref ikiYesil, btnYeşilSayısı.Text, ikiliFiyat);
            }
            else if (uctekerYeşil.Visible)
            {
                btnYeşilSayısı.Text = Add(ref ucYesil, btnYeşilSayısı.Text, ucluFiyat);
            }
        }
        private void btnKırmızı_Click(object sender, EventArgs e)
        {
            
            if (fotoKırmızı.Visible)
            {
                btnKırmızıSayısı.Text = Add(ref ikiKırmızı, btnKırmızıSayısı.Text, ikiliFiyat);
            }
            else if (uctekerKırmızı.Visible)
            {
                btnKırmızıSayısı.Text = Add(ref ucKırmızı, btnKırmızıSayısı.Text, ucluFiyat);
            }
            
        }
        private void btnSiyah_Click(object sender, EventArgs e)
        {
            if (fotoSiyah.Visible)
            {
                btnSiyahSayısı.Text = Add(ref ikiSiyah, btnSiyahSayısı.Text, ikiliFiyat);
            }
            else if (uctekerSiyah.Visible)
            {
                btnSiyahSayısı.Text = Add(ref ucSiyah,btnSiyahSayısı.Text,ucluFiyat);
            }
        }
        private String Add(ref byte renk, String buton, short fiyat)
        {
            lblSayi.Text = (Convert.ToByte(lblSayi.Text) + 1).ToString();
            if (Convert.ToByte(lblSayi.Text)<11)
            {
                renk++;
                buton = (renk).ToString();
                lblToplam.Text = (Convert.ToInt16(lblToplam.Text) + fiyat).ToString();
            }
            else
            {
                lblSayi.Text = "10";
            }
            return buton;
        }
        #endregion
        #region Seçilen Motorlar Siliniyor
        private void btnSarıEksi_Click(object sender, EventArgs e)
        {
            if (fotoSarı.Visible)
            {
                btnSarıSayısı.Text = Delete(ref ikiSarı, btnSarıSayısı.Text, ikiliFiyat);
            }
            else if (uctekerSarı.Visible)
            {
                btnSarıSayısı.Text = Delete(ref ucSarı, btnSarıSayısı.Text, ucluFiyat);
            }
        }
        private void btnBeyazEksi_Click(object sender, EventArgs e)
        {
            if (fotoBeyaz.Visible)
            {
                btnBeyazSayısı.Text = Delete(ref ikiBeyaz, btnBeyazSayısı.Text, ikiliFiyat);
            }
            else if (uctekerBeyaz.Visible)
            {
                btnBeyazSayısı.Text = Delete(ref ucBeyaz, btnBeyazSayısı.Text, ucluFiyat);
            }
        }
        private void btnSiyahEksi_Click(object sender, EventArgs e)
        {
            if (fotoSiyah.Visible)
            {
                btnSiyahSayısı.Text = Delete(ref ikiSiyah, btnSiyahSayısı.Text, ikiliFiyat);
            }
            else if (uctekerSiyah.Visible)
            {
                btnSiyahSayısı.Text = Delete(ref ucSiyah, btnSiyahSayısı.Text, ucluFiyat);
            }
        }
        private void pctrKapatma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKırmızıEksi_Click(object sender, EventArgs e)
        {
            if (fotoKırmızı.Visible)
            {
                btnKırmızıSayısı.Text = Delete(ref ikiKırmızı, btnKırmızıSayısı.Text, ikiliFiyat);
            }
            else if (uctekerKırmızı.Visible)
            {
                btnKırmızıSayısı.Text = Delete(ref ucKırmızı, btnKırmızıSayısı.Text, ucluFiyat);
            }
        }
        private void btnYeşilEksi_Click(object sender, EventArgs e)
        {
            if (fotoYeşil.Visible)
            {
                btnYeşilSayısı.Text = Delete(ref ikiYesil, btnYeşilSayısı.Text, ikiliFiyat);

            }
            else if (uctekerYeşil.Visible) 
            {
                btnYeşilSayısı.Text = Delete(ref ucYesil, btnYeşilSayısı.Text, ucluFiyat);
            }
        }
        private void btnTuruncuEksi_Click(object sender, EventArgs e)
        {
            if (fotoTuruncu.Visible)
            {
                btnTuruncuSayısı.Text = Delete(ref ikiTuruncu, btnTuruncuSayısı.Text, ikiliFiyat);

            }
            else if (uctekerTuruncu.Visible)
            {
                btnTuruncuSayısı.Text = Delete(ref ucTuruncu, btnTuruncuSayısı.Text, ucluFiyat);
            }
        }
        private void btnMaviEksi_Click(object sender, EventArgs e)
        {
            if (fotoMavi.Visible)
            {
                btnMaviSayısı.Text = Delete(ref ikiMavi, btnMaviSayısı.Text,ikiliFiyat);             
            }
            else if (uctekerMavi.Visible)
            {
                btnMaviSayısı.Text = Delete(ref ucMavi, btnMaviSayısı.Text, ucluFiyat);
            }
        }
        private void btnGriEksi_Click(object sender, EventArgs e)
        {
            
            if (fotoGri.Visible)
            {           
                    btnGriSayısı.Text = Delete(ref ikiGri,btnGriSayısı.Text,ikiliFiyat);
            }
            else if (uctekerGri.Visible)
            {
                    btnGriSayısı.Text = Delete(ref ucGri, btnGriSayısı.Text,ucluFiyat);
            }
        }
        private String Delete(ref byte renk,String buton,short fiyat)
        {
            if (lblSayi.Text != "0" && renk != 0)
            {
                lblSayi.Text = (Convert.ToByte(lblSayi.Text) - 1).ToString();
                renk--;
                buton = (renk).ToString();
                lblToplam.Text = (Convert.ToInt16(lblToplam.Text) - fiyat).ToString();
            }
            if (iade)
            {
                renk = Convert.ToByte(buton);
            }
            return (buton);
        }
        #endregion
        #region Görünüm ve Erişim Ayarlama
        private void btnArtıErisimKapa()
        {
            btnBeyazArtı.Enabled = false;
            btnGriArtı.Enabled = false;
            btnSiyahArtı.Enabled = false;
            btnSarıArtı.Enabled = false;
            btnMaviArtı.Enabled = false;
            btnYeşilArtı.Enabled = false;
            btnTuruncuArtı.Enabled = false;
            btnKırmızıArtı.Enabled = false;
        }
        private void btnArtıErisimAc()
        {
            btnGriArtı.Enabled = true;
            btnBeyazArtı.Enabled = true;
            btnSiyahArtı.Enabled = true;
            btnSarıArtı.Enabled = true;
            btnYeşilArtı.Enabled = true;
            btnTuruncuArtı.Enabled = true;
            btnKırmızıArtı.Enabled = true;
            btnMaviArtı.Enabled = true;
        }
        private void fotoGorunumAc()
        {
            fotoBeyaz.Visible = true;
            fotoGri.Visible = true;
            fotoSarı.Visible = true;
            fotoKırmızı.Visible = true;
            fotoTuruncu.Visible = true;
            fotoSiyah.Visible = true;
            fotoYeşil.Visible = true;
            fotoMavi.Visible = true;
        }
        private void fotoGorunumKapa()
        {
            fotoBeyaz.Visible = false;
            fotoGri.Visible = false;
            fotoSarı.Visible = false;
            fotoKırmızı.Visible = false;
            fotoTuruncu.Visible = false;
            fotoSiyah.Visible = false;
            fotoYeşil.Visible = false;
            fotoMavi.Visible = false;
        }
        private void ucTekerGorunumAc()
        {
            uctekerKırmızı.Visible = true;
            uctekerBeyaz.Visible = true;
            uctekerSarı.Visible = true;
            uctekerTuruncu.Visible = true;
            uctekerMavi.Visible = true;
            uctekerSiyah.Visible = true;
            uctekerGri.Visible = true;
            uctekerYeşil.Visible = true;
        }
        private void ucTekerGorunumKapa()
        {
            uctekerKırmızı.Visible = false;
            uctekerBeyaz.Visible = false;
            uctekerSarı.Visible = false;
            uctekerTuruncu.Visible = false;
            uctekerMavi.Visible = false;
            uctekerSiyah.Visible = false;
            uctekerGri.Visible = false;
            uctekerYeşil.Visible = false;
        }
        private void herSeyiSıfırla()
        {
            btnSarıSayısı.Text = "0";
            btnSiyahSayısı.Text = "0";
            btnTuruncuSayısı.Text = "0";
            btnBeyazSayısı.Text = "0";
            btnGriSayısı.Text = "0";
            btnMaviSayısı.Text = "0";
            btnKırmızıSayısı.Text = "0";
            btnYeşilSayısı.Text = "0";
            lblSayi.Text = "0";
            lblToplam.Text = "0";
        }
        private void degiskenSifirla()
        {
            ikiSarı = 0;
            ikiGri = 0;
            ikiBeyaz = 0;
            ikiKırmızı = 0;
            ikiMavi = 0;
            ikiSiyah = 0;
            ikiTuruncu = 0;
            ikiYesil = 0;
            ucBeyaz = 0;
            ucGri = 0;
            ucKırmızı = 0;
            ucMavi = 0;
            ucSarı = 0;
            ucSiyah = 0;
            ucTuruncu = 0;
            ucYesil = 0;
        }
        private String tarihOlustur(DateTime alısTarihi) {
            String tarih = "";
            String[] tarihDizi = {alısTarihi.Year.ToString(),alısTarihi.Month.ToString(),
                alısTarihi.Day.ToString(),alısTarihi.Hour.ToString(),alısTarihi.Minute.ToString()
                ,alısTarihi.Second.ToString()};
            tarihKontrol(tarihDizi);
            foreach (String item in tarihDizi)
            {
                tarih +=item + " ";
            }
            return tarih;
        }
        private String tarihFarkıAl(String Tarih,String kullanıcıAdı,byte ikiToplam,byte ucToplam)
        {
            String ucret = "";
            dt.Clear();
            dt = db.readData("select * from ucretlendirme","");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString().Equals(kullanıcıAdı))
                {
                    int yil = Convert.ToInt32(Tarih.Substring(0, 4)) - Convert.ToInt32(dt.Rows[i][1].ToString().Substring(0, 4));
                    int ay = Convert.ToInt32(Tarih.Substring(5, 2)) - Convert.ToInt32(dt.Rows[i][1].ToString().Substring(5, 2));
                    int gun = Convert.ToInt32(Tarih.Substring(8, 2)) - Convert.ToInt32(dt.Rows[i][1].ToString().Substring(8, 2));
                    int saat = Convert.ToInt32(Tarih.Substring(11, 2)) - Convert.ToInt32(dt.Rows[i][1].ToString().Substring(11, 2));
                    int dk = Convert.ToInt32(Tarih.Substring(14, 2)) - Convert.ToInt32(dt.Rows[i][1].ToString().Substring(14, 2));
                    int sn = Convert.ToInt32(Tarih.Substring(17, 2)) - Convert.ToInt32(dt.Rows[i][1].ToString().Substring(17, 2));
                    ucret = ((yil * 525.960) + (ay * 43829) + (gun * 1440) + (saat * 60) + (dk) + (sn / 30)).ToString();
                    ucret = ((Convert.ToInt32(ucret) * ikiToplam) + ((Convert.ToInt32(ucret) * ucToplam * 3) / 2)).ToString();
                }
            }
            return ucret;
        }
        #endregion
    }

}
