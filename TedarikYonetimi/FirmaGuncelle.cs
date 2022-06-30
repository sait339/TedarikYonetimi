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

namespace TedarikYonetimi
{
    public partial class FirmaGuncelle : Form
    {
        DataTable firmatablo = new DataTable();
        ArrayList sektoridler = new ArrayList();
        ArrayList firmaidler = new ArrayList();
        ArrayList firmasektoridler = new ArrayList();
        ArrayList firmaadlari = new ArrayList();
        ArrayList sektoradlari = new ArrayList();
        string islemyapanid,sektorid, sorumluid, sorumluadi, firmaadi, odemesekli, calısmasekli, websitesi, mail, iletisim, aciklama, sektoradi;
        public static string firmaid;
        public FirmaGuncelle()
        {
            InitializeComponent();
        }

        private void firmasecbtn_Click(object sender, EventArgs e)
        {
            firmaunvantextbox.Visible = true;
            firmaguncellebuton.Visible = true;
            odemeseklicombobox.Visible = true;
            sektorcombobox.Visible = true;
            calismaseklicombobox.Visible = true;
            iletisimtexbox.Visible = true;
            mailtextbox.Visible = true;
            websitesitextbox.Visible = true;
            aciklamatextbox.Visible = true;
            kartvizitguncellebuton.Visible = true;
            firmasecimlabel.Text = firmalardtgview.CurrentRow.Cells[1].Value.ToString();
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand sektorgetir = new SqlCommand("SELECT *FROM sektorler ORDER BY sektor_adi", SqlBaglanti.baglanti);
                SqlDataReader dr3 = sektorgetir.ExecuteReader();
                while (dr3.Read())
                {
                    sektorcombobox.Items.Add(dr3["sektor_adi"].ToString());
                }
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                SqlCommand bilgiler = new SqlCommand("SELECT *FROM firmalar WHERE firma_adi=@firmaadi", SqlBaglanti.baglanti);
                bilgiler.Parameters.AddWithValue("@firmaadi", firmalardtgview.CurrentRow.Cells[1].Value.ToString());
                SqlDataReader dr = bilgiler.ExecuteReader();
                if (dr.Read())
                {
                    firmaunvantextbox.Text = dr["firma_adi"].ToString();
                    odemeseklicombobox.Text = dr["firma_odemesekli"].ToString();
                    calismaseklicombobox.Text = dr["firma_calismasekli"].ToString();
                    websitesitextbox.Text = dr["firma_websitesi"].ToString();
                    mailtextbox.Text = dr["firma_mail"].ToString();
                    iletisimtexbox.Text = dr["firma_iletisim"].ToString();
                    aciklamatextbox.Text = dr["firma_aciklama"].ToString();
                    sektorid = dr["sektorID"].ToString();
                    sorumluid = dr["sorumluID"].ToString();
                    firmaid = dr["firma_id"].ToString();
                }
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                SqlCommand sektor = new SqlCommand("SELECT sektor_adi FROM sektorler WHERE sektor_id=@sektorid", SqlBaglanti.baglanti);
                sektor.Parameters.AddWithValue("@sektorid", sektorid);
                SqlDataReader dr1 = sektor.ExecuteReader();
                if (dr1.Read())
                {
                    sektorcombobox.Text = dr1["sektor_adi"].ToString();
                }
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                SqlCommand sorumlu = new SqlCommand("SELECT kullanici_adi FROM kullanicilar WHERE kullanici_id=@kullaniciid", SqlBaglanti.baglanti);
                sorumlu.Parameters.AddWithValue("@kullaniciid", sorumluid);
                SqlDataReader dr2 = sorumlu.ExecuteReader();
                if (dr2.Read())
                {
                    sorumluadi = dr2["kullanici_adi"].ToString();
                }
                SqlBaglanti.baglanti.Close();
                firmasecimlabel.Text += "\nFirma kaydını yapan : " + sorumluadi;
            }
            catch
            {

            }

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

        private void kartvizitguncellebuton_Click(object sender, EventArgs e)
        {
            FirmaKartvizitGuncelle kartvizitguncelle = new FirmaKartvizitGuncelle();
            kartvizitguncelle.Show();
        }

        private void firmaguncellebuton_Click(object sender, EventArgs e)
        {
            firmaadi = firmaunvantextbox.Text;
            iletisim = iletisimtexbox.Text;
            mail = mailtextbox.Text;
            websitesi = websitesitextbox.Text;
            aciklama = aciklamatextbox.Text;
            odemesekli = odemeseklicombobox.SelectedItem.ToString();
            calısmasekli = calismaseklicombobox.SelectedItem.ToString();
            sektoradi = sektorcombobox.SelectedItem.ToString();

            SqlBaglanti.baglanti.Open();
            SqlCommand sektoridd = new SqlCommand("SELECT sektor_id FROM sektorler WHERE sektor_adi=@sektoradi", SqlBaglanti.baglanti);
            sektoridd.Parameters.AddWithValue("@sektoradi", sektoradi);
            SqlDataReader dr = sektoridd.ExecuteReader();
            if (dr.Read())
            {
                sektorid = dr["sektor_id"].ToString();
            }
            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            SqlCommand sorumluidsorgula = new SqlCommand("SELECT kullanici_id FROM kullanicilar WHERE kullanici_adi=@kullaniciadi", SqlBaglanti.baglanti);
            sorumluidsorgula.Parameters.AddWithValue("@kullaniciadi", KullaniciAnaSayfa.sorumluadi);
            SqlDataReader dr1 = sorumluidsorgula.ExecuteReader();
            if (dr1.Read())
            {
                islemyapanid = dr1["kullanici_id"].ToString();
            }
            SqlBaglanti.baglanti.Close();
            if (islemyapanid==sorumluid || GirisEkranı.yetki == "1")
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand firmakayit = new SqlCommand("UPDATE firmalar SET firma_adi=@ad,firma_odemesekli=@odeme,firma_calismasekli=@calisma,firma_websitesi=@website," +
                    "firma_mail=@mail,firma_iletisim=@iletisim,firma_aciklama=@aciklama,sektorID=@sID" +
                    " WHERE firma_id='"+firmaid+"'", SqlBaglanti.baglanti);
                firmakayit.Parameters.AddWithValue("@ad", firmaadi);
                firmakayit.Parameters.AddWithValue("@odeme", odemesekli);
                firmakayit.Parameters.AddWithValue("@calisma", calısmasekli);
                firmakayit.Parameters.AddWithValue("@website", websitesi);
                firmakayit.Parameters.AddWithValue("@mail", mail);
                firmakayit.Parameters.AddWithValue("@iletisim", iletisim);
                firmakayit.Parameters.AddWithValue("@aciklama", aciklama);
                firmakayit.Parameters.AddWithValue("@sID", int.Parse(sektorid));
                firmakayit.ExecuteNonQuery();
                SqlBaglanti.baglanti.Close();

                HataEkranı hata = new HataEkranı();
                HataEkranı.durum = "ONAY";
                HataEkranı.baslik = "GÜNCELLEME BAŞARILI";
                HataEkranı.text = "Güncelleme işlemi başarılı.";
                hata.Show();
            }
            else
            {
                HataEkranı hata = new HataEkranı();
                HataEkranı.durum = "HATA";
                HataEkranı.baslik = "YETKİLENDİRME HATASI";
                HataEkranı.text = firmaadi + " \nfirmasında "+sorumluadi+" değişiklik yapabilir.";
                hata.Show();
            }
        }


        private void sektorfiltercombo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void FirmaGuncelle_Load(object sender, EventArgs e)
        {
            firmalardtgview.Rows.Clear();
            firmalardtgview.Refresh();
            firmatablo.Columns.Add("Sektor", typeof(string));
            firmatablo.Columns.Add("FirmaAdı", typeof(string));
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
    }
}
