using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;

namespace TedarikYonetimi
{
    public partial class YetkiliEkle : Form
    {
        string firmaadi,firmaid,yetkiliad,yetkilisoyad,yetkiliiletisim,yetkilimail,yetkilipozisyon,sorumluid;


        public YetkiliEkle()
        {
            InitializeComponent();
        }
        DataTable firmatablo = new DataTable();
        ArrayList sektoridler = new ArrayList();
        ArrayList firmaidler = new ArrayList();
        ArrayList firmasektoridler = new ArrayList();
        ArrayList firmaadlari = new ArrayList();
        ArrayList sektoradlari = new ArrayList();
        private void YetkiliEkle_Load(object sender, EventArgs e)
        {
            firmalardtgview.Rows.Clear();
            firmalardtgview.Refresh();
            firmatablo.Columns.Add("Sektor", typeof(string));
            firmatablo.Columns.Add("FirmaAdı", typeof(string));
            yetkilikaydetbuton.Enabled = false;
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand sektorfiltre = new SqlCommand("SELECT *FROM sektorler ORDER BY sektor_adi", SqlBaglanti.baglanti);
                SqlDataReader dr = sektorfiltre.ExecuteReader();
                while (dr.Read())
                {
                    sektoridler.Add(dr["sektor_id"].ToString());
                    sektorfiltercombo.Items.Add(dr["sektor_adi"].ToString());
                }
                SqlBaglanti.baglanti.Close();

                SqlBaglanti.baglanti.Open();
                SqlCommand firmalar = new SqlCommand("SELECT firma_id,firma_adi,sektorID FROM firmalar ORDER BY firma_adi", SqlBaglanti.baglanti);
                SqlDataReader fr = firmalar.ExecuteReader();
                while (fr.Read())
                {
                    firmaadlari.Add(fr["firma_adi"].ToString());
                    firmaidler.Add(fr["firma_id"].ToString());
                    firmasektoridler.Add(fr["sektorID"].ToString());
                }
                SqlBaglanti.baglanti.Close();

                for (int i = 0; i < firmasektoridler.Count; i++)
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand sektorID = new SqlCommand("SELECT sektor_adi FROM sektorler WHERE sektor_id=@sektorid", SqlBaglanti.baglanti);
                    sektorID.Parameters.AddWithValue("@sektorid", firmasektoridler[i]);
                    SqlDataReader sr = sektorID.ExecuteReader();
                    while (sr.Read())
                    {
                        sektoradlari.Add(sr["sektor_adi"].ToString());
                    }
                    SqlBaglanti.baglanti.Close();
                }
                for (int i = 0; i < firmasektoridler.Count; i++)
                {
                    firmatablo.Rows.Add(sektoradlari[i], firmaadlari[i]);
                }
                firmalardtgview.DataSource = firmatablo;
                firmalardtgview.Columns[0].Width = 200;
                firmalardtgview.Refresh();


            }
            catch { }
        }

        private void firmaaramatextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (firmaaramatextbox.Text.Equals("Firma Adına Göre Ara"))
            {
                firmaaramatextbox.Clear();
            }
        }

        private void firmaaramatextbox_Leave(object sender, EventArgs e)
        {
            if (firmaaramatextbox.Text.Equals(""))
            {
                firmaaramatextbox.Text = "Firma Adına Göre Ara";
            }
        }

        private void firmaaramatextbox_TextChanged(object sender, EventArgs e)
        {
            if (sektorfiltercombo.Text != "Tümü")
            {
                DataView dv = firmatablo.DefaultView;
                dv.RowFilter = String.Format("FirmaAdı LIKE '%" + firmaaramatextbox.Text + "%' AND SEKTOR LIKE '" + sektorfiltercombo.SelectedItem.ToString() + "'");
                firmalardtgview.DataSource = dv;
            }
            else
            {
                DataView dv = firmatablo.DefaultView;
                dv.RowFilter = "FirmaAdı LIKE '" + "%" + firmaaramatextbox.Text + "%'";
                firmalardtgview.DataSource = dv;
            }

        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (adıtextbox.Text.Equals("*Adı"))
            {
                adıtextbox.Clear();
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (adıtextbox.Text.Equals(""))
            {
                adıtextbox.Text = "*Adı";
            }
        }

        private void soyadıtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (soyadıtextbox.Text.Equals("*Soyadı"))
            {
                soyadıtextbox.Clear();
            }
        }

        private void soyadıtextbox_Leave(object sender, EventArgs e)
        {
            if (soyadıtextbox.Text.Equals(""))
            {
                soyadıtextbox.Text = "*Soyadı";
            }
        }

        private void telnotextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (telnotextbox.Text.Equals("*Telefon Numarası"))
            {
                telnotextbox.Clear();
            }
        }

        private void mailtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mailtextbox.Text.Equals("*Mail adresi"))
            {
                mailtextbox.Clear();
            }
        }

        private void mailtextbox_Leave(object sender, EventArgs e)
        {
            if (mailtextbox.Text.Equals(""))
            {
                mailtextbox.Text = "*Mail adresi";
            }
        }

        private void telnotextbox_Leave(object sender, EventArgs e)
        {
            if (telnotextbox.Text.Equals(""))
            {
                telnotextbox.Text = "*Telefon Numarası";
            }
        }

        private void pozisyontexbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pozisyontexbox.Text.Equals("*Pozisyonu"))
            {
                pozisyontexbox.Clear();
            }
        }

        private void pozisyontexbox_Leave(object sender, EventArgs e)
        {
            if (pozisyontexbox.Text.Equals(""))
            {
                pozisyontexbox.Text = "*Pozisyonu";
            }
        }

        private void sektorfiltercombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (firmaaramatextbox.Text != "Firma Adına Göre Ara")
            {
                firmaaramatextbox.Text = "Firma Adına Göre Ara";
            }
            if (sektorfiltercombo.SelectedItem.ToString() == "Tümü")
            {
                DataView dv = firmatablo.DefaultView;
                dv.RowFilter = "Sektor LIKE '" + "%" + "" + "%'";
                firmalardtgview.DataSource = dv;
            }
            else
            {
                DataView dv = firmatablo.DefaultView;
                dv.RowFilter = "Sektor LIKE '" + "%" + sektorfiltercombo.SelectedItem.ToString() + "%'";
                firmalardtgview.DataSource = dv;
            }
        }

        private void yetkilikaydetbuton_Click(object sender, EventArgs e)
        {
            if (mailtextbox.Text == "*Mail adresi" || mailtextbox.Text == "")
            {
                yetkilimail = null;
            }
            else
            {
                yetkilimail = mailtextbox.Text;
            }
            if (adıtextbox.Text == "*Adı" || adıtextbox.Text == "")
            {
                yetkiliad = null;
            }
            else
            {
                yetkiliad = adıtextbox.Text;
            }
            if (soyadıtextbox.Text == "*Soyadı" || soyadıtextbox.Text == "")
            {
                yetkilisoyad = null;
            }
            else
            {
                yetkilisoyad = soyadıtextbox.Text;
            }
            if (telnotextbox.Text == "*Telefon Numarası" || telnotextbox.Text == "")
            {
                yetkiliiletisim = null;
            }
            else
            {
                yetkiliiletisim = telnotextbox.Text;
            }
            if (pozisyontexbox.Text == "*Pozisyonu" || pozisyontexbox.Text == "")
            {
                 yetkilipozisyon = null;
            }
            else
            {
                yetkilipozisyon = pozisyontexbox.Text;
            }

            if(yetkiliad==null || yetkilisoyad==null | yetkiliiletisim==null || yetkilimail==null || yetkilipozisyon==null)
            {
                HataEkranı hata = new HataEkranı();
                HataEkranı.durum = "HATA";
                HataEkranı.baslik = "KAYIT BAŞARISIZ";
                HataEkranı.text = "Zorunlu Alanlar * Boş Geçilemez.";
                hata.Show();
            }
            else
            {
                try
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand sorumluidsorgula = new SqlCommand("SELECT kullanici_id FROM kullanicilar WHERE kullanici_adi=@kullaniciadi", SqlBaglanti.baglanti);
                    sorumluidsorgula.Parameters.AddWithValue("@kullaniciadi", KullaniciAnaSayfa.sorumluadi);
                    SqlDataReader dr1 = sorumluidsorgula.ExecuteReader();
                    if (dr1.Read())
                    {
                        sorumluid = dr1["kullanici_id"].ToString();
                    }
                    SqlBaglanti.baglanti.Close();

                    SqlBaglanti.baglanti.Open();
                    SqlCommand firmakayit = new SqlCommand("INSERT INTO yetkililer(yetkili_adi,yetkili_soyadi,yetkili_calismapozisyonu,yetkili_iletisim,yetkili_mail,firmaID,sorumluID) " +
                        "values(@ad,@soyad,@pozisyon,@tel,@mail,@fid,@sorumluid)", SqlBaglanti.baglanti);
                    firmakayit.Parameters.AddWithValue("@ad", yetkiliad);
                    firmakayit.Parameters.AddWithValue("@soyad", yetkilisoyad);
                    firmakayit.Parameters.AddWithValue("@pozisyon", yetkilipozisyon);
                    firmakayit.Parameters.AddWithValue("@tel", yetkiliiletisim);
                    firmakayit.Parameters.AddWithValue("@mail", yetkilimail);
                    firmakayit.Parameters.AddWithValue("@fid", int.Parse(firmaid));
                    firmakayit.Parameters.AddWithValue("@sorumluid", int.Parse(sorumluid));
                    firmakayit.ExecuteNonQuery();
                    SqlBaglanti.baglanti.Close();

                    HataEkranı hatagoster = new HataEkranı();
                    HataEkranı.durum = "ONAY";
                    HataEkranı.baslik = "BAŞARILI";
                    HataEkranı.text = "Yetkili kaydı başarılı.";
                    hatagoster.Show();


                }
                catch { }
            }

        }

        private void firmasecbtn_Click(object sender, EventArgs e)
        {
            adıtextbox.Visible = true;
            soyadıtextbox.Visible = true;
            mailtextbox.Visible = true;
            telnotextbox.Visible= true;
            pozisyontexbox.Visible = true;
            yetkilikaydetbuton.Visible = true;
            try
            {
                firmaadi = firmalardtgview.CurrentRow.Cells[1].Value.ToString();
                yetkilikaydetbuton.Enabled = true;
                SqlBaglanti.baglanti.Open();
                SqlCommand firmaids = new SqlCommand("SELECT firma_id FROM firmalar WHERE firma_adi=@firmaad", SqlBaglanti.baglanti);
                firmaids.Parameters.AddWithValue("@firmaad", firmaadi);
                SqlDataReader dr = firmaids.ExecuteReader();
                if (dr.Read())
                {
                    firmaid = dr["firma_id"].ToString();
                }
                SqlBaglanti.baglanti.Close();
                firmasecimlabel.Text = firmaadi;
            }
            catch
            {

            }
        }
    }
}
