using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameClass_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GetAlphabet_ReturnsDictionaryAlphabet_GameDictionary()
    {
      //Arrange
      Dictionary<string, int> _alphabet = new Dictionary<string, int>() {
      {"a", 1}, {"b", 3}, {"c", 3}, {"d", 2}, {"e", 1}, {"f", 4}, {"g", 2}, 
      {"h", 4}, {"i", 1}, {"j", 8}, {"k", 5}, {"l", 1}, {"m", 3}, {"n", 1},
      {"o", 1}, {"p", 3}, {"q", 10}, {"r", 1}, {"s", 1}, {"t", 1}, {"u", 1},
      {"v", 4}, {"w", 4}, {"x", 8}, {"y", 4}, {"z", 10}
      };

      //Act
      Dictionary<string, int> result = Game.GetAlphabet();

      //Assert
      CollectionAssert.AreEqual(_alphabet, result);
    }

    [TestMethod]
    public void WordScore_ReturnsWordScore_Int()
    {
      //Arrange
      Game newGame = new Game();
      string userInput = "house";
      int score = 8;

      //Act
      int result = newGame.WordScore(userInput);

      //Assert
      Assert.AreEqual(score, result);
    }
  }
}