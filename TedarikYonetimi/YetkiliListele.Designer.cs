namespace TedarikYonetimi
{
    partial class YetkiliListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.firmaadinagorearatextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.yetkililerdtgview = new System.Windows.Forms.DataGridView();
            this.yetkiliadinagorearatextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.excelaktarbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.yetkililerdtgview)).BeginInit();
            this.SuspendLayout();
            // 
            // firmaadinagorearatextbox
            // 
            this.firmaadinagorearatextbox.AutoRoundedCorners = true;
            this.firmaadinagorearatextbox.BackColor = System.Drawing.Color.Transparent;
            this.firmaadinagorearatextbox.BorderColor = System.Drawing.Color.Red;
            this.firmaadinagorearatextbox.BorderRadius = 17;
            this.firmaadinagorearatextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firmaadinagorearatextbox.DefaultText = "Firma Adına Göre Ara";
            this.firmaadinagorearatextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firmaadinagorearatextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firmaadinagorearatextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firmaadinagorearatextbox.DisabledState.Parent = this.firmaadinagorearatextbox;
            this.firmaadinagorearatextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firmaadinagorearatextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firmaadinagorearatextbox.FocusedState.Parent = this.firmaadinagorearatextbox;
            this.firmaadinagorearatextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmaadinagorearatextbox.ForeColor = System.Drawing.Color.Black;
            this.firmaadinagorearatextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firmaadinagorearatextbox.HoverState.Parent = this.firmaadinagorearatextbox;
            this.firmaadinagorearatextbox.Location = new System.Drawing.Point(513, 18);
            this.firmaadinagorearatextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmaadinagorearatextbox.Name = "firmaadinagorearatextbox";
            this.firmaadinagorearatextbox.PasswordChar = '\0';
            this.firmaadinagorearatextbox.PlaceholderText = "";
            this.firmaadinagorearatextbox.SelectedText = "";
            this.firmaadinagorearatextbox.SelectionStart = 20;
            this.firmaadinagorearatextbox.ShadowDecoration.Parent = this.firmaadinagorearatextbox;
            this.firmaadinagorearatextbox.Size = new System.Drawing.Size(593, 36);
            this.firmaadinagorearatextbox.TabIndex = 22;
            this.firmaadinagorearatextbox.TextChanged += new System.EventHandler(this.firmaadinagorearatextbox_TextChanged);
            this.firmaadinagorearatextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firmaadinagorearatextbox_KeyPress);
            this.firmaadinagorearatextbox.Leave += new System.EventHandler(this.firmaadinagorearatextbox_Leave);
            // 
            // yetkililerdtgview
            // 
            this.yetkililerdtgview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yetkililerdtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yetkililerdtgview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.yetkililerdtgview.ColumnHeadersHeight = 30;
            this.yetkililerdtgview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yetkililerdtgview.GridColor = System.Drawing.SystemColors.ControlLight;
            this.yetkililerdtgview.Location = new System.Drawing.Point(13, 75);
            this.yetkililerdtgview.MultiSelect = false;
            this.yetkililerdtgview.Name = "yetkililerdtgview";
            this.yetkililerdtgview.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yetkililerdtgview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.yetkililerdtgview.RowHeadersVisible = false;
            this.yetkililerdtgview.RowTemplate.Height = 25;
            this.yetkililerdtgview.RowTemplate.ReadOnly = true;
            this.yetkililerdtgview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.yetkililerdtgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yetkililerdtgview.Size = new System.Drawing.Size(1094, 480);
            this.yetkililerdtgview.TabIndex = 21;
            // 
            // yetkiliadinagorearatextbox
            // 
            this.yetkiliadinagorearatextbox.AutoRoundedCorners = true;
            this.yetkiliadinagorearatextbox.BackColor = System.Drawing.Color.Transparent;
            this.yetkiliadinagorearatextbox.BorderColor = System.Drawing.Color.Red;
            this.yetkiliadinagorearatextbox.BorderRadius = 17;
            this.yetkiliadinagorearatextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yetkiliadinagorearatextbox.DefaultText = "Yetkili Adına Göre Ara";
            this.yetkiliadinagorearatextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yetkiliadinagorearatextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yetkiliadinagorearatextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yetkiliadinagorearatextbox.DisabledState.Parent = this.yetkiliadinagorearatextbox;
            this.yetkiliadinagorearatextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yetkiliadinagorearatextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yetkiliadinagorearatextbox.FocusedState.Parent = this.yetkiliadinagorearatextbox;
            this.yetkiliadinagorearatextbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yetkiliadinagorearatextbox.ForeColor = System.Drawing.Color.Black;
            this.yetkiliadinagorearatextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yetkiliadinagorearatextbox.HoverState.Parent = this.yetkiliadinagorearatextbox;
            this.yetkiliadinagorearatextbox.Location = new System.Drawing.Point(13, 18);
            this.yetkiliadinagorearatextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yetkiliadinagorearatextbox.Name = "yetkiliadinagorearatextbox";
            this.yetkiliadinagorearatextbox.PasswordChar = '\0';
            this.yetkiliadinagorearatextbox.PlaceholderText = "";
            this.yetkiliadinagorearatextbox.SelectedText = "";
            this.yetkiliadinagorearatextbox.SelectionStart = 22;
            this.yetkiliadinagorearatextbox.ShadowDecoration.Parent = this.yetkiliadinagorearatextbox;
            this.yetkiliadinagorearatextbox.Size = new System.Drawing.Size(492, 36);
            this.yetkiliadinagorearatextbox.TabIndex = 23;
            this.yetkiliadinagorearatextbox.TextChanged += new System.EventHandler(this.yetkiliadinagorearatextbox_TextChanged);
            this.yetkiliadinagorearatextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yetkiliadinagorearatextbox_KeyPress);
            this.yetkiliadinagorearatextbox.Leave += new System.EventHandler(this.yetkiliadinagorearatextbox_Leave);
            // 
            // excelaktarbtn
            // 
            this.excelaktarbtn.AutoRoundedCorners = true;
            this.excelaktarbtn.BackColor = System.Drawing.Color.Transparent;
            this.excelaktarbtn.BorderRadius = 18;
            this.excelaktarbtn.CheckedState.Parent = this.excelaktarbtn;
            this.excelaktarbtn.CustomImages.Parent = this.excelaktarbtn;
            this.excelaktarbtn.FillColor = System.Drawing.Color.Maroon;
            this.excelaktarbtn.FillColor2 = System.Drawing.Color.Red;
            this.excelaktarbtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.excelaktarbtn.ForeColor = System.Drawing.Color.White;
            this.excelaktarbtn.HoverState.Parent = this.excelaktarbtn;
            this.excelaktarbtn.Location = new System.Drawing.Point(919, 575);
            this.excelaktarbtn.Name = "excelaktarbtn";
            this.excelaktarbtn.ShadowDecoration.Parent = this.excelaktarbtn;
            this.excelaktarbtn.Size = new System.Drawing.Size(188, 38);
            this.excelaktarbtn.TabIndex = 24;
            this.excelaktarbtn.Text = "Excele Aktar";
            this.excelaktarbtn.Click += new System.EventHandler(this.excelaktarbtn_Click);
            // 
            // YetkiliListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 668);
            this.Controls.Add(this.excelaktarbtn);
            this.Controls.Add(this.yetkiliadinagorearatextbox);
            this.Controls.Add(this.firmaadinagorearatextbox);
            this.Controls.Add(this.yetkililerdtgview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YetkiliListele";
            this.Text = "YetkiliListele";
            this.Load += new System.EventHandler(this.YetkiliListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yetkililerdtgview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox firmaadinagorearatextbox;
        private System.Windows.Forms.DataGridView yetkililerdtgview;
        private Guna.UI2.WinForms.Guna2TextBox yetkiliadinagorearatextbox;
        private Guna.UI2.WinForms.Guna2GradientButton excelaktarbtn;
    }
}