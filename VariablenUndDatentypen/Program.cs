#region Variablen
// Variablen Deklaration
using System.Diagnostics;
using System.Text.Json.Nodes;

string name;
int age;
object random;
float height;
// Variablen sind erst nach einer Deklaration verwendbar

// Console.WriteLine(age); -> Funktioniert erst nach der Initialisierung

// Variablen Initialisierung / Assignment:
name = "Default";
age = 0;
random = new object();
height = 0.0f;

// Deklaration und Initialisierung
int abc = 42;
string hello = "Hello";
var blubb = Console.ReadLine();

int i = 0;
while (i < 5)
  i++;
{
  Console.WriteLine(hello);
  var xyz = 10;
} // Wenn ein Codeblock geschlossen wird, sind alle Variablen die innerhalb des Blocks deklariert wurden nicht mehr gültig -> können dannach nicht mehr verwendet werden

// xyz -> Geht nicht, da xyz in anderem Block ist
// var xyz = 20; -> Variable kann dafür aber neu deklariert werden

#endregion


#region Datentypen
// Primitive Datentypen
bool boolean = false || true;
int ganzzahl = 500;
// ganzzahl = 500;
// Int16 test = 0; -> Würde man nie in der Praxis verwenden, der "norale" int ist dynamisch..

float width = 1.0f;
double depth = 1.0;
decimal moneten = 900000000.765m;
var testfloat = 1.0m; // hier einfach nach der zahl entweder f,m ,usw.. hinzufügen, damit c# erkennt um welchen datentypen es sich handelt. also m = decimal 
char sign = '+';
char letter = 'B';

#endregion


#region Komplexe Datentypen
// Komplexe Typen -> Refrenz Typen
object myObject = new object();
string greeting = "Hello World!";
// dynamic myDynamic;

#endregion


#region WerteVsReferenz-Typen
// Unterschied primitiv und koplex Beispiel:
int num1 = 10;

int[] array1 = { 1, 2, 3 };

Console.WriteLine("num1: " + num1);
Console.WriteLine("array1: " + array1);
Console.WriteLine("array1: " + string.Join(',', array1));
// num1 = 10
// array[0] = 1
Modify(num1, array1);
// num1 = 10
// array[0] = 100
Console.WriteLine("Nach Modify");
Console.WriteLine("num1: " + num1);
Console.WriteLine("array1: " + string.Join(',', array1));

void Modify(int num, int[] array)
{
  num = 100;
  array[0]
}

#endregion






