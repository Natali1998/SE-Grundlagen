using static System.Net.Mime.MediaTypeNames;
using System;
using System.ComponentModel.Design;

namespace Algorithms
{
  public static class CardAlgorithms //public = diese klasse kann überall verwendet werden, vorausgesetzt man hat zugriff drauf
  {
    public static int FindCardLocation(int[] cards, int query)
    {
      // Param: Zahlenliste cards
      // Param: Zahl query
      // Initialisiere variable index mit Wert 0
      // Schleife bis index gleich länge der cards Liste:
      //     Wenn zahl von cards an position index gleich query
      //         wahr: gebe index/ position zurück
      // 
      //     Inkrement(erhöhe) index um 1
      //       return -1;

      int index = 0;

      while (index < cards.Length)
      {
        if (cards[index] == query)
        {
          return index; // Funktion endet hier, falls query gefunden
        }

        index++;
      }

      return -1;
    }
  }

  // Setze Variable index auf Wert 0
  // Setze Variable left auf Wert 0
  // Setze Variable right auf Wert Länge von cards minus 1

  // Wenn Länge von cards gleich 0
  //    wahr: Gebe -1 zurück

  // Schleife solange left kleiner als right:
  // Setze Variable middle auf den Wert (left + right) / 2
  // Wenn middle gleich query:
  //    Wahr: Gebe middle zurück
  // Wenn query kleiner gleich cards an middle:
  //    Wahr: Setze right auf den Wert von middle - 1
  //    Falsch: Setze left auf den Wert von middle + 1


  // Code:
  public static int FindCardLocation2(int[] cards, int query)
  {
    int left = 0;
    int right = cards.Length - 1;

    if (cards.Length == 0)
    {
      return -1;
    }

    while (left < right)
    {
      int middle = (left + right) / 2;
      if (cards[middle] == query)
      {
        return middle;
      }
      else if (query < cards[middle])
      {
        right = middle - 1;
      }
      else
      {
        left = middle + 1;
      }
    }




  }
