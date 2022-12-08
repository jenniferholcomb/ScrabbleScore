using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word: ");
      string word = (Console.ReadLine()).ToLower();

      Game newGame = new Game();
      int score = newGame.WordScore(word);

      Console.WriteLine("Your score is " + score);
      Main();
    }
  }
}