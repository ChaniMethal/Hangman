using HangmanSystem;

namespace Hangman
{
    public partial class Hangman : Form
    {
        Game game = new();
        List<Button> lstbuttons;
        readonly System.Windows.Forms.Timer gametimer = new();
        bool gameOverShown = false;

        public Hangman()
        {
            InitializeComponent();
            lblTimer.DataBindings.Add("Text", game, nameof(game.TimerDescription));
            lblWord.DataBindings.Add("Text", game, nameof(Game.DisplayWord));
            lblWrongGuesses.DataBindings.Add("Text", game, nameof(Game.WrongGuessDescription));
            btnGiveUp.Enabled = false;
            
            lstbuttons = new() 
            {   
                btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, 
                btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, 
                btnU, btnV, btnW, btnX, btnY, btnZ 
            };
            InitializeLetterButtons();

            btnStart.Click += BtnStart_Click;
            btnGiveUp.Click += BtnGiveUp_Click;
            gametimer.Interval = 1000;
            gametimer.Tick += GameTimer_Tick;

            UpdateLetterButtonColors();

            tblMan.Paint += TblMan_Paint;
        }
        private void InitializeLetterButtons()
        {
            for (int i = 0; i < lstbuttons.Count; i++)
            {
                Button btn = lstbuttons[i];
                Letter letter = game.Letters[i];

                btn.Click += LetterButton_Click;

                btn.DataBindings.Add(
                    "Enabled",
                    letter,
                    nameof(Letter.IsEnabled));
            }
        }
        private void CheckGameStatus()
        {
            if (game.GameStatus == Game.GameStatusEnum.Playing ||
                game.GameStatus == Game.GameStatusEnum.NotStarted ||
                gameOverShown)
            {
                return;
            }

            gameOverShown = true;
            gametimer.Stop();

            UpdateLetterButtonColors();

            btnGiveUp.Enabled = false;
            btnGiveUp.BackColor = Color.White;

            MessageBox.Show(
                game.GameOverMessage,
                game.GameOverTitle);
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
            if (game.WrongGuesses >= 1)
                g.DrawEllipse(p, 145, 70, 50, 50);

            // body
            if (game.WrongGuesses >= 2)
                g.DrawLine(p, 170, 120, 170, 200);

            // left arm
            if (game.WrongGuesses >= 3)
                g.DrawLine(p, 170, 140, 135, 170);

            // right arm
            if (game.WrongGuesses >= 4)
                g.DrawLine(p, 170, 140, 205, 170);

            // left leg
            if (game.WrongGuesses >= 5)
                g.DrawLine(p, 170, 200, 140, 245);

            // right leg
            if (game.WrongGuesses >= 6)
                g.DrawLine(p, 170, 200, 200, 245);
        }

        private void TblMan_Paint(object? sender, PaintEventArgs e)
        {
            DrawMan(e);     
        }
       
        private void DisplayWrongGuesses()
        {
            lblWrongGuesses.Text = game.WrongGuessDescription;
        }

        private void GameTimer_Tick(object? sender, EventArgs e)
        {
            game.TimerTick();
            CheckGameStatus();
        }
        private void WhenletterIsClicked(Button btn)
        {
            int letternum = lstbuttons.IndexOf(btn);
            game.GuessLetter(letternum);

            tblMan.Invalidate();

            DisplayWrongGuesses();
            UpdateLetterButtonColors();
            CheckGameStatus();
        }
        private void UpdateLetterButtonColors()
        {
            for (int i = 0; i < lstbuttons.Count; i++)
            {
                lstbuttons[i].BackColor =
                    game.Letters[i].IsEnabled
                    ? Color.SkyBlue
                    : Color.White;
            }
        }

        private void Start()
        {
            gameOverShown = false;
            btnGiveUp.Enabled = true;
            btnGiveUp.BackColor = Color.SkyBlue;

            game.StartGame();
            UpdateLetterButtonColors();

            gametimer.Start();
            tblMan.Invalidate();
            DisplayWrongGuesses();
        }
        
        private void BtnGiveUp_Click(object? sender, EventArgs e)
        {
            game.GiveUp();
            CheckGameStatus();
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
