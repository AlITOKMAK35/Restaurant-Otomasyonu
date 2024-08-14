namespace PizzaciSon
{
    partial class GunlukGiderler
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPersonelAd = new System.Windows.Forms.TextBox();
            this.txtBxPersonelFiyat = new System.Windows.Forms.TextBox();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnPersonelKaldir = new System.Windows.Forms.Button();
            this.lstViewPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewMarketMutfak = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBxMarket = new System.Windows.Forms.TextBox();
            this.btnMarketMutfak = new System.Windows.Forms.Button();
            this.btnMarketMutfakKaldir = new System.Windows.Forms.Button();
            this.txtBxMutfak = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günlük Giderler";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBxPersonelAd
            // 
            this.txtBxPersonelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxPersonelAd.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBxPersonelAd.Location = new System.Drawing.Point(221, 194);
            this.txtBxPersonelAd.Multiline = true;
            this.txtBxPersonelAd.Name = "txtBxPersonelAd";
            this.txtBxPersonelAd.Size = new System.Drawing.Size(336, 45);
            this.txtBxPersonelAd.TabIndex = 1;
            this.txtBxPersonelAd.Text = "Personel Adı";
            this.txtBxPersonelAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxPersonelFiyat
            // 
            this.txtBxPersonelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxPersonelFiyat.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBxPersonelFiyat.Location = new System.Drawing.Point(563, 194);
            this.txtBxPersonelFiyat.Multiline = true;
            this.txtBxPersonelFiyat.Name = "txtBxPersonelFiyat";
            this.txtBxPersonelFiyat.Size = new System.Drawing.Size(121, 45);
            this.txtBxPersonelFiyat.TabIndex = 2;
            this.txtBxPersonelFiyat.Text = "Ücret";
            this.txtBxPersonelFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.Orange;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.Location = new System.Drawing.Point(221, 254);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(324, 46);
            this.btnPersonel.TabIndex = 5;
            this.btnPersonel.Text = "Günlük Personel Gider Ekle";
            this.btnPersonel.UseVisualStyleBackColor = false;
            // 
            // btnPersonelKaldir
            // 
            this.btnPersonelKaldir.BackColor = System.Drawing.Color.Red;
            this.btnPersonelKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelKaldir.ForeColor = System.Drawing.Color.White;
            this.btnPersonelKaldir.Location = new System.Drawing.Point(563, 252);
            this.btnPersonelKaldir.Name = "btnPersonelKaldir";
            this.btnPersonelKaldir.Size = new System.Drawing.Size(121, 48);
            this.btnPersonelKaldir.TabIndex = 7;
            this.btnPersonelKaldir.Text = "Kaldır";
            this.btnPersonelKaldir.UseVisualStyleBackColor = false;
            // 
            // lstViewPersonel
            // 
            this.lstViewPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstViewPersonel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewPersonel.ForeColor = System.Drawing.Color.Black;
            this.lstViewPersonel.HideSelection = false;
            this.lstViewPersonel.Location = new System.Drawing.Point(221, 373);
            this.lstViewPersonel.Name = "lstViewPersonel";
            this.lstViewPersonel.Size = new System.Drawing.Size(463, 252);
            this.lstViewPersonel.TabIndex = 9;
            this.lstViewPersonel.UseCompatibleStateImageBehavior = false;
            this.lstViewPersonel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personel Adı";
            this.columnHeader1.Width = 310;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Personel Gider";
            this.columnHeader2.Width = 200;
            // 
            // lstViewMarketMutfak
            // 
            this.lstViewMarketMutfak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewMarketMutfak.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewMarketMutfak.HideSelection = false;
            this.lstViewMarketMutfak.Location = new System.Drawing.Point(782, 373);
            this.lstViewMarketMutfak.Name = "lstViewMarketMutfak";
            this.lstViewMarketMutfak.Size = new System.Drawing.Size(463, 252);
            this.lstViewMarketMutfak.TabIndex = 10;
            this.lstViewMarketMutfak.UseCompatibleStateImageBehavior = false;
            this.lstViewMarketMutfak.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Market Giderleri";
            this.columnHeader3.Width = 255;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mutfak Giderleri";
            this.columnHeader4.Width = 255;
            // 
            // txtBxMarket
            // 
            this.txtBxMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxMarket.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBxMarket.Location = new System.Drawing.Point(782, 194);
            this.txtBxMarket.Multiline = true;
            this.txtBxMarket.Name = "txtBxMarket";
            this.txtBxMarket.Size = new System.Drawing.Size(243, 45);
            this.txtBxMarket.TabIndex = 11;
            this.txtBxMarket.Text = "Market";
            this.txtBxMarket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMarketMutfak
            // 
            this.btnMarketMutfak.BackColor = System.Drawing.Color.Orange;
            this.btnMarketMutfak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarketMutfak.Location = new System.Drawing.Point(782, 254);
            this.btnMarketMutfak.Name = "btnMarketMutfak";
            this.btnMarketMutfak.Size = new System.Drawing.Size(324, 46);
            this.btnMarketMutfak.TabIndex = 12;
            this.btnMarketMutfak.Text = "Market Mutfak Gideri Ekle";
            this.btnMarketMutfak.UseVisualStyleBackColor = false;
            // 
            // btnMarketMutfakKaldir
            // 
            this.btnMarketMutfakKaldir.BackColor = System.Drawing.Color.Red;
            this.btnMarketMutfakKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarketMutfakKaldir.ForeColor = System.Drawing.Color.White;
            this.btnMarketMutfakKaldir.Location = new System.Drawing.Point(1124, 254);
            this.btnMarketMutfakKaldir.Name = "btnMarketMutfakKaldir";
            this.btnMarketMutfakKaldir.Size = new System.Drawing.Size(121, 48);
            this.btnMarketMutfakKaldir.TabIndex = 13;
            this.btnMarketMutfakKaldir.Text = "Kaldır";
            this.btnMarketMutfakKaldir.UseVisualStyleBackColor = false;
            // 
            // txtBxMutfak
            // 
            this.txtBxMutfak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxMutfak.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBxMutfak.Location = new System.Drawing.Point(1031, 194);
            this.txtBxMutfak.Multiline = true;
            this.txtBxMutfak.Name = "txtBxMutfak";
            this.txtBxMutfak.Size = new System.Drawing.Size(214, 45);
            this.txtBxMutfak.TabIndex = 14;
            this.txtBxMutfak.Text = "Mutfak";
            this.txtBxMutfak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1124, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 61);
            this.button4.TabIndex = 41;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // GunlukGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1513, 751);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtBxMutfak);
            this.Controls.Add(this.btnMarketMutfakKaldir);
            this.Controls.Add(this.btnMarketMutfak);
            this.Controls.Add(this.txtBxMarket);
            this.Controls.Add(this.lstViewMarketMutfak);
            this.Controls.Add(this.lstViewPersonel);
            this.Controls.Add(this.btnPersonelKaldir);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.txtBxPersonelFiyat);
            this.Controls.Add(this.txtBxPersonelAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GunlukGiderler";
            this.Text = "GunlukGiderler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPersonelAd;
        private System.Windows.Forms.TextBox txtBxPersonelFiyat;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnPersonelKaldir;
        private System.Windows.Forms.ListView lstViewPersonel;
        private System.Windows.Forms.ListView lstViewMarketMutfak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtBxMarket;
        private System.Windows.Forms.Button btnMarketMutfak;
        private System.Windows.Forms.Button btnMarketMutfakKaldir;
        private System.Windows.Forms.TextBox txtBxMutfak;
        private System.Windows.Forms.Button button4;
    }
}