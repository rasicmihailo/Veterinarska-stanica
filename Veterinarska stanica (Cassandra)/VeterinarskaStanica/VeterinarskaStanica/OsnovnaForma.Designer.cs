namespace VeterinarskaStanica
{
    partial class OsnovnaForma
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
            this.listViewZivotinje = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPregledajLecenja = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewZivotinje
            // 
            this.listViewZivotinje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewZivotinje.FullRowSelect = true;
            this.listViewZivotinje.Location = new System.Drawing.Point(12, 12);
            this.listViewZivotinje.Name = "listViewZivotinje";
            this.listViewZivotinje.Size = new System.Drawing.Size(506, 181);
            this.listViewZivotinje.TabIndex = 0;
            this.listViewZivotinje.UseCompatibleStateImageBehavior = false;
            this.listViewZivotinje.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vrsta";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ime vlasnika";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prezime vlasnika";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // btnPregledajLecenja
            // 
            this.btnPregledajLecenja.Location = new System.Drawing.Point(12, 233);
            this.btnPregledajLecenja.Name = "btnPregledajLecenja";
            this.btnPregledajLecenja.Size = new System.Drawing.Size(114, 49);
            this.btnPregledajLecenja.TabIndex = 1;
            this.btnPregledajLecenja.Text = "Pregledaj istoriju lecenja";
            this.btnPregledajLecenja.UseVisualStyleBackColor = true;
            this.btnPregledajLecenja.Click += new System.EventHandler(this.btnPregledajLecenja_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(210, 233);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(122, 49);
            this.btnPregled.TabIndex = 2;
            this.btnPregled.Text = "Registruj i pregledaj";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(422, 233);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(96, 49);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // OsnovnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 290);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnPregledajLecenja);
            this.Controls.Add(this.listViewZivotinje);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 329);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 329);
            this.Name = "OsnovnaForma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OsnovnaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewZivotinje;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnPregledajLecenja;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnOtkazi;
    }
}