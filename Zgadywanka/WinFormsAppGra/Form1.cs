using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogikaGry;

namespace WinFormsAppGra
{
    public partial class Form1 : Form
    {
        private Gra gra;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            int max = int.Parse(textBoxMaxZakres.Text);
            int min = int.Parse(textBoxMinZakres.Text);
            gra = new Gra(min, max);
            groupBox1.Enabled = false;
        }

        private void buttonOcena_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPropozycja.Text);
            var odp = gra.Ocena(propozycja);
            switch( odp )
            {
                case Gra.Odpowiedz.Trafiony:
                    labelOdpowiedz.Text = "Trafiono"; break;
                case Gra.Odpowiedz.ZaDuzo:
                    labelOdpowiedz.Text = "Za dużo"; break;
                case Gra.Odpowiedz.ZaMalo:
                    labelOdpowiedz.Text = "Za mało"; break;
            }
        }
    }
}
