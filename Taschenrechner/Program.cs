decimal GetNumber()
{
  decimal num = 0;
  bool checkParse = false;
  do
  {
    Console.WriteLine("Gebe eine Zahl ein");
    string input = Console.ReadLine();
    checkParse = decimal.TryParse(input, out num);

    if (checkParse == false)
    {
      Console.WriteLine("Ungültige Eingabe: Nur Ganzzahlen sind erlaubt");
    }
  } while (checkParse == false);
  return num;
}

#region Aufgabe

//Aufgabe:

/*string GetOperation()
{
  Console.WriteLine("Bitte wähle eine Operation aus: ");
  Console.WriteLine("1. Addition +");
  Console.WriteLine("2. Subtraktion -");
  Console.WriteLine("3. Multiplikation *");
  Console.WriteLine("4. Division /");
  var userInput = Console.ReadLine();
  switch (userInput)
  {
    case "1":
      return "+";
    case "2":
      return "-";
    case "3":
      return "*";
    case "4":
      return "/";
    default:
      Console.WriteLine("Ungültige Auswahl. Bitte geben Sie eine gültige Option ein.");
      return GetOperation();
  }
}
*/

#endregion

string GetOperation()
{
  string operation;
  bool validOperation;

  do
  {
    Console.WriteLine("Wähle eine Operation (+ - * / ):");
    operation = Console.ReadLine();

    validOperation = operation == "+" || operation == "-" || operation == "*" || operation == "/";

    if (validOperation == false)
    {
      Console.WriteLine("Ungültige Eingabe, versuche es erneut");
    }
  } while (validOperation == false);

  return operation;
}

/* Ohne Kommazahlen:
 
 int Calculate(int num1, int num2, string operation)
 
{
  switch (operation)
  {
    case "+":
      return num1 + num2;
    case "-":
      return num1 - num2;
    case "*":
      return num1 * num2;
    case "/":
      return num1 / num2;
    default:
      Console.WriteLine("Ungültige Operation:Mögliche Werte sind + - * /");
      return 0;
  }
}
*/

// Mit Kommazahlen:
decimal Calculate(decimal num1, decimal num2, string operation)

{
  switch (operation)
  {
    case "+":
      return num1 + num2;
    case "-":
      return num1 - num2;
    case "*":
      return num1 * num2;
    case "/":
      if (num2 == 0)
      {
        Console.WriteLine("Ungültige Operation! Teiln durch null nicht erlaubt!");
        return 0;
      }
      return num1 / num2;
    default:
      Console.WriteLine("Ungültige Operation:Mögliche Werte sind + - * /");
      return 0;
  }
}



Console.WriteLine("Willkommen beim Taschenrechner KevinIstDumm3000");
while (true)
{
  //Get User input
  var num1 = GetNumber();
  var num2 = GetNumber();
  var operation = GetOperation();

  // Calculate result:
  var result = Calculate(num1, num2, operation);

  // Display Output:
  Console.WriteLine($"{num1} {operation} {num2} = {result}");

  // Bildschirm clearen:
  Console.WriteLine("------------------------------------");
  Console.WriteLine("Drücke eine beliebige Taste um die Berechnung zu löschen und eine neue durchzuführen. Oder Strg+C um das Programm zu beenden");
  Console.ReadKey();
  Console.Clear();



}






