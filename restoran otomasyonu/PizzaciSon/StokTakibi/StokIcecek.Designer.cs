namespace PizzaciSon.StokTakibi
{
    partial class StokIcecek
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
            this.lstViewStok = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBxMiktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDus = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFireIcecek = new System.Windows.Forms.Label();
            this.lblFire = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBxStokAdi = new System.Windows.Forms.ComboBox();
            this.cmbBxStokAdi2 = new System.Windows.Forms.ComboBox();
            this.txtBxMiktar2 = new System.Windows.Forms.TextBox();
            this.txtFire = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewStok
            // 
            this.lstViewStok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstViewStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewStok.HideSelection = false;
            this.lstViewStok.Location = new System.Drawing.Point(33, 92);
            this.lstViewStok.Name = "lstViewStok";
            this.lstViewStok.Size = new System.Drawing.Size(370, 388);
            this.lstViewStok.TabIndex = 0;
            this.lstViewStok.UseCompatibleStateImageBehavior = false;
            this.lstViewStok.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stok Adı";
            this.columnHeader1.Width = 201;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stok Miktarı";
            this.columnHeader2.Width = 139;
            // 
            // txtBxMiktar
            // 
            this.txtBxMiktar.Location = new System.Drawing.Point(502, 157);
            this.txtBxMiktar.Multiline = true;
            this.txtBxMiktar.Name = "txtBxMiktar";
            this.txtBxMiktar.Size = new System.Drawing.Size(171, 33);
            this.txtBxMiktar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(419, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Miktar:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Coral;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(502, 196);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(171, 33);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Stok Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnDus
            // 
            this.btnDus.BackColor = System.Drawing.Color.Coral;
            this.btnDus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDus.Location = new System.Drawing.Point(507, 376);
            this.btnDus.Name = "btnDus";
            this.btnDus.Size = new System.Drawing.Size(171, 33);
            this.btnDus.TabIndex = 8;
            this.btnDus.Text = "Stok Düş";
            this.btnDus.UseVisualStyleBackColor = false;
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Coral;
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFire.Location = new System.Drawing.Point(836, 247);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(171, 33);
            this.btnFire.TabIndex = 9;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(419, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Miktar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(741, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Miktar:";
            // 
            // lblFireIcecek
            // 
            this.lblFireIcecek.AutoSize = true;
            this.lblFireIcecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFireIcecek.Location = new System.Drawing.Point(780, 298);
            this.lblFireIcecek.Name = "lblFireIcecek";
            this.lblFireIcecek.Size = new System.Drawing.Size(179, 25);
            this.lblFireIcecek.TabIndex = 12;
            this.lblFireIcecek.Text = "İçecek Fire Tutar:";
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFire.Location = new System.Drawing.Point(780, 346);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(188, 25);
            this.lblFire.TabIndex = 13;
            this.lblFire.Text = "Toplam Fire Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(440, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 55);
            this.label6.TabIndex = 14;
            this.label6.Text = "İçecek Stok";
            // 
            // cmbBxStokAdi
            // 
            this.cmbBxStokAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBxStokAdi.FormattingEnabled = true;
            this.cmbBxStokAdi.Location = new System.Drawing.Point(502, 118);
            this.cmbBxStokAdi.Name = "cmbBxStokAdi";
            this.cmbBxStokAdi.Size = new System.Drawing.Size(171, 33);
            this.cmbBxStokAdi.TabIndex = 34;
            // 
            // cmbBxStokAdi2
            // 
            this.cmbBxStokAdi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBxStokAdi2.FormattingEnabled = true;
            this.cmbBxStokAdi2.Location = new System.Drawing.Point(507, 298);
            this.cmbBxStokAdi2.Name = "cmbBxStokAdi2";
            this.cmbBxStokAdi2.Size = new System.Drawing.Size(171, 33);
            this.cmbBxStokAdi2.TabIndex = 36;
            // 
            // txtBxMiktar2
            // 
            this.txtBxMiktar2.Location = new System.Drawing.Point(507, 337);
            this.txtBxMiktar2.Multiline = true;
            this.txtBxMiktar2.Name = "txtBxMiktar2";
            this.txtBxMiktar2.Size = new System.Drawing.Size(171, 33);
            this.txtBxMiktar2.TabIndex = 35;
            // 
            // txtFire
            // 
            this.txtFire.Location = new System.Drawing.Point(836, 208);
            this.txtFire.Multiline = true;
            this.txtFire.Name = "txtFire";
            this.txtFire.Size = new System.Drawing.Size(171, 33);
            this.txtFire.TabIndex = 37;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(958, 10);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(49, 48);
            this.btnCikis.TabIndex = 38;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // StokIcecek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1263, 657);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtFire);
            this.Controls.Add(this.cmbBxStokAdi2);
            this.Controls.Add(this.txtBxMiktar2);
            this.Controls.Add(this.cmbBxStokAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.lblFireIcecek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnDus);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxMiktar);
            this.Controls.Add(this.lstViewStok);
            this.Name = "StokIcecek";
            this.Text = "StokIcecek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewStok;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtBxMiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDus;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFireIcecek;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBxStokAdi;
        private System.Windows.Forms.ComboBox cmbBxStokAdi2;
        private System.Windows.Forms.TextBox txtBxMiktar2;
        private System.Windows.Forms.TextBox txtFire;
        private System.Windows.Forms.Button btnCikis;
    }
}