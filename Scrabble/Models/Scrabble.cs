using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class ScrabbleScore
  {
    private string _word;

    public ScrabbleScore(string word)
    {
      _word = word.ToUpper();
    }
    public int Score()
    {
      int score = 0;
      if(_word == "")
      {
       score = 0;
      }
      else
      {
        foreach(char ch in _word)
        {
          if(ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'L' || ch == 'N' || ch == 'R' || ch == 'S' || ch == 'T')
          {
            score = score + 1;
          }
          else if(ch == 'D' || ch == 'G')
          {
            score = score + 2;
          }
          else if(ch == 'B' || ch == 'C' || ch == 'M' || ch == 'P')
          {
            score = score + 3;
          }
          else if(ch == 'F' || ch == 'H' || ch == 'V' || ch == 'W' || ch == 'Y')
          {
            score = score + 4;
          }
          else if(ch == 'K' )
          {
            score = score + 5;
          }
          else if(ch == 'J' || ch == 'X' )
          {
            score = score + 8;
          }
          else if(ch == 'Q' || ch == 'Z' )
          {
            score = score + 10;
          }
        }
      }
      return score;
    }
  }
}
