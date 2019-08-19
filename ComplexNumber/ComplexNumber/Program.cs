using System;

namespace ComplexNumbers
{
  /// <summary>
  /// Entry point of program.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      ComplexNumber numberOne = new ComplexNumber(4, 8);
      ComplexNumber numberTwo = new ComplexNumber(2, 4);
      ComplexNumber result = numberOne + numberTwo;
      Console.Write(result);
    }
  }
}
