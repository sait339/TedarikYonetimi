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
    public partial class Tanimlamalar : Form
    {
        DataTable sektortablo = new DataTable();
        DataTable kullanicitablo = new DataTable();
        string yetki="";
        public Tanimlamalar()
        {
            InitializeComponent();
        }

        private void sektortanimla_Click(object sender, EventArgs e)
        {
            sektorgrup.Visible = true;
            kullanicigrup.Visible = false;
            try
            {
                sektortablo.Clear();
                SqlBaglanti.baglanti.Open();
                SqlCommand sektorlistele = new SqlCommand("SELECT *FROM sektorler",SqlBaglanti.baglanti);
                SqlDataAdapter dr = new SqlDataAdapter(sektorlistele);
                dr.Fill(sektortablo);
                sektorlerdtgview.DataSource = sektortablo;
                SqlBaglanti.baglanti.Close();
            }
            catch
            {

            }
            
        }

        private void sektoraditextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sektoraditextbox.Text.Equals("Sektör Adı"))
            {
                sektoraditextbox.Clear();
            }
        }

        private void sektoraciklamatextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sektoraciklamatextbox.Text.Equals("Sektör Açıklaması"))
            {
                sektoraciklamatextbox.Clear();
            }
        }

        private void sektoraditextbox_Leave(object sender, EventArgs e)
        {
            if (sektoraditextbox.Text.Equals(""))
            {
                sektoraditextbox.Text = "Sektör Adı";
            }
        }

        private void sektoraciklamatextbox_Leave(object sender, EventArgs e)
        {
            if (sektoraciklamatextbox.Text.Equals(""))
            {
                sektoraciklamatextbox.Text = "Sektör Açıklaması";
            }
        }

        private void sektoreklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(sektoraditextbox.Text!="Sektör Adı")
                {
                    string aciklama = sektoraciklamatextbox.Text;
                    if(aciklama=="Sektör Açıklaması")
                    {
                        aciklama = "";
                    }
                    SqlBaglanti.baglanti.Open();
                    SqlCommand sektorekle = new SqlCommand("INSERT INTO sektorler(sektor_adi,sektor_aciklama) VALUES (@ad,@aciklama)", SqlBaglanti.baglanti);
                    sektorekle.Parameters.AddWithValue("@ad", sektoraditextbox.Text);
                    sektorekle.Parameters.AddWithValue("@aciklama", aciklama);
                    sektorekle.ExecuteNonQuery();
                    SqlBaglanti.baglanti.Close();
                    sektortanimla.PerformClick();

                    HataEkranı onay = new HataEkranı();
                    HataEkranı.durum = "ONAY";
                    HataEkranı.baslik = "KAYIT BAŞARILI";
                    HataEkranı.text = sektoraditextbox.Text + "\nSektor başarılı bir şekilde eklenmiştir.";
                    onay.Show();
                }
                else
                {
                    HataEkranı hata = new HataEkranı();
                    HataEkranı.durum = "HATA";
                    HataEkranı.baslik = "KAYIT TAMAMLANAMADI";
                    HataEkranı.text = "Geçerli Bir sektör adı giriniz.";
                    hata.Show();
                }
                
            }
            catch
            {
                HataEkranı hata = new HataEkranı();
                HataEkranı.durum = "HATA";
                HataEkranı.baslik = "KAYIT TAMAMLANAMADI";
                HataEkranı.text = "Teknik Bir Hata Meydana Geldi.";
                hata.Show();
            }
            
        }

        private void kullanicieklebtn_Click(object sender, EventArgs e)
        {
            guncellegrup.Visible = false;
            eklegrup.Visible = true;
        }

        private void kullaniciaditextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (kullaniciaditextbox.Text.Equals("Kullanıcı Adı"))
            {
                kullaniciaditextbox.Clear();
            }
        }

        private void kullaniciaditextbox_Leave(object sender, EventArgs e)
        {
            if (kullaniciaditextbox.Text.Equals(""))
            {
                kullaniciaditextbox.Text = "Kullanıcı Adı";
            }
        }

        private void sifretextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sifretextbox.Text.Equals("Şifre"))
            {
                sifretextbox.Clear();
            }
        }

        private void sifretextbox_Leave(object sender, EventArgs e)
        {
            if (sifretextbox.Text.Equals(""))
            {
                sifretextbox.Text = "Şifre";
            }
        }


        private void kullanicitanimla_Click(object sender, EventArgs e)
        {
            sektorgrup.Visible = false;
            kullanicigrup.Visible = true;
            try
            {
                kullanicitablo.Clear();
                SqlBaglanti.baglanti.Open();
                SqlCommand kullanicilistele = new SqlCommand("SELECT *FROM kullanicilar", SqlBaglanti.baglanti);
                SqlDataAdapter dr = new SqlDataAdapter(kullanicilistele);
                dr.Fill(kullanicitablo);
                kullanicilardtgvw.DataSource = kullanicitablo;
                SqlBaglanti.baglanti.Close();
            }
            catch
            {

            }
        }

        private void kullanicikaydetbtn_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre,kontrol="";
            kullaniciadi = kullaniciaditextbox.Text;
            sifre = sifretextbox.Text;
            try
            {
                string secim = yetkicombobox.Text;
                if (secim == "ADMİN" )
                {
                    yetki = "1";
                }
                else if (secim == "KULLANICI")
                {
                    yetki = "2";
                }
                else if (secim == "MUHASEBE")
                {
                    yetki = "3";
                }
                else
                {
                    HataEkranı hata1 = new HataEkranı();
                    HataEkranı.durum = "HATA";
                    HataEkranı.baslik = "KAYIT TAMAMLANAMADI";
                    HataEkranı.text = "Yetki Seçimi Yapılmadı";
                    hata1.Show();
                }

                if (kullaniciadi == "" || kullaniciadi == "Kullanıcı Adı" || sifre == "" || sifre == "Şifre" || yetki == "")
                {
                    HataEkranı hata = new HataEkranı();
                    HataEkranı.durum = "HATA";
                    HataEkranı.baslik = "KAYIT TAMAMLANAMADI";
                    HataEkranı.text = "Geçerli bir kullanıcı adı, şifre ve yetki giriniz.";
                    hata.Show();
                }
                else
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand kullaniciadikontrol = new SqlCommand("SELECT kullanici_adi FROM kullanicilar", SqlBaglanti.baglanti);
                    SqlDataReader dr = kullaniciadikontrol.ExecuteReader();
                    while (dr.Read())
                    {
                        if (kullaniciadi.Equals(dr["kullanici_adi"].ToString()))
                        {
                            SqlBaglanti.baglanti.Close();
                            HataEkranı hata = new HataEkranı();
                            HataEkranı.durum = "HATA";
                            HataEkranı.baslik = "KAYIT TAMAMLANAMADI";
                            HataEkranı.text = "Kullanıcı Adı Zaten Kayıtlı.";
                            hata.Show();
                            kontrol = "1";
                            break;
                        }
                    }
                    if (kontrol != "1")
                    {
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();
                        SqlCommand sektorekle = new SqlCommand("INSERT INTO kullanicilar(kullanici_adi,kullanici_sifre,kullanici_yetki) VALUES (@ad,@sifre,@yetki)", SqlBaglanti.baglanti);
                        sektorekle.Parameters.AddWithValue("@ad", kullaniciadi);
                        sektorekle.Parameters.AddWithValue("@sifre", sifre);
                        sektorekle.Parameters.AddWithValue("@yetki", yetki);
                        sektorekle.ExecuteNonQuery();
                        SqlBaglanti.baglanti.Close();
                        kullanicitanimla.PerformClick();
                    }
                }
            }
            catch
            {

            }
            
        }

        private void kullaniciguncellebtn_Click(object sender, EventArgs e)
        {
            guncellegrup.Visible = true;
            eklegrup.Visible = false;
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string secim = kullaniciyetki.Text;
                if (secim == "ADMİN")
                {
                    yetki = "1";
                }
                else if (secim == "KULLANICI" )
                {
                    yetki = "2";
                }
                else if (secim == "MUHASEBE" )
                {
                    yetki = "3";
                }
                else
                {
                    HataEkranı hata1 = new HataEkranı();
                    HataEkranı.durum = "HATA";
                    HataEkranı.baslik = "KAYIT TAMAMLANAMADI";
                    HataEkranı.text = "Yetki Seçimi Yapılmadı";
                    hata1.Show();
                }

                string sifree = sifre.Text;
                SqlBaglanti.baglanti.Open();
                SqlCommand yetkiliguncelleme = new SqlCommand("UPDATE kullanicilar SET kullanici_sifre=@sifre,kullanici_yetki=@yetki WHERE kullanici_adi=@ad", SqlBaglanti.baglanti);
                yetkiliguncelleme.Parameters.AddWithValue("@sifre", sifree);
                yetkiliguncelleme.Parameters.AddWithValue("@yetki", yetki);
                yetkiliguncelleme.Parameters.AddWithValue("@ad", kullaniciadi.Text);
                yetkiliguncelleme.ExecuteNonQuery();
                SqlBaglanti.baglanti.Close();
                HataEkranı hata = new HataEkranı();
                HataEkranı.durum = "ONAY";
                HataEkranı.baslik = "GÜNCELLEME BAŞARILI";
                HataEkranı.text = "Güncelleme işlemi başarılı.";
                hata.Show();
                kullanicitanimla.PerformClick();
            }
            catch
            {

            }
            
            

        }


        private void kullanicilardtgvw_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ksifre, yetkidrum;
                ksifre = sifre.Text;
                if (eklegrup.Visible == false && guncellegrup.Visible == true)
                {
                    kullaniciadi.Text = kullanicilardtgvw.CurrentRow.Cells[1].Value.ToString();
                    sifre.Text = kullanicilardtgvw.CurrentRow.Cells[2].Value.ToString();
                    yetkidrum = kullanicilardtgvw.CurrentRow.Cells[3].Value.ToString();
                    if (yetkidrum == "1")
                    {
                        kullaniciyetki.Text = "ADMİN";
                    }
                    else if (yetkidrum == "2")
                    {
                        kullaniciyetki.Text = "KULLANICI";
                    }
                    else if (yetkidrum == "3")
                    {
                        kullaniciyetki.Text = "MUHASEBE";
                    }
                }
            }
            catch
            {

            }
        }
    }
}
