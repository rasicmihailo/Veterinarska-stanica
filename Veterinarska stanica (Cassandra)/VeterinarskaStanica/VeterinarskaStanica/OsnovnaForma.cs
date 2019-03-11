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
    public partial class OsnovnaForma : Form
    {
        #region Atributi

        private Doktor doktor;

        #endregion

        #region Konstruktori

        public OsnovnaForma()
        {
            InitializeComponent();
        }

        public OsnovnaForma(Doktor d)
        {
            this.doktor = d;
            InitializeComponent();
        }

        #endregion

        #region Metode

        public void popuniListu()
        {
            listViewZivotinje.Items.Clear();

            List<Zivotinja> zivotinje = DataProvider.GetZivotinje();

            if (zivotinje == null)
                return;

            foreach (Zivotinja z in zivotinje)
            {
                Vlasnik v = new Vlasnik();
                v = DataProvider.GetVlasnik(z.vlasnikId);

                ListViewItem item = new ListViewItem(new string[]
                {
                    z.id.ToString(),
                    z.ime,
                    z.vrsta,
                    v.ime,
                    v.prezime
                });

                listViewZivotinje.Items.Add(item);
            }
        }

        #endregion

        #region Events
        private void btnPregledajLecenja_Click(object sender, EventArgs e)
        {
            if(listViewZivotinje.SelectedItems.Count > 0)
            {
                int id = Int32.Parse(listViewZivotinje.SelectedItems[0].SubItems[0].Text);
                Zivotinja zivotinja = DataProvider.GetZivotinja(id);

                IstorijaLecenja istorija = new IstorijaLecenja();
                istorija.Zivotinja = zivotinja;
                istorija.Doktor = this.doktor;
                istorija.ShowDialog();             
            }
            else
            {
                MessageBox.Show("Morate odabrati zivotinju!");
            }
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            DodajZivotinju dodaj = new DodajZivotinju();
            dodaj.doktor = this.doktor;
            if(dodaj.ShowDialog()==DialogResult.OK)
            {
                this.popuniListu();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OsnovnaForma_Load(object sender, EventArgs e)
        {
            this.popuniListu();
        }

        #endregion


    }
}
