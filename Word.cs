namespace cse210_03{
public class Word{
    private List<string> _words = new List<string>();
    private List<string> _alreadyguest = new List<string>();
    public int _currentWord;
    public string theword;
    private bool _currentguessedletter;
    public Word(){
        _words.Add("qeue");
        _words.Add("squirel");
        _words.Add("misspelled");
        _words.Add("my name is john.");
        _words.Add("hello there");
        _words.Add("generalg kenobi");
        _words.Add("i have become self aware");
        _words.Add("whats up dog, my name is jack");
        _words.Add("luke i am your father");
        _words.Add("hi");

        theword = "null";
    }
    //  gets a random word when you call the funciton
    public void GetNextWord(){
        Random rd = new Random();
        // Call random int from size of list size.
        int _current_word = rd.Next(0,(_words.Count -1));
        theword = _words[_current_word];

    }
//    takes in Guess as a one letter string variable, and output a string that tells the user what they got wrong/ right in the guess.
//    Example: Word hello guess h output h_____ 
    public void CompareWords( string guess){
        Console.WriteLine(theword);
        // Goes through each of the letters of the words. It then produces word as characters in the word.
        foreach (var word in theword){
            _currentguessedletter = false;
            // Goes through each of the different letters that the user has already guessed.
            foreach (var guessed in _alreadyguest){
                if (Convert.ToString(guessed) == Convert.ToString(word)){
                    Console.Write(guessed);
                    _currentguessedletter = true;
                }
            }
            //  If you have guessed the letter it will print it out on the screen and then adds it to a list of guessed words.
            if (guess.Equals(Convert.ToString(word)) && _currentguessedletter != true){
                Console.Write(word);
                _alreadyguest.Add(Convert.ToString(word));
                }
            // If there is a space in the words, it will add a space in the words.
            if(string.IsNullOrWhiteSpace(Convert.ToString(word))){
                Console.Write(" ");
            }
            // If the guess is wrong, and 
            else if (_currentguessedletter != true){
                Console.Write("_");

            }
        }
        }
    }
}