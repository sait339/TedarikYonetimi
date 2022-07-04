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

namespace TedarikYonetimi
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void onaylabtn_Click(object sender, EventArgs e)
        {
            string sifre="",eskisifree, yenisifree1, yenisifree2;
            eskisifree = eskisifre.Text;
            yenisifree1 = yenisifre1.Text;
            yenisifree2 = yenisifre2.Text;
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand sifrekontrol = new SqlCommand("SELECT kullanici_sifre FROM kullanicilar WHERE kullanici_adi=@kullaniciad", SqlBaglanti.baglanti);
                sifrekontrol.Parameters.AddWithValue("@kullaniciad", KullaniciAnaSayfa.sorumluadi);
                SqlDataReader dr = sifrekontrol.ExecuteReader();
                if(dr.Read())
                {
                    sifre = dr["kullanici_sifre"].ToString();
                }
                SqlBaglanti.baglanti.Close();

                if(eskisifree==sifre && yenisifree1==yenisifree2)
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand guncelle = new SqlCommand("UPDATE kullanicilar SET kullanici_sifre=@sifre WHERE kullanici_adi=@adi", SqlBaglanti.baglanti);
                    guncelle.Parameters.AddWithValue("@sifre", yenisifree1);
                    guncelle.Parameters.AddWithValue("@adi", KullaniciAnaSayfa.sorumluadi);
                    guncelle.ExecuteNonQuery();
                    SqlBaglanti.baglanti.Close();
                    HataEkranı onay = new HataEkranı();
                    HataEkranı.durum = "ONAY";
                    HataEkranı.baslik = "GÜNCELLEME BAŞARILI";
                    HataEkranı.text = "Şifreniz Kaydedildi.";
                    onay.Show();
                }
            }
            catch
            {

            }
            

        }
    }
}
