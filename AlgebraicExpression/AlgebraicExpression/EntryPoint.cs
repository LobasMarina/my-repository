using System;

namespace AlgebraicExpression
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string expression = "[{2+(4-3)}]";
      CheckerValidBracket check = new CheckerValidBracket(expression);
      Console.Write(check.CheckLocationOfBrackets());
    }
  }
}
