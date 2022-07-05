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
    public partial class SozlesmeSil : Form
    {
        DataTable sozlesmeler = new DataTable();
        string dosya;
        public SozlesmeSil()
        {
            InitializeComponent();
        }

        private void SozlesmeSil_Load(object sender, EventArgs e)
        {
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

        private void sozlesmesilbtn_Click(object sender, EventArgs e)
        {
            dosya = "\\\\netsissrv\\NETSISV9\\tedarikyonetim\\Empero";
            string sozlesmeid, sozlesmedosyaadi,sorumlu,firmaadi;
            sozlesmeid = sozlesmelerdtgview.CurrentRow.Cells[0].Value.ToString();
            sozlesmedosyaadi = sozlesmelerdtgview.CurrentRow.Cells[1].Value.ToString();
            sorumlu = sozlesmelerdtgview.CurrentRow.Cells[4].Value.ToString();
            firmaadi = sozlesmelerdtgview.CurrentRow.Cells[3].Value.ToString();
            try
            {
                if (sorumlu == KullaniciAnaSayfa.sorumluadi || GirisEkranı.yetki == "1")
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show(sozlesmedosyaadi + " silinceketir.\nOnaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        SqlBaglanti.baglanti.Open();
                        SqlCommand yetkilisil = new SqlCommand("DELETE FROM sozlesmeler WHERE sozlesme_id=@sozlesmeid", SqlBaglanti.baglanti);
                        yetkilisil.Parameters.AddWithValue("@sozlesmeid", sozlesmeid);
                        yetkilisil.ExecuteNonQuery();
                        SqlBaglanti.baglanti.Close();
                        File.Delete(dosya + "\\2022Sözleşmeler\\" + firmaadi + "-" + sozlesmedosyaadi);
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
                    HataEkranı.text = sozlesmedosyaadi + " sözleşmesi üzerinde\n" + sorumlu + " işlem yapabilir.";
                    hata.Show();
                }
            }
            catch
            {

            }
        }

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
    }
}
