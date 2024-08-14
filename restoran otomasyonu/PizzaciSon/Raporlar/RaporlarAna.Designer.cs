namespace PizzaciSon.Raporlar
{
    partial class RaporlarAna
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
            this.btnPaketServis = new System.Windows.Forms.Button();
            this.btnAdisyonRapor = new System.Windows.Forms.Button();
            this.btnZRapor = new System.Windows.Forms.Button();
            this.btnBahşiş = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaketServis
            // 
            this.btnPaketServis.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPaketServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaketServis.Location = new System.Drawing.Point(148, 352);
            this.btnPaketServis.Name = "btnPaketServis";
            this.btnPaketServis.Size = new System.Drawing.Size(358, 146);
            this.btnPaketServis.TabIndex = 5;
            this.btnPaketServis.Text = "Paket Servis";
            this.btnPaketServis.UseVisualStyleBackColor = false;
            this.btnPaketServis.Click += new System.EventHandler(this.btnPaketServis_Click_1);
            // 
            // btnAdisyonRapor
            // 
            this.btnAdisyonRapor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdisyonRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdisyonRapor.Location = new System.Drawing.Point(718, 155);
            this.btnAdisyonRapor.Name = "btnAdisyonRapor";
            this.btnAdisyonRapor.Size = new System.Drawing.Size(358, 146);
            this.btnAdisyonRapor.TabIndex = 4;
            this.btnAdisyonRapor.Text = "Adisyon Raporu";
            this.btnAdisyonRapor.UseVisualStyleBackColor = false;
            this.btnAdisyonRapor.Click += new System.EventHandler(this.btnAdisyonRapor_Click_1);
            // 
            // btnZRapor
            // 
            this.btnZRapor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnZRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZRapor.Location = new System.Drawing.Point(148, 155);
            this.btnZRapor.Name = "btnZRapor";
            this.btnZRapor.Size = new System.Drawing.Size(358, 146);
            this.btnZRapor.TabIndex = 3;
            this.btnZRapor.Text = "ZRaporu";
            this.btnZRapor.UseVisualStyleBackColor = false;
            this.btnZRapor.Click += new System.EventHandler(this.btnZRapor_Click_1);
            // 
            // btnBahşiş
            // 
            this.btnBahşiş.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBahşiş.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBahşiş.Location = new System.Drawing.Point(718, 352);
            this.btnBahşiş.Name = "btnBahşiş";
            this.btnBahşiş.Size = new System.Drawing.Size(358, 146);
            this.btnBahşiş.TabIndex = 6;
            this.btnBahşiş.Text = "Bahşiş Miktari";
            this.btnBahşiş.UseVisualStyleBackColor = false;
            this.btnBahşiş.Click += new System.EventHandler(this.btnBahşiş_Click_1);
            // 
            // RaporlarAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1272, 661);
            this.Controls.Add(this.btnBahşiş);
            this.Controls.Add(this.btnPaketServis);
            this.Controls.Add(this.btnAdisyonRapor);
            this.Controls.Add(this.btnZRapor);
            this.Name = "RaporlarAna";
            this.Text = "RaporlarAna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaketServis;
        private System.Windows.Forms.Button btnAdisyonRapor;
        private System.Windows.Forms.Button btnZRapor;
        private System.Windows.Forms.Button btnBahşiş;
    }
}