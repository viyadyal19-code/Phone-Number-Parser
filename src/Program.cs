using System;

public class PhoneNumber
{
  private string? areaCode;
  private string? centralOfficeCode;
  private string? lineNumber;

  public void Parse(string number)
  {
    if(number.Length != 10)
    {
      throw new Exception ("Phone number must be exactly 10 digits.");
    }

    areaCode = number.Substring(0, 3); //first 3 digits
    centralOfficeCode = number.Substring(3, 3); //next 3 digits
    lineNumber = number.Substring(6, 4); // last 4 digits  
  }
  public override string ToString()
    {
        return $"({areaCode}){centralOfficeCode}-{lineNumber}";
    }
}

public class Program
{
  public static void Main()
  {
    PhoneNumber phone = new PhoneNumber();

    phone.Parse("5145551234");

    Console.WriteLine(phone.ToString());
  }
}
