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
    public partial class YetkiliListele : Form
    {
        DataTable yetkililertablo = new DataTable();
        ArrayList yetkiliidler = new ArrayList();
        ArrayList yetkiliadlar = new ArrayList();
        ArrayList yetkilisoyadlar = new ArrayList();
        ArrayList calismapozisyonlari = new ArrayList();
        ArrayList iletisimler = new ArrayList();
        ArrayList mailler = new ArrayList();
        ArrayList firmaIDler = new ArrayList();
        ArrayList sorumluIDler = new ArrayList();
        ArrayList firmaadlar = new ArrayList();
        ArrayList sorumluadlar = new ArrayList();
        public YetkiliListele()
        {
            InitializeComponent();
        }

        private void YetkiliListele_Load(object sender, EventArgs e)
        {
            yetkililerdtgview.Rows.Clear();
            yetkililerdtgview.Refresh();
            yetkililertablo.Columns.Add("ID", typeof(string));
            yetkililertablo.Columns.Add("AdıSoyadı", typeof(string));
            yetkililertablo.Columns.Add("Pozisyon", typeof(string));
            yetkililertablo.Columns.Add("İletişim", typeof(string));
            yetkililertablo.Columns.Add("Mail", typeof(string));
            yetkililertablo.Columns.Add("FirmaAdı", typeof(string));
            yetkililertablo.Columns.Add("Sorumlu Adı", typeof(string));
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand yetkilibilgiler = new SqlCommand("SELECT *FROM yetkililer ORDER BY yetkili_adi", SqlBaglanti.baglanti);
                SqlDataReader dr0 = yetkilibilgiler.ExecuteReader();
                while (dr0.Read())
                {
                    yetkiliidler.Add(dr0["yetkili_id"].ToString());
                    yetkiliadlar.Add(dr0["yetkili_adi"].ToString());
                    yetkilisoyadlar.Add(dr0["yetkili_soyadi"].ToString());
                    calismapozisyonlari.Add(dr0["yetkili_calismapozisyonu"].ToString());
                    iletisimler.Add(dr0["yetkili_iletisim"].ToString());
                    mailler.Add(dr0["yetkili_mail"].ToString());
                    firmaIDler.Add(dr0["firmaID"].ToString());
                    sorumluIDler.Add(dr0["sorumluID"].ToString());
                }
                SqlBaglanti.baglanti.Close();
                foreach(string sorumluid in sorumluIDler)
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand sorumluad = new SqlCommand("SELECT kullanici_adi FROM kullanicilar WHERE kullanici_id=@kid", SqlBaglanti.baglanti);
                    sorumluad.Parameters.AddWithValue("@kid", sorumluid);
                    SqlDataReader dr = sorumluad.ExecuteReader();
                    while (dr.Read())
                    {
                        sorumluadlar.Add(dr["kullanici_adi"].ToString());
                    }
                    SqlBaglanti.baglanti.Close();
                }
                foreach (string firmaid in firmaIDler)
                {
                    SqlBaglanti.baglanti.Open();
                    SqlCommand sorumluad = new SqlCommand("SELECT firma_adi FROM firmalar WHERE firma_id=@fid", SqlBaglanti.baglanti);
                    sorumluad.Parameters.AddWithValue("@fid", firmaid);
                    SqlDataReader dr2 = sorumluad.ExecuteReader();
                    while (dr2.Read())
                    {
                        firmaadlar.Add(dr2["firma_adi"].ToString());
                    }
                    SqlBaglanti.baglanti.Close();
                }
                for (int i = 0; i < yetkiliidler.Count; i++)
                {
                    yetkililertablo.Rows.Add(yetkiliidler[i], yetkiliadlar[i]+" " + yetkilisoyadlar[i], calismapozisyonlari[i], iletisimler[i], mailler[i], firmaadlar[i], sorumluadlar[i]);
                }
                yetkililerdtgview.DataSource = yetkililertablo;
                yetkililerdtgview.Refresh();
            }
            catch
            {

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

        private void yetkiliadinagorearatextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (yetkiliadinagorearatextbox.Text.Equals("Yetkili Adına Göre Ara"))
            {
                yetkiliadinagorearatextbox.Clear();
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
                DataView dv = yetkililertablo.DefaultView;
                dv.RowFilter = String.Format("AdıSoyadı LIKE '%" + yetkiliadinagorearatextbox.Text + "%' AND FirmaAdı LIKE '%" + firmaadinagorearatextbox.Text + "%'");
                yetkililerdtgview.DataSource = dv;
            }
            else if (yetkiliadinagorearatextbox.Text == "Yetkili Adına Göre Ara" && firmaadinagorearatextbox.Text == "Firma Adına Göre Ara")
            {
                yetkililerdtgview.Refresh();
            }
            else
            {
                DataView dv = yetkililertablo.DefaultView;
                dv.RowFilter = "AdıSoyadı LIKE '%" + yetkiliadinagorearatextbox.Text + "%'";
                yetkililerdtgview.DataSource = dv;
            }
        }

        private void firmaadinagorearatextbox_TextChanged(object sender, EventArgs e)
        {
            if (yetkiliadinagorearatextbox.Text != "Yetkili Adına Göre Ara")
            {
                DataView dv = yetkililertablo.DefaultView;
                dv.RowFilter = String.Format("FirmaAdı LIKE '%" + firmaadinagorearatextbox.Text + "%' AND AdıSoyadı LIKE '%" + yetkiliadinagorearatextbox.Text + "%'");
                yetkililerdtgview.DataSource = dv;
            }
            else if(yetkiliadinagorearatextbox.Text == "Yetkili Adına Göre Ara" && firmaadinagorearatextbox.Text == "Firma Adına Göre Ara")
            {
                yetkililerdtgview.Refresh();
            }
            else
            {
                DataView dv = yetkililertablo.DefaultView;
                dv.RowFilter = "FirmaAdı LIKE '%" + firmaadinagorearatextbox.Text + "%'";
                yetkililerdtgview.DataSource = dv;
            }
        }
    }
}
