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
                        File.Delete(Application.StartupPath + "\\2022Sözleşmeler\\" + firmaadi + "-" + sozlesmedosyaadi);
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
    }
}
