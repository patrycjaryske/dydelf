using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dydelf
{
    public partial class Gra : Form
    {
        private int wiersze, kolumny, pozostaleDydelfy;
        private int secondsLeft;
        private Button[,] board;
        private HashSet<Point> dydelfs = new HashSet<Point>();
        private Point? krokodyl = null;


        public Gra(int r, int c, int time, int dydelfy, int szopy, int krokodyle)
        {
            InitializeComponent();
            wiersze = r;
            kolumny = c;
            secondsLeft = time;
            pozostaleDydelfy = dydelfy;


        }

        private void InitBoard()
        {
            board = new Button[wiersze, kolumny];
            this.ClientSize = new Size(kolumny * 40, wiersze * 40 + 30);
            for (int y = 0; y < wiersze; y++)
            {
                for (int x = 0; x < kolumny; x++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(40, 40),
                        Location = new Point(x * 40, y * 40),
                        Tag = new Point(x * 40, y * 40),
                        BackColor = Color.Gray
                    };
                    // btn.Click += Tile_Click;
                    Controls.Add(btn);
                    board[y, x] = btn;
                }
            }

            Label timeLabel = new Label
            {
                Name = "iblTime",
                Text = $"Czas: {secondsLeft}s",
                Location = new Point(5, wiersze * 40),
                AutoSize = true,
            };
            Controls.Add(timeLabel);
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            secondsLeft--;
            Controls["iblTime"].Text = $"Czas: {secondsLeft}s";
            if (secondsLeft == 0)
            {
                EndGame(false, "czas sie skonczył");
            }
        }

        private void Tile_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Point pos = (Point)btn.Tag;

            btn.Enabled = false;

            if(dydelfs.Contains(pos))
            {
                btn.BackColor = Color.Green;
                pozostaleDydelfy--;
                if(pozostaleDydelfy == 0)
                {

                }
                else
                {
                    btn.BackColor = Color.LightGray;
                }
            }

            
            
        }

        private void EndGame(bool wins, string message)
        {
            foreach (Button b in board)
            {
                b.Enabled = false;

            }
            MessageBox.Show(message, wins ? "Wygrana" : "Przegrana", MessageBoxButtons.OK);
            this.Close();
        }

        private void PlaceDydelf(int count)
        {
            Random rand = new Random();
            while(dydelfs.Count > count)
            {
                Point p = new Point(rand.Next(kolumny), rand.Next(wiersze));
                dydelfs.Add(p);
            }
        }


    }
}
