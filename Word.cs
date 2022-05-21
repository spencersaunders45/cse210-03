namespace cse210_03{
    class Word{
        List<string> _words;
        public Word()
        {
            _words = new List<string>();
            _words.Add("qeue");
            _words.Add("squirrel");
            _words.Add("misspelled");
            _words.Add("my name is john.");
            _words.Add("hello there");
            _words.Add("general kenobi");
            _words.Add("i have become self aware");
            _words.Add("whats up dog my name is jack");
            _words.Add("luke i am your father");
            _words.Add("hi");
        }
    
        /// <summary>
        /// Return a randomly selected word from the list
        /// </summary>
        /// <returns></returns>
        public string GetRandomWord()
        {
            Random random = new Random();
            int randInt = random.Next(0, _words.Count);
            return _words[randInt];
        }

        /// <summary>
        /// Compares the guess against the word and returns the result.
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public string CompareGuess(string guess, string word, string currentWordState)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == guess[0])
                {
                    // Convert to char array for easier modification
                    Char[] newList = currentWordState.ToCharArray();
                    newList[i] = guess[0];
                    currentWordState = new string(newList);
                }
            }
            return currentWordState;
        }
    }
}