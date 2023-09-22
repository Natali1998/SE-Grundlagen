using MyCalculator;
namespace Projektstruktur
{
  internal class Program //class (Klasse) ist eine Datenstruktur. zb String, Datetime,.. Im Prinzip ist in C# alles eine Klasse oder innerhalt einer Klasse
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      var num1 = 10;
      var num2 = 20;

      var addResult = Calculator.Add(num1, num2);
      Console.WriteLine(addResult);
    }
  }
}