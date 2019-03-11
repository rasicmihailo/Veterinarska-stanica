namespace VeterinarskaStanica
{
    partial class Logovanje
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
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblKorisnicko = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(94, 43);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(197, 20);
            this.txtSifra.TabIndex = 12;
            this.txtSifra.UseSystemPasswordChar = true;
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(94, 12);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(197, 20);
            this.txtKorisnicko.TabIndex = 11;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(216, 83);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 38);
            this.btnOtkazi.TabIndex = 10;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(94, 83);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(75, 38);
            this.btnPrijaviSe.TabIndex = 9;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(10, 43);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(31, 13);
            this.lblSifra.TabIndex = 8;
            this.lblSifra.Text = "Sifra:";
            // 
            // lblKorisnicko
            // 
            this.lblKorisnicko.AutoSize = true;
            this.lblKorisnicko.Location = new System.Drawing.Point(10, 15);
            this.lblKorisnicko.Name = "lblKorisnicko";
            this.lblKorisnicko.Size = new System.Drawing.Size(78, 13);
            this.lblKorisnicko.TabIndex = 7;
            this.lblKorisnicko.Text = "Korisnicko ime:";
            // 
            // Logovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 142);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblKorisnicko);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 181);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 181);
            this.Name = "Logovanje";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Logovanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblKorisnicko;
    }
}

