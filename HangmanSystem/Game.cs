using System.ComponentModel;
using System.Runtime.CompilerServices;
using gnuciDictionary;

namespace HangmanSystem
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public const int MaxWrongGuesses = 6;

        public enum GameStatusEnum { NotStarted, Playing, Winner, Lost, GaveUp, TimesUp }

        Random rnd = new();
        string _currentword = "";
        string _displayword = "";
        int _wrongguesses = 0;
        int _secondsremaining = 60;

        char[] cdisplayword = Array.Empty<char>();

        GameStatusEnum _gamestatus = GameStatusEnum.NotStarted;

        const int GameTimeSeconds = 60;

        public Game()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                this.Letters.Add(new Letter()
                {
                    LetterValue = c.ToString(),
                    IsEnabled = false
                });
            }
        }

        public List<Letter> Letters { get; private set; } = new();
        public string CurrentWord
        {
            get => _currentword;
            private set
            {
                _currentword = value;
                this.InvokePropertyChanged();
            }
        }

        public string DisplayWord
        {
            get => _displayword;
            private set
            {
                _displayword = value;
                this.InvokePropertyChanged();
            }
        }

        public int WrongGuesses
        {
            get => _wrongguesses;
            private set
            {
                _wrongguesses = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("WrongGuessDescription");
            }
        }
        public string WrongGuessDescription { get => $"Wrong Guesses: {this.WrongGuesses}/{MaxWrongGuesses}"; }

        public int SecondsRemaining
        {
            get => _secondsremaining;
            private set
            {
                _secondsremaining = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("TimerDescription");
            }
        }

        public string TimerDescription { get => $"Time Left: {this.SecondsRemaining}s"; }

        public GameStatusEnum GameStatus
        {
            get => _gamestatus;
            private set
            {
                _gamestatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged(nameof(GameOverTitle));
        this.InvokePropertyChanged(nameof(GameOverMessage));
            }
        }
        public string GameOverTitle
        {
            get
            {
                return this.GameStatus switch
                {
                    GameStatusEnum.Winner => "Winner!",
                    GameStatusEnum.Lost => "You Lost!",
                    GameStatusEnum.GaveUp => "Game Over",
                    GameStatusEnum.TimesUp => "Time's Up!",
                    _ => ""
                };
            }
        }

        public string GameOverMessage
        {
            get
            {
                return this.GameStatus switch
                {
                    GameStatusEnum.Winner => "You guessed the word!",
                    GameStatusEnum.Lost => $"The word was {this.CurrentWord}.",
                    GameStatusEnum.GaveUp => $"The word was {this.CurrentWord}.",
                    GameStatusEnum.TimesUp => $"The word was {this.CurrentWord}.",
                    _ => ""
                };
            }
        }
        public void GuessLetter(int letternum)
        {
            Letter letter = this.Letters[letternum];

            if(this.GameStatus == GameStatusEnum.Playing && letter.IsEnabled)
            {
                letter.IsEnabled = false;

                bool found = false;

                for (int i = 0; i < this.CurrentWord.Length; i++)
                {
                    if (this.CurrentWord[i].ToString() == letter.LetterValue)
                    {
                        cdisplayword[i] = this.CurrentWord[i];
                        found = true;
                    }
                }
                if (!found)
                {
                    this.WrongGuesses++;
                }

                this.DisplayWord = string.Join(" ", cdisplayword);

                DetectWinner();
                DetectLoser();
            }
        }
        private void EndGame(GameStatusEnum status)
        {
            if (this.GameStatus != GameStatusEnum.Playing)
            {
                return;
            }

            this.GameStatus = status;

            this.DisplayWord = string.Join(" ", this.CurrentWord.ToCharArray());

            this.Letters.ForEach(l => l.IsEnabled = false);
        }
        public void TimerTick()
        {
            if (this.GameStatus == GameStatusEnum.Playing)
            {
                this.SecondsRemaining--;

                if (this.SecondsRemaining <= 0)
                {
                    EndGame(GameStatusEnum.TimesUp);
                }
            }
        }

        public void GiveUp()
        {
            if (this.GameStatus == GameStatusEnum.Playing)
            {
                EndGame(GameStatusEnum.GaveUp);
            }
        }
        private void DetectLoser()
        {
            if (this.WrongGuesses >= MaxWrongGuesses)
            {
                EndGame(GameStatusEnum.Lost);
            }
        }

        private void DetectWinner()
        {
            if (!cdisplayword.Contains('_'))
            {
                EndGame(GameStatusEnum.Winner);
            }
        }

        public void PickRandomWord()
        {
            var lst = gnuciDictionary.EnglishDictionary.GetAllWords().Where(w => w.ToString().Length <= 10).ToList();
            this.CurrentWord = lst[rnd.Next(lst.Count)].ToString().ToUpper();
            this.CurrentWord = new string(this.CurrentWord.Where(char.IsLetter).ToArray());
        }

        private void InitiazlizeDisplayWord()
        {
            cdisplayword = new char[this.CurrentWord.Length];

            for (int i = 0; i < cdisplayword.Length; i++)
            {
                cdisplayword[i] = '_';
            }
            this.DisplayWord = string.Join(" ", cdisplayword);
        }

        public void StartGame()
        {
            PickRandomWord();
            InitiazlizeDisplayWord();

            this.WrongGuesses = 0;
            this.SecondsRemaining = GameTimeSeconds;
            this.GameStatus = GameStatusEnum.Playing;

            this.Letters.ForEach(l => l.IsEnabled = true);
        }


        private void InvokePropertyChanged(
            [CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyname)
            );
        }
    }
}
