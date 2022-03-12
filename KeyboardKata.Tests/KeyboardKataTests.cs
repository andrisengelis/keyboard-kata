using Xunit;

namespace KeyboardKata.Tests;

public class KeyboardKataTests
{
  [Theory]
  [InlineData(1)]
  [InlineData(2)]
  [InlineData(0)]
  public void KataSessionInputLetterCountTest(int repeatInput)
  {
    var inputChar = 'a';

    var sut = new KataSession();

    var i = repeatInput;
    while (i > 0)
    {
      sut.Input(inputChar);
      i -= 1;
    }

    Assert.Equal(repeatInput, sut.Statistics.InputLettersCount);
  }
}