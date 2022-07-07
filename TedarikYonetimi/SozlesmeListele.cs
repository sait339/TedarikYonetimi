using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TedarikYonetimi
{
    public partial class SozlesmeListele : Form
    {
        DataTable sozlesmeler = new DataTable();
        string dosya;
        DataGridViewButtonColumn goruntule = new DataGridViewButtonColumn();
        public SozlesmeListele()
        {
            InitializeComponent();
        }

        private void SozlesmeListele_Load(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand sozlesmelergetir = new SqlCommand("SELECT *FROM SOZLESMELER_GETIR",SqlBaglanti.baglanti);
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

                goruntule.Name = "Görüntüle";
                goruntule.HeaderText = "Görüntüle";
                goruntule.Text = "Görüntüle";
                goruntule.UseColumnTextForButtonValue = true;
                goruntule.DefaultCellStyle.BackColor = Color.Red;
                goruntule.DefaultCellStyle.SelectionBackColor = Color.White;
                goruntule.Width = 70;
                sozlesmelerdtgview.Columns.Add(goruntule);
                sozlesmelerdtgview.Refresh();
            }
            catch
            {

            }
        }

        private void sozlesmelerdtgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dosya = "\\\\netsissrv\\NETSISV9\\tedarikyonetim\\Empero";
            string sozlesmeadi = sozlesmelerdtgview.CurrentRow.Cells["SözleşmeAdı"].Value.ToString();
            string firmaadi = sozlesmelerdtgview.CurrentRow.Cells["FirmaAdı"].Value.ToString();
            if(e.ColumnIndex ==0)
            {
                Process.Start(Path.Combine(dosya, "2022Sözleşmeler", firmaadi+"-"+sozlesmeadi));
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

        private void excelaktarbtn_Click(object sender, EventArgs e)
        {
            ExcelAktarma.Excel_Disa_Aktar(sozlesmelerdtgview);
        }
    }
}
