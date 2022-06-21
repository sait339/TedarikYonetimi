namespace TedarikYonetimi
{
    partial class FirmaGuncelle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.firmasecimlabel = new System.Windows.Forms.Label();
            this.firmasecbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sektorfiltercombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.firmaaramatextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firmalardtgview = new System.Windows.Forms.DataGridView();
            this.iletisimtexbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mailtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.websitesitextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.calismaseklicombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.odemeseklicombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.sektorcombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.aciklamatextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firmaunvantextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firmaguncellebuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kartvizitguncellebuton = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.firmalardtgview)).BeginInit();
            this.SuspendLayout();
            // 
            // firmasecimlabel
            // 
            this.firmasecimlabel.AutoSize = true;
            this.firmasecimlabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmasecimlabel.Location = new System.Drawing.Point(12, 296);
            this.firmasecimlabel.Name = "firmasecimlabel";
            this.firmasecimlabel.Size = new System.Drawing.Size(216, 25);
            this.firmasecimlabel.TabIndex = 19;
            this.firmasecimlabel.Text = "Firma Seçim Yapılmadı";
            // 
            // firmasecbtn
            // 
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
            this.firmasecbtn.Location = new System.Drawing.Point(955, 296);
            this.firmasecbtn.Name = "firmasecbtn";
            this.firmasecbtn.ShadowDecoration.Parent = this.firmasecbtn;
            this.firmasecbtn.Size = new System.Drawing.Size(150, 38);
            this.firmasecbtn.TabIndex = 18;
            this.firmasecbtn.Text = "Firma Seç";
            this.firmasecbtn.Click += new System.EventHandler(this.firmasecbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(213, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "FİRMA ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "SEKTÖR";
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
            this.sektorfiltercombo.Location = new System.Drawing.Point(12, 12);
            this.sektorfiltercombo.Name = "sektorfiltercombo";
            this.sektorfiltercombo.ShadowDecoration.Parent = this.sektorfiltercombo;
            this.sektorfiltercombo.Size = new System.Drawing.Size(361, 36);
            this.sektorfiltercombo.StartIndex = 0;
            this.sektorfiltercombo.TabIndex = 15;
            this.sektorfiltercombo.SelectedIndexChanged += new System.EventHandler(this.sektorfiltercombo_SelectedIndexChanged);
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
            this.firmaaramatextbox.Location = new System.Drawing.Point(380, 12);
            this.firmaaramatextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmaaramatextbox.Name = "firmaaramatextbox";
            this.firmaaramatextbox.PasswordChar = '\0';
            this.firmaaramatextbox.PlaceholderText = "";
            this.firmaaramatextbox.SelectedText = "";
            this.firmaaramatextbox.SelectionStart = 20;
            this.firmaaramatextbox.ShadowDecoration.Parent = this.firmaaramatextbox;
            this.firmaaramatextbox.Size = new System.Drawing.Size(725, 36);
            this.firmaaramatextbox.TabIndex = 14;
            this.firmaaramatextbox.TextChanged += new System.EventHandler(this.firmaaramatextbox_TextChanged);
            this.firmaaramatextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firmaaramatextbox_KeyPress);
            this.firmaaramatextbox.Leave += new System.EventHandler(this.firmaaramatextbox_Leave);
            // 
            // firmalardtgview
            // 
            this.firmalardtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firmalardtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmalardtgview.ColumnHeadersVisible = false;
            this.firmalardtgview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firmalardtgview.GridColor = System.Drawing.SystemColors.ControlLight;
            this.firmalardtgview.Location = new System.Drawing.Point(11, 91);
            this.firmalardtgview.MultiSelect = false;
            this.firmalardtgview.Name = "firmalardtgview";
            this.firmalardtgview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firmalardtgview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.firmalardtgview.RowHeadersVisible = false;
            this.firmalardtgview.RowTemplate.Height = 25;
            this.firmalardtgview.RowTemplate.ReadOnly = true;
            this.firmalardtgview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firmalardtgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firmalardtgview.Size = new System.Drawing.Size(1094, 196);
            this.firmalardtgview.TabIndex = 13;
            // 
            // iletisimtexbox
            // 
            this.iletisimtexbox.AutoRoundedCorners = true;
            this.iletisimtexbox.BackColor = System.Drawing.Color.Transparent;
            this.iletisimtexbox.BorderColor = System.Drawing.Color.Red;
            this.iletisimtexbox.BorderRadius = 23;
            this.iletisimtexbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iletisimtexbox.DefaultText = "*Telefon Numarası";
            this.iletisimtexbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iletisimtexbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.iletisimtexbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iletisimtexbox.DisabledState.Parent = this.iletisimtexbox;
            this.iletisimtexbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iletisimtexbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iletisimtexbox.FocusedState.Parent = this.iletisimtexbox;
            this.iletisimtexbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iletisimtexbox.ForeColor = System.Drawing.Color.Black;
            this.iletisimtexbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iletisimtexbox.HoverState.Parent = this.iletisimtexbox;
            this.iletisimtexbox.Location = new System.Drawing.Point(11, 415);
            this.iletisimtexbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iletisimtexbox.Name = "iletisimtexbox";
            this.iletisimtexbox.PasswordChar = '\0';
            this.iletisimtexbox.PlaceholderText = "";
            this.iletisimtexbox.SelectedText = "";
            this.iletisimtexbox.SelectionStart = 17;
            this.iletisimtexbox.ShadowDecoration.Parent = this.iletisimtexbox;
            this.iletisimtexbox.Size = new System.Drawing.Size(457, 49);
            this.iletisimtexbox.TabIndex = 24;
            this.iletisimtexbox.Visible = false;
            // 
            // mailtextbox
            // 
            this.mailtextbox.AutoRoundedCorners = true;
            this.mailtextbox.BackColor = System.Drawing.Color.Transparent;
            this.mailtextbox.BorderColor = System.Drawing.Color.Red;
            this.mailtextbox.BorderRadius = 23;
            this.mailtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailtextbox.DefaultText = "*Mail Adresi";
            this.mailtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mailtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mailtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailtextbox.DisabledState.Parent = this.mailtextbox;
            this.mailtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailtextbox.FocusedState.Parent = this.mailtextbox;
            this.mailtextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailtextbox.ForeColor = System.Drawing.Color.Black;
            this.mailtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailtextbox.HoverState.Parent = this.mailtextbox;
            this.mailtextbox.Location = new System.Drawing.Point(11, 472);
            this.mailtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mailtextbox.Name = "mailtextbox";
            this.mailtextbox.PasswordChar = '\0';
            this.mailtextbox.PlaceholderText = "";
            this.mailtextbox.SelectedText = "";
            this.mailtextbox.SelectionStart = 12;
            this.mailtextbox.ShadowDecoration.Parent = this.mailtextbox;
            this.mailtextbox.Size = new System.Drawing.Size(457, 49);
            this.mailtextbox.TabIndex = 22;
            this.mailtextbox.Visible = false;
            // 
            // websitesitextbox
            // 
            this.websitesitextbox.AutoRoundedCorners = true;
            this.websitesitextbox.BackColor = System.Drawing.Color.Transparent;
            this.websitesitextbox.BorderColor = System.Drawing.Color.Red;
            this.websitesitextbox.BorderRadius = 23;
            this.websitesitextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.websitesitextbox.DefaultText = "*Web Sitesi";
            this.websitesitextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.websitesitextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.websitesitextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.websitesitextbox.DisabledState.Parent = this.websitesitextbox;
            this.websitesitextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.websitesitextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.websitesitextbox.FocusedState.Parent = this.websitesitextbox;
            this.websitesitextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websitesitextbox.ForeColor = System.Drawing.Color.Black;
            this.websitesitextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.websitesitextbox.HoverState.Parent = this.websitesitextbox;
            this.websitesitextbox.Location = new System.Drawing.Point(11, 529);
            this.websitesitextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.websitesitextbox.Name = "websitesitextbox";
            this.websitesitextbox.PasswordChar = '\0';
            this.websitesitextbox.PlaceholderText = "";
            this.websitesitextbox.SelectedText = "";
            this.websitesitextbox.SelectionStart = 11;
            this.websitesitextbox.ShadowDecoration.Parent = this.websitesitextbox;
            this.websitesitextbox.Size = new System.Drawing.Size(457, 49);
            this.websitesitextbox.TabIndex = 21;
            this.websitesitextbox.Visible = false;
            // 
            // calismaseklicombobox
            // 
            this.calismaseklicombobox.AutoRoundedCorners = true;
            this.calismaseklicombobox.BackColor = System.Drawing.Color.Transparent;
            this.calismaseklicombobox.BorderColor = System.Drawing.Color.Red;
            this.calismaseklicombobox.BorderRadius = 17;
            this.calismaseklicombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.calismaseklicombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calismaseklicombobox.FocusedColor = System.Drawing.Color.Empty;
            this.calismaseklicombobox.FocusedState.Parent = this.calismaseklicombobox;
            this.calismaseklicombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calismaseklicombobox.ForeColor = System.Drawing.Color.Black;
            this.calismaseklicombobox.FormattingEnabled = true;
            this.calismaseklicombobox.HoverState.Parent = this.calismaseklicombobox;
            this.calismaseklicombobox.ItemHeight = 30;
            this.calismaseklicombobox.Items.AddRange(new object[] {
            "*Çalışma Şekli Seçiniz",
            "NAKİT",
            "VADELİ",
            "DİĞER(açıklama kısmında belirtiniz.)"});
            this.calismaseklicombobox.ItemsAppearance.Parent = this.calismaseklicombobox;
            this.calismaseklicombobox.Location = new System.Drawing.Point(588, 472);
            this.calismaseklicombobox.Name = "calismaseklicombobox";
            this.calismaseklicombobox.ShadowDecoration.Parent = this.calismaseklicombobox;
            this.calismaseklicombobox.Size = new System.Drawing.Size(517, 36);
            this.calismaseklicombobox.StartIndex = 0;
            this.calismaseklicombobox.TabIndex = 27;
            this.calismaseklicombobox.Visible = false;
            // 
            // odemeseklicombobox
            // 
            this.odemeseklicombobox.AutoRoundedCorners = true;
            this.odemeseklicombobox.BackColor = System.Drawing.Color.Transparent;
            this.odemeseklicombobox.BorderColor = System.Drawing.Color.Red;
            this.odemeseklicombobox.BorderRadius = 17;
            this.odemeseklicombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.odemeseklicombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odemeseklicombobox.FocusedColor = System.Drawing.Color.Empty;
            this.odemeseklicombobox.FocusedState.Parent = this.odemeseklicombobox;
            this.odemeseklicombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeseklicombobox.ForeColor = System.Drawing.Color.Black;
            this.odemeseklicombobox.FormattingEnabled = true;
            this.odemeseklicombobox.HoverState.Parent = this.odemeseklicombobox;
            this.odemeseklicombobox.ItemHeight = 30;
            this.odemeseklicombobox.Items.AddRange(new object[] {
            "*Ödeme Şekli Seçiniz",
            "SÖZLEŞMELİ",
            "TEKLİFLİ",
            "DİĞER(açıklama kısmında belirtiniz.)"});
            this.odemeseklicombobox.ItemsAppearance.Parent = this.odemeseklicombobox;
            this.odemeseklicombobox.Location = new System.Drawing.Point(589, 415);
            this.odemeseklicombobox.Name = "odemeseklicombobox";
            this.odemeseklicombobox.ShadowDecoration.Parent = this.odemeseklicombobox;
            this.odemeseklicombobox.Size = new System.Drawing.Size(517, 36);
            this.odemeseklicombobox.StartIndex = 0;
            this.odemeseklicombobox.TabIndex = 26;
            this.odemeseklicombobox.Visible = false;
            // 
            // sektorcombobox
            // 
            this.sektorcombobox.AutoRoundedCorners = true;
            this.sektorcombobox.BackColor = System.Drawing.Color.Transparent;
            this.sektorcombobox.BorderColor = System.Drawing.Color.Red;
            this.sektorcombobox.BorderRadius = 17;
            this.sektorcombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sektorcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sektorcombobox.FocusedColor = System.Drawing.Color.Empty;
            this.sektorcombobox.FocusedState.Parent = this.sektorcombobox;
            this.sektorcombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sektorcombobox.ForeColor = System.Drawing.Color.Black;
            this.sektorcombobox.FormattingEnabled = true;
            this.sektorcombobox.HoverState.Parent = this.sektorcombobox;
            this.sektorcombobox.ItemHeight = 30;
            this.sektorcombobox.Items.AddRange(new object[] {
            "*Sektör Seçiniz"});
            this.sektorcombobox.ItemsAppearance.Parent = this.sektorcombobox;
            this.sektorcombobox.Location = new System.Drawing.Point(588, 358);
            this.sektorcombobox.Name = "sektorcombobox";
            this.sektorcombobox.ShadowDecoration.Parent = this.sektorcombobox;
            this.sektorcombobox.Size = new System.Drawing.Size(517, 36);
            this.sektorcombobox.StartIndex = 0;
            this.sektorcombobox.TabIndex = 25;
            this.sektorcombobox.Visible = false;
            // 
            // aciklamatextbox
            // 
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
            this.aciklamatextbox.Location = new System.Drawing.Point(11, 586);
            this.aciklamatextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aciklamatextbox.Name = "aciklamatextbox";
            this.aciklamatextbox.PasswordChar = '\0';
            this.aciklamatextbox.PlaceholderText = "";
            this.aciklamatextbox.SelectedText = "";
            this.aciklamatextbox.SelectionStart = 16;
            this.aciklamatextbox.ShadowDecoration.Parent = this.aciklamatextbox;
            this.aciklamatextbox.Size = new System.Drawing.Size(902, 49);
            this.aciklamatextbox.TabIndex = 23;
            this.aciklamatextbox.Visible = false;
            // 
            // firmaunvantextbox
            // 
            this.firmaunvantextbox.AutoRoundedCorners = true;
            this.firmaunvantextbox.BackColor = System.Drawing.Color.Transparent;
            this.firmaunvantextbox.BorderColor = System.Drawing.Color.Red;
            this.firmaunvantextbox.BorderRadius = 23;
            this.firmaunvantextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firmaunvantextbox.DefaultText = "*Firma Ünvanı Giriniz";
            this.firmaunvantextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firmaunvantextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firmaunvantextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firmaunvantextbox.DisabledState.Parent = this.firmaunvantextbox;
            this.firmaunvantextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firmaunvantextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firmaunvantextbox.FocusedState.Parent = this.firmaunvantextbox;
            this.firmaunvantextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmaunvantextbox.ForeColor = System.Drawing.Color.Black;
            this.firmaunvantextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firmaunvantextbox.HoverState.Parent = this.firmaunvantextbox;
            this.firmaunvantextbox.Location = new System.Drawing.Point(13, 358);
            this.firmaunvantextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmaunvantextbox.Name = "firmaunvantextbox";
            this.firmaunvantextbox.PasswordChar = '\0';
            this.firmaunvantextbox.PlaceholderText = "";
            this.firmaunvantextbox.SelectedText = "";
            this.firmaunvantextbox.SelectionStart = 21;
            this.firmaunvantextbox.ShadowDecoration.Parent = this.firmaunvantextbox;
            this.firmaunvantextbox.Size = new System.Drawing.Size(565, 49);
            this.firmaunvantextbox.TabIndex = 20;
            this.firmaunvantextbox.Visible = false;
            // 
            // firmaguncellebuton
            // 
            this.firmaguncellebuton.AutoRoundedCorners = true;
            this.firmaguncellebuton.BackColor = System.Drawing.Color.Transparent;
            this.firmaguncellebuton.BorderRadius = 23;
            this.firmaguncellebuton.CheckedState.Parent = this.firmaguncellebuton;
            this.firmaguncellebuton.CustomImages.Parent = this.firmaguncellebuton;
            this.firmaguncellebuton.FillColor = System.Drawing.Color.Maroon;
            this.firmaguncellebuton.FillColor2 = System.Drawing.Color.Red;
            this.firmaguncellebuton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmaguncellebuton.ForeColor = System.Drawing.Color.White;
            this.firmaguncellebuton.HoverState.Parent = this.firmaguncellebuton;
            this.firmaguncellebuton.Location = new System.Drawing.Point(920, 586);
            this.firmaguncellebuton.Name = "firmaguncellebuton";
            this.firmaguncellebuton.ShadowDecoration.Parent = this.firmaguncellebuton;
            this.firmaguncellebuton.Size = new System.Drawing.Size(185, 49);
            this.firmaguncellebuton.TabIndex = 28;
            this.firmaguncellebuton.Text = "Bilgileri Güncelle";
            this.firmaguncellebuton.Visible = false;
            this.firmaguncellebuton.Click += new System.EventHandler(this.firmaguncellebuton_Click);
            // 
            // kartvizitguncellebuton
            // 
            this.kartvizitguncellebuton.AutoRoundedCorners = true;
            this.kartvizitguncellebuton.BackColor = System.Drawing.Color.Transparent;
            this.kartvizitguncellebuton.BorderRadius = 23;
            this.kartvizitguncellebuton.CheckedState.Parent = this.kartvizitguncellebuton;
            this.kartvizitguncellebuton.CustomImages.Parent = this.kartvizitguncellebuton;
            this.kartvizitguncellebuton.FillColor = System.Drawing.Color.Maroon;
            this.kartvizitguncellebuton.FillColor2 = System.Drawing.Color.Red;
            this.kartvizitguncellebuton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartvizitguncellebuton.ForeColor = System.Drawing.Color.White;
            this.kartvizitguncellebuton.HoverState.Parent = this.kartvizitguncellebuton;
            this.kartvizitguncellebuton.Location = new System.Drawing.Point(920, 529);
            this.kartvizitguncellebuton.Name = "kartvizitguncellebuton";
            this.kartvizitguncellebuton.ShadowDecoration.Parent = this.kartvizitguncellebuton;
            this.kartvizitguncellebuton.Size = new System.Drawing.Size(185, 49);
            this.kartvizitguncellebuton.TabIndex = 29;
            this.kartvizitguncellebuton.Text = "Kartvizit Güncelle";
            this.kartvizitguncellebuton.Visible = false;
            this.kartvizitguncellebuton.Click += new System.EventHandler(this.kartvizitguncellebuton_Click);
            // 
            // FirmaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 668);
            this.Controls.Add(this.kartvizitguncellebuton);
            this.Controls.Add(this.firmaguncellebuton);
            this.Controls.Add(this.iletisimtexbox);
            this.Controls.Add(this.mailtextbox);
            this.Controls.Add(this.websitesitextbox);
            this.Controls.Add(this.calismaseklicombobox);
            this.Controls.Add(this.odemeseklicombobox);
            this.Controls.Add(this.sektorcombobox);
            this.Controls.Add(this.aciklamatextbox);
            this.Controls.Add(this.firmaunvantextbox);
            this.Controls.Add(this.firmasecimlabel);
            this.Controls.Add(this.firmasecbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sektorfiltercombo);
            this.Controls.Add(this.firmaaramatextbox);
            this.Controls.Add(this.firmalardtgview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirmaGuncelle";
            this.Text = "FirmaGuncelle";
            this.Load += new System.EventHandler(this.FirmaGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmalardtgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firmasecimlabel;
        private Guna.UI2.WinForms.Guna2GradientButton firmasecbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox sektorfiltercombo;
        private Guna.UI2.WinForms.Guna2TextBox firmaaramatextbox;
        private System.Windows.Forms.DataGridView firmalardtgview;
        private Guna.UI2.WinForms.Guna2TextBox iletisimtexbox;
        private Guna.UI2.WinForms.Guna2TextBox mailtextbox;
        private Guna.UI2.WinForms.Guna2TextBox websitesitextbox;
        private Guna.UI2.WinForms.Guna2ComboBox calismaseklicombobox;
        private Guna.UI2.WinForms.Guna2ComboBox odemeseklicombobox;
        private Guna.UI2.WinForms.Guna2ComboBox sektorcombobox;
        private Guna.UI2.WinForms.Guna2TextBox aciklamatextbox;
        private Guna.UI2.WinForms.Guna2TextBox firmaunvantextbox;
        private Guna.UI2.WinForms.Guna2GradientButton firmaguncellebuton;
        private Guna.UI2.WinForms.Guna2GradientButton kartvizitguncellebuton;
    }
}