using HangmanSystem;

namespace HangmanMAUI;

public partial class HangmanGame : ContentPage
{
    Game game = new();
    List<Button> lstbuttons;
    IDispatcherTimer gametimer;
    public HangmanGame()
    {
        InitializeComponent();
        this.BindingContext = game;

        lstbuttons = new() { ABtn, BBtn, CBtn, DBtn, EBtn, FBtn, GBtn, HBtn, IBtn, JBtn, KBtn, LBtn, MBtn, NBtn, OBtn, PBtn, QBtn, RBtn, SBtn, TBtn, UBtn, VBtn, WBtn, XBtn, YBtn, ZBtn};

        gametimer = Dispatcher.CreateTimer();
        gametimer.Interval = TimeSpan.FromSeconds(1);
        gametimer.Tick += Gametimer_Tick;
    }

    private async void Gametimer_Tick(object? sender, EventArgs e)
    {
        game.TimerTick();

        if (game.GameStatus != Game.GameStatusEnum.Playing)
        {
            gametimer.Stop();
            await CheckGameStatus();
        }
    }

    private async Task CheckGameStatus()
    {
        if (game.GameStatus == Game.GameStatusEnum.Winner)
        {
            gametimer.Stop();
            await DisplayAlertAsync("Winner!", "You guessed the word!", "OK");
        }
        else if (game.GameStatus == Game.GameStatusEnum.Lost)
        {
            gametimer.Stop();
            await DisplayAlertAsync("You Lost!", $"The word was {game.CurrentWord}.", "OK");
        }
        else if (game.GameStatus == Game.GameStatusEnum.GaveUp)
        {
            gametimer.Stop();
            await DisplayAlertAsync("Game Over", $"The word was {game.CurrentWord}.", "OK");
        }
        else if (game.GameStatus == Game.GameStatusEnum.TimesUp)
        {
            gametimer.Stop();
            await DisplayAlertAsync("Time's Up!", $"The word was {game.CurrentWord}.", "OK");
        }
    }

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
        gametimer.Stop();
        game.StartGame();
        gametimer.Start();
    }

    private async void GiveUpBtn_Clicked(object sender, EventArgs e)
    {
        game.GiveUp();
        await CheckGameStatus();
    }
    private async void BtnLetter_Clicked(object sender, EventArgs e)
    {
        game.GuessLetter(lstbuttons.IndexOf((Button)sender));
        await CheckGameStatus();
    }
}

    