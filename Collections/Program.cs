// Collctions / Sammlung:

// Collections sind dafür da um mehrere Daten in eine Variable einzusetzn
// ints = intager array
// ein array ist nicht vergrößerbar. es ist nur so groß wie man es am anfang eingibt.

#region Arrays
// Neues int array:
int[] ints = new int[10]; // int [10] = länge des arrays -> also 0,1,2,3,4,5,6,7,8,9
int[] ints2 = { 1, 2, 3 }; // Man kann es auch so eingeben, aber blöd wenn man 100e Zahlen hat

for (int i = 0; i < ints.Length; i++) // das ist ein for-loop = solange i kleiner als int.length ist, soll der loop laufen -> also bis 9 
// int.length = so viele zahlen wie reinpassen
{
  ints[i] = i; // also int[an Position i = 0]
}

Console.WriteLine(string.Join(',', ints));

Console.WriteLine(ints[1]);

ints[1] = 952;

Console.WriteLine(string.Join(',', ints));

ints = new int[20]; // ich kann mit der variable den array überschreiben
ints[0] = 10;
Console.WriteLine(string.Join(",", ints));

ints.Append(20); // ??
Console.WriteLine(string.Join(',', ints));
#endregion

#region Lists
// Listen / Lists:

List<string> names = new List<string>(); // Die Liste ist der container des ganzen. in die <> schreibt man rein welche datentypen in die Liste reinommt
var x = new string(); // oder auch new int oder new datetime,.... hierfür gibt es aber auch einen feature um es einfacher zu machen:
List<string> names = new(); // Wie oben

names.Add("Natali Schwaberlad");
names.Add("Kevin Gersitz");
Console.WriteLine(string.Join(", ", names));

names.Remove("Kevin Gersitz");
names.Remove(names[1]);

Console.WriteLine(string.Join(", ", names));

if(names.Find(){
  Console.WriteLine("Natali ist in der Liste");

}

names.Sort();

Console.WriteLine(string.Join(", ", names));

List<int> intList = new() { 20, 40, 10, 3, 6, 42, 100, 13 };
intList.Sort();
Console.WriteLine(string.Join(", ", intList));

// Man kann das oben drüber auch anders schreiben:
Console.WriteLine("FOR-EACH");
foreach(var name in names)
{
  Console.WriteLine(name);
}
for (int i = 0; i < intList[i]) ;



#endregion
