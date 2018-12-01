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
    string testSplitSentence = { new testSentence ("I","took","apple","from","the", "appletree") };
      Word newWord = new Word(testWord, testSentence, testSplitSentence);
      Assert.AreEqual("apple", newWord.GetWord());
      Assert.AreEqual("I took apple from the appletree", newWord.GetSentence());
    }
    [TestMethod]
   public void CompareWord_ChecksIfWordsAreTheSame_True()
   {
     string testSentence = "I took apple from the appletree";
     string testWord = "apple";
   string testSplitSentence = { new testSentence ("I","took","apple","from","the", "appletree") };
     Word newWord = new Word(testWord, testSentence, testSplitSentence);
     bool actualResult = newWord.CompareWord("apple");
     bool expectedResult = true;
     Assert.AreEqual(expectedResult, actualResult);
   }
   [TestMethod]
  public void GetSplitSentence_SplitSentenceIntoArray_ExpectedResult()
  {
    string testSentence = "I took apple from the appletree";
    string testWord = "apple";
  string testSplitSentence = { new testSentence ("I","took","apple","from","the", "appletree") };
    // string[] phrase = phrase.Split(' ');
    Word newWord = new Word(testWord, testSentence, testSplitSentence);
    string actualResult = newWord.GetSplitSentence("I","took","apple","from","the", "appletree");
    string expectedResult = ("I","took","apple","from","the", "appletree");
    Assert.AreEqual(expectedResult, actualResult);
  }

  }
}
