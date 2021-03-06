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

namespace TedarikYonetimi
{
    public partial class KullaniciAnaSayfa : Form
    {
        public static string sorumluadi;
        public KullaniciAnaSayfa()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void firmaislemleri_Click(object sender, EventArgs e)
        {
            geridon.Visible = true;
            firmaekle.Visible = true;
            firmaguncelle.Visible = true;
            firmalistele.Visible = true;
            firmasil.Visible = true;
            yetkiliekle.Visible = false;
            yetkiligüncelle.Visible = false;
            yetkililistele.Visible = false;
            yetkilisil.Visible = false;
            firmaislemleri.Visible = false;
            yetkiliislemleri.Visible = false;
            sozlesmeler.Visible = false;
            sozlesmeekle.Visible = false;
            sozlesmeguncelle.Visible = false;
            sozlesmelistele.Visible = false;
            sozlesmesil.Visible = false;
            tanimlamalar.Visible = false;
        }

        private void yetkiliislemleri_Click(object sender, EventArgs e)
        {
            firmaekle.Visible = false;
            firmaguncelle.Visible = false;
            firmalistele.Visible = false;
            firmasil.Visible = false;
            yetkiliekle.Visible = true;
            yetkiligüncelle.Visible = true;
            yetkililistele.Visible = true;
            yetkilisil.Visible = true;
            yetkiliislemleri.Visible = false;
            firmaislemleri.Visible = false;
            sozlesmeler.Visible = false;
            geridon.Visible = true;
            sozlesmeekle.Visible = false;
            sozlesmeguncelle.Visible = false;
            sozlesmelistele.Visible = false;
            sozlesmesil.Visible = false;
            tanimlamalar.Visible = false;
        }

        private void sozlesmeler_Click(object sender, EventArgs e)
        {
            firmaekle.Visible = false;
            firmaguncelle.Visible = false;
            firmalistele.Visible = false;
            firmasil.Visible = false;
            yetkiliekle.Visible = false;
            yetkiligüncelle.Visible = false;
            yetkililistele.Visible = false;
            yetkilisil.Visible = false;
            yetkiliislemleri.Visible = false;
            firmaislemleri.Visible = false;
            sozlesmeler.Visible = false;
            geridon.Visible = true;
            sozlesmeekle.Visible = true;
            sozlesmeguncelle.Visible = true;
            sozlesmelistele.Visible = true;
            sozlesmesil.Visible = true;
            tanimlamalar.Visible = false;
            sorumluadi = kullanicibilgisi.Text;
            if (GirisEkranı.yetki == "1")
            {
                
            }
            else if (GirisEkranı.yetki == "2")
            {

            }
            else if (GirisEkranı.yetki == "3")
            {
                sozlesmeekle.Visible = false;
                sozlesmeguncelle.Visible = false;
                sozlesmelistele.Visible = true;
                sozlesmesil.Visible = false;
                sozlesmelistele.Location = new Point(12, 16);
                geridon.Location = new Point(12, 88);
            }
        }

        private void firmagerigel_Click(object sender, EventArgs e)
        {
            firmaislemleri.Visible = true;
            yetkiliislemleri.Visible = true;
            sozlesmeler.Visible = true;
            geridon.Visible = false;
            firmaekle.Visible = false;
            firmaguncelle.Visible = false;
            firmalistele.Visible = false;
            firmasil.Visible = false;
            yetkiliekle.Visible = false;
            yetkiligüncelle.Visible = false;
            yetkililistele.Visible = false;
            yetkilisil.Visible = false;
            sozlesmeekle.Visible = false;
            sozlesmeguncelle.Visible = false;
            sozlesmelistele.Visible = false;
            sozlesmesil.Visible = false;
            KullaniciGirisAnaPanel.Controls.Clear();
            sorumluadi = kullanicibilgisi.Text;
            if (GirisEkranı.yetki == "1")
            {
                tanimlamalar.Visible = true;
            }
            else if (GirisEkranı.yetki == "2")
            {

            }
            else if (GirisEkranı.yetki == "3")
            {
                firmaislemleri.Visible = false;
                yetkiliislemleri.Visible = false;
                sozlesmeler.Visible = true;
                sozlesmeler.Location = new Point(12, 16);
            }
        }

        private void firmaekle_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            FirmaEkle firmaekleform = new FirmaEkle();
            firmaekleform.TopLevel = false;
            firmaekleform.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(firmaekleform);
            firmaekleform.BringToFront();
            firmaekleform.Show();
        }


        private void KullaniciGirisUstPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void sozlesmeekle_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            SozlesmeEkle sozlesme = new SozlesmeEkle();
            sozlesme.TopLevel = false;
            sozlesme.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(sozlesme);
            sozlesme.BringToFront();
            sozlesme.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisEkranı g = new GirisEkranı();
            g.Show();
        }

        private void KullaniciAnaSayfa_Load(object sender, EventArgs e)
        {
            sorumluadi = kullanicibilgisi.Text;
            if(GirisEkranı.yetki=="1")
            {
                tanimlamalar.Visible = true;
            }
            else if (GirisEkranı.yetki == "2")
            {

            }
            else if (GirisEkranı.yetki == "3")
            {
                firmaislemleri.Visible = false;
                yetkiliislemleri.Visible = false;
                sozlesmeler.Visible = true;
                sozlesmeler.Location = new Point(12, 16);
            }
        }

        private void yetkiliekle_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            YetkiliEkle yetkiliekle = new YetkiliEkle();
            yetkiliekle.TopLevel = false;
            yetkiliekle.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(yetkiliekle);
            yetkiliekle.BringToFront();
            yetkiliekle.Show();
        }

        private void firmaguncelle_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            FirmaGuncelle firmaguncelle = new FirmaGuncelle();
            firmaguncelle.TopLevel = false;
            firmaguncelle.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(firmaguncelle);
            firmaguncelle.BringToFront();
            firmaguncelle.Show();
        }

        private void firmalistele_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            FirmaListele firmalistele= new FirmaListele();
            firmalistele.TopLevel = false;
            firmalistele.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(firmalistele);
            firmalistele.BringToFront();
            firmalistele.Show();
        }

        private void firmasil_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            FirmaSil firmasil = new FirmaSil();
            firmasil.TopLevel = false;
            firmasil.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(firmasil);
            firmasil.BringToFront();
            firmasil.Show();
        }

        private void yetkililistele_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            YetkiliListele yetkililistele = new YetkiliListele();
            yetkililistele.TopLevel = false;
            yetkililistele.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(yetkililistele);
            yetkililistele.BringToFront();
            yetkililistele.Show();
        }

        private void yetkiligüncelle_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            YetkiliGuncelle yetkiliguncelle = new YetkiliGuncelle();
            yetkiliguncelle.TopLevel = false;
            yetkiliguncelle.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(yetkiliguncelle);
            yetkiliguncelle.BringToFront();
            yetkiliguncelle.Show();
        }

        private void yetkilisil_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            YetkiliSil yetkilisil = new YetkiliSil();
            yetkilisil.TopLevel = false;
            yetkilisil.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(yetkilisil);
            yetkilisil.BringToFront();
            yetkilisil.Show();
        }

        private void sozlesmelistele_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            SozlesmeListele sozlesmelistele = new SozlesmeListele();
            sozlesmelistele.TopLevel = false;
            sozlesmelistele.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(sozlesmelistele);
            sozlesmelistele.BringToFront();
            sozlesmelistele.Show();
        }

        private void sozlesmeguncelle_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            SozlesmeGuncelle sozlesmeguncelle = new SozlesmeGuncelle();
            sozlesmeguncelle.TopLevel = false;
            sozlesmeguncelle.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(sozlesmeguncelle);
            sozlesmeguncelle.BringToFront();
            sozlesmeguncelle.Show();
        }

        private void sozlesmesil_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            SozlesmeSil sozlesmesil = new SozlesmeSil();
            sozlesmesil.TopLevel = false;
            sozlesmesil.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(sozlesmesil);
            sozlesmesil.BringToFront();
            sozlesmesil.Show();
        }

        private void tanimlamalar_Click(object sender, EventArgs e)
        {
            KullaniciGirisAnaPanel.Controls.Clear();
            Tanimlamalar tanimlamalar = new Tanimlamalar();
            tanimlamalar.TopLevel = false;
            tanimlamalar.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(tanimlamalar);
            tanimlamalar.BringToFront();
            tanimlamalar.Show();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            geridon.Visible = true;
            KullaniciGirisAnaPanel.Controls.Clear();
            SifreDegistir sifredegistir = new SifreDegistir();
            sifredegistir.TopLevel = false;
            sifredegistir.Dock = DockStyle.Fill;
            KullaniciGirisAnaPanel.Controls.Add(sifredegistir);
            sifredegistir.BringToFront();
            sifredegistir.Show();
        }
    }
}
