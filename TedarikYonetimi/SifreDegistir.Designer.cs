namespace TedarikYonetimi
{
    partial class SifreDegistir
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
            this.eskisifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.yenisifre1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.yenisifre2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.onaylabtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // eskisifre
            // 
            this.eskisifre.AutoRoundedCorners = true;
            this.eskisifre.BackColor = System.Drawing.Color.Transparent;
            this.eskisifre.BorderColor = System.Drawing.Color.Red;
            this.eskisifre.BorderRadius = 17;
            this.eskisifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.eskisifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eskisifre.DefaultText = "eski şifre";
            this.eskisifre.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.eskisifre.DisabledState.FillColor = System.Drawing.Color.White;
            this.eskisifre.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.eskisifre.DisabledState.Parent = this.eskisifre;
            this.eskisifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.eskisifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eskisifre.FocusedState.Parent = this.eskisifre;
            this.eskisifre.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eskisifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eskisifre.HoverState.Parent = this.eskisifre;
            this.eskisifre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.eskisifre.Location = new System.Drawing.Point(406, 225);
            this.eskisifre.Margin = new System.Windows.Forms.Padding(5);
            this.eskisifre.Name = "eskisifre";
            this.eskisifre.PasswordChar = '\0';
            this.eskisifre.PlaceholderForeColor = System.Drawing.Color.White;
            this.eskisifre.PlaceholderText = "";
            this.eskisifre.SelectedText = "";
            this.eskisifre.SelectionStart = 10;
            this.eskisifre.ShadowDecoration.Parent = this.eskisifre;
            this.eskisifre.Size = new System.Drawing.Size(229, 37);
            this.eskisifre.TabIndex = 0;
            this.eskisifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eskisifre_KeyPress);
            this.eskisifre.Leave += new System.EventHandler(this.eskisifre_Leave);
            // 
            // yenisifre1
            // 
            this.yenisifre1.AutoRoundedCorners = true;
            this.yenisifre1.BackColor = System.Drawing.Color.Transparent;
            this.yenisifre1.BorderColor = System.Drawing.Color.Red;
            this.yenisifre1.BorderRadius = 17;
            this.yenisifre1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.yenisifre1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yenisifre1.DefaultText = "yeni şifre";
            this.yenisifre1.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.yenisifre1.DisabledState.FillColor = System.Drawing.Color.White;
            this.yenisifre1.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.yenisifre1.DisabledState.Parent = this.yenisifre1;
            this.yenisifre1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yenisifre1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yenisifre1.FocusedState.Parent = this.yenisifre1;
            this.yenisifre1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenisifre1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yenisifre1.HoverState.Parent = this.yenisifre1;
            this.yenisifre1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.yenisifre1.Location = new System.Drawing.Point(406, 272);
            this.yenisifre1.Margin = new System.Windows.Forms.Padding(5);
            this.yenisifre1.Name = "yenisifre1";
            this.yenisifre1.PasswordChar = '\0';
            this.yenisifre1.PlaceholderForeColor = System.Drawing.Color.White;
            this.yenisifre1.PlaceholderText = "";
            this.yenisifre1.SelectedText = "";
            this.yenisifre1.SelectionStart = 10;
            this.yenisifre1.ShadowDecoration.Parent = this.yenisifre1;
            this.yenisifre1.Size = new System.Drawing.Size(229, 37);
            this.yenisifre1.TabIndex = 1;
            this.yenisifre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yenisifre1_KeyPress);
            this.yenisifre1.Leave += new System.EventHandler(this.yenisifre1_Leave);
            // 
            // yenisifre2
            // 
            this.yenisifre2.AutoRoundedCorners = true;
            this.yenisifre2.BackColor = System.Drawing.Color.Transparent;
            this.yenisifre2.BorderColor = System.Drawing.Color.Red;
            this.yenisifre2.BorderRadius = 17;
            this.yenisifre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.yenisifre2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yenisifre2.DefaultText = "yeni şifre";
            this.yenisifre2.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.yenisifre2.DisabledState.FillColor = System.Drawing.Color.White;
            this.yenisifre2.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.yenisifre2.DisabledState.Parent = this.yenisifre2;
            this.yenisifre2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yenisifre2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yenisifre2.FocusedState.Parent = this.yenisifre2;
            this.yenisifre2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenisifre2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yenisifre2.HoverState.Parent = this.yenisifre2;
            this.yenisifre2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.yenisifre2.Location = new System.Drawing.Point(406, 319);
            this.yenisifre2.Margin = new System.Windows.Forms.Padding(5);
            this.yenisifre2.Name = "yenisifre2";
            this.yenisifre2.PasswordChar = '\0';
            this.yenisifre2.PlaceholderForeColor = System.Drawing.Color.White;
            this.yenisifre2.PlaceholderText = "";
            this.yenisifre2.SelectedText = "";
            this.yenisifre2.SelectionStart = 10;
            this.yenisifre2.ShadowDecoration.Parent = this.yenisifre2;
            this.yenisifre2.Size = new System.Drawing.Size(229, 37);
            this.yenisifre2.TabIndex = 2;
            this.yenisifre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yenisifre2_KeyPress);
            this.yenisifre2.Leave += new System.EventHandler(this.yenisifre2_Leave);
            // 
            // onaylabtn
            // 
            this.onaylabtn.AutoRoundedCorners = true;
            this.onaylabtn.BackColor = System.Drawing.Color.Transparent;
            this.onaylabtn.BorderRadius = 18;
            this.onaylabtn.CheckedState.Parent = this.onaylabtn;
            this.onaylabtn.CustomImages.Parent = this.onaylabtn;
            this.onaylabtn.FillColor = System.Drawing.Color.Maroon;
            this.onaylabtn.FillColor2 = System.Drawing.Color.Red;
            this.onaylabtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylabtn.ForeColor = System.Drawing.Color.White;
            this.onaylabtn.HoverState.Parent = this.onaylabtn;
            this.onaylabtn.Location = new System.Drawing.Point(448, 386);
            this.onaylabtn.Name = "onaylabtn";
            this.onaylabtn.ShadowDecoration.Parent = this.onaylabtn;
            this.onaylabtn.Size = new System.Drawing.Size(150, 38);
            this.onaylabtn.TabIndex = 3;
            this.onaylabtn.Text = "Onayla";
            this.onaylabtn.Click += new System.EventHandler(this.onaylabtn_Click);
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 668);
            this.Controls.Add(this.onaylabtn);
            this.Controls.Add(this.yenisifre2);
            this.Controls.Add(this.yenisifre1);
            this.Controls.Add(this.eskisifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreDegistir";
            this.Text = "SifreDegistir";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox eskisifre;
        private Guna.UI2.WinForms.Guna2TextBox yenisifre1;
        private Guna.UI2.WinForms.Guna2TextBox yenisifre2;
        private Guna.UI2.WinForms.Guna2GradientButton onaylabtn;
    }
}