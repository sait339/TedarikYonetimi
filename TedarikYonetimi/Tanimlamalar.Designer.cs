namespace TedarikYonetimi
{
    partial class Tanimlamalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sektortanimla = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kullanicitanimla = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sektorgrup = new System.Windows.Forms.GroupBox();
            this.sektoreklebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sektoraciklamatextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sektoraditextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sektorlerdtgview = new System.Windows.Forms.DataGridView();
            this.kullanicigrup = new System.Windows.Forms.GroupBox();
            this.eklegrup = new System.Windows.Forms.GroupBox();
            this.kullaniciaditextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sifretextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.kullanicikaydetbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.yetkicombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.kullanicieklebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kullaniciguncellebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kullanicilardtgvw = new System.Windows.Forms.DataGridView();
            this.guncellegrup = new System.Windows.Forms.GroupBox();
            this.kullanicitextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guncellebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.yetkig = new Guna.UI2.WinForms.Guna2ComboBox();
            this.sektorgrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sektorlerdtgview)).BeginInit();
            this.kullanicigrup.SuspendLayout();
            this.eklegrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilardtgvw)).BeginInit();
            this.guncellegrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sektortanimla
            // 
            this.sektortanimla.AutoRoundedCorners = true;
            this.sektortanimla.BackColor = System.Drawing.Color.Transparent;
            this.sektortanimla.BorderRadius = 18;
            this.sektortanimla.CheckedState.Parent = this.sektortanimla;
            this.sektortanimla.CustomImages.Parent = this.sektortanimla;
            this.sektortanimla.FillColor = System.Drawing.Color.Maroon;
            this.sektortanimla.FillColor2 = System.Drawing.Color.Red;
            this.sektortanimla.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sektortanimla.ForeColor = System.Drawing.Color.White;
            this.sektortanimla.HoverState.Parent = this.sektortanimla;
            this.sektortanimla.Location = new System.Drawing.Point(26, 28);
            this.sektortanimla.Name = "sektortanimla";
            this.sektortanimla.ShadowDecoration.Parent = this.sektortanimla;
            this.sektortanimla.Size = new System.Drawing.Size(216, 38);
            this.sektortanimla.TabIndex = 3;
            this.sektortanimla.Text = "Sektör Tanımla";
            this.sektortanimla.Click += new System.EventHandler(this.sektortanimla_Click);
            // 
            // kullanicitanimla
            // 
            this.kullanicitanimla.AutoRoundedCorners = true;
            this.kullanicitanimla.BackColor = System.Drawing.Color.Transparent;
            this.kullanicitanimla.BorderRadius = 18;
            this.kullanicitanimla.CheckedState.Parent = this.kullanicitanimla;
            this.kullanicitanimla.CustomImages.Parent = this.kullanicitanimla;
            this.kullanicitanimla.FillColor = System.Drawing.Color.Maroon;
            this.kullanicitanimla.FillColor2 = System.Drawing.Color.Red;
            this.kullanicitanimla.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicitanimla.ForeColor = System.Drawing.Color.White;
            this.kullanicitanimla.HoverState.Parent = this.kullanicitanimla;
            this.kullanicitanimla.Location = new System.Drawing.Point(272, 28);
            this.kullanicitanimla.Name = "kullanicitanimla";
            this.kullanicitanimla.ShadowDecoration.Parent = this.kullanicitanimla;
            this.kullanicitanimla.Size = new System.Drawing.Size(241, 38);
            this.kullanicitanimla.TabIndex = 4;
            this.kullanicitanimla.Text = "Kullanıcı Tanımla";
            this.kullanicitanimla.Click += new System.EventHandler(this.kullanicitanimla_Click);
            // 
            // sektorgrup
            // 
            this.sektorgrup.Controls.Add(this.sektoreklebtn);
            this.sektorgrup.Controls.Add(this.sektoraciklamatextbox);
            this.sektorgrup.Controls.Add(this.sektoraditextbox);
            this.sektorgrup.Controls.Add(this.sektorlerdtgview);
            this.sektorgrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sektorgrup.Location = new System.Drawing.Point(26, 72);
            this.sektorgrup.Name = "sektorgrup";
            this.sektorgrup.Size = new System.Drawing.Size(1056, 556);
            this.sektorgrup.TabIndex = 7;
            this.sektorgrup.TabStop = false;
            this.sektorgrup.Text = "Sektör Tanımlamaları";
            this.sektorgrup.Visible = false;
            // 
            // sektoreklebtn
            // 
            this.sektoreklebtn.AutoRoundedCorners = true;
            this.sektoreklebtn.BackColor = System.Drawing.Color.Transparent;
            this.sektoreklebtn.BorderRadius = 18;
            this.sektoreklebtn.CheckedState.Parent = this.sektoreklebtn;
            this.sektoreklebtn.CustomImages.Parent = this.sektoreklebtn;
            this.sektoreklebtn.FillColor = System.Drawing.Color.Maroon;
            this.sektoreklebtn.FillColor2 = System.Drawing.Color.Red;
            this.sektoreklebtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sektoreklebtn.ForeColor = System.Drawing.Color.White;
            this.sektoreklebtn.HoverState.Parent = this.sektoreklebtn;
            this.sektoreklebtn.Location = new System.Drawing.Point(25, 159);
            this.sektoreklebtn.Name = "sektoreklebtn";
            this.sektoreklebtn.ShadowDecoration.Parent = this.sektoreklebtn;
            this.sektoreklebtn.Size = new System.Drawing.Size(216, 38);
            this.sektoreklebtn.TabIndex = 22;
            this.sektoreklebtn.Text = "Sektör Ekle";
            this.sektoreklebtn.Click += new System.EventHandler(this.sektoreklebtn_Click);
            // 
            // sektoraciklamatextbox
            // 
            this.sektoraciklamatextbox.AutoRoundedCorners = true;
            this.sektoraciklamatextbox.BackColor = System.Drawing.Color.Transparent;
            this.sektoraciklamatextbox.BorderColor = System.Drawing.Color.Red;
            this.sektoraciklamatextbox.BorderRadius = 23;
            this.sektoraciklamatextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sektoraciklamatextbox.DefaultText = "Sektör Açıklaması";
            this.sektoraciklamatextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sektoraciklamatextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sektoraciklamatextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sektoraciklamatextbox.DisabledState.Parent = this.sektoraciklamatextbox;
            this.sektoraciklamatextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sektoraciklamatextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sektoraciklamatextbox.FocusedState.Parent = this.sektoraciklamatextbox;
            this.sektoraciklamatextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sektoraciklamatextbox.ForeColor = System.Drawing.Color.Black;
            this.sektoraciklamatextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sektoraciklamatextbox.HoverState.Parent = this.sektoraciklamatextbox;
            this.sektoraciklamatextbox.Location = new System.Drawing.Point(25, 103);
            this.sektoraciklamatextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sektoraciklamatextbox.Name = "sektoraciklamatextbox";
            this.sektoraciklamatextbox.PasswordChar = '\0';
            this.sektoraciklamatextbox.PlaceholderText = "";
            this.sektoraciklamatextbox.SelectedText = "";
            this.sektoraciklamatextbox.SelectionStart = 17;
            this.sektoraciklamatextbox.ShadowDecoration.Parent = this.sektoraciklamatextbox;
            this.sektoraciklamatextbox.Size = new System.Drawing.Size(343, 49);
            this.sektoraciklamatextbox.TabIndex = 21;
            this.sektoraciklamatextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sektoraciklamatextbox_KeyPress);
            this.sektoraciklamatextbox.Leave += new System.EventHandler(this.sektoraciklamatextbox_Leave);
            // 
            // sektoraditextbox
            // 
            this.sektoraditextbox.AutoRoundedCorners = true;
            this.sektoraditextbox.BackColor = System.Drawing.Color.Transparent;
            this.sektoraditextbox.BorderColor = System.Drawing.Color.Red;
            this.sektoraditextbox.BorderRadius = 23;
            this.sektoraditextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sektoraditextbox.DefaultText = "Sektör Adı";
            this.sektoraditextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sektoraditextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sektoraditextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sektoraditextbox.DisabledState.Parent = this.sektoraditextbox;
            this.sektoraditextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sektoraditextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sektoraditextbox.FocusedState.Parent = this.sektoraditextbox;
            this.sektoraditextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sektoraditextbox.ForeColor = System.Drawing.Color.Black;
            this.sektoraditextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sektoraditextbox.HoverState.Parent = this.sektoraditextbox;
            this.sektoraditextbox.Location = new System.Drawing.Point(25, 46);
            this.sektoraditextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sektoraditextbox.Name = "sektoraditextbox";
            this.sektoraditextbox.PasswordChar = '\0';
            this.sektoraditextbox.PlaceholderText = "";
            this.sektoraditextbox.SelectedText = "";
            this.sektoraditextbox.SelectionStart = 10;
            this.sektoraditextbox.ShadowDecoration.Parent = this.sektoraditextbox;
            this.sektoraditextbox.Size = new System.Drawing.Size(343, 49);
            this.sektoraditextbox.TabIndex = 20;
            this.sektoraditextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sektoraditextbox_KeyPress);
            this.sektoraditextbox.Leave += new System.EventHandler(this.sektoraditextbox_Leave);
            // 
            // sektorlerdtgview
            // 
            this.sektorlerdtgview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sektorlerdtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sektorlerdtgview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sektorlerdtgview.ColumnHeadersHeight = 30;
            this.sektorlerdtgview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sektorlerdtgview.GridColor = System.Drawing.SystemColors.ControlLight;
            this.sektorlerdtgview.Location = new System.Drawing.Point(535, 28);
            this.sektorlerdtgview.MultiSelect = false;
            this.sektorlerdtgview.Name = "sektorlerdtgview";
            this.sektorlerdtgview.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sektorlerdtgview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.sektorlerdtgview.RowHeadersVisible = false;
            this.sektorlerdtgview.RowTemplate.Height = 25;
            this.sektorlerdtgview.RowTemplate.ReadOnly = true;
            this.sektorlerdtgview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sektorlerdtgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sektorlerdtgview.Size = new System.Drawing.Size(512, 513);
            this.sektorlerdtgview.TabIndex = 19;
            // 
            // kullanicigrup
            // 
            this.kullanicigrup.Controls.Add(this.guncellegrup);
            this.kullanicigrup.Controls.Add(this.eklegrup);
            this.kullanicigrup.Controls.Add(this.kullanicieklebtn);
            this.kullanicigrup.Controls.Add(this.kullaniciguncellebtn);
            this.kullanicigrup.Controls.Add(this.kullanicilardtgvw);
            this.kullanicigrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicigrup.Location = new System.Drawing.Point(26, 72);
            this.kullanicigrup.Name = "kullanicigrup";
            this.kullanicigrup.Size = new System.Drawing.Size(1056, 556);
            this.kullanicigrup.TabIndex = 23;
            this.kullanicigrup.TabStop = false;
            this.kullanicigrup.Text = "Kullanıcı Tanımlamaları";
            this.kullanicigrup.Visible = false;
            // 
            // eklegrup
            // 
            this.eklegrup.Controls.Add(this.kullaniciaditextbox);
            this.eklegrup.Controls.Add(this.sifretextbox);
            this.eklegrup.Controls.Add(this.kullanicikaydetbtn);
            this.eklegrup.Controls.Add(this.yetkicombobox);
            this.eklegrup.Location = new System.Drawing.Point(25, 234);
            this.eklegrup.Name = "eklegrup";
            this.eklegrup.Size = new System.Drawing.Size(462, 294);
            this.eklegrup.TabIndex = 27;
            this.eklegrup.TabStop = false;
            this.eklegrup.Text = "Kullanıcı Ekleme";
            this.eklegrup.Visible = false;
            // 
            // kullaniciaditextbox
            // 
            this.kullaniciaditextbox.AutoRoundedCorners = true;
            this.kullaniciaditextbox.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciaditextbox.BorderColor = System.Drawing.Color.Red;
            this.kullaniciaditextbox.BorderRadius = 23;
            this.kullaniciaditextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciaditextbox.DefaultText = "Kullanıcı Adı";
            this.kullaniciaditextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kullaniciaditextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kullaniciaditextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciaditextbox.DisabledState.Parent = this.kullaniciaditextbox;
            this.kullaniciaditextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciaditextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciaditextbox.FocusedState.Parent = this.kullaniciaditextbox;
            this.kullaniciaditextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciaditextbox.ForeColor = System.Drawing.Color.Black;
            this.kullaniciaditextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciaditextbox.HoverState.Parent = this.kullaniciaditextbox;
            this.kullaniciaditextbox.Location = new System.Drawing.Point(24, 47);
            this.kullaniciaditextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciaditextbox.Name = "kullaniciaditextbox";
            this.kullaniciaditextbox.PasswordChar = '\0';
            this.kullaniciaditextbox.PlaceholderText = "";
            this.kullaniciaditextbox.SelectedText = "";
            this.kullaniciaditextbox.SelectionStart = 13;
            this.kullaniciaditextbox.ShadowDecoration.Parent = this.kullaniciaditextbox;
            this.kullaniciaditextbox.Size = new System.Drawing.Size(343, 49);
            this.kullaniciaditextbox.TabIndex = 20;
            this.kullaniciaditextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullaniciaditextbox_KeyPress);
            this.kullaniciaditextbox.Leave += new System.EventHandler(this.kullaniciaditextbox_Leave);
            // 
            // sifretextbox
            // 
            this.sifretextbox.AutoRoundedCorners = true;
            this.sifretextbox.BackColor = System.Drawing.Color.Transparent;
            this.sifretextbox.BorderColor = System.Drawing.Color.Red;
            this.sifretextbox.BorderRadius = 23;
            this.sifretextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifretextbox.DefaultText = "Şifre";
            this.sifretextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sifretextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sifretextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifretextbox.DisabledState.Parent = this.sifretextbox;
            this.sifretextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifretextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifretextbox.FocusedState.Parent = this.sifretextbox;
            this.sifretextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifretextbox.ForeColor = System.Drawing.Color.Black;
            this.sifretextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifretextbox.HoverState.Parent = this.sifretextbox;
            this.sifretextbox.Location = new System.Drawing.Point(24, 104);
            this.sifretextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.PasswordChar = '\0';
            this.sifretextbox.PlaceholderText = "";
            this.sifretextbox.SelectedText = "";
            this.sifretextbox.SelectionStart = 5;
            this.sifretextbox.ShadowDecoration.Parent = this.sifretextbox;
            this.sifretextbox.Size = new System.Drawing.Size(343, 49);
            this.sifretextbox.TabIndex = 21;
            this.sifretextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifretextbox_KeyPress);
            this.sifretextbox.Leave += new System.EventHandler(this.sifretextbox_Leave);
            // 
            // kullanicikaydetbtn
            // 
            this.kullanicikaydetbtn.AutoRoundedCorners = true;
            this.kullanicikaydetbtn.BackColor = System.Drawing.Color.Transparent;
            this.kullanicikaydetbtn.BorderRadius = 18;
            this.kullanicikaydetbtn.CheckedState.Parent = this.kullanicikaydetbtn;
            this.kullanicikaydetbtn.CustomImages.Parent = this.kullanicikaydetbtn;
            this.kullanicikaydetbtn.FillColor = System.Drawing.Color.Maroon;
            this.kullanicikaydetbtn.FillColor2 = System.Drawing.Color.Red;
            this.kullanicikaydetbtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicikaydetbtn.ForeColor = System.Drawing.Color.White;
            this.kullanicikaydetbtn.HoverState.Parent = this.kullanicikaydetbtn;
            this.kullanicikaydetbtn.Location = new System.Drawing.Point(24, 213);
            this.kullanicikaydetbtn.Name = "kullanicikaydetbtn";
            this.kullanicikaydetbtn.ShadowDecoration.Parent = this.kullanicikaydetbtn;
            this.kullanicikaydetbtn.Size = new System.Drawing.Size(216, 38);
            this.kullanicikaydetbtn.TabIndex = 22;
            this.kullanicikaydetbtn.Text = "Kaydet";
            this.kullanicikaydetbtn.Click += new System.EventHandler(this.kullanicikaydetbtn_Click);
            // 
            // yetkicombobox
            // 
            this.yetkicombobox.AutoRoundedCorners = true;
            this.yetkicombobox.BackColor = System.Drawing.Color.Transparent;
            this.yetkicombobox.BorderColor = System.Drawing.Color.Red;
            this.yetkicombobox.BorderRadius = 17;
            this.yetkicombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yetkicombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yetkicombobox.FocusedColor = System.Drawing.Color.Empty;
            this.yetkicombobox.FocusedState.Parent = this.yetkicombobox;
            this.yetkicombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yetkicombobox.ForeColor = System.Drawing.Color.Black;
            this.yetkicombobox.FormattingEnabled = true;
            this.yetkicombobox.HoverState.Parent = this.yetkicombobox;
            this.yetkicombobox.ItemHeight = 30;
            this.yetkicombobox.Items.AddRange(new object[] {
            "*Yetki Seçiniz",
            "ADMİN",
            "KULLANICI",
            "MUHASEBE"});
            this.yetkicombobox.ItemsAppearance.Parent = this.yetkicombobox;
            this.yetkicombobox.Location = new System.Drawing.Point(24, 162);
            this.yetkicombobox.Name = "yetkicombobox";
            this.yetkicombobox.ShadowDecoration.Parent = this.yetkicombobox;
            this.yetkicombobox.Size = new System.Drawing.Size(343, 36);
            this.yetkicombobox.StartIndex = 0;
            this.yetkicombobox.TabIndex = 23;
            this.yetkicombobox.SelectedValueChanged += new System.EventHandler(this.yetkicombobox_SelectedValueChanged);
            // 
            // kullanicieklebtn
            // 
            this.kullanicieklebtn.AutoRoundedCorners = true;
            this.kullanicieklebtn.BackColor = System.Drawing.Color.Transparent;
            this.kullanicieklebtn.BorderRadius = 18;
            this.kullanicieklebtn.CheckedState.Parent = this.kullanicieklebtn;
            this.kullanicieklebtn.CustomImages.Parent = this.kullanicieklebtn;
            this.kullanicieklebtn.FillColor = System.Drawing.Color.Maroon;
            this.kullanicieklebtn.FillColor2 = System.Drawing.Color.Red;
            this.kullanicieklebtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicieklebtn.ForeColor = System.Drawing.Color.White;
            this.kullanicieklebtn.HoverState.Parent = this.kullanicieklebtn;
            this.kullanicieklebtn.Location = new System.Drawing.Point(25, 73);
            this.kullanicieklebtn.Name = "kullanicieklebtn";
            this.kullanicieklebtn.ShadowDecoration.Parent = this.kullanicieklebtn;
            this.kullanicieklebtn.Size = new System.Drawing.Size(216, 38);
            this.kullanicieklebtn.TabIndex = 26;
            this.kullanicieklebtn.Text = "Kullanıcı Ekle";
            this.kullanicieklebtn.Click += new System.EventHandler(this.kullanicieklebtn_Click);
            // 
            // kullaniciguncellebtn
            // 
            this.kullaniciguncellebtn.AutoRoundedCorners = true;
            this.kullaniciguncellebtn.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciguncellebtn.BorderRadius = 18;
            this.kullaniciguncellebtn.CheckedState.Parent = this.kullaniciguncellebtn;
            this.kullaniciguncellebtn.CustomImages.Parent = this.kullaniciguncellebtn;
            this.kullaniciguncellebtn.FillColor = System.Drawing.Color.Maroon;
            this.kullaniciguncellebtn.FillColor2 = System.Drawing.Color.Red;
            this.kullaniciguncellebtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciguncellebtn.ForeColor = System.Drawing.Color.White;
            this.kullaniciguncellebtn.HoverState.Parent = this.kullaniciguncellebtn;
            this.kullaniciguncellebtn.Location = new System.Drawing.Point(25, 130);
            this.kullaniciguncellebtn.Name = "kullaniciguncellebtn";
            this.kullaniciguncellebtn.ShadowDecoration.Parent = this.kullaniciguncellebtn;
            this.kullaniciguncellebtn.Size = new System.Drawing.Size(216, 38);
            this.kullaniciguncellebtn.TabIndex = 25;
            this.kullaniciguncellebtn.Text = "Kullanıcı Güncelle";
            this.kullaniciguncellebtn.Click += new System.EventHandler(this.kullaniciguncellebtn_Click);
            // 
            // kullanicilardtgvw
            // 
            this.kullanicilardtgvw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullanicilardtgvw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kullanicilardtgvw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.kullanicilardtgvw.ColumnHeadersHeight = 30;
            this.kullanicilardtgvw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kullanicilardtgvw.GridColor = System.Drawing.SystemColors.ControlLight;
            this.kullanicilardtgvw.Location = new System.Drawing.Point(535, 28);
            this.kullanicilardtgvw.MultiSelect = false;
            this.kullanicilardtgvw.Name = "kullanicilardtgvw";
            this.kullanicilardtgvw.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kullanicilardtgvw.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.kullanicilardtgvw.RowHeadersVisible = false;
            this.kullanicilardtgvw.RowTemplate.Height = 25;
            this.kullanicilardtgvw.RowTemplate.ReadOnly = true;
            this.kullanicilardtgvw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kullanicilardtgvw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kullanicilardtgvw.Size = new System.Drawing.Size(512, 513);
            this.kullanicilardtgvw.TabIndex = 19;
            // 
            // guncellegrup
            // 
            this.guncellegrup.Controls.Add(this.kullanicitextbox);
            this.guncellegrup.Controls.Add(this.sifre);
            this.guncellegrup.Controls.Add(this.guncellebtn);
            this.guncellegrup.Controls.Add(this.yetkig);
            this.guncellegrup.Location = new System.Drawing.Point(25, 234);
            this.guncellegrup.Name = "guncellegrup";
            this.guncellegrup.Size = new System.Drawing.Size(462, 294);
            this.guncellegrup.TabIndex = 28;
            this.guncellegrup.TabStop = false;
            this.guncellegrup.Text = "Kullanıcı Güncelleme";
            this.guncellegrup.Visible = false;
            // 
            // kullanicitextbox
            // 
            this.kullanicitextbox.AutoRoundedCorners = true;
            this.kullanicitextbox.BackColor = System.Drawing.Color.Transparent;
            this.kullanicitextbox.BorderColor = System.Drawing.Color.Red;
            this.kullanicitextbox.BorderRadius = 23;
            this.kullanicitextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullanicitextbox.DefaultText = "Kullanıcı Adı";
            this.kullanicitextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kullanicitextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kullanicitextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullanicitextbox.DisabledState.Parent = this.kullanicitextbox;
            this.kullanicitextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullanicitextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullanicitextbox.FocusedState.Parent = this.kullanicitextbox;
            this.kullanicitextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanicitextbox.ForeColor = System.Drawing.Color.Black;
            this.kullanicitextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullanicitextbox.HoverState.Parent = this.kullanicitextbox;
            this.kullanicitextbox.Location = new System.Drawing.Point(24, 47);
            this.kullanicitextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullanicitextbox.Name = "kullanicitextbox";
            this.kullanicitextbox.PasswordChar = '\0';
            this.kullanicitextbox.PlaceholderText = "";
            this.kullanicitextbox.ReadOnly = true;
            this.kullanicitextbox.SelectedText = "";
            this.kullanicitextbox.SelectionStart = 13;
            this.kullanicitextbox.ShadowDecoration.Parent = this.kullanicitextbox;
            this.kullanicitextbox.Size = new System.Drawing.Size(343, 49);
            this.kullanicitextbox.TabIndex = 20;
            // 
            // sifre
            // 
            this.sifre.AutoRoundedCorners = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.BorderColor = System.Drawing.Color.Red;
            this.sifre.BorderRadius = 23;
            this.sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.DefaultText = "Şifre";
            this.sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifre.DisabledState.Parent = this.sifre;
            this.sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifre.FocusedState.Parent = this.sifre;
            this.sifre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.ForeColor = System.Drawing.Color.Black;
            this.sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifre.HoverState.Parent = this.sifre;
            this.sifre.Location = new System.Drawing.Point(24, 104);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '\0';
            this.sifre.PlaceholderText = "";
            this.sifre.SelectedText = "";
            this.sifre.SelectionStart = 5;
            this.sifre.ShadowDecoration.Parent = this.sifre;
            this.sifre.Size = new System.Drawing.Size(343, 49);
            this.sifre.TabIndex = 21;
            // 
            // guncellebtn
            // 
            this.guncellebtn.AutoRoundedCorners = true;
            this.guncellebtn.BackColor = System.Drawing.Color.Transparent;
            this.guncellebtn.BorderRadius = 18;
            this.guncellebtn.CheckedState.Parent = this.guncellebtn;
            this.guncellebtn.CustomImages.Parent = this.guncellebtn;
            this.guncellebtn.FillColor = System.Drawing.Color.Maroon;
            this.guncellebtn.FillColor2 = System.Drawing.Color.Red;
            this.guncellebtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellebtn.ForeColor = System.Drawing.Color.White;
            this.guncellebtn.HoverState.Parent = this.guncellebtn;
            this.guncellebtn.Location = new System.Drawing.Point(24, 213);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.ShadowDecoration.Parent = this.guncellebtn;
            this.guncellebtn.Size = new System.Drawing.Size(216, 38);
            this.guncellebtn.TabIndex = 22;
            this.guncellebtn.Text = "Güncelle";
            // 
            // yetkig
            // 
            this.yetkig.AutoRoundedCorners = true;
            this.yetkig.BackColor = System.Drawing.Color.Transparent;
            this.yetkig.BorderColor = System.Drawing.Color.Red;
            this.yetkig.BorderRadius = 17;
            this.yetkig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yetkig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yetkig.FocusedColor = System.Drawing.Color.Empty;
            this.yetkig.FocusedState.Parent = this.yetkig;
            this.yetkig.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yetkig.ForeColor = System.Drawing.Color.Black;
            this.yetkig.FormattingEnabled = true;
            this.yetkig.HoverState.Parent = this.yetkig;
            this.yetkig.ItemHeight = 30;
            this.yetkig.Items.AddRange(new object[] {
            "*Yetki Seçiniz",
            "ADMİN",
            "KULLANICI",
            "MUHASEBE"});
            this.yetkig.ItemsAppearance.Parent = this.yetkig;
            this.yetkig.Location = new System.Drawing.Point(24, 162);
            this.yetkig.Name = "yetkig";
            this.yetkig.ShadowDecoration.Parent = this.yetkig;
            this.yetkig.Size = new System.Drawing.Size(343, 36);
            this.yetkig.StartIndex = 0;
            this.yetkig.TabIndex = 23;
            // 
            // Tanimlamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 668);
            this.Controls.Add(this.kullanicigrup);
            this.Controls.Add(this.sektorgrup);
            this.Controls.Add(this.kullanicitanimla);
            this.Controls.Add(this.sektortanimla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tanimlamalar";
            this.Text = "Tanimlamalar";
            this.sektorgrup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sektorlerdtgview)).EndInit();
            this.kullanicigrup.ResumeLayout(false);
            this.eklegrup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilardtgvw)).EndInit();
            this.guncellegrup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton sektortanimla;
        private Guna.UI2.WinForms.Guna2GradientButton kullanicitanimla;
        private System.Windows.Forms.GroupBox sektorgrup;
        private System.Windows.Forms.DataGridView sektorlerdtgview;
        private Guna.UI2.WinForms.Guna2GradientButton sektoreklebtn;
        private Guna.UI2.WinForms.Guna2TextBox sektoraciklamatextbox;
        private Guna.UI2.WinForms.Guna2TextBox sektoraditextbox;
        private System.Windows.Forms.GroupBox kullanicigrup;
        private Guna.UI2.WinForms.Guna2GradientButton kullanicikaydetbtn;
        private Guna.UI2.WinForms.Guna2TextBox sifretextbox;
        private Guna.UI2.WinForms.Guna2TextBox kullaniciaditextbox;
        private System.Windows.Forms.DataGridView kullanicilardtgvw;
        private System.Windows.Forms.GroupBox eklegrup;
        public Guna.UI2.WinForms.Guna2ComboBox yetkicombobox;
        private Guna.UI2.WinForms.Guna2GradientButton kullanicieklebtn;
        private Guna.UI2.WinForms.Guna2GradientButton kullaniciguncellebtn;
        private System.Windows.Forms.GroupBox guncellegrup;
        private Guna.UI2.WinForms.Guna2TextBox kullanicitextbox;
        private Guna.UI2.WinForms.Guna2TextBox sifre;
        private Guna.UI2.WinForms.Guna2GradientButton guncellebtn;
        public Guna.UI2.WinForms.Guna2ComboBox yetkig;
    }
}