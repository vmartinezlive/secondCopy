namespace WordCounter.Models
{
  public class Word
  {
    private string _word;
    private string _sentence;
    // private string _phrase = "I ate the apple from the appletree";
    // private string[] words = phrase.Split(' ');
    public Word(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      // -phrase = phrase;
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public bool CompareWord(string word)
    {
      if(_word == word)
      {
        return true;
      }
      return false;
    }
    public int CountWords()
    {
      int count = 0; // need to create variable to keep track of how many times the word occurs
      string[] words = _sentence.Split(' ');

      foreach(string word in words)
      {
        //logic for counting each word that matches test word
        if(_word == word)
        {
          count++;
        }
        System.Console.WriteLine($"{word}");
      }

      return count;
    }
    // public string phrase()
    // {
    //   foreach  (var word in words)
    //   {
    //     System.Console.WriteLine($"{word}>");
    //   }
    // }



  }
}
