namespace PizzaciSon.StokTakibi
{
    partial class Fire
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblFire = new System.Windows.Forms.Label();
            this.lblFireYiyecek = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxMiktar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(324, 18);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(49, 48);
            this.btnCikis.TabIndex = 57;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFire.Location = new System.Drawing.Point(84, 263);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(194, 25);
            this.lblFire.TabIndex = 5;
            this.lblFire.Text = "Yiyecek Fire Tutar:";
            // 
            // lblFireYiyecek
            // 
            this.lblFireYiyecek.AutoSize = true;
            this.lblFireYiyecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFireYiyecek.Location = new System.Drawing.Point(84, 220);
            this.lblFireYiyecek.Name = "lblFireYiyecek";
            this.lblFireYiyecek.Size = new System.Drawing.Size(194, 25);
            this.lblFireYiyecek.TabIndex = 4;
            this.lblFireYiyecek.Text = "Yiyecek Fire Tutar:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Coral;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(25, 164);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(234, 37);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Onayla";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yiyecek Fire";
            // 
            // txtBxMiktar
            // 
            this.txtBxMiktar.Location = new System.Drawing.Point(25, 107);
            this.txtBxMiktar.Multiline = true;
            this.txtBxMiktar.Name = "txtBxMiktar";
            this.txtBxMiktar.Size = new System.Drawing.Size(234, 38);
            this.txtBxMiktar.TabIndex = 1;
            // 
            // Fire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 374);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.lblFireYiyecek);
            this.Controls.Add(this.txtBxMiktar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Name = "Fire";
            this.Text = "Fire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxMiktar;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Label lblFireYiyecek;
        private System.Windows.Forms.Button btnCikis;
    }
}