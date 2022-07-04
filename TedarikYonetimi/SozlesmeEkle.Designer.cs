namespace TedarikYonetimi
{
    partial class SozlesmeEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.firmalardtgview = new System.Windows.Forms.DataGridView();
            this.firmaaramatextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sektorfiltercombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.sozlesmeyuklebuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dosyasecbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firmasecbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.aciklamatextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firmasecimlabel = new System.Windows.Forms.Label();
            this.dosyasecimlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firmalardtgview)).BeginInit();
            this.SuspendLayout();
            // 
            // firmalardtgview
            // 
            this.firmalardtgview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firmalardtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firmalardtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmalardtgview.ColumnHeadersVisible = false;
            this.firmalardtgview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firmalardtgview.GridColor = System.Drawing.SystemColors.ControlLight;
            this.firmalardtgview.Location = new System.Drawing.Point(12, 122);
            this.firmalardtgview.MultiSelect = false;
            this.firmalardtgview.Name = "firmalardtgview";
            this.firmalardtgview.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firmalardtgview.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.firmalardtgview.RowHeadersVisible = false;
            this.firmalardtgview.RowTemplate.Height = 25;
            this.firmalardtgview.RowTemplate.ReadOnly = true;
            this.firmalardtgview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firmalardtgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firmalardtgview.Size = new System.Drawing.Size(1094, 299);
            this.firmalardtgview.TabIndex = 0;
            // 
            // firmaaramatextbox
            // 
            this.firmaaramatextbox.AutoRoundedCorners = true;
            this.firmaaramatextbox.BackColor = System.Drawing.Color.Transparent;
            this.firmaaramatextbox.BorderColor = System.Drawing.Color.Red;
            this.firmaaramatextbox.BorderRadius = 17;
            this.firmaaramatextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firmaaramatextbox.DefaultText = "Firma Adına Göre Ara";
            this.firmaaramatextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firmaaramatextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firmaaramatextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firmaaramatextbox.DisabledState.Parent = this.firmaaramatextbox;
            this.firmaaramatextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firmaaramatextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firmaaramatextbox.FocusedState.Parent = this.firmaaramatextbox;
            this.firmaaramatextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmaaramatextbox.ForeColor = System.Drawing.Color.Black;
            this.firmaaramatextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firmaaramatextbox.HoverState.Parent = this.firmaaramatextbox;
            this.firmaaramatextbox.Location = new System.Drawing.Point(380, 25);
            this.firmaaramatextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmaaramatextbox.Name = "firmaaramatextbox";
            this.firmaaramatextbox.PasswordChar = '\0';
            this.firmaaramatextbox.PlaceholderText = "";
            this.firmaaramatextbox.SelectedText = "";
            this.firmaaramatextbox.SelectionStart = 20;
            this.firmaaramatextbox.ShadowDecoration.Parent = this.firmaaramatextbox;
            this.firmaaramatextbox.Size = new System.Drawing.Size(725, 36);
            this.firmaaramatextbox.TabIndex = 1;
            this.firmaaramatextbox.TextChanged += new System.EventHandler(this.firmaaramatextbox_TextChanged);
            this.firmaaramatextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firmaaramatextbox_KeyPress);
            this.firmaaramatextbox.Leave += new System.EventHandler(this.firmaaramatextbox_Leave);
            // 
            // sektorfiltercombo
            // 
            this.sektorfiltercombo.AutoRoundedCorners = true;
            this.sektorfiltercombo.BackColor = System.Drawing.Color.Transparent;
            this.sektorfiltercombo.BorderColor = System.Drawing.Color.Red;
            this.sektorfiltercombo.BorderRadius = 17;
            this.sektorfiltercombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sektorfiltercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sektorfiltercombo.FocusedColor = System.Drawing.Color.Empty;
            this.sektorfiltercombo.FocusedState.Parent = this.sektorfiltercombo;
            this.sektorfiltercombo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sektorfiltercombo.ForeColor = System.Drawing.Color.Black;
            this.sektorfiltercombo.FormattingEnabled = true;
            this.sektorfiltercombo.HoverState.Parent = this.sektorfiltercombo;
            this.sektorfiltercombo.ItemHeight = 30;
            this.sektorfiltercombo.Items.AddRange(new object[] {
            "Tümü"});
            this.sektorfiltercombo.ItemsAppearance.Parent = this.sektorfiltercombo;
            this.sektorfiltercombo.Location = new System.Drawing.Point(12, 25);
            this.sektorfiltercombo.Name = "sektorfiltercombo";
            this.sektorfiltercombo.ShadowDecoration.Parent = this.sektorfiltercombo;
            this.sektorfiltercombo.Size = new System.Drawing.Size(361, 36);
            this.sektorfiltercombo.StartIndex = 0;
            this.sektorfiltercombo.TabIndex = 4;
            this.sektorfiltercombo.SelectedValueChanged += new System.EventHandler(this.sektorfiltercombo_SelectedValueChanged);
            // 
            // sozlesmeyuklebuton
            // 
            this.sozlesmeyuklebuton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sozlesmeyuklebuton.AutoRoundedCorners = true;
            this.sozlesmeyuklebuton.BackColor = System.Drawing.Color.Transparent;
            this.sozlesmeyuklebuton.BorderRadius = 18;
            this.sozlesmeyuklebuton.CheckedState.Parent = this.sozlesmeyuklebuton;
            this.sozlesmeyuklebuton.CustomImages.Parent = this.sozlesmeyuklebuton;
            this.sozlesmeyuklebuton.FillColor = System.Drawing.Color.Maroon;
            this.sozlesmeyuklebuton.FillColor2 = System.Drawing.Color.Red;
            this.sozlesmeyuklebuton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sozlesmeyuklebuton.ForeColor = System.Drawing.Color.White;
            this.sozlesmeyuklebuton.HoverState.Parent = this.sozlesmeyuklebuton;
            this.sozlesmeyuklebuton.Location = new System.Drawing.Point(956, 594);
            this.sozlesmeyuklebuton.Name = "sozlesmeyuklebuton";
            this.sozlesmeyuklebuton.ShadowDecoration.Parent = this.sozlesmeyuklebuton;
            this.sozlesmeyuklebuton.Size = new System.Drawing.Size(150, 38);
            this.sozlesmeyuklebuton.TabIndex = 6;
            this.sozlesmeyuklebuton.Text = "Sözleşme Yükle";
            this.sozlesmeyuklebuton.Click += new System.EventHandler(this.sozlesmeyuklebuton_Click);
            // 
            // dosyasecbuton
            // 
            this.dosyasecbuton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dosyasecbuton.AutoRoundedCorners = true;
            this.dosyasecbuton.BackColor = System.Drawing.Color.Transparent;
            this.dosyasecbuton.BorderRadius = 18;
            this.dosyasecbuton.CheckedState.Parent = this.dosyasecbuton;
            this.dosyasecbuton.CustomImages.Parent = this.dosyasecbuton;
            this.dosyasecbuton.FillColor = System.Drawing.Color.Maroon;
            this.dosyasecbuton.FillColor2 = System.Drawing.Color.Red;
            this.dosyasecbuton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyasecbuton.ForeColor = System.Drawing.Color.White;
            this.dosyasecbuton.HoverState.Parent = this.dosyasecbuton;
            this.dosyasecbuton.Location = new System.Drawing.Point(955, 529);
            this.dosyasecbuton.Name = "dosyasecbuton";
            this.dosyasecbuton.ShadowDecoration.Parent = this.dosyasecbuton;
            this.dosyasecbuton.Size = new System.Drawing.Size(150, 38);
            this.dosyasecbuton.TabIndex = 7;
            this.dosyasecbuton.Text = "Dosya Seç";
            this.dosyasecbuton.Click += new System.EventHandler(this.dosyasecbuton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "SEKTÖR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(214, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "FİRMA ADI";
            // 
            // firmasecbtn
            // 
            this.firmasecbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.firmasecbtn.AutoRoundedCorners = true;
            this.firmasecbtn.BackColor = System.Drawing.Color.Transparent;
            this.firmasecbtn.BorderRadius = 18;
            this.firmasecbtn.CheckedState.Parent = this.firmasecbtn;
            this.firmasecbtn.CustomImages.Parent = this.firmasecbtn;
            this.firmasecbtn.FillColor = System.Drawing.Color.Maroon;
            this.firmasecbtn.FillColor2 = System.Drawing.Color.Red;
            this.firmasecbtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmasecbtn.ForeColor = System.Drawing.Color.White;
            this.firmasecbtn.HoverState.Parent = this.firmasecbtn;
            this.firmasecbtn.Location = new System.Drawing.Point(955, 463);
            this.firmasecbtn.Name = "firmasecbtn";
            this.firmasecbtn.ShadowDecoration.Parent = this.firmasecbtn;
            this.firmasecbtn.Size = new System.Drawing.Size(150, 38);
            this.firmasecbtn.TabIndex = 10;
            this.firmasecbtn.Text = "Firma Seç";
            this.firmasecbtn.Click += new System.EventHandler(this.firmasecbtn_Click);
            // 
            // aciklamatextbox
            // 
            this.aciklamatextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aciklamatextbox.AutoRoundedCorners = true;
            this.aciklamatextbox.BackColor = System.Drawing.Color.Transparent;
            this.aciklamatextbox.BorderColor = System.Drawing.Color.Red;
            this.aciklamatextbox.BorderRadius = 23;
            this.aciklamatextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aciklamatextbox.DefaultText = "Açıklama Giriniz";
            this.aciklamatextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.aciklamatextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.aciklamatextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aciklamatextbox.DisabledState.Parent = this.aciklamatextbox;
            this.aciklamatextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aciklamatextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.aciklamatextbox.FocusedState.Parent = this.aciklamatextbox;
            this.aciklamatextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aciklamatextbox.ForeColor = System.Drawing.Color.Black;
            this.aciklamatextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.aciklamatextbox.HoverState.Parent = this.aciklamatextbox;
            this.aciklamatextbox.Location = new System.Drawing.Point(12, 574);
            this.aciklamatextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aciklamatextbox.Name = "aciklamatextbox";
            this.aciklamatextbox.PasswordChar = '\0';
            this.aciklamatextbox.PlaceholderText = "";
            this.aciklamatextbox.SelectedText = "";
            this.aciklamatextbox.SelectionStart = 16;
            this.aciklamatextbox.ShadowDecoration.Parent = this.aciklamatextbox;
            this.aciklamatextbox.Size = new System.Drawing.Size(936, 49);
            this.aciklamatextbox.TabIndex = 11;
            this.aciklamatextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aciklamatextbox_KeyPress);
            this.aciklamatextbox.Leave += new System.EventHandler(this.aciklamatextbox_Leave);
            // 
            // firmasecimlabel
            // 
            this.firmasecimlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.firmasecimlabel.AutoSize = true;
            this.firmasecimlabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmasecimlabel.Location = new System.Drawing.Point(28, 476);
            this.firmasecimlabel.Name = "firmasecimlabel";
            this.firmasecimlabel.Size = new System.Drawing.Size(216, 25);
            this.firmasecimlabel.TabIndex = 12;
            this.firmasecimlabel.Text = "Firma Seçim Yapılmadı";
            // 
            // dosyasecimlabel
            // 
            this.dosyasecimlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dosyasecimlabel.AutoSize = true;
            this.dosyasecimlabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyasecimlabel.Location = new System.Drawing.Point(28, 528);
            this.dosyasecimlabel.Name = "dosyasecimlabel";
            this.dosyasecimlabel.Size = new System.Drawing.Size(218, 25);
            this.dosyasecimlabel.TabIndex = 13;
            this.dosyasecimlabel.Text = "Dosya Seçim Yapılmadı";
            // 
            // SozlesmeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 668);
            this.Controls.Add(this.dosyasecimlabel);
            this.Controls.Add(this.firmasecimlabel);
            this.Controls.Add(this.aciklamatextbox);
            this.Controls.Add(this.firmasecbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dosyasecbuton);
            this.Controls.Add(this.sozlesmeyuklebuton);
            this.Controls.Add(this.sektorfiltercombo);
            this.Controls.Add(this.firmaaramatextbox);
            this.Controls.Add(this.firmalardtgview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SozlesmeEkle";
            this.Text = "SozlesmeEkle";
            this.Load += new System.EventHandler(this.SozlesmeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmalardtgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView firmalardtgview;
        private Guna.UI2.WinForms.Guna2TextBox firmaaramatextbox;
        private Guna.UI2.WinForms.Guna2ComboBox sektorfiltercombo;
        private Guna.UI2.WinForms.Guna2GradientButton sozlesmeyuklebuton;
        private Guna.UI2.WinForms.Guna2GradientButton dosyasecbuton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton firmasecbtn;
        private Guna.UI2.WinForms.Guna2TextBox aciklamatextbox;
        private System.Windows.Forms.Label firmasecimlabel;
        private System.Windows.Forms.Label dosyasecimlabel;
    }
}