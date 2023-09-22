namespace MyCalculator //namespace ist dafür da um zu verhindern dass ich eine struktur verwende die es schon gibt. Meine Klassen mit meinen eigenen namespace namen prefixe, um zu verhindern dass es dafür schon eine andere gibt 
{
  internal static class Calculator
  {
    internal static int Add(int num1, int num2)
    {
      return num1 + num2;
    }
    internal static int Subtract(int num1, int num2)
    {
      return num1 - num2;
    }
  }

}

