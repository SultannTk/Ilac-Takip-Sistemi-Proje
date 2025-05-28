namespace IlacTakipSistemiProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvIlaclar = new DataGridView();
            btnIlacEkle = new Button();
            btnIlacDuzenle = new Button();
            btnIlacSil = new Button();
            lblIlacAdi = new Label();
            lblDozaj = new Label();
            lblBaslangic = new Label();
            lblBitis = new Label();
            lblSaatHatirlatici = new Label();
            txtIlacAdi = new TextBox();
            txtDozaj = new TextBox();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            dtpSaat = new DateTimePicker();
            btnYanEtkileriGoster = new Button();
            PicLogo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lstHazirIlaclar = new ListBox();
            btnIlacSec = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIlaclar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvIlaclar
            // 
            dgvIlaclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIlaclar.Location = new Point(20, 279);
            dgvIlaclar.Name = "dgvIlaclar";
            dgvIlaclar.RowHeadersWidth = 51;
            dgvIlaclar.Size = new Size(653, 159);
            dgvIlaclar.TabIndex = 0;
            dgvIlaclar.CellContentClick += dgvIlaclar_CellClick;
            dgvIlaclar.SelectionChanged += dgvIlaclar_SelectionChanged;
            // 
            // btnIlacEkle
            // 
            btnIlacEkle.BackColor = Color.DarkSeaGreen;
            btnIlacEkle.FlatStyle = FlatStyle.Flat;
            btnIlacEkle.Location = new Point(445, 217);
            btnIlacEkle.Name = "btnIlacEkle";
            btnIlacEkle.Size = new Size(94, 29);
            btnIlacEkle.TabIndex = 1;
            btnIlacEkle.Text = "İlaç Ekle";
            btnIlacEkle.UseVisualStyleBackColor = false;
            btnIlacEkle.Click += btnIlacEkle_Click;
            // 
            // btnIlacDuzenle
            // 
            btnIlacDuzenle.BackColor = SystemColors.ActiveCaption;
            btnIlacDuzenle.FlatStyle = FlatStyle.Flat;
            btnIlacDuzenle.Location = new Point(679, 291);
            btnIlacDuzenle.Name = "btnIlacDuzenle";
            btnIlacDuzenle.Size = new Size(94, 29);
            btnIlacDuzenle.TabIndex = 2;
            btnIlacDuzenle.Text = "Düzenle";
            btnIlacDuzenle.UseVisualStyleBackColor = false;
            btnIlacDuzenle.Click += btnIlacDuzenle_Click;
            // 
            // btnIlacSil
            // 
            btnIlacSil.BackColor = Color.RosyBrown;
            btnIlacSil.FlatStyle = FlatStyle.Flat;
            btnIlacSil.Location = new Point(679, 346);
            btnIlacSil.Name = "btnIlacSil";
            btnIlacSil.Size = new Size(94, 29);
            btnIlacSil.TabIndex = 3;
            btnIlacSil.Text = "İlaç Sil";
            btnIlacSil.UseVisualStyleBackColor = false;
            btnIlacSil.Click += btnIlacSil_Click;
            // 
            // lblIlacAdi
            // 
            lblIlacAdi.AutoSize = true;
            lblIlacAdi.Location = new Point(20, 42);
            lblIlacAdi.Name = "lblIlacAdi";
            lblIlacAdi.Size = new Size(62, 20);
            lblIlacAdi.TabIndex = 4;
            lblIlacAdi.Text = "İlaç Adı:";
            // 
            // lblDozaj
            // 
            lblDozaj.AutoSize = true;
            lblDozaj.Location = new Point(20, 86);
            lblDozaj.Name = "lblDozaj";
            lblDozaj.Size = new Size(47, 20);
            lblDozaj.TabIndex = 5;
            lblDozaj.Text = "Dozu:";
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(20, 131);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(114, 20);
            lblBaslangic.TabIndex = 6;
            lblBaslangic.Text = "Başlangıç Tarihi:";
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(20, 179);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(79, 20);
            lblBitis.TabIndex = 7;
            lblBitis.Text = "Bitiş Tarihi:";
            // 
            // lblSaatHatirlatici
            // 
            lblSaatHatirlatici.AutoSize = true;
            lblSaatHatirlatici.Location = new Point(20, 224);
            lblSaatHatirlatici.Name = "lblSaatHatirlatici";
            lblSaatHatirlatici.Size = new Size(130, 20);
            lblSaatHatirlatici.TabIndex = 8;
            lblSaatHatirlatici.Text = "Kullanılacağı Saat:";
            // 
            // txtIlacAdi
            // 
            txtIlacAdi.Location = new Point(154, 39);
            txtIlacAdi.Name = "txtIlacAdi";
            txtIlacAdi.Size = new Size(125, 27);
            txtIlacAdi.TabIndex = 9;
            // 
            // txtDozaj
            // 
            txtDozaj.Location = new Point(154, 83);
            txtDozaj.Name = "txtDozaj";
            txtDozaj.Size = new Size(125, 27);
            txtDozaj.TabIndex = 10;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(156, 131);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 11;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(154, 179);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 12;
            // 
            // dtpSaat
            // 
            dtpSaat.Format = DateTimePickerFormat.Time;
            dtpSaat.Location = new Point(156, 219);
            dtpSaat.Name = "dtpSaat";
            dtpSaat.Size = new Size(250, 27);
            dtpSaat.TabIndex = 13;
            // 
            // btnYanEtkileriGoster
            // 
            btnYanEtkileriGoster.BackColor = Color.Plum;
            btnYanEtkileriGoster.FlatStyle = FlatStyle.Flat;
            btnYanEtkileriGoster.Location = new Point(679, 397);
            btnYanEtkileriGoster.Name = "btnYanEtkileriGoster";
            btnYanEtkileriGoster.Size = new Size(94, 29);
            btnYanEtkileriGoster.TabIndex = 14;
            btnYanEtkileriGoster.Text = "Yan Etkileri";
            btnYanEtkileriGoster.UseVisualStyleBackColor = false;
            btnYanEtkileriGoster.Click += btnYanEtkileriGoster_Click;
            // 
            // PicLogo
            // 
            PicLogo.Image = Properties.Resources.logo_ilaç;
            PicLogo.Location = new Point(672, 13);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(101, 97);
            PicLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLogo.TabIndex = 15;
            PicLogo.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // lstHazirIlaclar
            // 
            lstHazirIlaclar.FormattingEnabled = true;
            lstHazirIlaclar.Location = new Point(479, 39);
            lstHazirIlaclar.Name = "lstHazirIlaclar";
            lstHazirIlaclar.Size = new Size(150, 104);
            lstHazirIlaclar.TabIndex = 16;
            lstHazirIlaclar.SelectedIndexChanged += lstHazirIlaclar_SelectedIndexChanged;
            // 
            // btnIlacSec
            // 
            btnIlacSec.BackColor = Color.BurlyWood;
            btnIlacSec.FlatStyle = FlatStyle.Flat;
            btnIlacSec.Location = new Point(328, 39);
            btnIlacSec.Name = "btnIlacSec";
            btnIlacSec.Size = new Size(94, 29);
            btnIlacSec.TabIndex = 17;
            btnIlacSec.Text = "İlaç Seç";
            btnIlacSec.UseVisualStyleBackColor = false;
            btnIlacSec.Click += btnIlacSec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIlacSec);
            Controls.Add(lstHazirIlaclar);
            Controls.Add(PicLogo);
            Controls.Add(btnYanEtkileriGoster);
            Controls.Add(dtpSaat);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(txtDozaj);
            Controls.Add(txtIlacAdi);
            Controls.Add(lblSaatHatirlatici);
            Controls.Add(lblBitis);
            Controls.Add(lblBaslangic);
            Controls.Add(lblDozaj);
            Controls.Add(lblIlacAdi);
            Controls.Add(btnIlacSil);
            Controls.Add(btnIlacDuzenle);
            Controls.Add(btnIlacEkle);
            Controls.Add(dgvIlaclar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İlaç Takip Sistemi- Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)dgvIlaclar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIlaclar;
        private Button btnIlacEkle;
        private Button btnIlacDuzenle;
        private Button btnIlacSil;
        private Label lblIlacAdi;
        private Label lblDozaj;
        private Label lblBaslangic;
        private Label lblBitis;
        private Label lblSaatHatirlatici;
        private TextBox txtIlacAdi;
        private TextBox txtDozaj;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpSaat;
        private Button btnYanEtkileriGoster;
        private PictureBox PicLogo;
        private System.Windows.Forms.Timer timer1;
        private ListBox lstHazirIlaclar;
        private Button btnIlacSec;
    }
}
