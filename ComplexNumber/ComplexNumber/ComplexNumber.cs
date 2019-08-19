using System;

namespace ComplexNumbers
{
  /// <summary>
  /// This class is used to create complex numbers and actions with them.
  /// </summary>
  public class ComplexNumber
  {
    public double RealPart { get; set; }
    public double ComplexPart { get; set; }

    public ComplexNumber()
    {

    }

    public ComplexNumber(double real, double complex)
    {
      RealPart = real;
      ComplexPart = complex;
    }

    public ComplexNumber(ComplexNumber number)
    {
      RealPart = number.RealPart;
      ComplexPart = number.ComplexPart;
    }

    public static ComplexNumber operator +(ComplexNumber numberOne, ComplexNumber numberTwo)
    {
      ComplexNumber number = new ComplexNumber();
      number.RealPart = numberOne.RealPart + numberTwo.RealPart;
      number.ComplexPart = numberOne.ComplexPart + numberTwo.ComplexPart;
      return number;
    }

    public static ComplexNumber operator -(ComplexNumber numberOne, ComplexNumber numberTwo)
    {
      ComplexNumber number = new ComplexNumber();
      number.RealPart = numberOne.RealPart - numberTwo.RealPart;
      number.ComplexPart = numberOne.ComplexPart - numberTwo.ComplexPart;
      return number;
    }

    public static ComplexNumber operator *(ComplexNumber numberOne, ComplexNumber numberTwo)
    {
      ComplexNumber number = new ComplexNumber();
      number.RealPart = numberOne.RealPart * numberTwo.RealPart - numberOne.ComplexPart * numberTwo.ComplexPart;
      number.ComplexPart = numberOne.RealPart * numberTwo.ComplexPart + numberTwo.RealPart * numberOne.ComplexPart;
      return number;
    }

    public static ComplexNumber operator /(ComplexNumber numberOne, ComplexNumber numberTwo)
    {
      ComplexNumber number = new ComplexNumber();
      number.RealPart = (numberOne.RealPart * numberTwo.RealPart + numberOne.ComplexPart * numberTwo.ComplexPart) / (Math.Pow(numberTwo.RealPart, 2) + Math.Pow(numberTwo.ComplexPart, 2));
      number.ComplexPart = (numberOne.ComplexPart * numberTwo.RealPart - numberOne.RealPart * numberTwo.ComplexPart) / (Math.Pow(numberTwo.RealPart, 2) + Math.Pow(numberTwo.ComplexPart, 2));
      return number;
    }
    /// <summary>
    /// This method is used to compare complex numbers.
    /// </summary>
    /// <param name="numberOne"> first complex number </param>
    /// <param name="numberTwo"> second complex number </param>
    /// <returns> true, if the numbers are equal, false otherwise </returns>
    public static bool operator ==(ComplexNumber numberOne, ComplexNumber numberTwo)
    {
      return ((numberOne.RealPart == numberTwo.RealPart) && (numberOne.ComplexPart == numberTwo.ComplexPart));
    }

    /// <summary>
    /// This method is used to compare complex numbers.
    /// </summary>
    /// <param name="numberOne"> first complex number </param>
    /// <param name="numberTwo"> second complex number </param>
    /// <returns> true, if the numbers are not equal, false otherwise </returns>
    public static bool operator !=(ComplexNumber numberOne, ComplexNumber numberTwo)
    {
      return !((numberOne.RealPart == numberTwo.RealPart) && (numberOne.ComplexPart == numberTwo.ComplexPart));
    }

    public override string ToString()
    {
      if (ComplexPart <= 0)
      {
        return RealPart.ToString() + ComplexPart.ToString() + "i";
      }
      else
      {
        return RealPart.ToString() + "+" + ComplexPart.ToString() + "i";
      }
    }
  }
}

