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
using System.Collections;

namespace TedarikYonetimi
{
    public partial class SozlesmeEkle : Form
    {
        string sozlesmeyolu, sozlesmedosyaadi, kayityolu, yıl;
        ArrayList sektoridler = new ArrayList();
        ArrayList firmaidler = new ArrayList();
        ArrayList firmasektoridler = new ArrayList();
        ArrayList firmaadlari = new ArrayList();
        ArrayList sektoradlari = new ArrayList();
        DataTable firmatablo = new DataTable();
        string firmaadi,firmaid, sozlesmeaciklama,sorumluid;
        public SozlesmeEkle()
        {
            InitializeComponent();
        }

        private void firmaaramatextbox_TextChanged(object sender, EventArgs e)
        {
            if (sektorfiltercombo.Text != "Tümü")
            {
                DataView dv = firmatablo.DefaultView;
                dv.RowFilter = String.Format("FirmaAdı LIKE '%"+ firmaaramatextbox.Text + "%' AND SEKTOR LIKE '"+ sektorfiltercombo.SelectedItem.ToString() + "'");  
                firmalardtgview.DataSource = dv;
            }
            else
            {
                DataView dv = firmatablo.DefaultView;
                dv.RowFilter = "FirmaAdı LIKE '" + "%" + firmaaramatextbox.Text + "%'";
                firmalardtgview.DataSource = dv;
            }
        }

        private void sektorfiltercombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (firmaaramatextbox.Text != "Firma Adına Göre Ara")
            {
                firmaaramatextbox.Text = "Firma Adına Göre Ara";
            }
            if (sektorfiltercombo.SelectedItem.ToString()=="Tümü")
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

        private void aciklamatextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aciklamatextbox.Text.Equals("Açıklama Giriniz"))
            {
                aciklamatextbox.Clear();
            }
        }

        private void aciklamatextbox_Leave(object sender, EventArgs e)
        {
            if (aciklamatextbox.Text.Equals(""))
            {
                aciklamatextbox.Text = "Açıklama Giriniz";
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

        private void firmasecbtn_Click(object sender, EventArgs e)
        {
            try
            {
                firmaadi = firmalardtgview.CurrentRow.Cells[1].Value.ToString();
                dosyasecbuton.Enabled = true;
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

        private void SozlesmeEkle_Load(object sender, EventArgs e)
        {
            firmalardtgview.Rows.Clear();
            firmalardtgview.Refresh();
            firmatablo.Columns.Add("Sektor", typeof(string));
            firmatablo.Columns.Add("FirmaAdı", typeof(string));
            sozlesmeyuklebuton.Enabled = false;
            dosyasecbuton.Enabled = false;
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

        private void dosyasecbuton_Click(object sender, EventArgs e)
        {
            OpenFileDialog sozlesme = new OpenFileDialog();
            sozlesme.Filter = "Tüm Dosyalar |*.*| Resim Dosyası *.jpg |*.jpg | PDF *.pdf|*.pdf"; ;
            sozlesme.Title = "Sözleşme Seçiniz.";
            yıl = DateTime.Now.Year.ToString();
            kayityolu = Application.StartupPath + "\\" + yıl + "Sözleşmeler";
            if (sozlesme.ShowDialog() == DialogResult.OK)
            {
                sozlesmedosyaadi = sozlesme.SafeFileName.ToString(); ;
                sozlesmeyolu = sozlesme.FileName.ToString();
                HataEkranı hatagoster = new HataEkranı();
                HataEkranı.durum = "ONAY";
                HataEkranı.baslik = "BAŞARILI";
                HataEkranı.text = "Seçim Yapıldı.";
                hatagoster.Show();
                sozlesmeyuklebuton.Enabled = true;
                dosyasecimlabel.Text = sozlesmedosyaadi;
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
        private void sozlesmeyuklebuton_Click(object sender, EventArgs e)
        {
            if (aciklamatextbox.Text == "Açıklama Giriniz" || aciklamatextbox.Text == "")
            {
                sozlesmeaciklama = "";
            }
            else
            {
                sozlesmeaciklama = aciklamatextbox.Text;
            }
            if (sozlesmeyolu != "")
            {
                if (File.Exists(kayityolu) == false)
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\" + yıl + "Sözleşmeler");
                    if (File.Exists(kayityolu + "\\" + firmaadi + "-" + sozlesmedosyaadi))
                    {
                        HataEkranı hatagoster = new HataEkranı();
                        HataEkranı.durum = "HATA";
                        HataEkranı.baslik = "BAŞARISIZ OLDU";
                        HataEkranı.text = "Sözleşmeler tablosunda\n" + sozlesmedosyaadi + "\nisimli dosya zaten mevcut...";
                        hatagoster.Show();
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
                            SqlCommand firmakayit = new SqlCommand("INSERT INTO sozlesmeler(sozlesme_dosyaadi,sozlesme_aciklama,firmaID,sorumluID) " +
                                "values(@ad,@aciklama,@fid,@sorumluid)", SqlBaglanti.baglanti);
                            firmakayit.Parameters.AddWithValue("@ad", sozlesmedosyaadi);
                            firmakayit.Parameters.AddWithValue("@aciklama", sozlesmeaciklama);
                            firmakayit.Parameters.AddWithValue("@fid", int.Parse(firmaid));
                            firmakayit.Parameters.AddWithValue("@sorumluid", int.Parse(sorumluid));
                            firmakayit.ExecuteNonQuery();
                            SqlBaglanti.baglanti.Close();

                            File.Copy(sozlesmeyolu, kayityolu + "\\" +firmaadi +"-"+ sozlesmedosyaadi);
                            HataEkranı hatagoster = new HataEkranı();
                            HataEkranı.durum = "ONAY";
                            HataEkranı.baslik = "BAŞARILI";
                            HataEkranı.text = "Sözleşme başarılı bir şekilde yüklenmiştir.";
                            hatagoster.Show();
                        }
                        catch
                        {

                        }

                        
                    }
                }
                else
                {

                }
            }
            else
            {
                //sözleşme seçilmedi
            }

        }
    }
}
