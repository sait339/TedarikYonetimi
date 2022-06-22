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
    public partial class FirmaListele : Form
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
        DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
        public FirmaListele()
        {
            InitializeComponent();
        }

        private void FirmaListele_Load(object sender, EventArgs e)
        {
            firmalardtgview.Rows.Clear();
            firmalardtgview.Refresh();
            firmalartablo.Columns.Add("ID", typeof(string));
            firmalartablo.Columns.Add("Firma Ünvan", typeof(string));
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
                foreach(string sektor in sektorIDler)
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand sektorad = new SqlCommand("SELECT sektor_adi FROM sektorler WHERE sektor_id=@sid", SqlBaglanti.baglanti);
                    sektorad.Parameters.AddWithValue("@sid", sektor);
                    SqlDataReader dr1 = sektorad.ExecuteReader();
                    if(dr1.Read())
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
                /*** NORMAL BUTON EKLEME ***/
                //Kolon Başlığı
                dgvBtn.HeaderText = "Açıklama";
                // Butonun Text
                dgvBtn.Text = "Oku";
                // Butonda Text Kullanılmasını aktifleştirme
                dgvBtn.UseColumnTextForButtonValue = true;
                // Buton çerçeve rengi
                dgvBtn.DefaultCellStyle.BackColor = Color.Red;
                // Buton seçiliykenki çerçeve rengi
                dgvBtn.DefaultCellStyle.SelectionBackColor = Color.White;
                // Butonun genişiliği
                dgvBtn.Width = 70;
                // DataGridView e ekleme
                firmalardtgview.DataSource = firmalartablo;
                firmalardtgview.Columns[0].Width = 30;
                firmalardtgview.Columns.Add(dgvBtn);
                firmalardtgview.Refresh();
            }
            catch
            {

            }

        }

        private void firmalardtgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firmaid = firmalardtgview.CurrentRow.Cells["ID"].Value.ToString();
            int index = firmaidler.IndexOf(firmaid);
            MessageBox.Show(aciklamalar[index].ToString(), "Açıklama");
        }
    }
}
