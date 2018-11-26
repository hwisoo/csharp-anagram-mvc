using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Models
{
  public class Variable
  {
    private string _word;
    private string _word2;
   

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public string GetWord()
    {
      return _word;
    }


    public void SetWord2(string newWord2)
    {
      _word2 = newWord2;
    }

    public string GetWord2()
    {
      return _word2;
    }

    public string AnagramCheck()
    {
      char[] FirstArray =  _word.ToCharArray();
      char[] SecondArray = _word2.ToCharArray();

      Array.Sort(FirstArray);
      Array.Sort(SecondArray);

      if(FirstArray.SequenceEqual(SecondArray))
      {
          return "These are anagrams";
      }
        else
        {
            return "These are not anagrams.";
        }
    }
    

  

  }
}