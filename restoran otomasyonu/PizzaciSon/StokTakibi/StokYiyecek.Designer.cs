namespace PizzaciSon.StokTakibi
{
    partial class StokYiyecek
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDus = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewStok = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            this.cmbBxStokAdi = new System.Windows.Forms.ComboBox();
            this.txtBxMiktar = new System.Windows.Forms.TextBox();
            this.cmbBxStokAdi2 = new System.Windows.Forms.ComboBox();
            this.txtBxMiktar2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(390, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 55);
            this.label6.TabIndex = 29;
            this.label6.Text = "Yiyecek Stok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(411, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Miktar:";
            // 
            // btnDus
            // 
            this.btnDus.BackColor = System.Drawing.Color.Coral;
            this.btnDus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDus.Location = new System.Drawing.Point(499, 405);
            this.btnDus.Name = "btnDus";
            this.btnDus.Size = new System.Drawing.Size(171, 36);
            this.btnDus.TabIndex = 23;
            this.btnDus.Text = "Stok Düş";
            this.btnDus.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Coral;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(499, 214);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(171, 37);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Stok Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(411, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Miktar:";
            // 
            // lstViewStok
            // 
            this.lstViewStok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstViewStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewStok.HideSelection = false;
            this.lstViewStok.Location = new System.Drawing.Point(12, 122);
            this.lstViewStok.Name = "lstViewStok";
            this.lstViewStok.Size = new System.Drawing.Size(370, 388);
            this.lstViewStok.TabIndex = 15;
            this.lstViewStok.UseCompatibleStateImageBehavior = false;
            this.lstViewStok.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stok Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stok Miktarı";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(913, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(49, 48);
            this.btnCikis.TabIndex = 39;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // cmbBxStokAdi
            // 
            this.cmbBxStokAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBxStokAdi.FormattingEnabled = true;
            this.cmbBxStokAdi.Location = new System.Drawing.Point(499, 132);
            this.cmbBxStokAdi.Name = "cmbBxStokAdi";
            this.cmbBxStokAdi.Size = new System.Drawing.Size(171, 33);
            this.cmbBxStokAdi.TabIndex = 41;
            // 
            // txtBxMiktar
            // 
            this.txtBxMiktar.Location = new System.Drawing.Point(499, 171);
            this.txtBxMiktar.Multiline = true;
            this.txtBxMiktar.Name = "txtBxMiktar";
            this.txtBxMiktar.Size = new System.Drawing.Size(171, 33);
            this.txtBxMiktar.TabIndex = 40;
            // 
            // cmbBxStokAdi2
            // 
            this.cmbBxStokAdi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBxStokAdi2.FormattingEnabled = true;
            this.cmbBxStokAdi2.Location = new System.Drawing.Point(499, 324);
            this.cmbBxStokAdi2.Name = "cmbBxStokAdi2";
            this.cmbBxStokAdi2.Size = new System.Drawing.Size(171, 33);
            this.cmbBxStokAdi2.TabIndex = 43;
            // 
            // txtBxMiktar2
            // 
            this.txtBxMiktar2.Location = new System.Drawing.Point(499, 363);
            this.txtBxMiktar2.Multiline = true;
            this.txtBxMiktar2.Name = "txtBxMiktar2";
            this.txtBxMiktar2.Size = new System.Drawing.Size(171, 33);
            this.txtBxMiktar2.TabIndex = 42;
            // 
            // StokYiyecek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(985, 560);
            this.Controls.Add(this.cmbBxStokAdi2);
            this.Controls.Add(this.txtBxMiktar2);
            this.Controls.Add(this.cmbBxStokAdi);
            this.Controls.Add(this.txtBxMiktar);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDus);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstViewStok);
            this.Name = "StokYiyecek";
            this.Text = "StokYiyecek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDus;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewStok;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ComboBox cmbBxStokAdi;
        private System.Windows.Forms.TextBox txtBxMiktar;
        private System.Windows.Forms.ComboBox cmbBxStokAdi2;
        private System.Windows.Forms.TextBox txtBxMiktar2;
    }
}