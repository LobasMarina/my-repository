using System;

namespace IntegerParser
{
  /// <summary>
  /// This class is used for convert string to int.
  /// </summary>
  public class StringToIntConverter
  {
    private string line;
    private bool isNumber;
    private bool isNegative;
    private int[] partsOfNumber;

    public StringToIntConverter(string lineForConvert)
    {
      line = lineForConvert;
      isNumber = CheckIfNumber();
      isNegative = CheckIfNegative();
    }

    /// <summary>
    /// This method is used for check if whether the entered sequence is a number.
    /// </summary>
    /// <returns> true if sequence is a number, false otherwise </returns>
    private bool CheckIfNumber()
    {
      bool isNumber = true;
      if ((line[0] > '0' && line[0] <= '9') || line[0] == '-')
      {
        for (int i = 1; i < line.Length; i++)
        {
          if (line[i] < '0' && line[i] > '9')
          {
            isNumber = false;
            break;
          }
        }
      }
      else
      {
        isNumber = false;
      }
      return isNumber;
    }

    /// <summary>
    /// Whether the number is negative.
    /// </summary>
    /// <returns> true if the number is negative </returns>
    private bool CheckIfNegative()
    {
      return line[0] == '-';
    }

    /// <summary>
    /// This method is used for filling the array with numbers depending on the sign of the number.
    /// </summary>
    private void FillArray()
    {
      if (isNegative)
      {
        partsOfNumber = new int[line.Length - 1];
        for (int i = 0; i < partsOfNumber.Length; i++)
        {
          partsOfNumber[i] += line[i + 1] - '0';
        }
      }
      else
      {
        partsOfNumber = new int[line.Length];
        for (int i = 0; i < line.Length; i++)
        {
          partsOfNumber[i] += line[i] - '0';
        }
      }
    }

    /// <summary>
    /// This method is used to calculate the result with an overflow check.
    /// </summary>
    /// <returns></returns>
    private int CalculateResult()
    {
      int result = 0;
      for (int i = 0; i < partsOfNumber.Length; i++)
      {
        checked
        {
          result += partsOfNumber[i] * (int)Math.Pow(10, partsOfNumber.Length - 1 - i);
        }
      }
      if (isNegative)
      {
        result = -result;
      }
      return result;
    }

    /// <summary>
    /// This method is used to turn a string into a number.
    /// </summary>
    /// <returns> result if the string is a number; if the string is not a number then an exception is thrown </returns>
    public int ConvertString()
    {
      if (isNumber)
      {
        FillArray();
        return CalculateResult();
      }
      else
      {
        throw new Exception("This is not number");
      }
    }
  }
}
