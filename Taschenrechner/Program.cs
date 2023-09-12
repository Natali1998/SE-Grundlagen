Console.WriteLine("Willkommen beim Taschenrechner -> KevinIstDumm <-");
bool CheckParse1 = false;
bool CheckParse2 = false;
var num1 = 0;
var num2 = 0;

while (!CheckParse1 || !CheckParse2)
{
  Console.WriteLine("Bitte gebe Zahl 1 an:");
  string input1 = Console.ReadLine();

  Console.WriteLine("Bitte gebe Zahl 2 an:");
  string input2 = Console.ReadLine();


  // Konvertierung von Text zu Zahlen
  CheckParse1 = int.TryParse(input1, out num1);
  CheckParse2 = int.TryParse(input2, out num2);
}



  var result = num1 + num2;
  Console.WriteLine($"{num1} + {num2} = {result}");


