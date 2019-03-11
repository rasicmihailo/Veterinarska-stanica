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
    public partial class FormNoviIzvestaj : Form
    {
        #region Atributi

        public int Tip;
        public Zivotinja Zivotinja { get; set; }
        public Doktor Doktor { get; set; }
        public Izvestaj Izvestaj { get; set; }

        #endregion

        #region Konstruktori

        public FormNoviIzvestaj()
        {
            InitializeComponent();
            Zivotinja = new Zivotinja();
            Doktor = new Doktor();
            Izvestaj = new Izvestaj();
        }

        #endregion

        #region Metode

        private void PopuniComboOrdinacije()
        {
            List<Ordinacija> ordinacije = new List<Ordinacija>();

            ordinacije = DataProvider.vratiOrdinacije();

            if (ordinacije.Count == 0) //ako se slucajno desi da ne postoji ordinacija, jednu ce dodati samo 
            {
                Ordinacija o = new Ordinacija();
                int id = DataProvider.NadjiID("Ordinacija");
                o.id = ++id;
                o.tip = "Ordinacija 1";
                DataProvider.DodajOrdinaciju(o);
                comboBox1.Items.Add(o.tip);
            }

            foreach(Ordinacija o in ordinacije)
            {
                comboBox1.Items.Add(o.tip);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void RetrieveInfo(Izvestaj iz)
        {
            comboBox1.Items.Clear();
            textBox1.Text = iz.izvestaj;
            textBox2.Text = iz.vrstaIntervencije;
            //nesh za combo, znash cimo vetj shta

            Ordinacija o = new Ordinacija();
            o = DataProvider.vratiOrdinaciju(iz.ordinacijaId);
            if (o == null)
                return;
            comboBox1.Items.Add(o.tip);
            comboBox1.SelectedIndex = 0;
        }

        public bool validacija()
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Morate uneti vrstu intervencije!");
                textBox2.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Morate napisati izvestaj!");
                textBox1.Focus();
                return false;
            }
            
            return true;
        }

        #endregion

        #region Events

        private void FormNoviIzvestaj_Load(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
                this.PopuniComboOrdinacije();
            else if (Tip == 1)//prikazi
            {
                this.RetrieveInfo(Izvestaj);
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                comboBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                string te = comboBox1.SelectedItem.ToString();
                Ordinacija ordinacija = DataProvider.vratiOrdinaciju(te);
                if (ordinacija == null)
                    return;

                int id = DataProvider.NadjiID("Izvestaj");
                Izvestaj.id = ++id;
                Izvestaj.izvestaj = textBox1.Text;
                Izvestaj.vrstaIntervencije = textBox2.Text;
                Izvestaj.ordinacijaId = ordinacija.id;
                Izvestaj.doktorId = this.Doktor.id;
                Izvestaj.zivotinjaId = this.Zivotinja.id;
                Izvestaj.datum = DateTime.Now.ToString();

                DataProvider.AddIzvestaj(Izvestaj);

                this.Close();
                DialogResult = DialogResult.OK;
            }
        }

        #endregion
    }
}
