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
    public partial class Logovanje : Form
    {
        #region Konstruktori

        public Logovanje()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(txtKorisnicko.Text))
            {
                MessageBox.Show("Morate uneti korisnicko ime!");
                txtKorisnicko.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSifra.Text))
            {
                MessageBox.Show("Morate uneti sifru!");
                txtSifra.Focus();
                return false;
            }
            if (DataProvider.vratiDoktora(txtKorisnicko.Text, txtSifra.Text) == null)
            {
                MessageBox.Show("Ne postoji takav korisnik!");
                txtKorisnicko.Focus();
                return false;
            }
            return true;
        }

        #endregion

        #region Events

        private void Logovanje_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                Doktor doc = DataProvider.vratiDoktora(txtKorisnicko.Text, txtSifra.Text);

                OsnovnaForma osnovna = new OsnovnaForma(doc);
                osnovna.ShowDialog();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
