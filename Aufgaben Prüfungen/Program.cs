// Aufgabe 5. ab) Prüfung 2020:

//Pseudocode:

// Start: Benutzername und Passwort generieren
//    Variable string gespeicherterBenutzername ist gleich Natali
//    Variable string gespeichertesPasswort ist gleich 1234
//    Variable bool erfolgreichEingeloggt auf false setzen
//
// Schleife:
// Während erfolgreichEingeloggt gleich false ist, wiederhole:
//    Gib "Benutzername:" aus
//    Lese den ein eingegebenen Benutzernamen 
//    Gib "Passwort:" aus
//    Lese das eingegebene Passwort
//
//   Wenn Benutzername gleich gespeicherterBenutzername und passwort gleich gespeichertesPasswort:
//        Generiere ein EinmalPasswort 
//        Gib "EinmalPasswort:" aus
//        Lese das eingegebene Einmalpasswort
//    Wenn eingegebenes Passwort gleich dem generierten EinmalPasswort:
//        Gib "Authentifizierung erfolgreich. Zugriff gewährt" aus
//    Ansonsten
//        Gib "Einmalpasswort ungültig. Bitte erneut versuchen" aus
//        Gib "Mit der Entertaste erneutes Eingeben" aus um das Programm erneut zu starten
//  Ansonsten
//    Gib "Benutzername oder Passwort ungültig. Bitte erneut versuchen" aus
//
//
// Einmal-Passwort generieren:
//    Zufallsgenerator initialisieren (random)
//    Eine Zeichenkette (characters) definieren mit Zeichen, die im Einmalpasswort verwendet werden sollen
//    Leeres Zeichenarray initialisieren mit der Zeichenlänge 8 bzw mit der gewünschten Zeichenlänge
//    Für jeden Index i im Bereich der gewünschten Länge des Einmalpassworts:
//        Generiere eine zufällige Zahl zwischen 0 und der Länge der character Zeichenkette (einschließlich) und speichere es als ZufallsIndex
//        Weise EinmalpasswortArray[i] den Zeichenwert von characters[zufallsIndex] zu
//    Erstelle eine Zeichenkette einmalPasswort aus dem einmalPasswortArray
//   Gib einmalPasswort als Ergebnis zurück
//
// Ende



using System;
using System.ComponentModel.Design;

class Program
{
  static void Main()
  {
    string gespeicherterBenutzername = "Natali";
    string gespeichertesPasswort = "1234";

    bool erfolgreichEingeloggt = false;
    while (!erfolgreichEingeloggt)
    {
      Console.WriteLine("Benutzername: ");
      string benutzername = Console.ReadLine();

      Console.WriteLine("Passwort: ");
      string passwort = Console.ReadLine();


      if (benutzername == gespeicherterBenutzername && passwort == gespeichertesPasswort)

      {
        string einmalPasswort = GeneriereEinmalPasswort();

        Console.WriteLine("EinmalPasswort: " + einmalPasswort);
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("EinmalPasswort eingeben:");
        string eingegebenesPasswort = Console.ReadLine();

        if (eingegebenesPasswort == einmalPasswort)
        {
          Console.WriteLine("Authentifizierung erfolgreich. Zugriff gewährt.");
        }
        else
        {
          Console.WriteLine("Einmalpasswort ungültig. Bitte erneut versuchen.");
        }

      }
      else
      {
        Console.WriteLine("Benutzername oder Passwort ungültig. Bitte erneut versuchen.");

        Console.WriteLine("Drücke die Enter Taste um Benutzername und Passwort erneut einzugeben. Oder Strg+C um das Programm zu beenden");
        Console.ReadKey();
        Console.Clear();
      }

    }
  }
    static string GeneriereEinmalPasswort()
    {
      Random random = new Random();
      const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
      char[] einmalPasswortArray = new char[8];

      for (int i = 0; i < einmalPasswortArray.Length; i++)
      {
        einmalPasswortArray[i] = characters[random.Next(characters.Length)];
      }
      return new string(einmalPasswortArray);
    }
  }



// Aufgabe 2023 readme letzte Aufgabe
// Aufgabenstellung: Schreibe eine Funktion in Pseudocode, die die Fakultät einer gegebenen Zahl berechnet. Die Fakultät einer Zahl n ist das Produkt aller positiven ganzen Zahlen von 1 bis n und wird als n! bezeichnet
// Zum Beispiel: 5! = 5 x 4 x 3 x 2 x 1 = 120)
//               6! = 6 x 5 x 4 x 3 x 2 x 1
//
// Die Funktion sollte einen Parameter haben, der die Zahl repräsentiert, für die die Fakultät berechnet werden soll.
// Die Funktion sollte die Fakultät dieser Zahl zurückgeben.
//
// ````csharp
// decimal factorial(int 5) {....}
//
// Pseudocode:
//
// Lege den Wert "n" fest auf Eingabe von Nutzer.
// Lege Variable z als Zwischenergebniss fest. 0 
// Lege Variable i fest mit dem Wert 1;
//
// Schleife bis i gleich n:
//    Setze den Wert von zwischenergebnis auf den Wert von zwischenergebnis multipliziert mit "i"
//    Erhöhe Wert von Variable "i" um 1
//    Gebe zwischenergebnis zurück
//
//  ---
//
// Param: Variable "n"
// Setze Variable "i" auf den Wert 0
// Setze Variable ergebis auf den Wert
//
// Schleife bis "i" gleich "n"
//    Setze Wert von Ergebnis auf Wert von Ergebnis mal "i"
//    Dekrement "i" um 1
//
// Gebe Ergebnis zurück
//
// ---
//
// Param: Variable "n"
// Setze Variable "i" auf den Wert "n"
// Setze Variable ergebnis auf den Wert von "n"
//
// Schleife bis "i" gleich 1:
//
