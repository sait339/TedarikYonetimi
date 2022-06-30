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
    public partial class YetkiliSil : Form
    {
        DataTable tablo = new DataTable();
        public YetkiliSil()
        {
            InitializeComponent();
        }

        private void YetkiliSil_Load(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand yetkiligetir = new SqlCommand("SELECT *FROM YETKILILER_GETIR", SqlBaglanti.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(yetkiligetir);
                da.Fill(tablo);
                yetkililerdtgview.DataSource = tablo;
                tablo.Columns["kullanici_adi"].ColumnName = "Sorumlu Adı";
                tablo.Columns["yetkili_calismapozisyonu"].ColumnName = "Çalışma Pozisyonu";
                tablo.Columns["firma_adi"].ColumnName = "FirmaAdı";
                tablo.Columns["yetkili_adi"].ColumnName = "Adı";
                tablo.Columns["yetkili_soyadi"].ColumnName = "Soyadı";
                tablo.Columns["yetkili_id"].ColumnName = "ID";
                yetkililerdtgview.Columns[0].Width = 30;
                yetkililerdtgview.Refresh();
                SqlBaglanti.baglanti.Close();
            }
            catch
            {

            }

        }

        private void yetkiliadinagorearatextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (yetkiliadinagorearatextbox.Text.Equals("Yetkili Adına Göre Ara"))
            {
                yetkiliadinagorearatextbox.Clear();
            }
        }

        private void firmaadinagorearatextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (firmaadinagorearatextbox.Text.Equals("Firma Adına Göre Ara"))
            {
                firmaadinagorearatextbox.Clear();
            }
        }

        private void firmaadinagorearatextbox_Leave(object sender, EventArgs e)
        {
            if (firmaadinagorearatextbox.Text.Equals(""))
            {
                firmaadinagorearatextbox.Text = "Firma Adına Göre Ara";
            }
        }

        private void yetkiliadinagorearatextbox_Leave(object sender, EventArgs e)
        {
            if (yetkiliadinagorearatextbox.Text.Equals(""))
            {
                yetkiliadinagorearatextbox.Text = "Yetkili Adına Göre Ara";
            }
        }

        private void yetkiliadinagorearatextbox_TextChanged(object sender, EventArgs e)
        {
            if (firmaadinagorearatextbox.Text != "Firma Adına Göre Ara")
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = String.Format("Adı LIKE '%" + yetkiliadinagorearatextbox.Text + "%' OR Soyadı LIKE '%" + yetkiliadinagorearatextbox.Text + "%' AND FirmaAdı LIKE ' % " + yetkiliadinagorearatextbox.Text + " % '");
                yetkililerdtgview.DataSource = dv;
            }
            else if (yetkiliadinagorearatextbox.Text == "Yetkili Adına Göre Ara" && firmaadinagorearatextbox.Text == "Firma Adına Göre Ara")
            {
                yetkililerdtgview.Refresh();
            }
            else
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = "Adı LIKE '%" + yetkiliadinagorearatextbox.Text + "%' OR Soyadı LIKE '%" + yetkiliadinagorearatextbox.Text + "%'";
                yetkililerdtgview.DataSource = dv;
            }
        }

        private void firmaadinagorearatextbox_TextChanged(object sender, EventArgs e)
        {
            if (yetkiliadinagorearatextbox.Text != "Yetkili Adına Göre Ara")
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = String.Format("FirmaAdı LIKE '%" + firmaadinagorearatextbox.Text + "%' AND Adı LIKE '%" + yetkiliadinagorearatextbox.Text + "%' OR Soyadı LIKE '%" + yetkiliadinagorearatextbox.Text + "%'");
                yetkililerdtgview.DataSource = dv;
            }
            else if (yetkiliadinagorearatextbox.Text == "Yetkili Adına Göre Ara" && firmaadinagorearatextbox.Text == "Firma Adına Göre Ara")
            {
                yetkililerdtgview.Refresh();
            }
            else
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = "FirmaAdı LIKE '%" + firmaadinagorearatextbox.Text + "%'";
                yetkililerdtgview.DataSource = dv;
            }
        }

        private void yetkilisilbuton_Click(object sender, EventArgs e)
        {
            string sorumlu, yetkiliid,yetkiliad;
            try
            {
                sorumlu = yetkililerdtgview.CurrentRow.Cells[5].Value.ToString();
                yetkiliad= yetkililerdtgview.CurrentRow.Cells[1].Value.ToString();
                yetkiliad += " "+ yetkililerdtgview.CurrentRow.Cells[2].Value.ToString();
                yetkiliid = yetkililerdtgview.CurrentRow.Cells[0].Value.ToString();
                if (sorumlu == KullaniciAnaSayfa.sorumluadi || GirisEkranı.yetki == "1")
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show(yetkiliad+" silinceketir.\nOnaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dialog == DialogResult.Yes)
                    {
                        SqlBaglanti.baglanti.Open();
                        SqlCommand yetkilisil = new SqlCommand("DELETE FROM yetkililer WHERE yetkili_id=@yetkiliid", SqlBaglanti.baglanti);
                        yetkilisil.Parameters.AddWithValue("@yetkiliid", yetkiliid);
                        yetkilisil.ExecuteNonQuery();
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
                    HataEkranı.text = yetkiliad+" yetkilisi üzerinde\n"+sorumlu + " işlem yapabilir.";
                    hata.Show();
                }
            }
            catch
            {

            }
        }
    }
}
