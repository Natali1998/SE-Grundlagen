Console.WriteLine("Schleifen-Demo");
int iterCount = 0;
// 1. SchleifenVariante: bei while (true) schreibt "MEEP" so lange bis man es stopt.
while (iterCount > 0) 
{
  Console.WriteLine("MEEP");
  iterCount = iterCount - 1;
}

iterCount = 0;
do
{
  Console.WriteLine("DO-WHILE");
  iterCount--;
} while (iterCount > 0);

//2. SchleifenVariante:
Console.WriteLine("FOR-LOOP");
for (int i = 0; i < 10; i++)
{
  Console.WriteLine("FOR");
}
