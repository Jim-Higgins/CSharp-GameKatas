using System;
using System.Collections.Generic;
using Xunit;

namespace GameZone.Tests {
  public class GameZoneTests {
    [Fact]
    public void GetValidRandomSeedReturnsValidInt () {
      // Arrange
      var testGame = new SuspendPersonNC ();
      int max = 4;

      // Act
      int seed = testGame.GetValidRandomSeed (max);

      // Assert
      Assert.InRange (seed, 0, 3);
    }

    [Fact]
    public void ReturnsCharWhenFoundInList () {
      // Arrange
      var testGame = new SuspendPersonNC ();
      var guesses = new List<char> () { 'a', 'b', 'c' };
      char guess = 'a';

      // Act
      char actual = testGame.GetCharacterToPrint (guesses, guess);

      // Assert
      Assert.Equal ('a', actual);
    }

    [Fact]
    public void ReturnsDashWhenNotFoundInList () {
      // Arrange
      var testGame = new SuspendPersonNC ();
      var guesses = new List<char> () { 'a', 'b', 'c' };
      char guess = 'd';

      // Act
      char actual = testGame.GetCharacterToPrint (guesses, guess);

      // Assert
      Assert.Equal ('-', actual);
    }
  }
}