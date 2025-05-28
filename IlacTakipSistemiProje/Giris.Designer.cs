namespace IlacTakipSistemiProje
{
    partial class GirisFormu
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
            lblBaslik = new Label();
            PicLogo = new PictureBox();
            lblKullanici = new Label();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.BackColor = SystemColors.ButtonFace;
            lblBaslik.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = SystemColors.WindowFrame;
            lblBaslik.Location = new Point(184, 9);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(280, 38);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "İLAÇ TAKİP SİSTEMİ";
            // 
            // PicLogo
            // 
            PicLogo.Image = Properties.Resources.logo_ilaç;
            PicLogo.Location = new Point(24, 12);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(101, 97);
            PicLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLogo.TabIndex = 1;
            PicLogo.TabStop = false;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Location = new Point(184, 101);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(95, 20);
            lblKullanici.TabIndex = 2;
            lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(184, 153);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 20);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(321, 98);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(321, 153);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 5;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.RoyalBlue;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.ForeColor = SystemColors.Window;
            btnGirisYap.Location = new Point(274, 223);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(95, 33);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = SystemColors.ControlDark;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Location = new Point(507, 289);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(94, 29);
            btnKayitOl.TabIndex = 7;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // GirisFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 346);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(lblKullanici);
            Controls.Add(PicLogo);
            Controls.Add(lblBaslik);
            Name = "GirisFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İlaç Takip Sistemi - Giriş";
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private PictureBox PicLogo;
        private Label lblKullanici;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private Button btnKayitOl;
    }
}