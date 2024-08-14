namespace PizzaciSon.Raporlar
{
    partial class PaketServis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaketServis));
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lstViewSiparis = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewPaketServis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxToplamTutar = new System.Windows.Forms.Button();
            this.txtBxTelefon = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
         //   this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.LightGreen;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(1125, 530);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(110, 107);
            this.btnYazdir.TabIndex = 8;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lstViewSiparis
            // 
            this.lstViewSiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstViewSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewSiparis.HideSelection = false;
            this.lstViewSiparis.Location = new System.Drawing.Point(737, 3);
            this.lstViewSiparis.Name = "lstViewSiparis";
            this.lstViewSiparis.Size = new System.Drawing.Size(371, 406);
            this.lstViewSiparis.TabIndex = 6;
            this.lstViewSiparis.UseCompatibleStateImageBehavior = false;
            this.lstViewSiparis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adet";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ürün";
            this.columnHeader9.Width = 205;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fiyatı";
            this.columnHeader10.Width = 77;
            // 
            // lstViewPaketServis
            // 
            this.lstViewPaketServis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstViewPaketServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewPaketServis.HideSelection = false;
            this.lstViewPaketServis.Location = new System.Drawing.Point(44, 3);
            this.lstViewPaketServis.Name = "lstViewPaketServis";
            this.lstViewPaketServis.Size = new System.Drawing.Size(687, 653);
            this.lstViewPaketServis.TabIndex = 5;
            this.lstViewPaketServis.UseCompatibleStateImageBehavior = false;
            this.lstViewPaketServis.View = System.Windows.Forms.View.Details;
            this.lstViewPaketServis.SelectedIndexChanged += new System.EventHandler(this.lstViewPaketServis_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adisyon No";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Açılış Saati";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kapanış Saati";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ödeme Durumu";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İşlem";
            this.columnHeader5.Width = 52;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tutar(TL)";
            this.columnHeader6.Width = 97;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fiş İçeriği";
            this.columnHeader7.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(737, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adres:";
            // 
            // txtBxAdres
            // 
            this.txtBxAdres.Location = new System.Drawing.Point(737, 530);
            this.txtBxAdres.Multiline = true;
            this.txtBxAdres.Name = "txtBxAdres";
            this.txtBxAdres.Size = new System.Drawing.Size(371, 38);
            this.txtBxAdres.TabIndex = 11;
            this.txtBxAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxAdres_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(737, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Telefon:";
            // 
            // txtBxToplamTutar
            // 
            this.txtBxToplamTutar.BackColor = System.Drawing.Color.Black;
            this.txtBxToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxToplamTutar.ForeColor = System.Drawing.Color.White;
            this.txtBxToplamTutar.Location = new System.Drawing.Point(737, 415);
            this.txtBxToplamTutar.Name = "txtBxToplamTutar";
            this.txtBxToplamTutar.Size = new System.Drawing.Size(371, 84);
            this.txtBxToplamTutar.TabIndex = 14;
            this.txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
            this.txtBxToplamTutar.UseVisualStyleBackColor = false;
            // 
            // txtBxTelefon
            // 
            this.txtBxTelefon.Location = new System.Drawing.Point(737, 599);
            this.txtBxTelefon.Multiline = true;
            this.txtBxTelefon.Name = "txtBxTelefon";
            this.txtBxTelefon.Size = new System.Drawing.Size(371, 38);
            this.txtBxTelefon.TabIndex = 15;
            this.txtBxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxTelefon_KeyPress);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(1138, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(97, 54);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
         //   this.bunifuElipse1.ElipseRadius = 5;
          //  this.bunifuElipse1.TargetControl = this;
            // 
            // ımageList3
            // 
            this.ımageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // PaketServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1274, 661);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtBxTelefon);
            this.Controls.Add(this.txtBxToplamTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lstViewSiparis);
            this.Controls.Add(this.lstViewPaketServis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaketServis";
            this.Text = "PaketServis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ListView lstViewSiparis;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lstViewPaketServis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtBxToplamTutar;
        private System.Windows.Forms.TextBox txtBxTelefon;
        private System.Windows.Forms.Button btnCikis;
       // private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}