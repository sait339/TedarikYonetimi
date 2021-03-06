using System;
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
    public partial class SozlesmeGuncelle : Form
    {
        DataTable sozlesmeler = new DataTable();
        string sozlesmeadi, sozlesmeyolu,sozlesmeid,sozlesmedosyaadi,aciklama,firmaadi,sorumluadi,dosya;

        private void sozlesmeadinagoreara_TextChanged(object sender, EventArgs e)
        {
            if (firmaaramatextbox.Text != "Firma Adına Göre Ara")
            {
                DataView dv = sozlesmeler.DefaultView;
                dv.RowFilter = String.Format("SözleşmeAdı LIKE '%" + sozlesmeadinagoreara.Text + "%' AND FirmaAdı LIKE '%" + firmaaramatextbox.Text + "%'");
                sozlesmelerdtgview.DataSource = dv;
            }
            else if (sozlesmeadinagoreara.Text == "Sözleşme Adına Göre Ara" && firmaaramatextbox.Text == "Firma Adına Göre Ara")
            {
                sozlesmelerdtgview.Refresh();
            }
            else
            {
                DataView dv = sozlesmeler.DefaultView;
                dv.RowFilter = "SözleşmeAdı LIKE '%" + sozlesmeadinagoreara.Text + "%'";
                sozlesmelerdtgview.DataSource = dv;
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

        private void sozlesmeadinagoreara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sozlesmeadinagoreara.Text.Equals("Sözleşme Adına Göre Ara"))
            {
                sozlesmeadinagoreara.Clear();
            }
        }

        private void sozlesmeadinagoreara_Leave(object sender, EventArgs e)
        {
            if (sozlesmeadinagoreara.Text.Equals(""))
            {
                sozlesmeadinagoreara.Text = "Sözleşme Adına Göre Ara";
            }
        }

        private void firmaaramatextbox_TextChanged(object sender, EventArgs e)
        {
            if (sozlesmeadinagoreara.Text != "Sözleşme Adına Göre Ara")
            {
                DataView dv = sozlesmeler.DefaultView;
                dv.RowFilter = String.Format("FirmaAdı LIKE '%" + firmaaramatextbox.Text + "%' AND SözleşmeAdı LIKE '%" + sozlesmeadinagoreara.Text + "%'");
                sozlesmelerdtgview.DataSource = dv;
            }
            else if (firmaaramatextbox.Text == "Firma Adına Göre Ara" && sozlesmeadinagoreara.Text == "Sözleşme Adına Göre Ara")
            {
                sozlesmelerdtgview.Refresh();
            }
            else
            {
                DataView dv = sozlesmeler.DefaultView;
                dv.RowFilter = "SözleşmeAdı LIKE '%" + firmaaramatextbox.Text + "%'";
                sozlesmelerdtgview.DataSource = dv;
            }
        }

        public SozlesmeGuncelle()
        {
            InitializeComponent();
        }

        private void sozlesmesecbtn_Click(object sender, EventArgs e)
        {
            sozlesmeid= sozlesmelerdtgview.CurrentRow.Cells[0].Value.ToString();
            sozlesmedosyaadi = sozlesmelerdtgview.CurrentRow.Cells[1].Value.ToString();
            aciklama = sozlesmelerdtgview.CurrentRow.Cells[2].Value.ToString();
            firmaadi = sozlesmelerdtgview.CurrentRow.Cells[3].Value.ToString();
            sorumluadi = sozlesmelerdtgview.CurrentRow.Cells[4].Value.ToString();
            aciklamatextbox.Text = aciklama;
            sozlesmedegistirbtn.Enabled = true;
        }

        private void SozlesmeGuncelle_Load(object sender, EventArgs e)
        {
            sozlesmedegistirbtn.Enabled = false;
            sozlesmeonaylabtn.Enabled = false;
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand sozlesmelergetir = new SqlCommand("SELECT *FROM SOZLESMELER_GETIR", SqlBaglanti.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(sozlesmelergetir);
                da.Fill(sozlesmeler);
                sozlesmelerdtgview.DataSource = sozlesmeler;
                sozlesmeler.Columns["sozlesme_id"].ColumnName = "ID";
                sozlesmeler.Columns["sozlesme_dosyaadi"].ColumnName = "SözleşmeAdı";
                sozlesmeler.Columns["sozlesme_aciklama"].ColumnName = "Açıklama";
                sozlesmeler.Columns["firma_adi"].ColumnName = "FirmaAdı";
                sozlesmeler.Columns["kullanici_adi"].ColumnName = "Sorumlu";
                sozlesmelerdtgview.Columns[0].Width = 30;
                sozlesmelerdtgview.Refresh();
                SqlBaglanti.baglanti.Close();
                sozlesmelerdtgview.Refresh();
            }
            catch
            {

            }
        }

        private void sozlesmedegistirbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog kartvizit = new OpenFileDialog();
                kartvizit.Filter = "Tüm Dosyalar |*.*| Resim Dosyası *.jpg |*.jpg | PDF *.pdf|*.pdf";
                kartvizit.Title = "Sözleşme Seçiniz.";
                if (kartvizit.ShowDialog() == DialogResult.OK)
                {
                    sozlesmeyolu = kartvizit.FileName;
                    sozlesmeadi= kartvizit.SafeFileName;
                    HataEkranı hatagoster = new HataEkranı();
                    HataEkranı.durum = "ONAY";
                    HataEkranı.baslik = "BAŞARILI";
                    HataEkranı.text = "Seçim Yapıldı.";
                    hatagoster.Show();
                    sozlesmeonaylabtn.Enabled = true;
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
            catch
            {

            }
        }

        private void sozlesmeonaylabtn_Click(object sender, EventArgs e)
        {
            dosya = "\\\\netsissrv\\NETSISV9\\tedarikyonetim\\Empero";
            try
            {
                if(sorumluadi==KullaniciAnaSayfa.sorumluadi || GirisEkranı.yetki == "1")
                {
                    File.Delete(dosya + "\\2022Sözleşmeler\\" + firmaadi + "-" + sozlesmedosyaadi);
                    File.Copy(sozlesmeyolu, dosya + "\\2022Sözleşmeler" + "\\" + firmaadi + "-" + sozlesmeadi);
                    SqlBaglanti.baglanti.Open();
                    SqlCommand guncelle = new SqlCommand("UPDATE sozlesmeler SET sozlesme_aciklama=@aciklama,sozlesme_dosyaadi=@dosyaadi WHERE sozlesme_id=@id", SqlBaglanti.baglanti);
                    guncelle.Parameters.AddWithValue("@aciklama",aciklamatextbox.Text);
                    guncelle.Parameters.AddWithValue("@dosyaadi",sozlesmeadi);
                    guncelle.Parameters.AddWithValue("@id",sozlesmeid);
                    guncelle.ExecuteNonQuery();
                    SqlBaglanti.baglanti.Close();
                    HataEkranı onay = new HataEkranı();
                    HataEkranı.durum = "ONAY";
                    HataEkranı.baslik = "GÜNCELLEME BAŞARILI";
                    HataEkranı.text = firmaadi + "-" + sozlesmedosyaadi + " sözleşmesi\n" +
                        firmaadi+"-"+sozlesmeadi+" olarak güncellenmiştir.";
                    onay.Show();
                }
                else
                {
                    HataEkranı hata = new HataEkranı();
                    HataEkranı.durum = "HATA";
                    HataEkranı.baslik = "YETKİLENDİRME HATASI";
                    HataEkranı.text = firmaadi + "-" + sozlesmedosyaadi + "\nsözleşmesi üzerinde " + sorumluadi + " işlem yapabilir.";
                    hata.Show();
                }
                
            }
            catch
            {

            }
        }
    }
}
