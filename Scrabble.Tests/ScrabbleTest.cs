using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleScoreTest
  {
    [TestMethod]
    public void Score_ReturnsAScoreForA_Integer()
    {
      int expected = 1;
      ScrabbleScore score = new ScrabbleScore("A");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForAEIOULNRST_Integer()
    {
      int expected = 10;
      ScrabbleScore score = new ScrabbleScore("AEIOULNRST");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForD_Integer()
    {
      int expected = 2;
      ScrabbleScore score = new ScrabbleScore("D");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForDG_Integer()
    {
      int expected = 4;
      ScrabbleScore score = new ScrabbleScore("DG");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForB_Integer()
    {
      int expected = 3;
      ScrabbleScore score = new ScrabbleScore("B");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForBCMP_Integer()
    {
      int expected = 12;
      ScrabbleScore score = new ScrabbleScore("BCMP");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForF_Integer()
    {
      int expected = 4;
      ScrabbleScore score = new ScrabbleScore("F");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForFHVWY_Integer()
    {
      int expected = 20;
      ScrabbleScore score = new ScrabbleScore("FHVWY");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForK_Integer()
    {
      int expected = 5;
      ScrabbleScore score = new ScrabbleScore("K");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForJ_Integer()
    {
      int expected = 8;
      ScrabbleScore score = new ScrabbleScore("J");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForJX_Integer()
    {
      int expected = 16;
      ScrabbleScore score = new ScrabbleScore("JX");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForQ_Integer()
    {
      int expected = 10;
      ScrabbleScore score = new ScrabbleScore("Q");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForQZ_Integer()
    {
      int expected = 20;
      ScrabbleScore score = new ScrabbleScore("QZ");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForAllCharacters_Integer()
    {
      int expected = 87;
      ScrabbleScore score = new ScrabbleScore("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void Score_ReturnsAScoreForEmptyWordInput_Integer()
    {
      int expected = 0;
      ScrabbleScore score = new ScrabbleScore("");
      int actual = score.Score();
      Assert.AreEqual(expected,actual);
    }
  }
}
