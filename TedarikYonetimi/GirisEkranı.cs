using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TedarikYonetimi
{
    public partial class GirisEkranı : Form
    {
        int sayac = 0;
        public GirisEkranı()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void kullaniciadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (kullaniciadi.Text.Equals("kullanıcı adı"))
            {
                kullaniciadi.Clear();
            }
        }
        private void sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sayac == 0)
            {
                sifre.Clear();
                sayac++;

            }

            if (sifre.Text.Equals(""))
            {
                sifre.PasswordChar = '\0';
            }
            else
            {
                sifre.PasswordChar = '*';
            }
        }

        private void GirisUstPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void kullaniciadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                girisyapbuton.PerformClick();
        }

        private void girisyapbuton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT *FROM kullanicilar WHERE kullanici_adi=@kadi AND kullanici_sifre=@sifre", SqlBaglanti.baglanti);
                cmd.Parameters.AddWithValue("@kadi", kullaniciadi.Text);
                cmd.Parameters.AddWithValue("@sifre", sifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    string yetki = dr["kullanici_yetki"].ToString();
                    if(yetki=="1")
                    {
                        
                    }
                    else if(yetki=="2")
                    {
                        KullaniciAnaSayfa giris = new KullaniciAnaSayfa();
                        giris.kullanicibilgisi.Text = kullaniciadi.Text;
                        giris.Show();
                        this.Hide();
                    }
                    else if (yetki == "3")
                    {

                    }
                    else
                    {
                        HataEkranı hata = new HataEkranı();
                        HataEkranı.durum = "HATA";
                        HataEkranı.baslik = "Yetkilendirme hatası";
                        HataEkranı.text = "Yetkilendirme hatalı";
                        hata.Show();
                    }
                }
                else
                {
                    HataEkranı hata = new HataEkranı();
                    HataEkranı.durum = "HATA";
                    HataEkranı.baslik = "Giriş Başarısız";
                    HataEkranı.text= "Kullanıcı adı veya şifre hatalı";
                    hata.Show();
                }
                SqlBaglanti.baglanti.Close();
            }
            catch(Exception) 
            {
                HataEkranı hata = new HataEkranı();
                HataEkranı.durum = "HATA";
                HataEkranı.baslik = "İşlem Başarısız";
                HataEkranı.text = "İşlem sırasında bir hata ile karşılaşıldı.";
                hata.Show();
            }

        }

        private void kullaniciadi_Leave(object sender, EventArgs e)
        {
            if (kullaniciadi.Text.Equals(""))
            {
                kullaniciadi.Text = "kullanıcı adı";
            }
        }

        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text.Equals(""))
            {
                sifre.Text = "şifre";
                sifre.PasswordChar = '\0';
                sayac = 0;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
