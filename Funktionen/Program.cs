void printHello()
{
  Console.WriteLine("Hello");
}


string getHello()
{
  return "Hello";
}

void printGreeting(string name, int itercount)
{
  int i = 0;
  while (i < itercount)
  {
    Console.WriteLine($"Hello {name}");
    i++; //i = i + 1 
  }
}

printHello();

var hello = getHello();

hello = hello + " World";

Console.WriteLine(hello);

Console.WriteLine("Nenne mir deinen Namen");
var inputName = Console.ReadLine();

printGreeting(inputName, 20);


// oder:
//printGreeting(name: inputName, itercount: 10);
//printGreeting(itercount: 42, name: "Olaf");
//printGreeting(itercount: 42, name: inputName);
