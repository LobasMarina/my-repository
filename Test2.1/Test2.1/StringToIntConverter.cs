using System;

namespace Test2._1
{
  class StringToIntConverter
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

    private bool CheckIfNegative()
    {
      return line[0] == '-';
    }

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
