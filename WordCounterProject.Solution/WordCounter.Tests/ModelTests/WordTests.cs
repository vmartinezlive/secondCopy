using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

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
      string testWord = "apple";

      //Act
      Word newWord = new Word(testWord, testSentence);

      //Act
      Assert.AreEqual("apple", newWord.GetWord());
      Assert.AreEqual("I took apple from the appletree", newWord.GetSentence());
    }
    [TestMethod]
    public void CompareWord_ChecksIfWordsAreTheSame_True()
    {
      // Arrange
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";

      //Act
      Word newWord = new Word(testWord, testSentence);
      bool actualResult = newWord.CompareWord("apple");
      bool expectedResulkgslt = true;

      //Act
      Assert.AreEqual(expectedResult, actualResult);
    }
    [TestMethod]
    public void GetcountWords_CountsTheNumberOfApplesInSentence_Int()
    {
      // Arrange
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";
      string[] expectedresult = testSentence.Split(' ');

      //Act

      int actualResult = newWord.GetcountWords(2);
      int expectedResult = (2);

      //Act
      Assert.AreEqual(expectedResult, actualResult);
    }

  }
}
