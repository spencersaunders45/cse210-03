namespace cse210_03
{
    public class Director
    {
        // Initialize necessary variables
        private IO _io;
        private Word _word;

        private string _currentWord;

        private int _wrongGuesses;
        private string _guess;
        private string _currentWordState;

        /// <summary>
        /// Director constructor
        /// </summary>
        public Director()
        {
            _io = new IO();
            _word = new Word();
            _currentWord = _word.GetNextWord();
            _wrongGuesses = 0;
            _currentWordState = "";

            // foreach (char character in _currentWord)
            // {
            //     if (character != ' ')
            //         _currentWordState += "_";
            //     else
            //         _currentWordState += " ";
            // }
        }
        
        /// <summary>
        /// Run the game logic
        /// </summary>
        public void RunGame()
        {
            while (_wrongGuesses < 4)
            {
                _currentWordState = _word.CompareWords("");
                // Display basic information to player
                _io.DisplayJumper(_wrongGuesses, 4);
                _io.DisplayCurrentWord(_currentWordState);
                
                // Get the players' guess
                _guess = _io.JumperGuess();
                
                // Compare guess against the current word
                string guessed = _word.CompareWords(_guess); //_currentWord, _currentWordState
                
                // Apply the consequence based on the results of the guess comparison
                if (_currentWordState == guessed)
                    _wrongGuesses++;
                else
                    _currentWordState = guessed;

                // Win Condition
                if (_currentWordState == _currentWord)
                {
                    Console.WriteLine("You Win!");
                    return;
                }
            }
            
            // Loss Condition
            _io.DisplayJumper(_wrongGuesses, 4);
            Console.WriteLine("You Lose!");
        }
    }
}