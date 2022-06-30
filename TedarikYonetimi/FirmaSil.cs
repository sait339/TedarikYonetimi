using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TedarikYonetimi
{
    public partial class FirmaSil : Form
    {
        DataTable firmalartablo = new DataTable();
        ArrayList firmaidler = new ArrayList();
        ArrayList firmaadlari = new ArrayList();
        ArrayList odemesekilleri = new ArrayList();
        ArrayList calismasekilleri = new ArrayList();
        ArrayList websiteleri = new ArrayList();
        ArrayList mailler = new ArrayList();
        ArrayList iletisimler = new ArrayList();
        ArrayList aciklamalar = new ArrayList();
        ArrayList kartvizitIDler = new ArrayList();
        ArrayList sektorIDler = new ArrayList();
        ArrayList sektoradlar = new ArrayList();
        ArrayList sorumluIDler = new ArrayList();
        ArrayList sorumluadlar = new ArrayList();
        string islemyapanid,sorumluid,kartvizitID,sorumluID;

        public FirmaSil()
        {
            InitializeComponent();
        }

        private void FirmaSil_Load(object sender, EventArgs e)
        {
            SqlBaglanti.baglanti.Open();
            SqlCommand sektorfiltre = new SqlCommand("SELECT *FROM sektorler ORDER BY sektor_adi", SqlBaglanti.baglanti);
            SqlDataReader dr0 = sektorfiltre.ExecuteReader();
            while (dr0.Read())
            {
                sektorfiltercombo.Items.Add(dr0["sektor_adi"].ToString());
            }

            SqlBaglanti.baglanti.Close();
            firmalardtgview.Rows.Clear();
            firmalardtgview.Refresh();
            firmalartablo.Columns.Add("ID", typeof(string));
            firmalartablo.Columns.Add("FirmaÜnvan", typeof(string));
            firmalartablo.Columns.Add("Ödeme Şekli", typeof(string));
            firmalartablo.Columns.Add("Çalışma Şekli", typeof(string));
            firmalartablo.Columns.Add("Web Sitesi", typeof(string));
            firmalartablo.Columns.Add("Mail Adresi", typeof(string));
            firmalartablo.Columns.Add("İletişim", typeof(string));
            firmalartablo.Columns.Add("Sektör", typeof(string));
            firmalartablo.Columns.Add("Sorumlu Adı", typeof(string));
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand firmalar = new SqlCommand("SELECT *FROM firmalar ORDER BY firma_adi", SqlBaglanti.baglanti);
                SqlDataReader dr = firmalar.ExecuteReader();
                while (dr.Read())
                {
                    firmaidler.Add(dr["firma_id"].ToString());
                    firmaadlari.Add(dr["firma_adi"].ToString());
                    odemesekilleri.Add(dr["firma_odemesekli"].ToString());
                    calismasekilleri.Add(dr["firma_calismasekli"].ToString());
                    websiteleri.Add(dr["firma_websitesi"].ToString());
                    mailler.Add(dr["firma_mail"].ToString());
                    iletisimler.Add(dr["firma_iletisim"].ToString());
                    aciklamalar.Add(dr["firma_aciklama"].ToString());
                    kartvizitIDler.Add(dr["kartvizitID"].ToString());
                    sektorIDler.Add(dr["sektorID"].ToString());
                    sorumluIDler.Add(dr["sorumluID"].ToString());
                }
                SqlBaglanti.baglanti.Close();
                foreach (string sektor in sektorIDler)
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand sektorad = new SqlCommand("SELECT sektor_adi FROM sektorler WHERE sektor_id=@sid", SqlBaglanti.baglanti);
                    sektorad.Parameters.AddWithValue("@sid", sektor);
                    SqlDataReader dr1 = sektorad.ExecuteReader();
                    if (dr1.Read())
                    {
                        sektoradlar.Add(dr1["sektor_adi"].ToString());
                    }
                    SqlBaglanti.baglanti.Close();
                }
                foreach (string sorumlu in sorumluIDler)
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand sorumluad = new SqlCommand("SELECT kullanici_adi FROM kullanicilar WHERE kullanici_id=@kid", SqlBaglanti.baglanti);
                    sorumluad.Parameters.AddWithValue("@kid", sorumlu);
                    SqlDataReader dr2 = sorumluad.ExecuteReader();
                    if (dr2.Read())
                    {
                        sorumluadlar.Add(dr2["kullanici_adi"].ToString());
                    }
                    SqlBaglanti.baglanti.Close();
                }
                for (int i = 0; i < firmaidler.Count; i++)
                {
                    firmalartablo.Rows.Add(firmaidler[i], firmaadlari[i], odemesekilleri[i], calismasekilleri[i], websiteleri[i], mailler[i], iletisimler[i], sektoradlar[i], sorumluadlar[i]);
                }
                
                firmalardtgview.DataSource = firmalartablo;
                firmalardtgview.Columns[0].Width = 30;
                firmalardtgview.Refresh();
            }
            catch
            {

            }
        }

        private void firmaaramatextbox_TextChanged(object sender, EventArgs e)
        {
            if (sektorfiltercombo.Text != "Tümü")
            {
                DataView dv = firmalartablo.DefaultView;
                dv.RowFilter = String.Format("FirmaÜnvan LIKE '%" + firmaaramatextbox.Text + "%' AND Sektör LIKE '" + sektorfiltercombo.SelectedItem.ToString() + "'");
                firmalardtgview.DataSource = dv;
            }
            else
            {
                DataView dv = firmalartablo.DefaultView;
                dv.RowFilter = "FirmaÜnvan LIKE '%" + firmaaramatextbox.Text + "%'";
                firmalardtgview.DataSource = dv;
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
                DataView dv = firmalartablo.DefaultView;
                dv.RowFilter = "Sektör LIKE '" + "%" + "" + "%'";
                firmalardtgview.DataSource = dv;
            }
            else
            {
                DataView dv = firmalartablo.DefaultView;
                dv.RowFilter = "Sektör LIKE '" + "%" + sektorfiltercombo.SelectedItem.ToString() + "%'";
                firmalardtgview.DataSource = dv;
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

        private void firmasilbuton_Click(object sender, EventArgs e)
        {
            string firmaid = firmalardtgview.CurrentRow.Cells["ID"].Value.ToString();
            string firmaadi = firmalardtgview.CurrentRow.Cells["FirmaÜnvan"].Value.ToString();
            string sorumluadi = firmalardtgview.CurrentRow.Cells["Sorumlu Adı"].Value.ToString();
            int index = firmaidler.IndexOf(firmaid);
            string kartvizitID = kartvizitIDler[index].ToString();
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand sorumluidsorgula = new SqlCommand("SELECT kullanici_id FROM kullanicilar WHERE kullanici_adi=@kullaniciadi", SqlBaglanti.baglanti);
                sorumluidsorgula.Parameters.AddWithValue("@kullaniciadi", KullaniciAnaSayfa.sorumluadi);
                SqlDataReader dr1 = sorumluidsorgula.ExecuteReader();
                if (dr1.Read())
                {
                    islemyapanid = dr1["kullanici_id"].ToString();
                }
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                SqlCommand firmabilgisorgula = new SqlCommand("SELECT kartvizitID,sorumluID FROM firmalar WHERE firma_id=@firmaid", SqlBaglanti.baglanti);
                firmabilgisorgula.Parameters.AddWithValue("@firmaid", firmaid);
                SqlDataReader dr = firmabilgisorgula.ExecuteReader();
                if (dr.Read())
                {
                    kartvizitID = dr["kartvizitID"].ToString();
                    sorumluID = dr["sorumluID"].ToString();
                }
                SqlBaglanti.baglanti.Close();
                if(sorumluID==islemyapanid)//silme işlemi
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Firmaya tüm bilgiler silinceketir.\nOnaylıyor musunuz?", "Dikkat" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
                    if(dialog==DialogResult.Yes)
                    {
                        SqlBaglanti.baglanti.Open();
                        SqlCommand kartvizitadisorgula = new SqlCommand("SELECT kartvizit_ismi FROM kartvizitler WHERE kartvizit_id=@kID", SqlBaglanti.baglanti);
                        kartvizitadisorgula.Parameters.AddWithValue("@kID", kartvizitID);
                        SqlDataReader kr = kartvizitadisorgula.ExecuteReader();
                        if (kr.Read())
                        {
                            string kartvizitADI = kr["kartvizit_ismi"].ToString();
                            File.Delete(Application.StartupPath + "\\Kartvizitler\\" + kartvizitADI);
                        }
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();
                        SqlCommand sozlesmelersorgula = new SqlCommand("SELECT sozlesme_dosyaadi FROM sozlesmeler WHERE firmaID=@fID", SqlBaglanti.baglanti);
                        sozlesmelersorgula.Parameters.AddWithValue("@fID", firmaid);
                        SqlDataReader sr = sozlesmelersorgula.ExecuteReader();
                        while (sr.Read())
                        {
                            string sozlesmead = sr["sozlesme_dosyaadi"].ToString();
                            File.Delete(Application.StartupPath + "\\2022Sözleşmeler\\" +firmaadi +"-"+ sozlesmead);
                        }
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();
                        SqlCommand sozlesmesil = new SqlCommand("DELETE FROM sozlesmeler WHERE firmaID=@firmaid", SqlBaglanti.baglanti);
                        sozlesmesil.Parameters.AddWithValue("@firmaid", firmaid);
                        sozlesmesil.ExecuteNonQuery();
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();
                        SqlCommand yetkilisil = new SqlCommand("DELETE FROM yetkililer WHERE firmaID=@firmaid", SqlBaglanti.baglanti);
                        yetkilisil.Parameters.AddWithValue("@firmaid", firmaid);
                        yetkilisil.ExecuteNonQuery();
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();
                        SqlCommand firmasil = new SqlCommand("DELETE FROM firmalar WHERE firma_id=@firmaid", SqlBaglanti.baglanti);
                        firmasil.Parameters.AddWithValue("@firmaid", firmaid);
                        firmasil.ExecuteNonQuery();
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();
                        SqlCommand kartvizitsil = new SqlCommand("DELETE FROM kartvizitler WHERE kartvizit_id=@kartvizitid", SqlBaglanti.baglanti);
                        kartvizitsil.Parameters.AddWithValue("@kartvizitid", kartvizitID);
                        kartvizitsil.ExecuteNonQuery();
                        SqlBaglanti.baglanti.Close();

                        HataEkranı hata = new HataEkranı();
                        HataEkranı.durum = "ONAY";
                        HataEkranı.baslik = "BAŞARILI";
                        HataEkranı.text = "Silme işlemi tamamlandı.";
                        hata.Show();
                    }
                    else
                    {
                        HataEkranı hata = new HataEkranı();
                        HataEkranı.durum = "HATA";
                        HataEkranı.baslik = "BİLGİ";
                        HataEkranı.text = "İŞLEMDEN VAZGEÇİLDİ";
                        hata.Show();
                    }
                    

                }
                else
                {
                    HataEkranı hata = new HataEkranı();
                    HataEkranı.durum = "HATA";
                    HataEkranı.baslik = "YETKİLENDİRME HATASI";
                    HataEkranı.text = firmaadi + " \nfirmasında " + sorumluadi + " işlem yapabilir.";
                    hata.Show();
                }
            }
            catch
            {
                HataEkranı hata = new HataEkranı();
                HataEkranı.durum = "HATA";
                HataEkranı.baslik = "HATA";
                HataEkranı.text = "Silme İşlemi Sırasında Hata Meydana Geldi";
                hata.Show();
            }
        }
    }
}
