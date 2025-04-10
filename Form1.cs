namespace dydelf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            
        }

        private void ustawienia_Click(object sender, EventArgs e)
        {
            Ustawienia ustawienia = new Ustawienia();
            if (ustawienia.ShowDialog() == DialogResult.OK)
            {
                int wiersz = ustawienia.Wiersze;
                int kolumny = ustawienia.Kolumny;
                int dydelfy = ustawienia.Dydelfy;
                int szopy = ustawienia.Szopy;
                int krokodyle = ustawienia.Krokodyle;

            }
        }

        private void koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
