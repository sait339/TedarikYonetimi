using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TedarikYonetimi
{
    public partial class FirmaKartvizitGuncelle : Form
    {
        string dosyaismi, kartvizitid, kartvizityolu, kartvizitismi,islemyapanid,sorumluid;
        public FirmaKartvizitGuncelle()
        {
            InitializeComponent();
        }

        private void kartvizitguncellebuton_Click(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath + "\\Kartvizitler\\" + dosyaismi);
            File.Copy(kartvizityolu, Application.StartupPath + "\\Kartvizitler" + "\\" + dosyaismi);
            HataEkranı onay = new HataEkranı();
            HataEkranı.durum = "ONAY";
            HataEkranı.baslik = "GÜNCELLEME BAŞARILI";
            HataEkranı.text = "Kartvizit Güncellenmiştir.";
            onay.Show();
        }

        private void kartvizityüklebuton_Click(object sender, EventArgs e)
        {

            OpenFileDialog kartvizit = new OpenFileDialog();
            kartvizit.Filter = "Resim Dosyası (.jpg/.nef/.png) |*.jpg;*.nef;*.png";
            kartvizit.Title = "Kartvizit Seçiniz.";
            if (kartvizit.ShowDialog() == DialogResult.OK)
            {
                kartvizityolu = kartvizit.FileName;
                kartvizitismi = kartvizit.SafeFileName;
                kartvizitpicturebox.ImageLocation = kartvizityolu;
                HataEkranı hatagoster = new HataEkranı();
                HataEkranı.durum = "ONAY";
                HataEkranı.baslik = "BAŞARILI";
                HataEkranı.text = "Seçim Yapıldı.";
                hatagoster.Show();
                kartvizitguncellebuton.Enabled = true;
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

        private void iptalbuton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirmaKartvizitGuncelle_Load(object sender, EventArgs e)
        {
            SqlBaglanti.baglanti.Open();
            SqlCommand islemyaopanidsorgula = new SqlCommand("SELECT kullanici_id FROM kullanicilar WHERE kullanici_adi=@kullaniciadi", SqlBaglanti.baglanti);
            islemyaopanidsorgula.Parameters.AddWithValue("@kullaniciadi", KullaniciAnaSayfa.sorumluadi);
            SqlDataReader dr3 = islemyaopanidsorgula.ExecuteReader();
            if (dr3.Read())
            {
                islemyapanid = dr3["kullanici_id"].ToString();
            }
            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            SqlCommand sorumluidsorgula = new SqlCommand("SELECT sorumluID FROM firmalar WHERE firma_id=@fid", SqlBaglanti.baglanti);
            sorumluidsorgula.Parameters.AddWithValue("@fid", FirmaGuncelle.firmaid);
            SqlDataReader dr4 = sorumluidsorgula.ExecuteReader();
            if (dr4.Read())
            {
                sorumluid = dr4["sorumluID"].ToString();
            }
            SqlBaglanti.baglanti.Close();
            if (islemyapanid == sorumluid || GirisEkranı.yetki == "1")
            {
                kartvizityüklebuton.Enabled = true;
            }
            else
            {
                kartvizityüklebuton.Enabled = false;
            }
            kartvizitguncellebuton.Enabled = false;
            SqlBaglanti.baglanti.Open();
            SqlCommand kartvizitidgetir = new SqlCommand("SELECT kartvizitID FROM firmalar WHERE firma_id=@firmaid", SqlBaglanti.baglanti);
            kartvizitidgetir.Parameters.AddWithValue("@firmaid", FirmaGuncelle.firmaid);
            SqlDataReader dr1 = kartvizitidgetir.ExecuteReader();
            if (dr1.Read())
            {
                kartvizitid = dr1["kartvizitID"].ToString();
            }
            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            SqlCommand dosyaismigetir = new SqlCommand("SELECT kartvizit_ismi FROM kartvizitler WHERE kartvizit_id=@kartvizitid", SqlBaglanti.baglanti);
            dosyaismigetir.Parameters.AddWithValue("@kartvizitid", kartvizitid);
            SqlDataReader dr = dosyaismigetir.ExecuteReader();
            if (dr.Read())
            {
                dosyaismi = dr["kartvizit_ismi"].ToString();
            }
            SqlBaglanti.baglanti.Close();
            kartvizitpicturebox.ImageLocation = Application.StartupPath + "\\Kartvizitler\\" + dosyaismi;
        }
    }
}
