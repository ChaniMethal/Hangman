using gnuciDictionary;

namespace Hangman
{
    public partial class Hangman : Form
    {
        List<Button> lstbuttons;
        string scurrentword = "";
        Char[] cdisplayword;
        Random rnd = new();
        int nwrongguesses = 0;
        const int GameTimeSeconds = 60;
        int nsecondsremaining = GameTimeSeconds;
        readonly System.Windows.Forms.Timer gametimer = new();

        public Hangman()
        {
            InitializeComponent();
            btnGiveUp.Enabled = false;
            
            lstbuttons = new() 
            {   
                btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, 
                btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, 
                btnU, btnV, btnW, btnX, btnY, btnZ 
            };
            lstbuttons.ForEach(b => b.Click += LetterButton_Click);

            btnStart.Click += BtnStart_Click;
            btnGiveUp.Click += BtnGiveUp_Click;
            gametimer.Interval = 1000;
            gametimer.Tick += GameTimer_Tick;
            UpdateTimerDisplay();

            lstbuttons.ForEach(b => b.Enabled = false);

            tblMan.Paint += TblMan_Paint;
        }

        private void DrawMan(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.White, 4);

            // gallows
            g.DrawLine(p, 40, 300, 160, 300); // base
            g.DrawLine(p, 80, 300, 80, 40);   // pole
            g.DrawLine(p, 80, 40, 170, 40);   // top
            g.DrawLine(p, 170, 40, 170, 70);  // rope

            // head
            if (nwrongguesses >= 1)
                g.DrawEllipse(p, 145, 70, 50, 50);

            // body
            if (nwrongguesses >= 2)
                g.DrawLine(p, 170, 120, 170, 200);

            // left arm
            if (nwrongguesses >= 3)
                g.DrawLine(p, 170, 140, 135, 170);

            // right arm
            if (nwrongguesses >= 4)
                g.DrawLine(p, 170, 140, 205, 170);

            // left leg
            if (nwrongguesses >= 5)
                g.DrawLine(p, 170, 200, 140, 245);

            // right leg
            if (nwrongguesses >= 6)
                g.DrawLine(p, 170, 200, 200, 245);
        }

        private void TblMan_Paint(object? sender, PaintEventArgs e)
        {
            DrawMan(e);     
        }
       
        private void DisplayWrongGuesses()
        {
            lblWrongGuesses.Text = "Wrong Guesses: " + nwrongguesses.ToString() + "/6";
        }
        private void Loser()
        {
            if (nwrongguesses >= 6)
            {
                gametimer.Stop();
                lblWord.Text = string.Join(" ", scurrentword.ToCharArray());
                DisableLetterButtons();
                btnGiveUp.Enabled = false;
                btnGiveUp.BackColor = Color.White;
                MessageBox.Show("You Lost!");
            }
        }
        private void GiveUp()
        {
            gametimer.Stop();
            lblWord.Text = string.Join(" ", scurrentword.ToCharArray());
            DisableLetterButtons();
            btnGiveUp.Enabled = false;
            btnGiveUp.BackColor = Color.White;
            MessageBox.Show("You gave up.", "Game Over");
        }
        private void Winner()
        {
            if (!cdisplayword.Contains('_'))
            {
                gametimer.Stop();
                btnGiveUp.Enabled = false;
                btnGiveUp.BackColor = Color.White;
                
                MessageBox.Show("You Win!");
                DisableLetterButtons();
            }
        }
        private void UpdateTimerDisplay()
        {
            lblTimer.Text = $"Time Left: {nsecondsremaining}s";
        }

        private void GameTimer_Tick(object? sender, EventArgs e)
        {
            nsecondsremaining--;
            UpdateTimerDisplay();

            if (nsecondsremaining <= 0)
            {
                gametimer.Stop();
                lblWord.Text = string.Join(" ", scurrentword.ToCharArray());
                DisableLetterButtons();
                btnGiveUp.Enabled = false;
                btnGiveUp.BackColor = Color.White;
                MessageBox.Show("Time's up! You lost.", "Game Over");
            }
        }
        private void WhenletterIsClicked(Button btn)
        {
            btn.Enabled = false;
            

            string sletter = btn.Text;
            bool found = false;

            for (int i = 0; i < scurrentword.Length; i++)
            {
                if (scurrentword[i].ToString() == sletter)
                {
                    cdisplayword[i] = scurrentword[i];
                    found = true;
                }
            }

            if (!found)
            {
                nwrongguesses++;
                tblMan.Invalidate();
            }
            lblWord.Text = string.Join(" ", cdisplayword);

            DisplayWrongGuesses();
            Winner();
            Loser();
        }
        private void InitializeDisplayWord()
        {
            cdisplayword = new char[scurrentword.Length];

            for (int i = 0; i < cdisplayword.Length; i++)
            {
                cdisplayword[i] = '_';
            }

            lblWord.Text = string.Join(" ", cdisplayword);
        }

        private void EnableLetterButtons()
        {
            lstbuttons.ForEach(b =>
            {
                b.Enabled = true;
                b.BackColor = Color.SkyBlue;
            });
        }

        private void DisableLetterButtons()
        {
            lstbuttons.ForEach(b =>
            {
                b.Enabled = false;
                b.BackColor = Color.White;
            });
        }
        private void PickRandomWord()
        {
            var lst = gnuciDictionary.EnglishDictionary.GetAllWords()
                .Where(w => w.ToString().Length <= 10)
                .ToList();
            scurrentword = lst[rnd.Next(lst.Count)].ToString().ToUpper();
            scurrentword = new string(scurrentword.Where(char.IsLetter).ToArray());
        }
  
        private void Start()
        {
            btnGiveUp.Enabled = true;
            btnGiveUp.BackColor = Color.SkyBlue;

            PickRandomWord();
            InitializeDisplayWord();
            EnableLetterButtons();

            nwrongguesses = 0;
            nsecondsremaining = GameTimeSeconds;
            UpdateTimerDisplay();
            gametimer.Start();
            tblMan.Invalidate();
            DisplayWrongGuesses();
        }
        
        private void BtnGiveUp_Click(object? sender, EventArgs e)
        {
            GiveUp();
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            Start();
        }

        private void LetterButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                WhenletterIsClicked(btn);
            }
        }
    }
}
