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
            string sozlesmeadi = sozlesmelerdtgview.CurrentRow.Cells["SözleşmeAdı"].Value.ToString();
            string firmaadi = sozlesmelerdtgview.CurrentRow.Cells["FirmaAdı"].Value.ToString();
            if(e.ColumnIndex ==0)
            {
                Process.Start(Path.Combine(Application.StartupPath, "2022Sözleşmeler", firmaadi+"-"+sozlesmeadi));
            }
        }
    }
}
