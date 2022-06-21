namespace TedarikYonetimi
{
    partial class HataEkranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.hatabaslik = new System.Windows.Forms.Label();
            this.hatatext = new System.Windows.Forms.Label();
            this.hata = new System.Windows.Forms.PictureBox();
            this.onay = new System.Windows.Forms.PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tamambuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onay)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.hatabaslik);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.Silver;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(436, 44);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // hatabaslik
            // 
            this.hatabaslik.AutoSize = true;
            this.hatabaslik.BackColor = System.Drawing.Color.Transparent;
            this.hatabaslik.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hatabaslik.Location = new System.Drawing.Point(12, 16);
            this.hatabaslik.Name = "hatabaslik";
            this.hatabaslik.Size = new System.Drawing.Size(47, 19);
            this.hatabaslik.TabIndex = 2;
            this.hatabaslik.Text = "HATA";
            this.hatabaslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // hatatext
            // 
            this.hatatext.AutoSize = true;
            this.hatatext.BackColor = System.Drawing.Color.Transparent;
            this.hatatext.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hatatext.Location = new System.Drawing.Point(144, 34);
            this.hatatext.Name = "hatatext";
            this.hatatext.Size = new System.Drawing.Size(77, 15);
            this.hatatext.TabIndex = 6;
            this.hatatext.Text = "HATA Mesajı";
            this.hatatext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // hata
            // 
            this.hata.BackColor = System.Drawing.Color.Transparent;
            this.hata.Image = global::TedarikYonetimi.Properties.Resources.carpi;
            this.hata.Location = new System.Drawing.Point(16, 25);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(113, 91);
            this.hata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hata.TabIndex = 2;
            this.hata.TabStop = false;
            this.hata.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // onay
            // 
            this.onay.BackColor = System.Drawing.Color.Transparent;
            this.onay.Image = global::TedarikYonetimi.Properties.Resources.Onay;
            this.onay.Location = new System.Drawing.Point(16, 25);
            this.onay.Name = "onay";
            this.onay.Size = new System.Drawing.Size(113, 91);
            this.onay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onay.TabIndex = 1;
            this.onay.TabStop = false;
            this.onay.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.tamambuton);
            this.guna2Panel2.Controls.Add(this.hata);
            this.guna2Panel2.Controls.Add(this.hatatext);
            this.guna2Panel2.Controls.Add(this.onay);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 44);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(436, 152);
            this.guna2Panel2.TabIndex = 7;
            // 
            // tamambuton
            // 
            this.tamambuton.Animated = true;
            this.tamambuton.AutoRoundedCorners = true;
            this.tamambuton.BackColor = System.Drawing.Color.Transparent;
            this.tamambuton.BorderRadius = 16;
            this.tamambuton.CheckedState.Parent = this.tamambuton;
            this.tamambuton.CustomImages.Parent = this.tamambuton;
            this.tamambuton.FillColor = System.Drawing.Color.Red;
            this.tamambuton.FillColor2 = System.Drawing.Color.DimGray;
            this.tamambuton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tamambuton.ForeColor = System.Drawing.Color.White;
            this.tamambuton.HoverState.Parent = this.tamambuton;
            this.tamambuton.Location = new System.Drawing.Point(313, 105);
            this.tamambuton.Margin = new System.Windows.Forms.Padding(4);
            this.tamambuton.Name = "tamambuton";
            this.tamambuton.ShadowDecoration.Parent = this.tamambuton;
            this.tamambuton.Size = new System.Drawing.Size(110, 34);
            this.tamambuton.TabIndex = 7;
            this.tamambuton.Text = "TAMAM";
            this.tamambuton.UseTransparentBackground = true;
            this.tamambuton.Click += new System.EventHandler(this.guna2GradientButton1_Click_1);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.Location = new System.Drawing.Point(391, 11);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // HataEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 196);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HataEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HataEkranı";
            this.Load += new System.EventHandler(this.HataEkranı_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onay)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label hatabaslik;
        private System.Windows.Forms.PictureBox hata;
        private System.Windows.Forms.PictureBox onay;
        private System.Windows.Forms.Label hatatext;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GradientButton tamambuton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}