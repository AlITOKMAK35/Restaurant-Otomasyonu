namespace PizzaciSon.StokTakibi
{
    partial class StokTakibiAna
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
            this.btnYiyecekStok = new System.Windows.Forms.Button();
            this.btnIcecekStok = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYiyecekStok
            // 
            this.btnYiyecekStok.BackColor = System.Drawing.Color.Plum;
            this.btnYiyecekStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYiyecekStok.Location = new System.Drawing.Point(33, 171);
            this.btnYiyecekStok.Name = "btnYiyecekStok";
            this.btnYiyecekStok.Size = new System.Drawing.Size(242, 113);
            this.btnYiyecekStok.TabIndex = 0;
            this.btnYiyecekStok.Text = "Yiyecek Stok";
            this.btnYiyecekStok.UseVisualStyleBackColor = false;
            // 
            // btnIcecekStok
            // 
            this.btnIcecekStok.BackColor = System.Drawing.Color.Plum;
            this.btnIcecekStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIcecekStok.Location = new System.Drawing.Point(360, 171);
            this.btnIcecekStok.Name = "btnIcecekStok";
            this.btnIcecekStok.Size = new System.Drawing.Size(242, 113);
            this.btnIcecekStok.TabIndex = 1;
            this.btnIcecekStok.Text = "İçecek Stok";
            this.btnIcecekStok.UseVisualStyleBackColor = false;
            this.btnIcecekStok.UseWaitCursor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(674, 43);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(49, 48);
            this.btnCikis.TabIndex = 39;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // StokTakibiAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(776, 415);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnIcecekStok);
            this.Controls.Add(this.btnYiyecekStok);
            this.Name = "StokTakibiAna";
            this.Text = "StokTakibiAna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYiyecekStok;
        private System.Windows.Forms.Button btnIcecekStok;
        private System.Windows.Forms.Button btnCikis;
    }
}