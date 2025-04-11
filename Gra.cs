using System;
using System.Drawing;
using System.Windows.Forms;

namespace dydelf
{
    public partial class Gra : Form
    {
        private int kolumny, wiersze, czas;
        private int dydelfy, szopy, krokodyle;
        private Button[,] grid;
        private string[,] board;
        private System.Windows.Forms.Timer gameTimer;
        private int czasDoKonca;
        private int znalezioneDydelfy = 0;
        private Button krokodylBtn;
        private System.Windows.Forms.Timer krokodylTimer;
        private bool krokodylKlikniety = false;
        private List<Button> szopZablokowanePola = new List<Button>();
        private System.Windows.Forms.Timer szopTimer;
        private Label czasLabel;
        private bool[,] odkryteDydelfy;

        public Gra(int l, int w, int c, int d, int s, int k)
        {
            InitializeComponent();

            kolumny = l;
            wiersze = w;
            czas = c;
            dydelfy = d;
            szopy = s;
            krokodyle = k;

            InitGame();
        }

        private void InitGame()
        {
            grid = new Button[kolumny, wiersze];
            board = new string[kolumny, wiersze];
            odkryteDydelfy = new bool[kolumny, wiersze];

            TableLayoutPanel panel = new TableLayoutPanel
            {
                RowCount = wiersze,
                ColumnCount = kolumny,
                Dock = DockStyle.Fill,
            };

            for (int y = 0; y < wiersze; y++)
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / wiersze));

            for (int x = 0; x < kolumny; x++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / kolumny));
                for (int y = 0; y < wiersze; y++)
                {
                    var btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        Tag = new Point(x, y),
                        BackColor = Color.LightGray,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold)
                    };
                    btn.Click += Cell_Click;
                    grid[x, y] = btn;
                    panel.Controls.Add(btn, x, y);
                }
            }

            Controls.Add(panel);

            PlaceRandomItems("D", dydelfy);
            PlaceRandomItems("S", szopy);
            PlaceRandomItems("K", krokodyle);

            czasDoKonca = czas;
            gameTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
            czasLabel = new Label
            {
                Text = $"Czas: {czasDoKonca}s",
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                BackColor = Color.White
            };
            Controls.Add(czasLabel);
            czasLabel.BringToFront(); 

            this.Text = $"Znajdź wszystkie Dydelfy! Pozostały czas: {czasDoKonca} s";
        }

        private void PlaceRandomItems(string symbol, int count)
        {
            Random rand = new Random();
            int placed = 0;
            while (placed < count)
            {
                int x = rand.Next(kolumny);
                int y = rand.Next(wiersze);
                if (string.IsNullOrEmpty(board[x, y]))
                {
                    board[x, y] = symbol;
                    placed++;
                }
            }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Point pos = (Point)btn.Tag;
            int x = pos.X;
            int y = pos.Y;

            string cellValue = board[x, y];

            if (!btn.Enabled && !(cellValue == "K" && btn == krokodylBtn && krokodylKlikniety))
                return;

            if (cellValue == "D")
            {
                btn.Text = "D";
                btn.BackColor = Color.LightGreen;

                if (!odkryteDydelfy[x, y])
                {
                    odkryteDydelfy[x, y] = true;
                    znalezioneDydelfy++;
                    if (znalezioneDydelfy == dydelfy)
                        EndGame(true, "Wygrałeś! Znalazłeś wszystkie Dydelfy!");
                }

            }
            else if (cellValue == "S")
            {
                btn.Text = "";
                btn.BackColor = Color.LightGray;
                btn.Enabled = true;
                board[x, y] = ""; // usuń szopa z planszy
                ZakryjNaChwileSasiednie(x, y);
            }
            else if (cellValue == "K")
            {
                if (!krokodylKlikniety)
                {
                    krokodylKlikniety = true;
                    krokodylBtn = btn;
                    btn.Text = "K";
                    btn.BackColor = Color.Red;
                    btn.Enabled = true; // zostaw aktywny do kliknięcia

                    krokodylTimer = new System.Windows.Forms.Timer { Interval = 2000 };
                    krokodylTimer.Tick += KrokodylTimer_Tick;
                    krokodylTimer.Start();
                }
                else if (btn == krokodylBtn)
                {
                    krokodylTimer.Stop();
                    krokodylBtn.Text = "-";
                    krokodylBtn.BackColor = Color.White;
                    krokodylBtn.Enabled = false;
                    krokodylKlikniety = false;
                }
            }
            else
            {
                btn.Text = "-";
                btn.BackColor = Color.White;
                btn.Enabled = false;
            }
        }


        private class PoleBackup
        {
            public Button Przycisk;
            public string Tekst;
            public Color Kolor;
            public bool CzyAktywny;
        }

        private List<PoleBackup> szopBackupPola = new List<PoleBackup>();

        private void ZakryjNaChwileSasiednie(int x, int y)
        {
            szopZablokowanePola.Clear();

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;
                    if (nx >= 0 && ny >= 0 && nx < kolumny && ny < wiersze)
                    {
                        var b = grid[nx, ny];

                        // Resetujemy wygląd przycisku do stanu "nieodkrytego"
                        b.Text = "";
                        b.BackColor = Color.LightGray;
                        b.Enabled = false;

                        szopZablokowanePola.Add(b);
                    }
                }
            }

            szopTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            szopTimer.Tick += SzopTimer_Tick;
            szopTimer.Start();
        }

        private void SzopTimer_Tick(object sender, EventArgs e)
        {
            szopTimer.Stop();

            foreach (var btn in szopZablokowanePola)
            {
                btn.Text = "";
                btn.BackColor = Color.LightGray;
                btn.Enabled = true;
            }

            szopZablokowanePola.Clear();
        }

        

        

        private void KrokodylTimer_Tick(object sender, EventArgs e)
        {
            krokodylTimer.Stop();
            if (krokodylKlikniety)
            {
                EndGame(false, "Ups! Nie odkliknąłeś Krokodyla na czas!");
            }
        }




        private void GameTimer_Tick(object sender, EventArgs e)
        {
            czasDoKonca--;
            this.Text = $"Znajdź wszystkie Dydelfy! Pozostały czas: {czasDoKonca} s";
            czasLabel.Text = $"Czas: {czasDoKonca}s";

            if (czasDoKonca <= 0)
                EndGame(false, "Koniec czasu!");
        }

        private void EndGame(bool win, string message)
        {
            gameTimer.Stop();
            MessageBox.Show(message, win ? "Gratulacje!" : "Koniec gry");
            this.Close();
        }
    }
}
