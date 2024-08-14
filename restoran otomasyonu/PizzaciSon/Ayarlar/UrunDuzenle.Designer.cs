namespace PizzaciSon.Ayarlar
{
    partial class UrunDuzenle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMasaEkleKaldir = new System.Windows.Forms.Button();
            this.btnUrunEkleKaldir = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lstViewUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.cmbBxKategori = new System.Windows.Forms.ComboBox();
            this.txtBxUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBxUrunFiyati = new System.Windows.Forms.TextBox();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(963, 510);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 36);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(796, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(796, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Kategori :";
            // 
            // btnMasaEkleKaldir
            // 
            this.btnMasaEkleKaldir.BackColor = System.Drawing.Color.Orange;
            this.btnMasaEkleKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaEkleKaldir.Location = new System.Drawing.Point(903, 5);
            this.btnMasaEkleKaldir.Name = "btnMasaEkleKaldir";
            this.btnMasaEkleKaldir.Size = new System.Drawing.Size(297, 52);
            this.btnMasaEkleKaldir.TabIndex = 28;
            this.btnMasaEkleKaldir.Text = "Masa Ekle/Kaldır";
            this.btnMasaEkleKaldir.UseVisualStyleBackColor = false;
            // 
            // btnUrunEkleKaldir
            // 
            this.btnUrunEkleKaldir.BackColor = System.Drawing.Color.LightBlue;
            this.btnUrunEkleKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkleKaldir.Location = new System.Drawing.Point(600, 6);
            this.btnUrunEkleKaldir.Name = "btnUrunEkleKaldir";
            this.btnUrunEkleKaldir.Size = new System.Drawing.Size(297, 52);
            this.btnUrunEkleKaldir.TabIndex = 27;
            this.btnUrunEkleKaldir.Text = "Ürün Ekle/Kaldır";
            this.btnUrunEkleKaldir.UseVisualStyleBackColor = false;
            this.btnUrunEkleKaldir.Click += new System.EventHandler(this.btnUrunEkleKaldir_Click_1);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.GreenYellow;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(158, 251);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(171, 35);
            this.btnListele.TabIndex = 26;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            // 
            // lstViewUrunler
            // 
            this.lstViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViewUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewUrunler.HideSelection = false;
            this.lstViewUrunler.Location = new System.Drawing.Point(21, 309);
            this.lstViewUrunler.Name = "lstViewUrunler";
            this.lstViewUrunler.Size = new System.Drawing.Size(712, 348);
            this.lstViewUrunler.TabIndex = 25;
            this.lstViewUrunler.UseCompatibleStateImageBehavior = false;
            this.lstViewUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 310;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Fiyatı";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(36, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 51);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün Düzenle Ekranı";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(1206, 6);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(49, 48);
            this.btnCikis.TabIndex = 33;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // cmbBxKategori
            // 
            this.cmbBxKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBxKategori.FormattingEnabled = true;
            this.cmbBxKategori.Location = new System.Drawing.Point(158, 212);
            this.cmbBxKategori.Name = "cmbBxKategori";
            this.cmbBxKategori.Size = new System.Drawing.Size(171, 33);
            this.cmbBxKategori.TabIndex = 34;
            // 
            // txtBxUrunAdi
            // 
            this.txtBxUrunAdi.Location = new System.Drawing.Point(942, 421);
            this.txtBxUrunAdi.Multiline = true;
            this.txtBxUrunAdi.Name = "txtBxUrunAdi";
            this.txtBxUrunAdi.Size = new System.Drawing.Size(171, 34);
            this.txtBxUrunAdi.TabIndex = 35;
            // 
            // txtBxUrunFiyati
            // 
            this.txtBxUrunFiyati.Location = new System.Drawing.Point(942, 461);
            this.txtBxUrunFiyati.Multiline = true;
            this.txtBxUrunFiyati.Name = "txtBxUrunFiyati";
            this.txtBxUrunFiyati.Size = new System.Drawing.Size(171, 34);
            this.txtBxUrunFiyati.TabIndex = 36;
            // 
            // ımageList3
            // 
            this.ımageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1286, 665);
            this.Controls.Add(this.txtBxUrunFiyati);
            this.Controls.Add(this.txtBxUrunAdi);
            this.Controls.Add(this.cmbBxKategori);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMasaEkleKaldir);
            this.Controls.Add(this.btnUrunEkleKaldir);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lstViewUrunler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunDuzenle";
            this.Text = "UrunDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMasaEkleKaldir;
        private System.Windows.Forms.Button btnUrunEkleKaldir;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListView lstViewUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ComboBox cmbBxKategori;
        private System.Windows.Forms.TextBox txtBxUrunAdi;
        private System.Windows.Forms.TextBox txtBxUrunFiyati;
        private System.Windows.Forms.ImageList ımageList3;
       // private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}