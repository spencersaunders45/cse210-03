/*
summary: Gets the input from the user and displays information to the user
*/

using System;

class IO
{

   List<string> _jumperImage;

   public IO()
   {
      _jumperImage = new List<string>();
      CreateJumperImage();
   }

   /*
   summary: Creates the List that will display the jumper
   */
   private void CreateJumperImage()
   {
      _jumperImage.Add(" ___ ");
      _jumperImage.Add("/___\\");
      _jumperImage.Add("\\   /");
      _jumperImage.Add(" \\ /");
      _jumperImage.Add("  0  ");
      _jumperImage.Add(" /|\\ ");
      _jumperImage.Add(" / \\ ");
   }

   /*
   summary: Chooses which jumper to display
   param: (int wrongGuesses) the number of incorrect guesses | (int correctWord) the length of the correct word
   */
   public void DisplayJumper(int wrongGuesses, int correctWord)
   {
      if (wrongGuesses == correctWord)
      {
         DeadJumper();
      }
      else
      {
         AliveJumper(wrongGuesses);
      }
   }

   /*
   summary: Displays the jumper when guesses remain
   param: (int wrongGuesses) the number of incorrect guesses
   */
   private void AliveJumper(int wrongGuesses)
   {
      for (int i = wrongGuesses; i < _jumperImage.Count; i++)
      {
         Console.WriteLine(_jumperImage[i]);
      }
      Console.Write("\n");
      Console.WriteLine("^^^^^^^");
   }

   /*
   summary: Displays the jumper when no guesses remain
   */
   private void DeadJumper()
   {
      Console.WriteLine("  x  ");
      Console.WriteLine(" /|\\ ");
      Console.WriteLine(" / \\ ");
      Console.Write("\n");
      Console.WriteLine("^^^^^^^");
   }

   /*
   summary: Displays the current guesses letters to the user
   param: (string word) The current state of the guesses word
   */
   public void DisplayCurrentWord(string word)
   {
      Console.WriteLine(word);
   }

   /*
   summary: Gets the guessed letter from the user
   return: (string) returns a single letter
   */
   public string JumperGuess()
   {
      Console.Write("Guess a letter [a-z]: ");
      string guess = Console.ReadLine();
      return guess;
   }
}