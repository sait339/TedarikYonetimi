using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TedarikYonetimi
{
    public partial class FirmaEkle : Form
    {
        string kartvizityolu, kartvizitismi,kayityolu;
        public FirmaEkle()
        {
            InitializeComponent();
        }

        private void kartviziteklebuton_Click(object sender, EventArgs e)
        {
            OpenFileDialog kartvizit = new OpenFileDialog();
            kartvizit.Filter = "Resim Dosyası (.jpg/.nef/.png) |*.jpg;*.nef;*.png";
            kartvizit.Title = "Kartvizit Seçiniz.";
            if(kartvizit.ShowDialog() == DialogResult.OK)
            {
                kartvizityolu = kartvizit.FileName;
                kartvizitismi = kartvizit.SafeFileName;
                kartvizitpicturebox.ImageLocation = kartvizityolu;
                HataEkranı hatagoster = new HataEkranı();
                HataEkranı.durum = "ONAY";
                HataEkranı.baslik = "BAŞARILI";
                HataEkranı.text = "Seçim Yapıldı.";
                hatagoster.Show();
                firmaeklebuton.Enabled = true;
            }
            else
            {
                HataEkranı hatagoster = new HataEkranı();
                HataEkranı.durum = "HATA";
                HataEkranı.baslik = "BAŞARISIZ OLDU";
                HataEkranı.text = "Dosya Seçimi Yapılmadı.";
                hatagoster.Show();
            }
            
        }

        private void firmaunvantextbox_Leave(object sender, EventArgs e)
        {
            if (firmaunvantextbox.Text.Equals(""))
            {
                firmaunvantextbox.Text = "*Firma Ünvanı Giriniz";
            }
        }

        private void aciklamatextbox_Leave(object sender, EventArgs e)
        {
            if (aciklamatextbox.Text.Equals(""))
            {
                aciklamatextbox.Text = "Açıklama Giriniz";
            }
        }

        private void websitesitextbox_Leave(object sender, EventArgs e)
        {
            if (websitesitextbox.Text.Equals(""))
            {
                websitesitextbox.Text = "*Web Sitesi";
            }
        }

        private void mailtextbox_Leave(object sender, EventArgs e)
        {
            if (mailtextbox.Text.Equals(""))
            {
                mailtextbox.Text = "*Mail Adresi";
            }
        }

        private void iletisimtexbox_Leave(object sender, EventArgs e)
        {
            if (iletisimtexbox.Text.Equals(""))
            {
                iletisimtexbox.Text = "*Telefon Numarası";
            }
        }

        private void firmaunvantextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (firmaunvantextbox.Text.Equals("*Firma Ünvanı Giriniz"))
            {
                firmaunvantextbox.Clear();
            }
        }

        private void aciklamatextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aciklamatextbox.Text.Equals("Açıklama Giriniz"))
            {
                aciklamatextbox.Clear();
            }
        }

        private void websitesitextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (websitesitextbox.Text.Equals("*Web Sitesi"))
            {
                websitesitextbox.Clear();
            }
        }

        private void mailtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mailtextbox.Text.Equals("*Mail Adresi"))
            {
                mailtextbox.Clear();
            }
        }

        private void iletisimtexbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (iletisimtexbox.Text.Equals("*Telefon Numarası"))
            {
                iletisimtexbox.Clear();
            }
        }


        private void firmaeklebuton_Click(object sender, EventArgs e)
        {
            kayityolu = Application.StartupPath + "\\Kartvizitler";
            try
            {
                if (File.Exists(kayityolu) == false)
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Kartvizitler");
                    if (File.Exists(kayityolu + "\\" + kartvizitismi))
                    {
                        HataEkranı hatagoster = new HataEkranı();
                        HataEkranı.durum = "HATA";
                        HataEkranı.baslik = "BAŞARISIZ OLDU";
                        HataEkranı.text = "Kartvizit tablosunda\n" + kartvizitismi + "\nisimli dosya zaten mevcut...";
                        hatagoster.Show();
                    }
                    else
                    {
                        HataEkranı onaygoster = new HataEkranı();
                        HataEkranı.durum = "ONAY";
                        HataEkranı.baslik = "BAŞARILI.";
                        HataEkranı.text = "Kartvizit başarılı bir şekilde yüklenmiştir.";
                        onaygoster.Show();

                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();
                        SqlCommand kartvizitkayıt = new SqlCommand("INSERT INTO kartvizitler(kartvizit_ismi) values(@kartvizit)", SqlBaglanti.baglanti);
                        kartvizitkayıt.Parameters.AddWithValue("@kartvizit", kartvizitismi);
                        kartvizitkayıt.ExecuteNonQuery();
                        SqlBaglanti.baglanti.Close();
                        string kartvizitid="";
                        SqlBaglanti.baglanti.Open();
                        SqlCommand kartvizitidsorgula = new SqlCommand("SELECT kartvizit_id FROM kartvizitler WHERE kartvizit_ismi=@kartvizit", SqlBaglanti.baglanti);
                        kartvizitidsorgula.Parameters.AddWithValue("@kartvizit", kartvizitismi);
                        SqlDataReader dr = kartvizitidsorgula.ExecuteReader();
                        if(dr.Read())
                        {
                            kartvizitid = dr["kartvizit_id"].ToString();
                        }
                        SqlBaglanti.baglanti.Close();
                        string sorumluid = "";
                        SqlBaglanti.baglanti.Open();
                        SqlCommand sorumluidsorgula = new SqlCommand("SELECT kullanici_id FROM kullanicilar WHERE kullanici_adi=@kullaniciadi", SqlBaglanti.baglanti);
                        sorumluidsorgula.Parameters.AddWithValue("@kullaniciadi",KullaniciAnaSayfa.sorumluadi);
                        SqlDataReader dr1 = sorumluidsorgula.ExecuteReader();
                        if (dr1.Read())
                        {
                            sorumluid = dr1["kullanici_id"].ToString();
                        }
                        SqlBaglanti.baglanti.Close();
                        string sektorid = "";
                        SqlBaglanti.baglanti.Open();
                        SqlCommand sektoridsorgula = new SqlCommand("SELECT sektor_id FROM sektorler WHERE sektor_adi=@sektoradi", SqlBaglanti.baglanti);
                        sektoridsorgula.Parameters.AddWithValue("@sektoradi", sektorcombobox.SelectedItem.ToString());
                        SqlDataReader dr2 = sektoridsorgula.ExecuteReader();
                        if(dr2.Read())
                        {
                            sektorid = dr2["sektor_id"].ToString();
                        }
                        SqlBaglanti.baglanti.Close();

                        string ad, odeme, calisma, website, mail, iletisim, aciklama;
                       
                        if(aciklamatextbox.Text=="Açıklama Giriniz" || aciklamatextbox.Text == "")
                        {
                            aciklama = "";
                        }
                        else
                        {
                            aciklama = aciklamatextbox.Text;
                        }
                        if(calismaseklicombobox.SelectedIndex==0)
                        {
                            calisma = null;
                        }
                        else if(calismaseklicombobox.SelectedItem.Equals("DİĞER(açıklama kısmında belirtiniz.)"))
                        {
                            calisma = "Diğer";
                        }
                        else
                        {
                            calisma = calismaseklicombobox.SelectedItem.ToString();
                        }
                        if(odemeseklicombobox.SelectedIndex==0)
                        {
                            odeme = null; 
                        }
                        else if (odemeseklicombobox.SelectedItem.Equals("DİĞER(açıklama kısmında belirtiniz.)"))
                        {
                            odeme = "Diğer";
                        }
                        else
                        {
                            odeme = odemeseklicombobox.SelectedItem.ToString();
                        }
                        if(websitesitextbox.Text== "*Web Sitesi" || websitesitextbox.Text=="")
                        {
                            website = null; 
                        }
                        else
                        {
                            website = websitesitextbox.Text;
                        }
                        if(mailtextbox.Text== "*Mail Adresi" || mailtextbox.Text == "")
                        {
                            mail = null;    
                        }
                        else
                        {
                            mail = mailtextbox.Text;
                        }
                        if(iletisimtexbox.Text == "*Telefon Numarası" || iletisimtexbox.Text=="")
                        {
                            iletisim = null;
                        }
                        else
                        {
                            iletisim = iletisimtexbox.Text;
                        }
                        if(firmaunvantextbox.Text== "*Firma Ünvanı Giriniz" || firmaunvantextbox.Text == "")
                        {
                            ad = null;
                        }
                        else
                        {
                            ad=firmaunvantextbox.Text;
                        }
                        if(ad != null && odeme != null && calisma != null && website != null && mail != null && iletisim != null)
                        {
                            SqlBaglanti.baglanti.Open();
                            SqlCommand firmakayit = new SqlCommand("INSERT INTO firmalar(firma_adi,firma_odemesekli,firma_calismasekli,firma_websitesi,firma_mail,firma_iletisim,firma_aciklama,kartvizitID,sektorID,sorumluID) " +
                                "values(@ad,@odeme,@calisma,@website,@mail,@iletisim,@aciklama,@kID,@sID,@sorumluID)", SqlBaglanti.baglanti);
                            firmakayit.Parameters.AddWithValue("@ad", ad);
                            firmakayit.Parameters.AddWithValue("@odeme", odeme);
                            firmakayit.Parameters.AddWithValue("@calisma", calisma);
                            firmakayit.Parameters.AddWithValue("@website", website);
                            firmakayit.Parameters.AddWithValue("@mail", mail);
                            firmakayit.Parameters.AddWithValue("@iletisim", iletisim);
                            firmakayit.Parameters.AddWithValue("@aciklama", aciklama);
                            firmakayit.Parameters.AddWithValue("@kID", kartvizitid);
                            firmakayit.Parameters.AddWithValue("@sID", sektorid);
                            firmakayit.Parameters.AddWithValue("@sorumluID", sorumluid);
                            firmakayit.ExecuteNonQuery();
                            SqlBaglanti.baglanti.Close();

                            File.Copy(kartvizityolu, kayityolu + "\\" + kartvizitismi);
                            HataEkranı onay = new HataEkranı();
                            HataEkranı.durum = "ONAY";
                            HataEkranı.baslik = "KAYIT BAŞARILI";
                            HataEkranı.text = "Firma başarılı bir şekilde eklenmiştir.";
                            onay.Show();
                        }
                        else
                        {
                            HataEkranı hata = new HataEkranı();
                            HataEkranı.durum = "HATA";
                            HataEkranı.baslik = "KAYIT TAMAMLANAMADI";
                            HataEkranı.text = "Zorunlu Alanlar Boş Geçilemez.";
                            hata.Show();
                        }

                        




                    }
                }
                else
                {

                }

            }
            catch(Exception) 
            { 
            }
            
        }

        private void FirmaEkle_Load(object sender, EventArgs e)
        {
            firmaeklebuton.Enabled = false;
            SqlBaglanti.baglanti.Open();
            SqlCommand sektorlistele = new SqlCommand("SELECT sektor_adi FROM sektorler ORDER BY sektor_adi", SqlBaglanti.baglanti);
            SqlDataReader dr1 = sektorlistele.ExecuteReader();
            while(dr1.Read())
            {
                sektorcombobox.Items.Add(dr1["sektor_adi"].ToString());
            }
            SqlBaglanti.baglanti.Close();

        }
    }
}
