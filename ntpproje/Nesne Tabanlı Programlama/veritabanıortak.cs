using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Nesne_Tabanlı_Programlama
{

    internal class veritabanıortak
    {
    }
    public class addDelete
    {
        //Data Source=SAFFET\SQLEXPRESS;Initial Catalog=kayit;Integrated Security=True
        static String constring = "Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=ntp;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
        public void ekle(String username, String email, String password, String fullname, String age,int deger = -1,int deger2 = 0)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    #region// ntpkisi veritabanında kullanıcının kaydı yapılıyor
                    String kayit = "insert into ntpkisi (kullaniciAdi,eposta,sifre,adsoyad,yas) values(@kullaniciadi,@ePosta,@Sifre,@Adsoyad,@Yas)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@kullaniciAdi", username);
                    komut.Parameters.AddWithValue("@eposta", email);
                    komut.Parameters.AddWithValue("@sifre", password);
                    komut.Parameters.AddWithValue("@adsoyad", fullname);
                    komut.Parameters.AddWithValue("@yas", age);
                    komut.ExecuteNonQuery();
                    #endregion
                    #region// ücretlendirme veritabanında kullanıcının kaydı yapılıyor
                    String kayit2 = "insert into ucretlendirme (kullaniciAdi,girisTarihi,cikisTarihi) values (@kullaniciAdi,@girisTarihi,@cikisTarihi)";
                    SqlCommand komut2 = new SqlCommand(kayit2, baglan);
                    komut2.Parameters.AddWithValue("@kullaniciAdi", username);
                    komut2.Parameters.AddWithValue("@girisTarihi",deger);
                    komut2.Parameters.AddWithValue("@cikisTarihi",deger2);
                    komut2.ExecuteNonQuery();
                    #endregion
                    #region// Scsayisi veritabanında kullanıcının kaydı yapılıyor
                    String kayit3 = "insert into ScSayisi (kullaniciAdi,ikibeyaz) values (@kullaniciAdi,@ikibeyaz)";
                    SqlCommand komut3 = new SqlCommand(kayit3, baglan);
                    komut3.Parameters.AddWithValue("@kullaniciAdi", username);
                    komut3.Parameters.AddWithValue("@ikibeyaz",deger);
                    komut3.ExecuteNonQuery();
                    #endregion
                    MessageBox.Show("Yeni Kullanıcı kaydı başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eklenemedi.");

            }
        }
        public bool sil(String ad)
        {
            //String delete = "delete from ntpkisi where kullaniciAdi=@ad";
            try
            {
                baglan.Open();
                #region// delete from ntpkisi database
                String silKisi = ("delete  from ntpkisi where kullaniciAdi = @kullaniciAdi");
                SqlCommand komutKisi = new SqlCommand(silKisi, baglan);
                komutKisi.Parameters.AddWithValue("@kullaniciAdi", ad);
                komutKisi.ExecuteNonQuery();
                #endregion
                #region// delete from Ucretlendirme database
                String silUcret = ("delete from ucretlendirme where kullaniciAdi = @username");
                SqlCommand komutUcret = new SqlCommand(silUcret,baglan);
                komutUcret.Parameters.AddWithValue("@username",ad);
                komutUcret.ExecuteNonQuery();
                #endregion
                #region// delete from ScSayisi database
                String silScSayisi = ("delete from ScSayisi where kullaniciAdi = @userName");
                SqlCommand komutScSayisi = new SqlCommand(silScSayisi,baglan);
                komutScSayisi.Parameters.AddWithValue("@userName",ad);
                komutScSayisi.ExecuteNonQuery();
                #endregion
                baglan.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql hatası", MessageBoxButtons.OK);
                return false;
            }
        }
        public bool sifreKontrol(String sifre)
        {
            String[] rakamlar = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            char[] chars = {'!','£','#','^','+','$','%','½','&','/','{','(','[',')',']','=','}','?','*','_','-',
                '|','é','.',':',';',',','`','@','€','ß','æ','<','>'};
            char[] bharfler = {'A','B','C','Ç','D','E','F','G','Ğ','H','I','İ','J','K','L','M','N','O','Ö','P','R','S','Ş',
                'T','U','Ü','V','Y','Z','X','Q'};
            String[] kharfler = new string[bharfler.Length];
            for (byte i = 0; i < kharfler.Length; i++)
            {
                kharfler[i] = (bharfler[i].ToString().ToLower());
            }
            byte rakam = 0, krktr = 0, bharf = 0, kharf = 0;
            if (sifre.Length > 5 && sifre.Length <= 20)
            {
                for (byte i = 0; i < sifre.Length; i++)
                {
                    foreach (string sayi in rakamlar)
                    {
                        if (sifre.Substring(i, 1) == sayi)
                        {
                            rakam++;
                        }
                    }
                    foreach (char chr in chars)
                    {
                        if (sifre.Substring(i, 1) == chr.ToString())
                        {
                            krktr++;
                        }
                    }
                    foreach (char degerb in bharfler)
                    {
                        if (sifre.Substring(i, 1) == degerb.ToString())
                        {
                            bharf++;
                        }
                    }
                    foreach (string degerk in kharfler)
                    {
                        if (sifre.Substring(i, 1) == degerk)
                        {
                            kharf++;
                        }
                    }
                }
                if ((rakam + krktr + bharf + kharf) == sifre.Length)
                {
                    if (rakam != 0 && krktr != 0 && bharf != 0 && kharf != 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sifreniz en az 1 adet karakter,büyük harf,küçük harf ve rakamdan oluşmalıdır. ", "Şifre kombinasyon hatası");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Sifrenizde geçersiz karakter bulunmaktadır. ", "geçersiz karakter hatası");
                    return false;

                }

            }
            else
            {
                MessageBox.Show("Sifreniz en az 6 karakterden oluşmalıdır", "Şifre uzunluk hatası");
                return false;
            }

        }
        public bool epostaKontrol(String ePosta)
        {
            if (ePosta.EndsWith("@gmail.com") || ePosta.EndsWith("@yandex.com") || ePosta.EndsWith("@hotmail.com") || ePosta.EndsWith("@outlook.com"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
    public class ucretlendirmeNtp
    {
        static String constring = "Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=ntp;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
        public void guncelle(String kullaniciAdi, String tarih, String ScSayisi, String saatlikUcret,String FiyatFarki,String cıkıs = "0")
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String kayit = "";
                    #region//Ücretlendirme Database
                    if (cıkıs.Equals("0"))
                    {
                        kayit = "Update ucretlendirme set girisTarihi=@addTime,adet=@adet,saatlikucret =@saatlikucrt,fiyatFarki = @fark Where kullaniciAdi = @username";
                    }
                    else
                    {
                        kayit = "Update ucretlendirme set cikisTarihi=@addTime,adet=@adet,saatlikucret =@saatlikucrt,fiyatFarki = @fark Where kullaniciAdi = @username";
                        tarih = cıkıs;
                    }

                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@addTime", tarih);
                    komut.Parameters.AddWithValue("@adet", ScSayisi);
                    komut.Parameters.AddWithValue("@saatlikucrt", saatlikUcret);
                    komut.Parameters.AddWithValue("@username", kullaniciAdi);
                    komut.Parameters.AddWithValue("@fark",FiyatFarki);
                    #endregion
                    komut.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eklenemedi.");

            }
        }
    }
    public class Scsayisi {
        static String constring = "Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=ntp;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
        public void guncelle(String kullaniciAdi,byte[] renkSayı)
        {
            try
            {

                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    #region //ScSayisi DataBase
                    String kayit = "Update ScSayisi set ikibeyaz = @ikibeyaz , ikisiyah = @ikisiyah , ikigri = @ikigri" +
                        ", ikisari = @ikisari , ikimavi = @ikimavi , ikiyesil=@ikiyesil , ikituruncu = @ikituruncu" +
                        ", ikikirmizi = @ikikirmizi , ucbeyaz = @ucbeyaz , ucsiyah = @ucsiyah , ucgri = @ucgri" +
                        ", ucsari = @ucsari , ucmavi = @ucmavi , ucyesil=@ucyesil , ucturuncu = @ucturuncu" +
                        ", uckirmizi = @uckirmizi  Where kullaniciAdi = @username";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@ikibeyaz", renkSayı[0]);
                    komut.Parameters.AddWithValue("@ikisiyah", renkSayı[1]);
                    komut.Parameters.AddWithValue("@ikigri", renkSayı[2]);
                    komut.Parameters.AddWithValue("@ikisari", renkSayı[3]);
                    komut.Parameters.AddWithValue("@ikimavi", renkSayı[4]);
                    komut.Parameters.AddWithValue("@ikiyesil", renkSayı[5]); 
                    komut.Parameters.AddWithValue("@ikituruncu", renkSayı[6]);
                    komut.Parameters.AddWithValue("@ikikirmizi", renkSayı[7]);
                    komut.Parameters.AddWithValue("@ucbeyaz", renkSayı[8]);
                    komut.Parameters.AddWithValue("@ucsiyah", renkSayı[9]);
                    komut.Parameters.AddWithValue("@ucgri", renkSayı[10]);
                    komut.Parameters.AddWithValue("@ucsari", renkSayı[11]);
                    komut.Parameters.AddWithValue("@ucmavi", renkSayı[12]);
                    komut.Parameters.AddWithValue("@ucyesil", renkSayı[13]);
                    komut.Parameters.AddWithValue("@ucturuncu", renkSayı[14]);
                    komut.Parameters.AddWithValue("@uckirmizi", renkSayı[15]);
                    komut.Parameters.AddWithValue("@username", kullaniciAdi);
                    #endregion
                    komut.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eklenemedi.");

            }
        }


    }
    public class epostaGonder {
        public static bool EPostaGonder(string konu, string icerik, String mail)
        {

            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("saffetcan5665@gmail.com".ToString());
            ePosta.To.Add(mail.ToString());
            ePosta.Subject = konu;
            ePosta.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("saffetcan5665@gmail.com".ToString(), "mtnldxzupeumigqp".ToString());
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com".ToString();
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(ePosta);
                return true;
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
                return false;
            }
        }
    }
}

