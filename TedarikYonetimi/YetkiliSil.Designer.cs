namespace TedarikYonetimi
{
    partial class YetkiliSil
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
            this.firmasilbuton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sektorfiltercombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.firmaaramatextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firmalardtgview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.firmalardtgview)).BeginInit();
            this.SuspendLayout();
            // 
            // firmasilbuton
            // 
            this.firmasilbuton.AutoRoundedCorners = true;
            this.firmasilbuton.BackColor = System.Drawing.Color.Transparent;
            this.firmasilbuton.BorderRadius = 18;
            this.firmasilbuton.CheckedState.Parent = this.firmasilbuton;
            this.firmasilbuton.CustomImages.Parent = this.firmasilbuton;
            this.firmasilbuton.FillColor = System.Drawing.Color.Maroon;
            this.firmasilbuton.FillColor2 = System.Drawing.Color.Red;
            this.firmasilbuton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmasilbuton.ForeColor = System.Drawing.Color.White;
            this.firmasilbuton.HoverState.Parent = this.firmasilbuton;
            this.firmasilbuton.Location = new System.Drawing.Point(955, 540);
            this.firmasilbuton.Name = "firmasilbuton";
            this.firmasilbuton.ShadowDecoration.Parent = this.firmasilbuton;
            this.firmasilbuton.Size = new System.Drawing.Size(150, 38);
            this.firmasilbuton.TabIndex = 28;
            this.firmasilbuton.Text = "Sil";
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
            this.sektorfiltercombo.TabIndex = 27;
            // 
            // firmaaramatextbox
            // 
            this.firmaaramatextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.firmaaramatextbox.TabIndex = 26;
            // 
            // firmalardtgview
            // 
            this.firmalardtgview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firmalardtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firmalardtgview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.firmalardtgview.ColumnHeadersHeight = 30;
            this.firmalardtgview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firmalardtgview.GridColor = System.Drawing.SystemColors.ControlLight;
            this.firmalardtgview.Location = new System.Drawing.Point(11, 91);
            this.firmalardtgview.MultiSelect = false;
            this.firmalardtgview.Name = "firmalardtgview";
            this.firmalardtgview.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firmalardtgview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.firmalardtgview.RowHeadersVisible = false;
            this.firmalardtgview.RowTemplate.Height = 25;
            this.firmalardtgview.RowTemplate.ReadOnly = true;
            this.firmalardtgview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firmalardtgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firmalardtgview.Size = new System.Drawing.Size(1094, 429);
            this.firmalardtgview.TabIndex = 25;
            // 
            // YetkiliSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 668);
            this.Controls.Add(this.firmasilbuton);
            this.Controls.Add(this.sektorfiltercombo);
            this.Controls.Add(this.firmaaramatextbox);
            this.Controls.Add(this.firmalardtgview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YetkiliSil";
            this.Text = "YetkiliSil";
            ((System.ComponentModel.ISupportInitialize)(this.firmalardtgview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton firmasilbuton;
        private Guna.UI2.WinForms.Guna2ComboBox sektorfiltercombo;
        private Guna.UI2.WinForms.Guna2TextBox firmaaramatextbox;
        private System.Windows.Forms.DataGridView firmalardtgview;
    }
}