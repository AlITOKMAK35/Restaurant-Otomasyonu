namespace PizzaciSon.Ayarlar
{
    partial class AyarlarAna
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
            this.btnUrunEkleKaldir = new System.Windows.Forms.Button();
            this.btnUrunDuzenle = new System.Windows.Forms.Button();
            this.btnMasaEkleKaldir = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnUrunEkleKaldir
            // 
            this.btnUrunEkleKaldir.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUrunEkleKaldir.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkleKaldir.Location = new System.Drawing.Point(178, 189);
            this.btnUrunEkleKaldir.Name = "btnUrunEkleKaldir";
            this.btnUrunEkleKaldir.Size = new System.Drawing.Size(358, 146);
            this.btnUrunEkleKaldir.TabIndex = 0;
            this.btnUrunEkleKaldir.Text = "Ürün Ekle/Kaldır";
            this.btnUrunEkleKaldir.UseVisualStyleBackColor = false;
            this.btnUrunEkleKaldir.Click += new System.EventHandler(this.btnUrunEkleKaldir_Click_1);
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUrunDuzenle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunDuzenle.Location = new System.Drawing.Point(748, 189);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(358, 146);
            this.btnUrunDuzenle.TabIndex = 1;
            this.btnUrunDuzenle.Text = "Ürün Düzenle";
            this.btnUrunDuzenle.UseVisualStyleBackColor = false;
            // 
            // btnMasaEkleKaldir
            // 
            this.btnMasaEkleKaldir.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMasaEkleKaldir.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaEkleKaldir.Location = new System.Drawing.Point(469, 401);
            this.btnMasaEkleKaldir.Name = "btnMasaEkleKaldir";
            this.btnMasaEkleKaldir.Size = new System.Drawing.Size(358, 146);
            this.btnMasaEkleKaldir.TabIndex = 2;
            this.btnMasaEkleKaldir.Text = "Masa Ekle/Kaldır";
            this.btnMasaEkleKaldir.UseVisualStyleBackColor = false;
            // 
            // ımageList3
            // 
            this.ımageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AyarlarAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1163, 568);
            this.Controls.Add(this.btnMasaEkleKaldir);
            this.Controls.Add(this.btnUrunDuzenle);
            this.Controls.Add(this.btnUrunEkleKaldir);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "AyarlarAna";
            this.Text = "AyarlarAna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkleKaldir;
        private System.Windows.Forms.Button btnUrunDuzenle;
        private System.Windows.Forms.Button btnMasaEkleKaldir;
        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList ımageList3;
    }
}