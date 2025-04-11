using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dydelf
{

    public partial class Ustawienia : Form
    {
        public int Wiersze { get; private set; }
        public int Kolumny { get; private set; }
        public int Czas { get; private set; }
        public int Dydelfy { get; private set; }
        public int Krokodyle { get; private set; }
        public int Szopy { get; private set; }


        public Ustawienia()
        {
            InitializeComponent();
            xTxt.Text = "5";
            yTxt.Text = "5";
            CzasTxt.Text = "30";
            dydelfTxt.Text = "2";
            SzopTxt.Text = "3";
            krokodylTxt.Text = "1";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Kolumny = int.Parse(xTxt.Text);
                Wiersze = int.Parse(yTxt.Text);
                Czas = int.Parse(CzasTxt.Text);
                Dydelfy = int.Parse(dydelfTxt.Text);
                Szopy = int.Parse(SzopTxt.Text);
                Krokodyle = int.Parse(krokodylTxt.Text);

                if (Kolumny < 3 || Kolumny > 10 ||
                    Wiersze < 3 || Wiersze > 10 ||
                    Czas < 10 || Czas > 60 ||
                    Dydelfy < 1 || Dydelfy > 6 ||
                    Szopy < 3 || Szopy > 8 ||
                    Krokodyle < 0 || Krokodyle > 1)
                {
                    MessageBox.Show("Wprowadź poprawne wartości zgodne z zakresem!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadź poprawne liczby całkowite we wszystkich polach!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
