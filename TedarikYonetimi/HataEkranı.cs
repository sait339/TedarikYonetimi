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
    public partial class HataEkranı : Form
    {
        public static string baslik, text ,durum;
        public HataEkranı()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void HataYazdir(string baslik,string text)
        {
            hatabaslik.Text = baslik;
            hatatext.Text = text;
            hata.Visible = true;
            onay.Visible = false;
        }
        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HataEkranı_Load(object sender, EventArgs e)
        {
            if(durum=="HATA")
            {
                HataYazdir(baslik, text);
            }
            else if (durum == "ONAY")
            {
                OnayYazdir(baslik, text);
            }
        }

        private void OnayYazdir(string baslik, string text)
        {
            hatabaslik.Text = baslik;
            hatatext.Text = text;
            hata.Visible = false;
            onay.Visible = true;
        }
    }
}
