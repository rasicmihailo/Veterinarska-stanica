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
    public partial class IstorijaLecenja : Form
    {
        #region Atributi
        public Zivotinja Zivotinja { get; set; }
        public Doktor Doktor { get; set; }

        #endregion

        #region Konstruktori

        public IstorijaLecenja()
        {
            InitializeComponent();
            Zivotinja = new Zivotinja();
            Doktor = new Doktor();
        }

        #endregion

        #region Metode 

        private void RetrieveInfo(Zivotinja zivotinja)
        {

            labelVrsta.Text = zivotinja.vrsta.ToString();
            labelDatum.Text = zivotinja.datumRodjenja.ToString();
            labelIme.Text = zivotinja.ime.ToString();
            string vlasnik = DataProvider.GetVlasnik(zivotinja.vlasnikId).ime;
            labelVlasnik.Text = vlasnik;

            this.PrikaziSveIzvestaje();


        }

        private void PrikaziSveIzvestaje()
        {
            foreach (var iz in DataProvider.GetIzvestaji(Zivotinja.id))
            {
                try
                {
                    ListViewItem item = new ListViewItem(new string[] { iz.id.ToString(), iz.datum, iz.vrstaIntervencije });
                    listViewIzvestaji.Items.Add(item);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            listViewIzvestaji.Refresh();
        }

        private void PopulateInfos()
        {
            listViewIzvestaji.Items.Clear();
            List<Izvestaj> izList = DataProvider.GetIzvestaji(Zivotinja.id);
            foreach (Izvestaj iz in izList)
            {

                ListViewItem item = new ListViewItem(new string[] { iz.id.ToString(), iz.datum, iz.vrstaIntervencije });
                listViewIzvestaji.Items.Add(item);

            }
            listViewIzvestaji.Refresh();
        }



        #endregion

        #region Events

        private void buttonNapraviNovi_Click(object sender, EventArgs e)
        {
            FormNoviIzvestaj f = new FormNoviIzvestaj();

            f.Tip = 0;
            f.Zivotinja = Zivotinja;
            f.Doktor = Doktor;

            if (f.ShowDialog() == DialogResult.OK)
            {
                this.PopulateInfos();
            }
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            if (listViewIzvestaji.SelectedItems.Count > 0)
            {

                int id = Int32.Parse(listViewIzvestaji.SelectedItems[0].SubItems[0].Text);
                Izvestaj iz = DataProvider.GetIzvestaj(id);

                FormNoviIzvestaj f = new FormNoviIzvestaj();

                f.Tip = 1;
                f.Zivotinja = Zivotinja;
                f.Izvestaj = iz;
                f.Doktor = Doktor;

                f.Show();
            }
            else
            {
                MessageBox.Show("Morate odabrati izvestaj!");
            }
        }

        private void IstorijaLecenja_Load(object sender, EventArgs e)
        {
            this.RetrieveInfo(this.Zivotinja);
        }

        #endregion
    }
}
