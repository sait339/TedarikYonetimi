using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            string updatetxt = ConfigurationManager.ConnectionStrings["UpdateTXT"].ConnectionString;
            string updateexe = ConfigurationManager.ConnectionStrings["UpdateEXE"].ConnectionString;
            string gelenVers = "0";
            string lastVers = "1.0.0.0";
            StreamReader versionread = new StreamReader(updatetxt);
            gelenVers = versionread.ReadLine().ToString();
            if (Convert.ToDouble(gelenVers)<=Convert.ToDouble(lastVers))
            {
                return false;
            }
            else
            {
                Process.Start(updateexe);
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
                    if (dialog == DialogResult.OK)
                    {
                        this.Close();
                    }
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

    }
}
