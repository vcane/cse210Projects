using System;
using System.Xml.Schema;
//useless comment for push test
class Program
{
  static void Main(string[] args)
  {
    // Getter and Setter to write 1/2 to console
    Fraction getSet = new Fraction();
    getSet.SetTop(1);
    getSet.SetBottom(2);
    Console.WriteLine($"{getSet.GetTop()}/{getSet.GetBottom()}");

    Fraction f1 = new Fraction();
    Console.WriteLine(f1.GetFractionString());
    Console.WriteLine(f1.GetDecimalValue());

    Fraction f2 = new Fraction(5);
    Console.WriteLine(f2.GetFractionString());
    Console.WriteLine(f2.GetDecimalValue());

    Fraction f3 = new Fraction(3, 4);
    Console.WriteLine(f3.GetFractionString());
    Console.WriteLine(f3.GetDecimalValue());

    Fraction f4 = new Fraction(1, 3);
    Console.WriteLine(f4.GetDecimalValue());
    Console.WriteLine(f4.GetFractionString());
  }
}