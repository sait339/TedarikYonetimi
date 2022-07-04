using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TedarikYonetimi
{
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
        }

        static bool UpdateControl()
        {
            Uri versionurl = new Uri("http://localhost/emperosetup/version/version.txt");
            Uri updateurl = new Uri("http://localhost/emperosetup/emperologo.png"); 
            string gelenVers = "0";
            string lastVers = "0.1";
            WebClient update = new WebClient();
            update.DownloadFileAsync(versionurl, "version.txt");
            while (update.IsBusy)
            {
                Thread.Sleep(1);
            }
            StreamReader versionread = new StreamReader("version.txt");
            gelenVers = versionread.ReadLine().ToString();


            if (Convert.ToDouble(gelenVers)<=Convert.ToDouble(lastVers))
            {
                return false;
            }
            else
            {
                update.DownloadFileAsync(updateurl, "emperologo.png");
                while (update.IsBusy)
                {
                    Thread.Sleep(1);
                }
                Process.Start("emperologo.png");
                return true;
            }
        }

        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width == 101)
            {
                if(UpdateControl()==true)
                {
                    zamanlayici.Stop();
                    zamanlayici.Enabled = false;
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Yeni Bir Güncelleme Mevcut.Güncelleme Yüklenirken\nLütfen Bekleyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.OK);
                    this.Close();
                }
            }
            else if (panel2.Width >= 430)
            {
                zamanlayici.Stop();
                zamanlayici.Enabled = false;
                this.Hide();
                GirisEkranı f = new GirisEkranı();
                f.Show();
            }
            
        }

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
