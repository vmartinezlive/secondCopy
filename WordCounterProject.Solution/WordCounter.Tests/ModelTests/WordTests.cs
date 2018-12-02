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
    public void GetSplitSentence_SplitSentenceIntoArray_ExpectedResult()
    {
      // Arrange
      string testSentence = "I took apple from the appletree";
      string[] phrase = phrase.Split(' ');

      //Act
      SplitSentence  newSplitSentence = new SplitSentence (testSplitSentence);
      // Word newWord = new Word(testWord, testSentence, testSplitSentence);
      string actualResult = newWord.GetSplitSentence("I","took","apple","from","the", "appletree");
      string expectedResult = (" ");

      //Act
      Assert.AreEqual(expectedResult, actualResult);
    }

  }
}
