namespace VeterinarskaStanica
{
    partial class IstorijaLecenja
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
            this.labelVlasnik = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVrsta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.listViewIzvestaji = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNapraviNovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVlasnik
            // 
            this.labelVlasnik.AutoSize = true;
            this.labelVlasnik.Location = new System.Drawing.Point(714, 21);
            this.labelVlasnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVlasnik.Name = "labelVlasnik";
            this.labelVlasnik.Size = new System.Drawing.Size(46, 17);
            this.labelVlasnik.TabIndex = 26;
            this.labelVlasnik.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Vlasnik:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(488, 21);
            this.labelDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(46, 17);
            this.labelDatum.TabIndex = 24;
            this.labelDatum.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Datum rodjenja:";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(248, 21);
            this.labelIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(46, 17);
            this.labelIme.TabIndex = 22;
            this.labelIme.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ime:";
            // 
            // labelVrsta
            // 
            this.labelVrsta.AutoSize = true;
            this.labelVrsta.Location = new System.Drawing.Point(73, 21);
            this.labelVrsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVrsta.Name = "labelVrsta";
            this.labelVrsta.Size = new System.Drawing.Size(46, 17);
            this.labelVrsta.TabIndex = 20;
            this.labelVrsta.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vrsta:";
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Location = new System.Drawing.Point(652, 185);
            this.buttonPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(203, 28);
            this.buttonPrikazi.TabIndex = 18;
            this.buttonPrikazi.Text = "Prikazi izvestaj";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // listViewIzvestaji
            // 
            this.listViewIzvestaji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewIzvestaji.FullRowSelect = true;
            this.listViewIzvestaji.Location = new System.Drawing.Point(24, 117);
            this.listViewIzvestaji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewIzvestaji.Name = "listViewIzvestaji";
            this.listViewIzvestaji.Size = new System.Drawing.Size(559, 376);
            this.listViewIzvestaji.TabIndex = 17;
            this.listViewIzvestaji.UseCompatibleStateImageBehavior = false;
            this.listViewIzvestaji.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DATUM";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "VRSTA INTERVENCIJE";
            this.columnHeader3.Width = 218;
            // 
            // buttonNapraviNovi
            // 
            this.buttonNapraviNovi.Location = new System.Drawing.Point(652, 117);
            this.buttonNapraviNovi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNapraviNovi.Name = "buttonNapraviNovi";
            this.buttonNapraviNovi.Size = new System.Drawing.Size(203, 28);
            this.buttonNapraviNovi.TabIndex = 16;
            this.buttonNapraviNovi.Text = "Napravi novi izvestaj";
            this.buttonNapraviNovi.UseVisualStyleBackColor = true;
            this.buttonNapraviNovi.Click += new System.EventHandler(this.buttonNapraviNovi_Click);
            // 
            // IstorijaLecenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 516);
            this.Controls.Add(this.labelVlasnik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVrsta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.listViewIzvestaji);
            this.Controls.Add(this.buttonNapraviNovi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(898, 563);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(898, 563);
            this.Name = "IstorijaLecenja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.IstorijaLecenja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVlasnik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.ListView listViewIzvestaji;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonNapraviNovi;
    }
}