using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinarskaStanica.Entiteti;

namespace VeterinarskaStanica
{
    public partial class DodajZivotinju : Form
    {

        #region Atributi

        public Zivotinja zivotinja;
        public Vlasnik vlasnik;
        public Doktor doktor;
        private static int br = 0;

        #endregion

        #region Konstruktori

        public DodajZivotinju()
        {
            this.zivotinja = new Zivotinja();
            this.vlasnik = new Vlasnik();
            this.doktor = new Doktor();
            InitializeComponent();
        }

        #endregion

        #region Metode

        public void Dodaj()
        {
            this.vlasnik = DataProvider.GetVlasnik(txtJMBG.Text);
            if (vlasnik == null)
            {
                int novi = DataProvider.NadjiID("Vlasnik");
                vlasnik = new Vlasnik();
                vlasnik.id = ++novi;
                vlasnik.ime = txtImeVlasnika.Text;
                vlasnik.prezime = txtPrezime.Text;
                vlasnik.jmbg = txtJMBG.Text;
                DataProvider.AddVlasnik(this.vlasnik); //samo ako ne postoji vlasnik dodaje se novi
            }

            int noviID = DataProvider.NadjiID("Zivotinja");
            zivotinja.ime = txtImeZivotinje.Text;
            zivotinja.vrsta = txtVrsta.Text;
            zivotinja.id = ++noviID;
            zivotinja.vlasnikId = vlasnik.id;

            DateTime dateTime = datRodj.Value;

            String dan = dateTime.Day.ToString();
            String mesec = dateTime.Month.ToString();
            String godina = dateTime.Year.ToString();

            String datumRodj = dan + "." + mesec + "." + godina;

            zivotinja.datumRodjenja = datumRodj;

            DataProvider.AddZivotinja(this.zivotinja);
        }

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(txtImeVlasnika.Text))
            {
                MessageBox.Show("Morate uneti ime vlasnika!");
                txtImeVlasnika.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Morate uneti prezime vlasnika!");
                txtPrezime.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtJMBG.Text))
            {
                MessageBox.Show("Morate uneti JMBG vlasnika!");
                txtJMBG.Focus();
                return false;
            }
            if (txtJMBG.TextLength != 13)
            {
                MessageBox.Show("JMBG sadrzi 13 cifara!");
                txtJMBG.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtImeZivotinje.Text))
            {
                MessageBox.Show("Morate uneti ime zivotinje!");
                txtImeZivotinje.Focus();
                return false;
            }  
            if (string.IsNullOrEmpty(txtVrsta.Text))
            {
                MessageBox.Show("Morate uneti vrstu zivotinje!");
                txtVrsta.Focus();
                return false;
            }         
            return true;
        }

        #endregion

        #region Events
    
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                this.Dodaj();

                FormNoviIzvestaj novi = new FormNoviIzvestaj();
                novi.Zivotinja = this.zivotinja;
                novi.Doktor = this.doktor;
                novi.Tip = 0;
                if (novi.ShowDialog() == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {               
                e.Handled = true;               
            }
        }

        #endregion


    }
}
