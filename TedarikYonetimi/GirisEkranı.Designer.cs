namespace TedarikYonetimi
{
    partial class GirisEkranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkranı));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.GirisUstPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.GirisAnaPanel = new System.Windows.Forms.Panel();
            this.GirisEkrani = new Guna.UI2.WinForms.Guna2GroupBox();
            this.girisyapbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.kullaniciadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.benihatirla = new System.Windows.Forms.CheckBox();
            this.GirisUstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GirisAnaPanel.SuspendLayout();
            this.GirisEkrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // GirisUstPanel
            // 
            this.GirisUstPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GirisUstPanel.Controls.Add(this.pictureBox1);
            this.GirisUstPanel.Controls.Add(this.guna2ControlBox3);
            this.GirisUstPanel.Controls.Add(this.guna2ControlBox2);
            this.GirisUstPanel.Controls.Add(this.guna2ControlBox1);
            this.GirisUstPanel.FillColor = System.Drawing.Color.DimGray;
            this.GirisUstPanel.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.GirisUstPanel.Location = new System.Drawing.Point(0, 0);
            this.GirisUstPanel.Margin = new System.Windows.Forms.Padding(2);
            this.GirisUstPanel.Name = "GirisUstPanel";
            this.GirisUstPanel.ShadowDecoration.Parent = this.GirisUstPanel;
            this.GirisUstPanel.Size = new System.Drawing.Size(725, 60);
            this.GirisUstPanel.TabIndex = 0;
            this.GirisUstPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GirisUstPanel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TedarikYonetimi.Properties.Resources.emperologo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox3.Location = new System.Drawing.Point(644, 17);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.Location = new System.Drawing.Point(605, 17);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Location = new System.Drawing.Point(682, 17);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // GirisAnaPanel
            // 
            this.GirisAnaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GirisAnaPanel.BackColor = System.Drawing.Color.Silver;
            this.GirisAnaPanel.Controls.Add(this.GirisEkrani);
            this.GirisAnaPanel.Location = new System.Drawing.Point(0, 60);
            this.GirisAnaPanel.Margin = new System.Windows.Forms.Padding(2);
            this.GirisAnaPanel.Name = "GirisAnaPanel";
            this.GirisAnaPanel.Size = new System.Drawing.Size(725, 415);
            this.GirisAnaPanel.TabIndex = 1;
            // 
            // GirisEkrani
            // 
            this.GirisEkrani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GirisEkrani.BackColor = System.Drawing.Color.Transparent;
            this.GirisEkrani.BorderColor = System.Drawing.Color.Red;
            this.GirisEkrani.BorderRadius = 16;
            this.GirisEkrani.BorderThickness = 0;
            this.GirisEkrani.Controls.Add(this.benihatirla);
            this.GirisEkrani.Controls.Add(this.girisyapbuton);
            this.GirisEkrani.Controls.Add(this.sifre);
            this.GirisEkrani.Controls.Add(this.kullaniciadi);
            this.GirisEkrani.CustomBorderColor = System.Drawing.Color.White;
            this.GirisEkrani.FillColor = System.Drawing.Color.Gainsboro;
            this.GirisEkrani.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisEkrani.ForeColor = System.Drawing.Color.Red;
            this.GirisEkrani.Location = new System.Drawing.Point(192, 81);
            this.GirisEkrani.Name = "GirisEkrani";
            this.GirisEkrani.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GirisEkrani.ShadowDecoration.Parent = this.GirisEkrani;
            this.GirisEkrani.Size = new System.Drawing.Size(345, 233);
            this.GirisEkrani.TabIndex = 0;
            this.GirisEkrani.Text = "Kullanıcı Giriş Ekranı";
            this.GirisEkrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // girisyapbuton
            // 
            this.girisyapbuton.AutoRoundedCorners = true;
            this.girisyapbuton.BackColor = System.Drawing.Color.Transparent;
            this.girisyapbuton.BorderRadius = 18;
            this.girisyapbuton.CheckedState.Parent = this.girisyapbuton;
            this.girisyapbuton.CustomImages.Parent = this.girisyapbuton;
            this.girisyapbuton.FillColor = System.Drawing.Color.Maroon;
            this.girisyapbuton.FillColor2 = System.Drawing.Color.Red;
            this.girisyapbuton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisyapbuton.ForeColor = System.Drawing.Color.White;
            this.girisyapbuton.HoverState.Parent = this.girisyapbuton;
            this.girisyapbuton.Location = new System.Drawing.Point(94, 176);
            this.girisyapbuton.Name = "girisyapbuton";
            this.girisyapbuton.ShadowDecoration.Parent = this.girisyapbuton;
            this.girisyapbuton.Size = new System.Drawing.Size(150, 38);
            this.girisyapbuton.TabIndex = 3;
            this.girisyapbuton.Text = "Giriş Yap";
            this.girisyapbuton.Click += new System.EventHandler(this.girisyapbuton_Click);
            // 
            // sifre
            // 
            this.sifre.AutoRoundedCorners = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.BorderColor = System.Drawing.Color.Red;
            this.sifre.BorderRadius = 17;
            this.sifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.DefaultText = "şifre";
            this.sifre.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.sifre.DisabledState.FillColor = System.Drawing.Color.White;
            this.sifre.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.sifre.DisabledState.Parent = this.sifre;
            this.sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifre.FocusedState.Parent = this.sifre;
            this.sifre.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifre.HoverState.Parent = this.sifre;
            this.sifre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.Location = new System.Drawing.Point(59, 102);
            this.sifre.Margin = new System.Windows.Forms.Padding(5);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '\0';
            this.sifre.PlaceholderForeColor = System.Drawing.Color.White;
            this.sifre.PlaceholderText = "";
            this.sifre.SelectedText = "";
            this.sifre.SelectionStart = 5;
            this.sifre.ShadowDecoration.Parent = this.sifre;
            this.sifre.Size = new System.Drawing.Size(229, 37);
            this.sifre.TabIndex = 1;
            this.sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kullaniciadi_KeyDown);
            this.sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifre_KeyPress);
            this.sifre.Leave += new System.EventHandler(this.sifre_Leave);
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoRoundedCorners = true;
            this.kullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciadi.BorderColor = System.Drawing.Color.Red;
            this.kullaniciadi.BorderRadius = 17;
            this.kullaniciadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.kullaniciadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciadi.DefaultText = "kullanıcı adı";
            this.kullaniciadi.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.kullaniciadi.DisabledState.FillColor = System.Drawing.Color.White;
            this.kullaniciadi.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.kullaniciadi.DisabledState.Parent = this.kullaniciadi;
            this.kullaniciadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciadi.FocusedState.Parent = this.kullaniciadi;
            this.kullaniciadi.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciadi.HoverState.Parent = this.kullaniciadi;
            this.kullaniciadi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciadi.Location = new System.Drawing.Point(59, 55);
            this.kullaniciadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.PasswordChar = '\0';
            this.kullaniciadi.PlaceholderForeColor = System.Drawing.Color.White;
            this.kullaniciadi.PlaceholderText = "";
            this.kullaniciadi.SelectedText = "";
            this.kullaniciadi.SelectionStart = 13;
            this.kullaniciadi.ShadowDecoration.Parent = this.kullaniciadi;
            this.kullaniciadi.Size = new System.Drawing.Size(229, 37);
            this.kullaniciadi.TabIndex = 0;
            this.kullaniciadi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kullaniciadi_KeyDown);
            this.kullaniciadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullaniciadi_KeyPress);
            this.kullaniciadi.Leave += new System.EventHandler(this.kullaniciadi_Leave);
            // 
            // benihatirla
            // 
            this.benihatirla.AutoSize = true;
            this.benihatirla.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.benihatirla.Location = new System.Drawing.Point(70, 147);
            this.benihatirla.Name = "benihatirla";
            this.benihatirla.Size = new System.Drawing.Size(105, 23);
            this.benihatirla.TabIndex = 2;
            this.benihatirla.Text = "Beni Hatırla";
            this.benihatirla.UseVisualStyleBackColor = true;
            // 
            // GirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 475);
            this.Controls.Add(this.GirisAnaPanel);
            this.Controls.Add(this.GirisUstPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GirisEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.GirisUstPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GirisAnaPanel.ResumeLayout(false);
            this.GirisEkrani.ResumeLayout(false);
            this.GirisEkrani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel GirisUstPanel;
        private System.Windows.Forms.Panel GirisAnaPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GroupBox GirisEkrani;
        private Guna.UI2.WinForms.Guna2TextBox kullaniciadi;
        private Guna.UI2.WinForms.Guna2TextBox sifre;
        private Guna.UI2.WinForms.Guna2GradientButton girisyapbuton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox benihatirla;
    }
}

