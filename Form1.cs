using System;
using System.Xml.Linq;

namespace dydelf
{
    public partial class Form1 : Form
    {
        int wiersz = 5;
        int kolumny = 5;
        int dydelfy = 2;
        int szopy = 3;
        int krokodyle = 1;
        int czas = 30;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Gdzie jest dydelf?";

        }

        private void start_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Rozpoczynasz grê na planszy {kolumny}x{wiersz} z czasem {czas} sekund!");
            Gra game = new Gra(kolumny, wiersz, czas, dydelfy, szopy, krokodyle);
            game.ShowDialog();
        }

        private void ustawienia_Click(object sender, EventArgs e)
        {
            Ustawienia ustawienia = new Ustawienia();
            if (ustawienia.ShowDialog() == DialogResult.OK)
            {
                wiersz = ustawienia.Wiersze;
                kolumny = ustawienia.Kolumny;
                dydelfy = ustawienia.Dydelfy;
                szopy = ustawienia.Szopy;
                krokodyle = ustawienia.Krokodyle;
                czas = ustawienia.Czas;
            }
        }

        private void koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
