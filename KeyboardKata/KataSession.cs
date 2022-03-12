using System.Security.AccessControl;

namespace KeyboardKata;

public class KataSession
{
  public KataStatistics Statistics { get; } = new();

  public void Input(char inputLetter)
  {
    Statistics.InputLettersCount += 1;
  }
}