using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void Constructor_SetsWordAndSentence_True()
    {
      // Arrange
      string testSentence = "I took apple from the appletree";
      string testWord = "pie";
      Word newWord = new Word(testWord, testSentence);
      Assert.AreEqual("apple", newWord.GetWord());
      Assert.AreEqual("I took apple from the appletree", newWord.GetSentence());
    }
    [TestMethod]
    public void CompareWord_ChecksIfWordsAreTheSame_True()
    {
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";
      Word newWord = new Word(testWord, testSentence);
      bool actualResult = newWord.CompareWord("apple");
      bool expectedResult = true;
      Assert.AreEqual(expectedResult, actualResult);
    }

  }
}
