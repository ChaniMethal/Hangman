using HangmanSystem;

namespace HangmanTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestStartGame()
        {
            Game game = new();
            game.StartGame();

            string msg = $"game status = {game.GameStatus} " +
                         $"word = {game.CurrentWord} " +
                         $"num letters = {game.Letters.Count} " +
                         $"wrong guesses = {game.WrongGuesses}";

            Assert.That(
                game.GameStatus == Game.GameStatusEnum.Playing
                && game.Letters.Count == 26
                && game.WrongGuesses == 0
                && game.SecondsRemaining == 60,
                msg);

            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestCorrectGuess()
        {
            Game game = new();
            game.StartGame();

            string letter = game.CurrentWord[0].ToString();

            int letternum = game.Letters.FindIndex(
                l => l.LetterValue == letter);

            game.GuessLetter(letternum);

            string msg = $"letter guessed = {letter} " +
                         $"display word = {game.DisplayWord} " +
                         $"wrong guesses = {game.WrongGuesses}";

            Assert.That(
                game.DisplayWord.Contains(letter)
                && game.WrongGuesses == 0,
                msg);

            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestWrongGuess()
        {
            Game game = new();
            game.StartGame();

            int letternum = game.Letters.FindIndex(
                l => !game.CurrentWord.Contains(l.LetterValue));

            game.GuessLetter(letternum);

            string msg = $"wrong guesses = {game.WrongGuesses}";

            Assert.That(game.WrongGuesses == 1, msg);

            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestWinner()
        {
            Game game = new();
            game.StartGame();

            foreach (char c in game.CurrentWord.Distinct())
            {
                int letternum = game.Letters.FindIndex(
                    l => l.LetterValue == c.ToString());

                game.GuessLetter(letternum);
            }

            string msg = $"game status = {game.GameStatus} " +
                         $"word = {game.CurrentWord}";

            Assert.That(
                game.GameStatus == Game.GameStatusEnum.Winner,
                msg);

            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestLoser()
        {
            Game game = new();
            game.StartGame();

            var wrongletters = game.Letters
                .Where(l => !game.CurrentWord.Contains(l.LetterValue))
                .Take(6)
                .ToList();

            wrongletters.ForEach(l =>
            {
                game.GuessLetter(game.Letters.IndexOf(l));
            });

            string msg = $"game status = {game.GameStatus} " +
                         $"wrong guesses = {game.WrongGuesses}";

            Assert.That(
                game.GameStatus == Game.GameStatusEnum.Lost
                && game.WrongGuesses == 6,
                msg);

            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestGiveUp()
        {
            Game game = new();
            game.StartGame();

            game.GiveUp();

            string msg = $"game status = {game.GameStatus} " +
                         $"word = {game.CurrentWord}";

            Assert.That(
                game.GameStatus == Game.GameStatusEnum.GaveUp,
                msg);

            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestTimer()
        {
            Game game = new();
            game.StartGame();

            game.TimerTick();

            string msg =
                $"seconds remaining = {game.SecondsRemaining}";

            Assert.That(game.SecondsRemaining == 59, msg);

            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestTimesUp()
        {
            Game game = new();
            game.StartGame();

            for (int i = 0; i < 60; i++)
            {
                game.TimerTick();
            }

            string msg = $"game status = {game.GameStatus} " +
                         $"seconds remaining = {game.SecondsRemaining}";

            Assert.That(
                game.GameStatus == Game.GameStatusEnum.TimesUp
                && game.SecondsRemaining == 0,
                msg);

            TestContext.WriteLine(msg);
        }
    }
}