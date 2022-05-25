namespace cse210_03{
public class Word{
    private List<string> _words = new List<string>();
    private List<string> _alreadyguest = new List<string>();
    public int _currentWord;
    public string theword;
    private bool _currentguessedletter;
    public Word(){
    _words.Add("blubber");
    _words.Add("sausage");
    _words.Add("pencil");
    _words.Add("cloud");
    _words.Add("moon");
    _words.Add("water");
    _words.Add("computer");
    _words.Add("school");
    _words.Add("network");
    _words.Add("hammer");
    _words.Add("walking");
    _words.Add("violently");
    _words.Add("mediocre");
    _words.Add("literature");
    _words.Add("chair");
    _words.Add("two");
    _words.Add("window");
    _words.Add("cords");
    _words.Add("musical");
    _words.Add("zebra");
    _words.Add("xylophone");
    _words.Add("penguin");
    _words.Add("home");
    _words.Add("dog");
    _words.Add("final");
    _words.Add("ink");
    _words.Add("teacher");
    _words.Add("fun");
    _words.Add("website");
    _words.Add("banana");
    _words.Add("uncle");
    _words.Add("softly");
    _words.Add("mega");
    _words.Add("ten");
    _words.Add("awesome");
    _words.Add("attatch");
    _words.Add("blue");
    _words.Add("internet");
    _words.Add("bottle");
    _words.Add("tight");
    _words.Add("zone");
    _words.Add("tomato");
    _words.Add("prison");
    _words.Add("hydro");
    _words.Add("cleaning");
    _words.Add("telivision");
    _words.Add("send");
    _words.Add("frog");
    _words.Add("cup");
    _words.Add("book");
    _words.Add("zooming");
    _words.Add("falling");
    _words.Add("evily");
    _words.Add("gamer");
    _words.Add("lid");
    _words.Add("juice");
    _words.Add("moniter");
    _words.Add("captain");
    _words.Add("bonding");
    _words.Add("loudly");
    _words.Add("thudding");
    _words.Add("guitar");
    _words.Add("shaving");
    _words.Add("hair");
    _words.Add("soccer");
    _words.Add("water");
    _words.Add("racket");
    _words.Add("table");
    _words.Add("late");
    _words.Add("media");
    _words.Add("desktop");
    _words.Add("flipper");
    _words.Add("club");
    _words.Add("flying");
    _words.Add("smooth");
    _words.Add("monster");
    _words.Add("purple");
    _words.Add("guardian");
    _words.Add("bold");
    _words.Add("hyperlink");
    _words.Add("presentation");
    _words.Add("world");
    _words.Add("national");
    _words.Add("comment");
    _words.Add("element");
    _words.Add("magic");
    _words.Add("lion");
    _words.Add("sand");
    _words.Add("crust");
    _words.Add("toast");
    _words.Add("jam");
    _words.Add("hunter");
    _words.Add("forest");
    _words.Add("foraging");
    _words.Add("silently");
    _words.Add("tawesomated");
    _words.Add("joshing");
    _words.Add("pong");

        theword = "null";
    }
    public string GetNextWord(){
        Random rd = new Random();
        int _current_word = rd.Next(0,(_words.Count -1));
        theword = _words[_current_word];
        return _words[_current_word];
    }
//    takes in Guess as a one letter string variable, and output a string that tells the user what they got wrong/ right in the guess.
//    Example: Word hello guess h output h_____ 
    public string CompareWords( string guess){
        string wordCurrentState = "";
        // Console.WriteLine(theword);
        // Goes through each of the letters of the words. It then produces word as characters in the word.
        foreach (var word in theword){
            _currentguessedletter = false;
            // Goes through each of the different letters that the user has already guessed.
            foreach (var guessed in _alreadyguest){
                if (Convert.ToString(guessed) == Convert.ToString(word)){
                    wordCurrentState = wordCurrentState + guessed;
                    // Console.Write(guessed);
                    _currentguessedletter = true;
                }
            }
            //  If you have guessed the letter it will print it out on the screen and then adds it to a list of guessed words.
            if (guess.Equals(Convert.ToString(word)) && _currentguessedletter != true){
                wordCurrentState = wordCurrentState + word;
                // Console.Write(word);
                _alreadyguest.Add(Convert.ToString(word));
                _currentguessedletter = true;
                }
            // If there is a space in the words, it will add a space in the words.
            if(string.IsNullOrWhiteSpace(Convert.ToString(word))){
                wordCurrentState = wordCurrentState + " ";
                // Console.Write(" ");
            }
            else if ("\'".Equals(Convert.ToString(word)) && _currentguessedletter != true){
                wordCurrentState = wordCurrentState + word;
                // Console.Write(word);
                _alreadyguest.Add(Convert.ToString(word));
                _currentguessedletter = true;
                }
            else if ("-".Equals(Convert.ToString(word)) && _currentguessedletter != true){
                wordCurrentState = wordCurrentState + word;
                // Console.Write(word);
                _alreadyguest.Add(Convert.ToString(word));
                _currentguessedletter = true;
                }
            else if (",".Equals(Convert.ToString(word)) && _currentguessedletter != true){
                wordCurrentState = wordCurrentState + word;
                // Console.Write(word);
                _alreadyguest.Add(Convert.ToString(word));
                _currentguessedletter = true;
                }
            // If the guess is wrong, and 
            else if (_currentguessedletter != true){
                wordCurrentState = wordCurrentState + "_";
                // Console.Write("_");

            }
        }
        return wordCurrentState;
        }
    }
}