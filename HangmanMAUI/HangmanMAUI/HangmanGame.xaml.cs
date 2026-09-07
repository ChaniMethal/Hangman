using HangmanSystem;
using static HangmanSystem.Game;

namespace HangmanMAUI;

public partial class HangmanGame : ContentPage
{
    Game game = new();
    List<Button> lstbuttons;
    IDispatcherTimer gametimer;
    bool gameOverShown = false;
    public HangmanGame()
    {
        InitializeComponent();
        this.BindingContext = game;

        lstbuttons = new() { ABtn, BBtn, CBtn, DBtn, EBtn, FBtn, GBtn, HBtn, IBtn, JBtn, KBtn, LBtn, MBtn, NBtn, OBtn, PBtn, QBtn, RBtn, SBtn, TBtn, UBtn, VBtn, WBtn, XBtn, YBtn, ZBtn };

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
        if (game.GameStatus == Game.GameStatusEnum.Playing ||
        game.GameStatus == Game.GameStatusEnum.NotStarted ||
        gameOverShown)
        {
            return;
        }

        gameOverShown = true;
        gametimer.Stop();

        await DisplayAlertAsync(game.GameOverTitle,game.GameOverMessage,"OK");
    }

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
        gametimer.Stop();
        gameOverShown = false;
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

