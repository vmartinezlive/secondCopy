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
   [TestMethod]
  public void GetArray_SentenceIntoArray_True()
  {
    string testSentence = "I took apple from the appletree";
    string[] arrayArray = array.Split(' ');
    Word newWord = new Word(testWord, testSentence, testarray);
    string actualResult = newWord.GetArray("I","took","apple","from","the", "appletree");
    string expectedResult = true;
    Assert.AreEqual(expectedResult, actualResult);
  }


  }
}
