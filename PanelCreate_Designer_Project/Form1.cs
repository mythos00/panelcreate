
using System.Media;
namespace PanelCreate
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        private readonly System.Windows.Forms.Timer collisionTimer =
        new System.Windows.Forms.Timer();
        private SoundPlayer? explosionPlayer;
        private int score = 0;
        private bool gameOver = false;

        public Form1()
        {
            InitializeComponent();

            string assets = Path.Combine(AppContext.BaseDirectory, "Assets");
            string bombPath = Path.Combine(assets, "bomb.png");
            string soundPath = Path.Combine(assets, "explosion.wav");

            if (File.Exists(bombPath))
                pictureBox1.Image = Image.FromFile(bombPath);

            if (File.Exists(soundPath))
                explosionPlayer = new SoundPlayer(soundPath);

            MoveBomb();
            collisionTimer.Interval = 100;
            collisionTimer.Tick += (_, _) => CheckCollision();
            collisionTimer.Start();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (gameOver) return;

            Panel p = new Panel
            {
                Size = new Size(50, 50),
                BackColor = Color.FromArgb(random.Next(40, 256), random.Next(40, 256), random.Next(40, 256)),
                Location = new Point(
                    random.Next(0, Math.Max(1, gameArea.Width - 50)),
                    random.Next(0, Math.Max(1, gameArea.Height - 50)))
            };

            gameArea.Controls.Add(p);
            p.SendToBack();
            pictureBox1.BringToFront();

            score++;
            label2.Text = score.ToString();
            CheckCollision();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            if (gameOver) return;
            MoveBomb();
            CheckCollision();
        }

        private void button3_Click(object? sender, EventArgs e) => Close();

        private void MoveBomb()
        {
            int maxX = Math.Max(0, gameArea.ClientSize.Width - pictureBox1.Width);
            int maxY = Math.Max(0, gameArea.ClientSize.Height - pictureBox1.Height);
            pictureBox1.Location = new Point(random.Next(maxX + 1), random.Next(maxY + 1));
            pictureBox1.BringToFront();
        }

        private void CheckCollision()
        {
            if (gameOver) return;

            foreach (Control c in gameArea.Controls)
            {
                if (c is Panel panel && panel != gameArea &&
                    pictureBox1.Bounds.IntersectsWith(panel.Bounds))
                {
                    EndGame();
                    return;
                }
            }
        }

        private void EndGame()
        {
            gameOver = true;
            collisionTimer.Stop();
            try { explosionPlayer?.Play(); } catch { }

            score = 0;
            label2.Text = "0";

            DialogResult answer = MessageBox.Show(
                "Bomba panelə toxundu! Xal sıfırlandı.\nYeni oyun başlasın?",
                "Oyun bitdi",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (answer == DialogResult.OK)
            {
                for (int i = gameArea.Controls.Count - 1; i >= 0; i--)
                {
                    Control c = gameArea.Controls[i];
                    if (c != pictureBox1)
                    {
                        gameArea.Controls.Remove(c);
                        c.Dispose();
                    }
                }

                score = 0;
                label2.Text = "0";
                MoveBomb();
                gameOver = false;
                collisionTimer.Start();
            }
            else
            {
                Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            collisionTimer.Stop();
            explosionPlayer?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
