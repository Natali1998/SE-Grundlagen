Console.WriteLine("Wie viele Zufallszahlen möchtest du?");

var inputAmount = Console.ReadLine();


var randomAmount = int.Parse(inputAmount!);

var rng = new Random();

//array erstellen: array immer mit [] nach int:
int[] randomNumbers = new int[randomAmount];

for (int i = 0; i < randomNumbers.Length; i++)
{
    randomNumbers[i] = rng.Next();
}

Console.WriteLine(string.Join(", ", randomNumbers));